using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimonBueno
{

    public partial class Form1 : Form
    {
        ClaseSimon clases;
        public Form1()
        {
            InitializeComponent();
            clases = new ClaseSimon(bEmpezar, this, bVerde, bRojo, bAmarillo, bAzul, lblPuntos);
        }


        public void bEmpezar_Click(object sender, EventArgs e)
        {
            clases.TurnoOrdenador();
            bEmpezar.Enabled = false;

        }
        public void bVerde_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(1);
        }
        private void bRojo_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(2);
        }

        private void bAmarillo_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(3);
        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(4);
        }
    }
}