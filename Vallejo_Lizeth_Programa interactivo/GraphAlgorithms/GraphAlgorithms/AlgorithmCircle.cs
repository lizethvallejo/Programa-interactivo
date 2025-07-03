using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithms
{
    internal class AlgorithmCircle
    {
        private int radius;
        private List<Point> circlePoints;
        private Point center;
        private int animationInterval = 5;

        public AlgorithmCircle()
        {
            radius = 0;
            center = new Point(0, 0);
            circlePoints = new List<Point>();
        }

        public List<Point> GetCirclePoints() => circlePoints;

        public void ReadData(TextBox txtRadius, TextBox txtX1, TextBox txtY1)
        {
            if (string.IsNullOrWhiteSpace(txtRadius.Text))
            {
                MessageBox.Show("Radius field must be filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtRadius.Text, out radius) || radius <= 0)
            {
                MessageBox.Show("Please enter a positive integer for the radius.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtX1.Text) || string.IsNullOrWhiteSpace(txtY1.Text))
            {
                MessageBox.Show("Center coordinates must be filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!int.TryParse(txtX1.Text, out int centerX) || !int.TryParse(txtY1.Text, out int centerY))
            {
                MessageBox.Show("Center coordinates must be valid integers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            center = new Point(centerX, centerY);

        }

        public void InitializeData(TextBox txtRadius, PictureBox picCanvas)
        {
            txtRadius.Text = "";
            picCanvas.Refresh();

            radius = 0;
            center = new Point(0, 0);
            circlePoints = new List<Point>();
        }

        // Calcula los puntos del círculo usando simetría de 8 octantes
        private void CalculateCircle()
        {
            circlePoints.Clear();

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            while (x <= y)
            {
                AddSymmetricPoints(center.X, center.Y, x, y);
                if (d < 0)
                {
                    d += 2 * x + 3;
                }
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
            }
        }

        // Agrega los 8 puntos simétricos del círculo
        private void AddSymmetricPoints(int cx, int cy, int x, int y)
        {
            circlePoints.Add(new Point(cx + x, cy + y));
            circlePoints.Add(new Point(cx - x, cy + y));
            circlePoints.Add(new Point(cx + x, cy - y));
            circlePoints.Add(new Point(cx - x, cy - y));
            circlePoints.Add(new Point(cx + y, cy + x));
            circlePoints.Add(new Point(cx - y, cy + x));
            circlePoints.Add(new Point(cx + y, cy - x));
            circlePoints.Add(new Point(cx - y, cy - x));
        }

        // Dibuja los puntos del círculo
        public void PlotShape(Graphics g)
        {
            CalculateCircle();

            foreach (var pt in circlePoints)
            {
                g.FillRectangle(Brushes.MidnightBlue, pt.X, pt.Y, 2, 2);
                Application.DoEvents();          // Permite refrescar la interfaz gráfica
                System.Threading.Thread.Sleep(animationInterval);
            }
        }
    }
}
