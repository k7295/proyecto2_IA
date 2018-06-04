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
        private string hora;
        private string dia;

        public Orden() { }

        public Orden(string iD, string nombre, string servicio,string hora,string dia)
        {
            this.ID1 = iD;
            this.Nombre = nombre;
            this.Servicio = servicio;
            this.Hora = hora;
            this.Dia = dia;
            
        }

        public string Servicio { get => servicios; set => servicios = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Dia { get => dia; set => dia = value; }

        public void toString()
        {
            Console.WriteLine("id:" + this.ID1 + " nombre: " + this.Nombre + " servicios: " + this.Servicio +
                              " hora: " + this.Hora + " dia: " + this.Dia);
        }
    }
}
