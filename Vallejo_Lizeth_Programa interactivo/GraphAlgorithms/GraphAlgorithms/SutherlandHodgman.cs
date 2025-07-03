using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms
{
    internal class SutherlandHodgman
    {
        public static List<Point> ClipPolygon(List<Point> subjectPolygon, Rectangle clipRect)
        {
            List<Point> outputList = new List<Point>(subjectPolygon);

            // Recortar contra cada borde del rectángulo
            outputList = ClipEdge(outputList, new Point(clipRect.Left, clipRect.Top), new Point(clipRect.Right, clipRect.Top));     // Top
            outputList = ClipEdge(outputList, new Point(clipRect.Right, clipRect.Top), new Point(clipRect.Right, clipRect.Bottom)); // Right
            outputList = ClipEdge(outputList, new Point(clipRect.Right, clipRect.Bottom), new Point(clipRect.Left, clipRect.Bottom));// Bottom
            outputList = ClipEdge(outputList, new Point(clipRect.Left, clipRect.Bottom), new Point(clipRect.Left, clipRect.Top));    // Left

            return outputList;
        }

        private static List<Point> ClipEdge(List<Point> inputList, Point edgeStart, Point edgeEnd)
        {
            List<Point> outputList = new List<Point>();

            for (int i = 0; i < inputList.Count; i++)
            {
                Point current = inputList[i];
                Point prev = inputList[(i - 1 + inputList.Count) % inputList.Count];

                bool currInside = IsInside(current, edgeStart, edgeEnd);
                bool prevInside = IsInside(prev, edgeStart, edgeEnd);

                if (currInside)
                {
                    if (!prevInside)
                    {
                        Point intersect = ComputeIntersection(prev, current, edgeStart, edgeEnd);
                        outputList.Add(intersect);
                    }
                    outputList.Add(current);
                }
                else if (prevInside)
                {
                    Point intersect = ComputeIntersection(prev, current, edgeStart, edgeEnd);
                    outputList.Add(intersect);
                }
            }

            return outputList;
        }

        private static bool IsInside(Point p, Point edgeStart, Point edgeEnd)
        {
            return (edgeEnd.X - edgeStart.X) * (p.Y - edgeStart.Y) - (edgeEnd.Y - edgeStart.Y) * (p.X - edgeStart.X) >= 0;
        }

        private static Point ComputeIntersection(Point p1, Point p2, Point edgeStart, Point edgeEnd)
        {
            float A1 = p2.Y - p1.Y;
            float B1 = p1.X - p2.X;
            float C1 = A1 * p1.X + B1 * p1.Y;

            float A2 = edgeEnd.Y - edgeStart.Y;
            float B2 = edgeStart.X - edgeEnd.X;
            float C2 = A2 * edgeStart.X + B2 * edgeStart.Y;

            float det = A1 * B2 - A2 * B1;

            if (det == 0) return p1; // paralelas
            float x = (B2 * C1 - B1 * C2) / det;
            float y = (A1 * C2 - A2 * C1) / det;

            return new Point((int)x, (int)y);
        }
    }
}

