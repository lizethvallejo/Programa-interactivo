using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithms
{
    public abstract class Figure
    {
        private List<Point> filledPixels = new List<Point>();
        public IEnumerable<Point> GetPixels() => filledPixels;

        public Pen Borde { get; set; } = new Pen(Color.Black, 2);
        public Color ColorRelleno { get; set; } = Color.Transparent;

        public abstract void PlotShape(Graphics g, PictureBox picCanvas);

        public virtual void FloodFill(Point p, Bitmap bmp, Color targetColor, Color fillColor, PictureBox canvas)
        {
            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            Stack<Point> workStack = new Stack<Point>();
            workStack.Push(p);

            while (workStack.Count > 0)
            {
                Point pt = workStack.Pop();
                if (pt.X < 0 || pt.Y < 0 || pt.X >= bmp.Width || pt.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(pt.X, pt.Y).ToArgb() == targetColor.ToArgb())
                {
                    bmp.SetPixel(pt.X, pt.Y, fillColor);
                    filledPixels.Add(pt);

                    workStack.Push(new Point(pt.X + 1, pt.Y));
                    workStack.Push(new Point(pt.X - 1, pt.Y));
                    workStack.Push(new Point(pt.X, pt.Y + 1));
                    workStack.Push(new Point(pt.X, pt.Y - 1));
                }
                canvas.Refresh();

            }

        }

        public virtual void ScanlineFill(Point seed, Bitmap bmp, Color borderColor, Color fillColor, PictureBox canvas)
        {
            if (borderColor.ToArgb() == fillColor.ToArgb()) return;

            filledPixels.Clear();

            int width = bmp.Width;
            int height = bmp.Height;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(seed);

            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                int x = p.X;
                int y = p.Y;

                // Buscar el límite izquierdo
                while (x >= 0 && bmp.GetPixel(x, y).ToArgb() != borderColor.ToArgb() && bmp.GetPixel(x, y).ToArgb() != fillColor.ToArgb())
                {
                    x--;
                }
                x++; // Regresar al primer pixel válido

                bool spanAbove = false;
                bool spanBelow = false;

                // Llenar hacia la derecha hasta encontrar el borde
                for (; x < width && bmp.GetPixel(x, y).ToArgb() != borderColor.ToArgb() && bmp.GetPixel(x, y).ToArgb() != fillColor.ToArgb(); x++)
                {
                    bmp.SetPixel(x, y, fillColor);
                    filledPixels.Add(new Point(x, y));

                    // Revisar la línea de arriba
                    if (y > 0)
                    {
                        Color pixelAbove = bmp.GetPixel(x, y - 1);
                        if (pixelAbove.ToArgb() != borderColor.ToArgb() && pixelAbove.ToArgb() != fillColor.ToArgb())
                        {
                            if (!spanAbove)
                            {
                                stack.Push(new Point(x, y - 1));
                                spanAbove = true;
                            }
                        }
                        else
                        {
                            spanAbove = false;
                        }
                    }

                    // Revisar la línea de abajo
                    if (y < height - 1)
                    {
                        Color pixelBelow = bmp.GetPixel(x, y + 1);
                        if (pixelBelow.ToArgb() != borderColor.ToArgb() && pixelBelow.ToArgb() != fillColor.ToArgb())
                        {
                            if (!spanBelow)
                            {
                                stack.Push(new Point(x, y + 1));
                                spanBelow = true;
                            }
                        }
                        else
                        {
                            spanBelow = false;
                        }
                    }
                }
                canvas.Refresh();
            }
        }

    }

}
