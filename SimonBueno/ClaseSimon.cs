using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimonBueno;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimonBueno
{
    public class ClaseSimon
    {
        public static List<int> secuencia = new List<int>();
        Random random = new Random();
        int secuenciaIndice = 0;
        String puntos = "Puntuacion: ";
        int puntuacion = 0;
        public void TurnoJuego(int numBoton ,Form formu,Button bEmpezar, Button bVerde, Button bRojo, Button bAmarillo, Button bAzul,Label lblPuntos)
        {
            bEmpezar.Enabled = false;
            if (numBoton == secuencia[secuenciaIndice])
            {
                switch (secuencia[secuenciaIndice])
                {
                    case 1:
                        bVerde.BackColor = Color.Green;
                        break;
                    case 2:
                        bRojo.BackColor = Color.Red;
                        break;
                    case 3:
                        bAmarillo.BackColor = Color.Yellow;
                        break;
                    case 4:
                        bAzul.BackColor = Color.Blue;
                        break;
                }
                formu.Refresh();
                Thread.Sleep(500);
                
                bRojo.BackColor = Color.Silver;
                bVerde.BackColor = Color.Silver;
                bAzul.BackColor = Color.Silver;
                bAmarillo.BackColor = Color.Silver;

                secuenciaIndice++;
                puntuacion += 10;
                if (secuenciaIndice == secuencia.Count)
                {
                    Thread.Sleep(500);
                    TurnoOrdenador(formu,bVerde, bRojo,bAmarillo,bAzul,lblPuntos);
                }
            }else{
                bRojo.BackColor = Color.Black;
                bVerde.BackColor = Color.Black;
                bAzul.BackColor = Color.Black;
                bAmarillo.BackColor = Color.Black;
                bEmpezar.Enabled = true;
                secuenciaIndice = 0;
                secuencia.Clear();
                puntuacion = 0;
            }

        }

        public void TurnoOrdenador(Form formu, Button bVerde, Button bRojo, Button bAmarillo, Button bAzul,Label lblPuntos)
        {
            lblPuntos.Text = puntos + puntuacion;
            secuencia.Add(random.Next(1, 5));
            bVerde.Enabled = false;
            bRojo.Enabled = false;
            bAmarillo.Enabled = false;
            bAzul.Enabled = false;

            for (int i = 0; i < secuencia.Count; i++)
            {
                if (secuencia[i] == 1)
                {
                    bVerde.BackColor = Color.Green;
                }
                else if (secuencia[i] == 2)
                {
                    bRojo.BackColor = Color.Red;
                }
                else if (secuencia[i] == 3)
                {
                    bAmarillo.BackColor = Color.Yellow;
                }
                else if (secuencia[i] == 4)
                {
                    bAzul.BackColor = Color.Blue;
                }
                formu.Refresh();
                Thread.Sleep(1000);
                
                bRojo.BackColor = Color.Silver;
                bVerde.BackColor = Color.Silver;
                bAzul.BackColor = Color.Silver;
                bAmarillo.BackColor = Color.Silver;

                formu.Refresh();
                Thread.Sleep(100);
            }
            bVerde.Enabled = true;
            bRojo.Enabled = true;
            bAmarillo.Enabled = true;
            bAzul.Enabled = true;
            secuenciaIndice = 0;
        }
    }
}
