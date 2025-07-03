using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithms
{
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formulario)
        {
            panelContenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void algoritmoDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDDA());
            this.Text = "Algoritmo DDA";
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBresenham());
            this.Text = "Bresenham Lineas";
        }

        private void bresenhamCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCircle());
            this.Text = "Bresenham Circunferencias";
        }

        private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmFloodFill());
            this.Text = "Flood Fill";
        }

        private void scanlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmScanline());
            this.Text = "Scanline";
        }

        private void cohenSutherlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCohenSutherland());
            this.Text = "Cohen Sutherland";
        }

        private void sutherlandHodgmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSutherlandHodgman());
            this.Text = "Sutherland Hodgman";
        }

        private void bezierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBezierCurve());
            this.Text = "Bezier Curves";
        }

        private void bSplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBSplineCurve());
            this.Text = "B-Spline Curves";
        }

        private void bresenhamElipsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOval());
            this.Text = "Bresenham Elipses";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
