using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithms
{
    internal class AlgorithmDDA
    {
        private Point startPoint;
        private Point endPoint;
        private List<Point> linePoints;
        private int animationInterval = 20;
        public AlgorithmDDA()
        {
            startPoint = new Point(0, 0);
            endPoint = new Point(0, 0);
            linePoints = new List<Point>();
        }
        public List<Point> GetLinePoints() => linePoints;

        public void ReadData(TextBox txtX1, TextBox txtY1, TextBox txtX2, TextBox txtY2)
        {
            if (string.IsNullOrWhiteSpace(txtX1.Text) ||
                string.IsNullOrWhiteSpace(txtY1.Text) ||
                string.IsNullOrWhiteSpace(txtX2.Text) ||
                string.IsNullOrWhiteSpace(txtY2.Text))
            {
                MessageBox.Show("All coordinate fields must be filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int x1 = int.Parse(txtX1.Text);
            int y1 = int.Parse(txtY1.Text);
            int x2 = int.Parse(txtX2.Text);
            int y2 = int.Parse(txtY2.Text);

            if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0)
            {
                MessageBox.Show("Coordinates must be non-negative integers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.startPoint = new Point(x1, y1);
            this.endPoint = new Point(x2, y2);
        }

        public void InitializeData(TextBox txtX1, TextBox txtY1, TextBox txtX2, TextBox txtY2, PictureBox picCanvas)
        {
            txtX1.Text = "";
            txtY1.Text = "";
            txtX2.Text = "";
            txtY2.Text = "";
            picCanvas.Refresh();

            startPoint = new Point(0, 0);
            endPoint = new Point(0, 0);
            linePoints = new List<Point>();
        }

        // Calcula los puntos de la línea usando DDA
        private void CalculateLine()
        {
            linePoints.Clear();

            int dx = endPoint.X - startPoint.X;
            int dy = endPoint.Y - startPoint.Y;

            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;

            float x = startPoint.X;
            float y = startPoint.Y;

            for (int i = 0; i <= steps; i++)
            {
                int scaledX = (int)Math.Round(x);
                int scaledY = (int)Math.Round(y);
                linePoints.Add(new Point(scaledX, scaledY));
                x += xIncrement;
                y += yIncrement;
            }
        }

        // Dibuja la línea y los puntos calculados
        public void PlotShape(Graphics g)
        {
            CalculateLine();

            foreach (var pt in linePoints)
            {
                g.FillRectangle(Brushes.MidnightBlue, pt.X, pt.Y, 2, 2);
                Application.DoEvents();          // Permite refrescar la interfaz gráfica
                System.Threading.Thread.Sleep(animationInterval);
            }

        }
    }
}
