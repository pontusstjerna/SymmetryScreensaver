using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetryScreensaver
{
    public partial class SymmetryScr : Form
    {
        private Point mousePos;

        private Animation graph;
        private Graphics graphics;
        private bool previewMode = false;


        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);


        public SymmetryScr()
        {
            InitializeComponent();
        }

        public SymmetryScr(Rectangle Bounds) : this()
        {
            this.Bounds = Bounds;
        }

        //For preview
        public SymmetryScr(IntPtr PreviewWndHandle) : this()
        {
            //Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            //Make this a child window so it will close when parent closes
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);
            //Let's hope bounds changes itself

            previewMode = true;
        }

        private void SymmetryScr_Load(object sender, EventArgs e)
        {
            //When the form loads, we'll want to hide cursor etc
            if (!previewMode)
            {
                Cursor.Hide();
                TopMost = true;
            }

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\SymmetryScreensaver");

            //Setup graph
            graph = new Animation(Bounds.Width / 2, 0);
            graph.CreateStdGraph(Bounds.Width, Bounds.Height);
            graphics = this.CreateGraphics();

            if(key != null)
            {
                object colorValue = key.GetValue("colour");
                object thicknessValue = key.GetValue("thickness");

                if(colorValue != null)
                {
                    //Casting from STRING to edge's colors
                    graph.SetColor((Edge.Colors)Enum.Parse(typeof(Edge.Colors), (string)colorValue));
                }
                else
                {
                    graph.SetColor(Edge.Colors.BLUE);
                }

                if(thicknessValue != null)
                {
                    graph.SetThickness(float.Parse((string)key.GetValue("thickness")));
                }
                else
                {
                    graph.SetThickness(0.05f);
                }
            }
            else
            {
                graph.SetColor(Edge.Colors.BLUE);
                graph.SetThickness(0.05f);
            }
            graph.EnableColorChange(true);

            DoubleBuffered = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SymmetryScr_Paint);

            //Setup animation timer
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void SymmetryScr_MouseClick(object sender, MouseEventArgs e)
        {
            if(!previewMode)
                Application.Exit();
        }

        private void SymmetryScr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void SymmetryScr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousePos.IsEmpty && !previewMode)
            {
                const int threshold = 3;
                if (Math.Abs(mousePos.X - e.X) > threshold ||
                   Math.Abs(mousePos.Y - e.Y) > threshold)
                {
                    Application.Exit();
                }
            }
            mousePos = e.Location;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private Pen GetPen(int i)
        {
            graph.Edges[i].ChangeColor();
            
            Pen pen = new Pen(
            Color.FromArgb(
                graph.Edges[i].GetAlpha(),
                graph.Edges[i].GetR(),
                graph.Edges[i].GetG(),
                graph.Edges[i].GetB()),
                graph.Edges[i].Thickness);

            return pen;
        }

        private void SymmetryScr_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < graph.Edges.Length; i++)
            {
                e.Graphics.DrawLine(GetPen(i), graph.Edges[i].Start, graph.Edges[i].End);
            }
        }
    }
}
