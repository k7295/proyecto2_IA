using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Agente
    {
       
        private int ID;
        private String nombre;
        private List<String> cod_servicios;
        private List<Pedido> ordenes = new List<Pedido>();


        private bool[] servicios_Disp;

        
        public int ID1 { get => ID; set => ID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<string> Cod_Servicios { get => cod_servicios; set => cod_servicios = value; }
        public bool[] Servicios_Disp { get => servicios_Disp; set => servicios_Disp = value; }



        public List<Pedido> Ordenes { get => this.ordenes; set => this.ordenes = value; }

        public Agente(){ }

        //public Agente(string iD, string nombre, List<string> servicios)
        //{
        //    this.ID1 = int.Parse(iD);
        //    this.Nombre = nombre;
        //    this.Servicios = servicios;
        //}

        public Agente(string ID,String nombre, bool[] servicios)
        {
            this.ID1 = int.Parse(ID);
            this.Nombre = nombre;
            this.Servicios_Disp = servicios;
            this.Cod_Servicios = this.obtener_Lista_Servcios();
            this.ordenes = new List<Pedido>();
        }

        public bool puede_Servicio(String servicio)
        {
            return Servicios_Disp[pasar_Codigo_Ind(servicio)];
        }

        public List<String> obtener_Lista_Servcios()
        {
            List<String> lista = new List<String>();

            for (int i = 0; i < this.Servicios_Disp.Length; i++)
            {
                if (Servicios_Disp[i])
                {
                    lista.Add(pasar_Codigo_Servicio(i));
                }
            }
            return lista;
        }

        public List<bool> obtener_servicios_bool(List<string> lista_servicios)
        {
            List<string> servicios = new List<string>(new string[] { "ICE", "ICG", "ILA", "RCE", "RCG", "RLA" });
            List<bool> servicios_bool = new List<bool>();

            for (int j = 0; j < servicios.Count; j++)
            {
                if (lista_servicios.Contains(servicios[j]))
                {
                    servicios_bool.Add(true);
                }
                else
                {
                    servicios_bool.Add(false);
                }
            }
           
            return servicios_bool;
        }

        public void add_Orden(Pedido p)
        {
            this.ordenes.Add(p);
        }

        private String pasar_Codigo_Servicio(int i)
        {
            switch (i)
            {
                case 0:
                    return "ICE";
                case 1:
                    return "ICG";
                case 2:
                    return "ILA";
                case 3:
                    return "RCE";
                case 4:
                    return "RCG";
                case 5:
                    return "RLA";
                default:
                    return "";
            }
        }

        private int pasar_Codigo_Ind(String codigo_actual)
        {


            switch (codigo_actual)
            {
                case "ICE":
                    return 0;
                case "ICG":
                    return 1;
                case "ILA":
                    return 2;
                case "RCE":
                    return 3;
                case "RCG":
                    return 4;
                case "RLA":
                    return 5;
                default:
                    return -1;
            }
        }

        public void imprimirLista(List<Pedido> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("/" + lista[i].Codigo_servicio);
            }
        }


        public string toString_servicios()
        {
            string servicios = "";
            for (int i = 0; i < this.Cod_Servicios.Count; i++)
            {
                Console.WriteLine("/" + this.Cod_Servicios[i]);
                servicios += this.Cod_Servicios[i] + ", ";
            }
            return servicios;
        }

        public int comision_total()
        {
            List<Servicios> servicios_disp = servicios_disponibles();
            int comision = 0;
            for (int i = 0; i < this.ordenes.Count; i++)
            {

                for (int j = 0; j < servicios_disp.Count; j++)
                {
                    if(servicios_disp[j].Nombre == this.ordenes[i].Codigo_servicio)
                    {
                        comision += int.Parse(servicios_disp[j].Comision);
                    }
                    
                }
            }
            return comision;
        }

        public int horas_total()
        {
            List<Servicios> servicios_disp = servicios_disponibles();
            int horas = 0;
            for (int i = 0; i < this.ordenes.Count; i++)
            {

                for (int j = 0; j < servicios_disp.Count; j++)
                {
                    if (servicios_disp[j].Nombre == this.ordenes[i].Codigo_servicio)
                    {
                        horas += int.Parse(servicios_disp[j].Hora);
                    }

                }
            }
            return horas;
        }

        public string toString_servicios_bool()
        {
            string servicios = "";
            for (int i = 0; i < this.servicios_Disp.Length; i++)
            {
                Console.WriteLine("/" + this.servicios_Disp[i]);
                servicios += this.servicios_Disp + ", ";
            }
            return servicios;
        }

        public List<Servicios> servicios_disponibles()
        {
            List<Servicios> lista_servicios = new List<Servicios>();
            Servicios ICE = new Servicios("ICE", "250", "2");
            Servicios ICG = new Servicios("ICG", "400", "4");
            Servicios ILA = new Servicios("ILA", "200", "1");
            Servicios RCE = new Servicios("RCE", "300", "4");
            Servicios RCG = new Servicios("RCG", "500", "6");
            Servicios RLA = new Servicios("RLA", "250", "6");
            lista_servicios.Add(ICE);
            lista_servicios.Add(ICG);
            lista_servicios.Add(ILA);
            lista_servicios.Add(RCE);
            lista_servicios.Add(RCG);
            lista_servicios.Add(RLA);

            return lista_servicios;
        }

        public void toString()
        {
            Console.WriteLine("id:" + this.ID1 + " nombre: " + this.Nombre + " comision: " + comision_total() +" horas totales: " + horas_total()+" servicios: ");
            imprimirLista(this.ordenes);
        }

    }

}
