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
        public Form1()
        {
            InitializeComponent();

        }
        ClaseSimon clases = new ClaseSimon();

        public void bEmpezar_Click(object sender, EventArgs e)
        {
            clases.TurnoOrdenador(this, bVerde, bRojo, bAmarillo, bAzul);
            bEmpezar.Enabled = false;
        }
        public void bVerde_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(1,this, bEmpezar, bVerde, bRojo, bAmarillo, bAzul);
        }
        private void bRojo_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(2, this ,bEmpezar, bVerde, bRojo, bAmarillo, bAzul);
        }

        private void bAmarillo_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(3,this, bEmpezar, bVerde, bRojo, bAmarillo, bAzul);
        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(4,this, bEmpezar, bVerde, bRojo, bAmarillo, bAzul);
        }
    }
}
