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
    public partial class FrmDDA : Form
    {
        private AlgorithmDDA algorithmDDA = new AlgorithmDDA();
        private int clickCount = 0;

        public FrmDDA()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            algorithmDDA.ReadData(txtX1, txtY1, txtX2, txtY2);
            algorithmDDA.PlotShape(picCanvas.CreateGraphics());
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickCount == 0)
            {
                txtX1.Text = e.X.ToString();
                txtY1.Text = e.Y.ToString();
                txtX2.Text = "";
                txtY2.Text = "";

                picCanvas.Refresh(); // Limpia el PictureBox

                // Dibuja el primer punto
                using (Graphics g = picCanvas.CreateGraphics())
                {
                    g.FillRectangle(Brushes.MidnightBlue, e.X, e.Y, 2, 2);
                }
                clickCount = 1;
            }
            else if (clickCount == 1)
            {
                txtX2.Text = e.X.ToString();
                txtY2.Text = e.Y.ToString();

                // Dibuja segundo punto
                using (Graphics g = picCanvas.CreateGraphics())
                {
                    g.FillRectangle(Brushes.MidnightBlue, e.X, e.Y, 2, 2);
                }
                clickCount = 0;
            }
        }
    }
}
