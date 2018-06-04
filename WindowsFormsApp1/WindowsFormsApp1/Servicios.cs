using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Servicios
    {
        private string nombre;
        private string comision;
        private string hora;

        public Servicios(string nombre, string comision, string hora)
        {
            this.Nombre = nombre;
            this.Comision = comision;
            this.Hora = hora;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Comision { get => comision; set => comision = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
