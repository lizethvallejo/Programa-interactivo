using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphAlgorithms
{
    public partial class FrmBezierCurve : Form
    {
        private BezierCurve bezier = new BezierCurve();
        private int draggingIndex = -1;
        private bool isDragging = false;

        public FrmBezierCurve()
        {
            InitializeComponent();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isDragging)
            {
                bezier.AddPoint(e.Location);
                picCanvas.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                bezier.RemovePointAt(e.Location);
                picCanvas.Invalidate();
            }

            if (bezier.ControlPoints.Count < 4)
            {
                lblEstado.Text = "⚠️ Dibuje al menos 4 puntos para generar la curva Bézier.";
            }
            else
            {
                lblEstado.Text = "✅ Curva Bézier generada con los puntos actuales.";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            bezier.Clear();
            picCanvas.Invalidate();
            lblEstado.Text = "⚠️ Dibuje al menos 4 puntos para generar la curva Bézier.";
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            bezier.Draw(e.Graphics);
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            draggingIndex = bezier.GetPointIndexAt(e.Location);
            if (draggingIndex != -1)
                isDragging = true;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggingIndex != -1)
            {
                bezier.MovePoint(draggingIndex, e.Location);
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            draggingIndex = -1;
        }
    }
}
