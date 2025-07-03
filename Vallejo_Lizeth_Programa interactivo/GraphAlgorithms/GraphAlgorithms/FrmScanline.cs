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
    public partial class FrmScanline : Form
    {
        private Bitmap canvasBitmap;
        private Polygon polygon = new Polygon();
        private Color fillColor = Color.DodgerBlue;
        public FrmScanline()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!polygon.ReadData(txtRadio, txtNumLados))
            {
                return;
            }
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                polygon.PlotShape(g, picCanvas);
            }
            picCanvas.Invalidate();
        }

        private void FrmScanline_Load(object sender, EventArgs e)
        {
            polygon.InitializeData(txtRadio, txtNumLados, picCanvas);
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = canvasBitmap;
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Color target = canvasBitmap.GetPixel(e.X, e.Y);
            polygon.ScanlineFill(new Point(e.X, e.Y), canvasBitmap, Color.Black, fillColor, picCanvas);
            picCanvas.Invalidate();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.fillColor = Color.DodgerBlue;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.fillColor = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.fillColor = Color.SpringGreen;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            this.fillColor = Color.MediumPurple;
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            this.fillColor = Color.Violet;
        }

        private void txtNumLados_Enter(object sender, EventArgs e)
        {
            lblInfoSide.Visible = true;
        }

        private void txtNumLados_Leave(object sender, EventArgs e)
        {
            lblInfoSide.Visible = false;
        }
    }
}
