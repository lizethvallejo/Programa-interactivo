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
    public partial class FrmCircle : Form
    {
        private AlgorithmCircle algorithmCircle = new AlgorithmCircle();

        public FrmCircle()
        {
            InitializeComponent();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            txtX1.Text = e.X.ToString();
            txtY1.Text = e.Y.ToString();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            algorithmCircle.ReadData(txtRadio,txtX1,txtY1);
            algorithmCircle.PlotShape(picCanvas.CreateGraphics());
        }

    }
}
