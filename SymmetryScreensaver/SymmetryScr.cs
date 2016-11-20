using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public SymmetryScr()
        {
            InitializeComponent();
        }

        public SymmetryScr(Rectangle Bounds) : this()
        {
            this.Bounds = Bounds;
        }

        private void SymmetryScr_Load(object sender, EventArgs e)
        {
            //When the form loads, we'll want to hide cursor etc
            Cursor.Hide();
            TopMost = true;

            //Setup graph
            graph = new Animation(Bounds.Width / 2, 0);
            graph.CreateStdGraph(Bounds.Width, Bounds.Height);
            graphics = this.CreateGraphics();
            graph.SetColor(Edge.Colors.BLUE);
            graph.SetThickness(0.05f);
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
            Application.Exit();
        }

        private void SymmetryScr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void SymmetryScr_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousePos.IsEmpty)
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
