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
    public partial class FrmCohenSutherland : Form
    {
        Rectangle clippingRect;
        int cellWidth, cellHeight;
        List<(Point, Point)> lines = new List<(Point, Point)>();
        List<(Point, Point)> clippedLines = new List<(Point, Point)>();
        bool isDrawing = false;
        Point startPoint, currentPoint;


        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            currentPoint = e.Location;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                Point endPoint = e.Location;
                lines.Add((startPoint, endPoint));
                picCanvas.Invalidate();
            }
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            clippedLines.Clear();

            foreach (var line in lines)
            {
                if (CohenSutherland.ClipLine(line.Item1, line.Item2, clippingRect, out Point p1, out Point p2))
                {
                    clippedLines.Add((p1, p2)); // solo las partes recortadas
                }
            }

            picCanvas.Invalidate(); // Redibujar todo
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lines.Clear();         // Borra todas las líneas originales
            clippedLines.Clear();  // Borra todas las líneas recortadas
            isDrawing = false;     // Por si se estaba dibujando una línea
            picCanvas.Invalidate(); // Redibuja el PictureBox
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            cellWidth = picCanvas.Width / 3;
            cellHeight = picCanvas.Height / 3;

            // Dibujar cuadrícula 3x3
            for (int i = 1; i < 3; i++)
            {
                g.DrawLine(Pens.LightGray, 0, i * cellHeight, picCanvas.Width, i * cellHeight);
                g.DrawLine(Pens.LightGray, i * cellWidth, 0, i * cellWidth, picCanvas.Height);
            }

            // Dibujar el rectángulo de recorte (centro)
            clippingRect = new Rectangle(cellWidth, cellHeight, cellWidth, cellHeight);
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(pen, clippingRect);
            }

            // Usar pens gruesos para las líneas
            using (Pen grayPen = new Pen(Color.DarkGray, 2))
            using (Pen greenPen = new Pen(Color.Green, 3))
            using (Pen bluePen = new Pen(Color.Blue, 2))
            {
                // Líneas originales en gris grueso
                foreach (var line in lines)
                {
                    g.DrawLine(grayPen, line.Item1, line.Item2);
                }

                // Líneas recortadas en verde grueso
                foreach (var clipped in clippedLines)
                {
                    g.DrawLine(greenPen, clipped.Item1, clipped.Item2);
                }

                // Línea que se está dibujando en azul grueso
                if (isDrawing)
                {
                    g.DrawLine(bluePen, startPoint, currentPoint);
                }
            }
        }


        public FrmCohenSutherland()
        {
            InitializeComponent();
        }
    }
}
