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
    public partial class FrmBSplineCurve : Form
    {
        private BSplineCurve bspline = new BSplineCurve();
        private int draggingIndex = -1;
        private bool isDragging = false;
        public FrmBSplineCurve()
        {
            InitializeComponent();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isDragging)
            {
                bspline.AddPoint(e.Location);
                picCanvas.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                bspline.RemovePointAt(e.Location);
                picCanvas.Invalidate();
            }
            if (bspline.ControlPoints.Count < 4)
            {
                lblEstado.Text = "⚠️ Dibuje al menos 4 puntos para generar la curva Bézier.";
            }
            else
            {
                lblEstado.Text = "✅ Curva Bézier generada con los puntos actuales.";
            }
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            draggingIndex = bspline.GetPointIndexAt(e.Location);
            if (draggingIndex != -1)
                isDragging = true;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggingIndex != -1)
            {
                bspline.MovePoint(draggingIndex, e.Location);
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggingIndex = -1;
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            bspline.Draw(e.Graphics);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            bspline.Clear();
            picCanvas.Invalidate();
            lblEstado.Text = "⚠️ Dibuje al menos 4 puntos para generar la curva B-Spline.";
        }
    }
}
