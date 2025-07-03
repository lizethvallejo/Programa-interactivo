using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms
{
    internal class BezierCurve
    {
        public List<Point> ControlPoints { get; } = new List<Point>();

        public void AddPoint(Point p) => ControlPoints.Add(p);

        public void Clear() => ControlPoints.Clear();

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

        public void RemovePointAt(Point p, int radius = 6)
        {
            int index = GetPointIndexAt(p, radius);
            if (index != -1)
                ControlPoints.RemoveAt(index);
        }

        public void Draw(Graphics g)
        {
            int n = ControlPoints.Count;

            // Dibujar líneas guía
            if (n > 1)
            {
                using (Pen guidePen = new Pen(Color.LightGray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot })
                {
                    g.DrawLines(guidePen, ControlPoints.ToArray());
                }
            }

            // Dibujar puntos de control
            for (int i = 0; i < n; i++)
            {
                var p = ControlPoints[i];
                g.FillEllipse(Brushes.OrangeRed, p.X - 4, p.Y - 4, 8, 8);
                g.DrawString($"P{i}", SystemFonts.DefaultFont, Brushes.Black, p.X + 6, p.Y - 12);
            }

            // Dibujar curva solo si hay al menos 4 puntos
            if (n >= 4)
            {
                using (Pen curvePen = new Pen(Color.DarkRed, 3))
                {
                    for (float t = 0; t <= 1; t += 0.001f)
                    {
                        PointF pt = DeCasteljau(ControlPoints, t);
                        g.FillEllipse(Brushes.DarkRed, pt.X - 1, pt.Y - 1, 2, 2);
                    }
                }
            }
        }

        private PointF DeCasteljau(List<Point> points, float t)
        {
            List<PointF> temp = new List<PointF>(points.ConvertAll(p => (PointF)p));

            while (temp.Count > 1)
            {
                List<PointF> next = new List<PointF>();
                for (int i = 0; i < temp.Count - 1; i++)
                {
                    float x = (1 - t) * temp[i].X + t * temp[i + 1].X;
                    float y = (1 - t) * temp[i].Y + t * temp[i + 1].Y;
                    next.Add(new PointF(x, y));
                }
                temp = next;
            }

            return temp[0];
        }
    }
}
