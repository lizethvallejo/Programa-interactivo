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
    public partial class FrmSutherlandHodgman : Form
    {
        List<Point> polygon = new List<Point>();
        List<Point> clippedPolygon = new List<Point>();
        Rectangle clipRect;
        int cellW, cellH;
        public FrmSutherlandHodgman()
        {
            InitializeComponent();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            polygon.Add(e.Location);
            if (polygon.Count >= 3)
            {
                clippedPolygon.Clear(); // se limpia hasta presionar recortar
            }
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            cellW = picCanvas.Width / 3;
            cellH = picCanvas.Height / 3;
            clipRect = new Rectangle(cellW, cellH, cellW, cellH);

            // Dibujar 9 cuadrantes
            for (int i = 1; i < 3; i++)
            {
                g.DrawLine(Pens.LightGray, 0, i * cellH, picCanvas.Width, i * cellH);
                g.DrawLine(Pens.LightGray, i * cellW, 0, i * cellW, picCanvas.Height);
            }

            // Dibujar área de recorte
            using (Pen blackPen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(blackPen, clipRect);
            }

            // Pen para líneas gruesas
            using (Pen thickRedPen = new Pen(Color.DarkGray, 2))
            using (Pen thickGreenPen = new Pen(Color.Green, 3))
            {
                // Dibujar polígono original con líneas rojas gruesas
                if (polygon.Count >= 2)
                    g.DrawPolygon(thickRedPen, polygon.ToArray());

                // Dibujar polígono recortado con líneas verdes gruesas
                if (clippedPolygon.Count >= 3)
                    g.DrawPolygon(thickGreenPen, clippedPolygon.ToArray());
            }

            // Dibujar puntos (vértices) para el polígono original
            foreach (Point p in polygon)
            {
                g.FillEllipse(Brushes.Blue, p.X - 4, p.Y - 4, 8, 8); // círculo azul de diámetro 8
            }

            // Dibujar puntos para el polígono recortado
            foreach (Point p in clippedPolygon)
            {
                g.FillEllipse(Brushes.DarkGreen, p.X - 4, p.Y - 4, 8, 8);
            }
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            if (polygon.Count >= 3)
            {
                clippedPolygon = SutherlandHodgman.ClipPolygon(polygon, clipRect);
                picCanvas.Invalidate();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            polygon.Clear();
            clippedPolygon.Clear();
            picCanvas.Invalidate();
        }
    }
}
