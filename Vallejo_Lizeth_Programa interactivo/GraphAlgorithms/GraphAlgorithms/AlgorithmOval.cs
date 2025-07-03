using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithms
{
    internal class AlgorithmOval
    {
        private int rx, ry;
        private Point center;
        private List<Point> ellipsePoints = new List<Point>();
        private int animationInterval = 5;

        public void ReadData(TextBox txtRx, TextBox txtRy, TextBox txtX, TextBox txtY)
        {
            if (!int.TryParse(txtRx.Text, out rx) || rx <= 0 ||
                !int.TryParse(txtRy.Text, out ry) || ry <= 0)
            {
                MessageBox.Show("Ingrese valores positivos válidos para rx y ry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtX.Text, out int cx) || !int.TryParse(txtY.Text, out int cy))
            {
                MessageBox.Show("Ingrese coordenadas válidas para el centro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            center = new Point(cx, cy);
        }

        private void CalculateEllipse()
        {
            ellipsePoints.Clear();
            int x = 0;
            int y = ry;

            int rx2 = rx * rx;
            int ry2 = ry * ry;

            double p1 = ry2 - rx2 * ry + 0.25 * rx2;
            int dx = 2 * ry2 * x;
            int dy = 2 * rx2 * y;

            // Región 1
            while (dx < dy)
            {
                AddSymmetricPoints(center.X, center.Y, x, y);
                if (p1 < 0)
                {
                    x++;
                    dx += 2 * ry2;
                    p1 += dx + ry2;
                }
                else
                {
                    x++; y--;
                    dx += 2 * ry2;
                    dy -= 2 * rx2;
                    p1 += dx - dy + ry2;
                }
            }

            // Región 2
            double p2 = ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2;

            while (y >= 0)
            {
                AddSymmetricPoints(center.X, center.Y, x, y);
                if (p2 > 0)
                {
                    y--;
                    dy -= 2 * rx2;
                    p2 += rx2 - dy;
                }
                else
                {
                    y--; x++;
                    dx += 2 * ry2;
                    dy -= 2 * rx2;
                    p2 += dx - dy + rx2;
                }
            }
        }

        private void AddSymmetricPoints(int cx, int cy, int x, int y)
        {
            ellipsePoints.Add(new Point(cx + x, cy + y));
            ellipsePoints.Add(new Point(cx - x, cy + y));
            ellipsePoints.Add(new Point(cx + x, cy - y));
            ellipsePoints.Add(new Point(cx - x, cy - y));
        }

        public void PlotShape(Graphics g)
        {
            CalculateEllipse();

            foreach (var pt in ellipsePoints)
            {
                g.FillRectangle(Brushes.DarkRed, pt.X, pt.Y, 2, 2);
                Application.DoEvents();
                Thread.Sleep(animationInterval);
            }
        }
    }
}
