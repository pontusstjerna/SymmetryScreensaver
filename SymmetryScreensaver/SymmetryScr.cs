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
            graph = new Animation(Bounds.Width/2, 0);
            graphics = CreateGraphics();
        }

        private void SymmetryScr_Load(object sender, EventArgs e)
        {
            //When the form loads, we'll want to hide cursor etc
            Cursor.Hide();
            TopMost = true;

            //Start animation timer
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
            for (int i = 0; i < graph.Edges.Length; i++)
            {
                graph.Edges[i].ChangeColor();

                Pen pen = new Pen(
                    Color.FromArgb(
                    graph.Edges[i].rgbColor[0],
                    graph.Edges[i].rgbColor[1],
                    graph.Edges[i].rgbColor[2]),
                    graph.Edges[i].Thickness);

                graphics.DrawLine(pen, graph.Edges[i].Start, graph.Edges[i].End);
            }
        }
    }
}
