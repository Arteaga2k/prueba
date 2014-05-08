using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Git_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            muestraMensaje();
        }

        /// <summary>
        /// Método que muestra un mensaje por pantalla
        /// </summary>
        private void muestraMensaje()
        {
            MessageBox.Show("Saludos desde ¡Hola Mundo!");
        }

    }
}
