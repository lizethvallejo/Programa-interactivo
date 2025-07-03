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
    public partial class FrmOval : Form
    {
        private AlgorithmOval algorithmOval = new AlgorithmOval();

        public FrmOval()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            algorithmOval.ReadData(txtRx, txtRy, txtX, txtY);
            algorithmOval.PlotShape(picCanvas.CreateGraphics());
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            txtX.Text = e.X.ToString();
            txtY.Text = e.Y.ToString();
        }
    }
}
