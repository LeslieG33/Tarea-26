using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_26
{
    public partial class frmTarea26 : Form
    {
        public frmTarea26()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            // Calcular el factorial de cualquier número entero positivo
            // Tarea 26
            // Leslie Giselle Avila Romero 23211918

            // Declaración de variables y tipo Random
            ulong c = 0, c2 = 1;
            int N;
            
            //Random aleatorio = new Random();

            // Generación y asignación del número aleatorio
            //N = aleatorio.Next(100);
            N = Convert.ToInt32(txtN.Text);
            // Do-While para captura del número
            if (N > 0)
            {
                do
                {
                    c = c + 1;
                    c2 = c2 * c;

                } while (N > 1);
                MessageBox.Show("El factorial de " + N.ToString() + " = " + c2.ToString(), "RESULTADO"); ;
                txtN.Clear();
                txtN.Focus();
            }
            else 
            {
                MessageBox.Show("El factorial de 0 es 1","RESULTADO");
                txtN.Clear();
                txtN.Focus();
            }
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
        }
        private void cmdSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
