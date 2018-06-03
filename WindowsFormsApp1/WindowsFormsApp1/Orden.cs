using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Orden
    {
        private string ID;
        private string nombre;
        private string servicios;

        public Orden() { }

        public Orden(string iD, string nombre, string servicio)
        {
            this.ID1 = iD;
            this.Nombre = nombre;
            this.Servicio = servicio;
        }

        public string Servicio { get => servicios; set => servicios = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        public void toString()
        {
            Console.WriteLine("id:" + this.ID1 + " nombre: " + this.Nombre + " servicios: " + this.Servicio);
        }
    }
}
