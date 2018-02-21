using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_2_Evaluacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Semaforo semaforo_1;
        Semaforo semaforo_2;
        Semaforo semaforo_3;
        Semaforo semaforo_4;

        private void boton_averia_Click(object sender, EventArgs e)
        {
            semaforo_1 = new Semaforo(5, "ambar");
            semaforo_2 = new Semaforo();
            semaforo_3 = new Semaforo();
            semaforo_4 = new Semaforo();
        }

        private void boton_normal_Click(object sender, EventArgs e)
        {

        }

        private void boton_preferencia_Click(object sender, EventArgs e)
        {

        }

        private void boton_inteligente_Click(object sender, EventArgs e)
        {

        }
    }
}
