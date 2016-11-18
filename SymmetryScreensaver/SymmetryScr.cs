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
        public SymmetryScr()
        {
            InitializeComponent();
        }

        public SymmetryScr(Rectangle Bounds)
        {
            InitializeComponent();
            //this.Bounds = Bounds;
        }

        private void SymmetryScr_Load(object sender, EventArgs e)
        {
            //When the form loads, we'll want to hide cursor etc
            Cursor.Hide();
            TopMost = true;
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
            Application.Exit();
        }
    }
}
