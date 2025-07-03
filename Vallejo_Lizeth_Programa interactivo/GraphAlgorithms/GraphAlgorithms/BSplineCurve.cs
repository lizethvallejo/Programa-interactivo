using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms
{
    internal class BSplineCurve
    {
        public List<Point> ControlPoints { get; } = new List<Point>();

        public void AddPoint(Point p)
        {
            ControlPoints.Add(p);
        }

        public void Clear()
        {
            ControlPoints.Clear();
        }

        public void MovePoint(int index, Point newPos)
        {
            if (index >= 0 && index < ControlPoints.Count)
                ControlPoints[index] = newPos;
        }

        public int GetPointIndexAt(Point p, int radius = 6)
        {
            for (int i = 0; i < ControlPoints.Count; i++)
            {
                double dist = Math.Sqrt(Math.Pow(p.X - ControlPoints[i].X, 2) + Math.Pow(p.Y - ControlPoints[i].Y, 2));
                if (dist <= radius)
                    return i;
            }
            return -1;
        }

        public void Draw(Graphics g)
        {
            int n = ControlPoints.Count;

            // Dibujar líneas entre puntos si hay al menos 2
            if (n > 1)
            {
                using (Pen guidePen = new Pen(Color.LightGray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot })
                {
                    g.DrawLines(guidePen, ControlPoints.ToArray());
                }
            }

            // Dibujar los puntos de control
            for (int i = 0; i < n; i++)
            {
                var p = ControlPoints[i];
                g.FillEllipse(Brushes.Blue, p.X - 4, p.Y - 4, 8, 8);
                g.DrawString($"P{i}", SystemFonts.DefaultFont, Brushes.Black, p.X + 6, p.Y - 12);
            }

            // Dibujar la curva si hay al menos 4 puntos
            if (n >= 4)
            {
                using (Pen curvePen = new Pen(Color.DarkBlue, 3))
                {
                    for (float t = 0.0f; t <= n - 3; t += 0.01f)
                    {
                        PointF pt = DeBoor(t);
                        g.FillEllipse(Brushes.DarkBlue, pt.X - 1, pt.Y - 1, 2, 2);
                    }
                }
            }
        }
        public void RemovePointAt(Point location, int radius = 6)
        {
            int index = GetPointIndexAt(location, radius);
            if (index != -1)
            {
                ControlPoints.RemoveAt(index);
            }
        }


        private PointF DeBoor(float t)
        {
            int k = 3; // grado cúbico
            int n = ControlPoints.Count - 1;
            int m = n + k + 1; // número total de nodos

            float[] knot = new float[m + 1];
            for (int i = 0; i <= m; i++)
                knot[i] = i;

            // Ubicar el intervalo de t
            int span = (int)Math.Floor(t + k);
            if (span >= m) span = m - 1;

            PointF[] d = new PointF[k + 1];
            for (int j = 0; j <= k; j++)
            {
                int idx = span - k + j;
                if (idx < 0) idx = 0;
                if (idx > n) idx = n;
                d[j] = ControlPoints[idx];
            }

            for (int r = 1; r <= k; r++)
            {
                for (int j = k; j >= r; j--)
                {
                    int i = span - k + j;
                    float alpha = (t + k - i) / (knot[i + k + 1 - r] - knot[i]);
                    d[j].X = (1 - alpha) * d[j - 1].X + alpha * d[j].X;
                    d[j].Y = (1 - alpha) * d[j - 1].Y + alpha * d[j].Y;
                }
            }

            return d[k];
        }
    }
}
