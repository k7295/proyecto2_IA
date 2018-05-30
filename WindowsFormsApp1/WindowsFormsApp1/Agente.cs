using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Agente
    {
        private string ID;
        private string nombre;
        private List<string> servicios;

        public Agente(){ }

        public Agente(string iD, string nombre, List<string> servicios)
        {
            this.ID1 = iD;
            this.Nombre = nombre;
            this.Servicios = servicios;
        }

        public List<string> Servicios { get => servicios; set => servicios = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void imprimirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("/" + lista[i]);
            }
        }

        public void toString()
        {
            Console.WriteLine("id:" + this.ID1 + " nombre: " + this.Nombre + " servicios: ");
           imprimirLista(this.Servicios);
        }

    }

}
