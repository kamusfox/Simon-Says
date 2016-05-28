using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimonBueno
{
    public class ClaseSimon
    {
        Form formuClass;
        Button bEmpezarClass;
        Button bVerdeClass;
        Button bRojoClass;
        Button bAmarilloClass;
        Button bAzulClass;
        Label lblPuntosClass;
        /// <summary>
        /// Constructor de los objetos que utilizaremos para poder actuar sobre la ventana
        /// </summary>
        /// <param name="bEmpezar">Boton con el cual empezamos una nueva partida</param>
        /// <param name="formu">Objeto Form el cual pasamos para poder hacer Refresh()</param>
        /// <param name="bVerde">Boton Verde del juego</param>
        /// <param name="bRojo">Boton Rojo del juego</param>
        /// <param name="bAmarillo">Boton Amarillo del juego</param>
        /// <param name="bAzul">Boton Azul del juego</param>
        /// <param name="lblPuntos">Mostramos la cantidad de puntos va acumulando en cada partida</param>
        public ClaseSimon(Button bEmpezar, Form formu, Button bVerde, Button bRojo, Button bAmarillo, Button bAzul, Label lblPuntos)
        {
            this.bEmpezarClass = bEmpezar;
            this.formuClass = formu;
            this.bVerdeClass = bVerde;
            this.bRojoClass = bRojo;
            this.bAmarilloClass = bAmarillo;
            this.bAzulClass = bAzul;
            this.lblPuntosClass = lblPuntos;

        }
        // Listado de int que va almacenando la secuencia de colores
        public static List<int> secuencia = new List<int>();
        //Variable Random que utilizamos para generar aleatoriamente un color para añadir a la lista
        Random random = new Random();
        //Contador que va indicando la posicion del indice que comprobaremos en cada iteracion
        int secuenciaIndice = 0;
        //String que mas adelante concatenaremos con la cantidad de puntos en lblPuntos
        String puntos = "Puntuacion: ";
        //String que mas adelante concatenaremos con la cantidad de puntos en lblPuntos
        String puntosFin = "Puntuacion Final: ";
        //Variable que va contando los puntos
        int puntuacion = 0;
        /// <summary>
        /// Cada vez que se pulsa un boton se llamara a esta funcion la cual comprobara si el boton
        /// pulsado es el que corresponde con la sencuencia. Si fallas, vuelve todos los botones a
        /// negro y resetea las variables para poder empezar una nueva partida.
        /// </summary>
        /// <param name="numBoton">Parametro que identifica que boton ha sido pulsado.</param>
        public void TurnoJuego(int numBoton)
        {
            bEmpezarClass.Enabled = false;
            if (numBoton == secuencia[secuenciaIndice])
            {
                switch (secuencia[secuenciaIndice])
                {
                    case 1:
                        bVerdeClass.BackColor = Color.Green;
                        break;
                    case 2:
                        bRojoClass.BackColor = Color.Red;
                        break;
                    case 3:
                        bAmarilloClass.BackColor = Color.Yellow;
                        break;
                    case 4:
                        bAzulClass.BackColor = Color.Blue;
                        break;
                }
                formuClass.Refresh();
                Thread.Sleep(500);

                bRojoClass.BackColor = Color.Silver;
                bVerdeClass.BackColor = Color.Silver;
                bAzulClass.BackColor = Color.Silver;
                bAmarilloClass.BackColor = Color.Silver;

                secuenciaIndice++;
                puntuacion += 10;
                //Si acertamos hasta el ultimo color de la lista llamamos al metodo TurnoOdenador()
                if (secuenciaIndice == secuencia.Count)
                {
                    Thread.Sleep(500);
                    TurnoOrdenador();
                }
            }
            else
            {
                bRojoClass.BackColor = Color.Black;
                bVerdeClass.BackColor = Color.Black;
                bAzulClass.BackColor = Color.Black;
                bAmarilloClass.BackColor = Color.Black;
                lblPuntosClass.Text = puntosFin + puntuacion;
                bEmpezarClass.Enabled = true;
                secuenciaIndice = 0;
                secuencia.Clear();
                puntuacion = 0;
            }

        }
        /// <summary>
        /// Metodo que sera llamado al empezar una partida o al haber completado correctamente
        /// la secuencia. Al principio agrega un nuevo color a la secuencia , desactivamos los
        /// botones y comenzamos a recorrer la secuencia y mostramos los colores de cada 
        /// posicion de la secuencia. Al final volvemos a activar los botones para que puedan
        /// ser pulsados.
        /// </summary>
        public void TurnoOrdenador()
        {
            lblPuntosClass.Text = puntos + puntuacion;
            secuencia.Add(random.Next(1, 5));
            bVerdeClass.Enabled = false;
            bRojoClass.Enabled = false;
            bAmarilloClass.Enabled = false;
            bAzulClass.Enabled = false;
            Thread.Sleep(500);

            for (int i = 0; i < secuencia.Count; i++)
            {
                if (secuencia[i] == 1)
                {
                    bVerdeClass.BackColor = Color.Green;
                }
                else if (secuencia[i] == 2)
                {
                    bRojoClass.BackColor = Color.Red;
                }
                else if (secuencia[i] == 3)
                {
                    bAmarilloClass.BackColor = Color.Yellow;
                }
                else if (secuencia[i] == 4)
                {
                    bAzulClass.BackColor = Color.Blue;
                }
                formuClass.Refresh();
                Thread.Sleep(1000);

                bRojoClass.BackColor = Color.Silver;
                bVerdeClass.BackColor = Color.Silver;
                bAzulClass.BackColor = Color.Silver;
                bAmarilloClass.BackColor = Color.Silver;

                formuClass.Refresh();
                Thread.Sleep(100);
            }
            bVerdeClass.Enabled = true;
            bRojoClass.Enabled = true;
            bAmarilloClass.Enabled = true;
            bAzulClass.Enabled = true;
            secuenciaIndice = 0;
        }
    }
}