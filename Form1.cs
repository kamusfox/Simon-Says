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
        //Declaracion del objeto para poder utilizar la clase
        ClaseSimon clases;
        public Form1()
        {
            InitializeComponent();
            //Creacion del objeto con los botones y que vamos a utiliar
            clases = new ClaseSimon(bEmpezar, this, bVerde, bRojo, bAmarillo, bAzul, lblPuntos);
        }

        //Evento que que hará que empiece el juego y deshabilitara el boton
        public void bEmpezar_Click(object sender, EventArgs e)
        {
            bEmpezar.Enabled = false;
            //this.BackgroundImage = Properties.Resources.wallpaperFinal;
            this.BackgroundImage = null;
            clases.TurnoOrdenador();

        }
        #region EVENTOS DE LOS BOTONES
        //Evento que se produce al pulsar algun boton que llamara al metodo de la clase
        public void bVerde_Click(object sender, EventArgs e)
        {
            clases.TurnoJuego(1);
            //this.BackgroundImage = null;

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
        #endregion
    }
}