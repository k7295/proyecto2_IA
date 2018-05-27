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

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void logica_labels(string accion)
        {
            Console.WriteLine(accion);
            switch (accion)
            {
                case "iniciar":
                    Console.WriteLine("LA PUTA AMA");
                    picture_rojo.Visible = true;
                    // ponerle delay :c 
                    Funciones form_funciones = new Funciones(); // se llama el form funciones (hay que cambiarle de nombre)
                    form_funciones.Visible = true;
                    this.Visible = false;
                    break;

            }
       
        }

        private void boton_temporal_Click(object sender, EventArgs e)
        {
           string texto = this.textBox_temporal.Text;
           logica_labels(texto);
        }
    }
}
