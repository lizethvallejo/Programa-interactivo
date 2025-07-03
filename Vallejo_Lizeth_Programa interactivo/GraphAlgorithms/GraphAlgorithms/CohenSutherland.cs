using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms
{
    internal class CohenSutherland
    {
        // Códigos de región
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1;   // 0001
        private const int RIGHT = 2;  // 0010
        private const int BOTTOM = 4; // 0100
        private const int TOP = 8;    // 1000

        /// <summary>
        /// Calcula el código de región para un punto.
        /// </summary>
        private static int ComputeOutCode(int x, int y, Rectangle rect)
        {
            int code = INSIDE;

            if (x < rect.Left)
                code |= LEFT;
            else if (x > rect.Right)
                code |= RIGHT;

            if (y < rect.Top)
                code |= TOP;
            else if (y > rect.Bottom)
                code |= BOTTOM;

            return code;
        }

        /// <summary>
        /// Aplica el algoritmo Cohen-Sutherland y devuelve true si hay intersección.
        /// </summary>
        public static bool ClipLine(Point p0, Point p1, Rectangle rect, out Point clippedP0, out Point clippedP1)
        {
            int x0 = p0.X, y0 = p0.Y;
            int x1 = p1.X, y1 = p1.Y;

            int outcode0 = ComputeOutCode(x0, y0, rect);
            int outcode1 = ComputeOutCode(x1, y1, rect);

            bool accept = false;

            while (true)
            {
                if ((outcode0 | outcode1) == 0)
                {
                    // Ambos extremos están dentro
                    accept = true;
                    break;
                }
                else if ((outcode0 & outcode1) != 0)
                {
                    // Ambos extremos están fuera y en la misma región
                    break;
                }
                else
                {
                    int outcodeOut = (outcode0 != 0) ? outcode0 : outcode1;
                    int x = 0, y = 0;

                    if ((outcodeOut & TOP) != 0)
                    {
                        x = x0 + (x1 - x0) * (rect.Top - y0) / (y1 - y0);
                        y = rect.Top;
                    }
                    else if ((outcodeOut & BOTTOM) != 0)
                    {
                        x = x0 + (x1 - x0) * (rect.Bottom - y0) / (y1 - y0);
                        y = rect.Bottom;
                    }
                    else if ((outcodeOut & RIGHT) != 0)
                    {
                        y = y0 + (y1 - y0) * (rect.Right - x0) / (x1 - x0);
                        x = rect.Right;
                    }
                    else if ((outcodeOut & LEFT) != 0)
                    {
                        y = y0 + (y1 - y0) * (rect.Left - x0) / (x1 - x0);
                        x = rect.Left;
                    }

                    if (outcodeOut == outcode0)
                    {
                        x0 = x;
                        y0 = y;
                        outcode0 = ComputeOutCode(x0, y0, rect);
                    }
                    else
                    {
                        x1 = x;
                        y1 = y;
                        outcode1 = ComputeOutCode(x1, y1, rect);
                    }
                }
            }

            if (accept)
            {
                clippedP0 = new Point(x0, y0);
                clippedP1 = new Point(x1, y1);
                return true;
            }
            else
            {
                clippedP0 = Point.Empty;
                clippedP1 = Point.Empty;
                return false;
            }
        }
    }
}
