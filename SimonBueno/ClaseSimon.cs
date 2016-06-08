using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//METEMOS ESTAS CLASES PARA USAR LOS COLORES, OBEJETOS DE LOS FORMULARIOS Y EL SLEEP
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimonBueno
{   
    public class ClaseSimon
    {
        #region DECLARACION DE CAMPOS
        //Variables que utilizaremos para el constructor
        Form formuClass;
        Button bEmpezarClass;
        Button bVerdeClass;
        Button bRojoClass;
        Button bAmarilloClass;
        Button bAzulClass;
        Label lblPuntosClass;
        // Listado de int que va almacenando la secuencia de colores
        public static List<int> secuencia = new List<int>();
        //Declaracion de sinidos de los botones
        System.Media.SoundPlayer boton1 = new System.Media.SoundPlayer(Resource1.boton1);
        System.Media.SoundPlayer boton2 = new System.Media.SoundPlayer(Resource1.boton2);
        System.Media.SoundPlayer boton3 = new System.Media.SoundPlayer(Resource1.boton3);
        System.Media.SoundPlayer boton4 = new System.Media.SoundPlayer(Resource1.boton4);
        System.Media.SoundPlayer perder = new System.Media.SoundPlayer(Resource1.perder);
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
        #endregion

        #region CONSTRUCTOR
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
        #endregion

        #region DECLARACION DE METODOS
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
                        boton1.Play();
                        break;
                    case 2:
                        bRojoClass.BackColor = Color.Red;
                        boton2.Play();
                        break;
                    case 3:
                        bAmarilloClass.BackColor = Color.Yellow;
                        boton3.Play();
                        break;
                    case 4:
                        bAzulClass.BackColor = Color.Blue;
                        boton4.Play();
                        break;
                }
                formuClass.Refresh();
                Thread.Sleep(500);

                bRojoClass.BackColor = Color.Transparent;
                bVerdeClass.BackColor = Color.Transparent;
                bAzulClass.BackColor = Color.Transparent;
                bAmarilloClass.BackColor = Color.Transparent;

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
                /* bRojoClass.BackColor = Color.Black;
                    bVerdeClass.BackColor = Color.Black;
                    bAzulClass.BackColor = Color.Black;
                    bAmarilloClass.BackColor = Color.Black;*/
                formuClass.BackgroundImage = Properties.Resources.wallpaperFinal;
                perder.Play();
                lblPuntosClass.Text = puntosFin + puntuacion;
                MessageBox.Show(puntosFin + puntuacion);
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
            /*bVerdeClass.Enabled = false;
            bRojoClass.Enabled = false;
            bAmarilloClass.Enabled = false;
            bAzulClass.Enabled = false;*/
            Thread.Sleep(500);

            for (int i = 0; i < secuencia.Count; i++)
            {
                if (secuencia[i] == 1)
                {
                    bVerdeClass.BackColor = Color.Green;
                    boton1.Play();
                }
                else if (secuencia[i] == 2)
                {
                    bRojoClass.BackColor = Color.Red;
                    boton2.Play();
                }
                else if (secuencia[i] == 3)
                {
                    bAmarilloClass.BackColor = Color.Yellow;
                    boton3.Play();
                }
                else if (secuencia[i] == 4)
                {
                    bAzulClass.BackColor = Color.Blue;
                    boton4.Play();
                }
                formuClass.Refresh();
                Thread.Sleep(1000);

                bRojoClass.BackColor = Color.Transparent;
                bVerdeClass.BackColor = Color.Transparent;
                bAzulClass.BackColor = Color.Transparent;
                bAmarilloClass.BackColor = Color.Transparent;

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
    #endregion
}