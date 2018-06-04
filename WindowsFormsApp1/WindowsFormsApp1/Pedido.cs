using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pedido
    {
        private string ID;
        private string nombre_cliente;
        private String codigo_servicio;
        private string hora_cita;
        private string dia_cita;

        public Pedido() { }

        
        static int[] Precio = { 250, 400, 200, 300, 500, 250 };
        static int[] Horas = { 2, 4, 1, 4, 6, 6 };

        public string id { get => ID; set => ID = value; }
        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Codigo_servicio { get => codigo_servicio; set => codigo_servicio = value; }
        public string Hora_cita { get => hora_cita; set => hora_cita = value; }
        public string Dia_cita { get => dia_cita; set => dia_cita = value; }

        public Pedido(int pid, String conmbre_cliente, String codigo_servicio, String hora_cita, String dia_cita)
        {
            this.id = pid.ToString();
            this.Nombre_cliente = Nombre_cliente;
            this.Codigo_servicio = codigo_servicio;
            this.Hora_cita = hora_cita;
            this.Dia_cita = dia_cita;

        }

        private int pasar_Codigo_Ind()
        {
            String codigo_actual = this.Codigo_servicio;

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

        public int pasar_Dia_Ind()
        {
            String dia_actual = this.dia_cita;
            switch (dia_actual)
            {
                case "Lunes":
                    return 0;
                case "Martes":
                    return 1;
                case "Miercoles":
                    return 2;
                case "Jueves":
                    return 3;
                case "Viernes":
                    return 4;
                case "Sabado":
                    return 5;
                case "Domingo":
                    return 6;
                default:
                    return -1;

            }
        }

        public int pasar_Hora_Inicio_Ind()
        {
            string[] hora_dividida = this.Hora_cita.Split(':');
            String h = hora_dividida[0];
            String m = hora_dividida[1];

            int ind = 0;
            ind += 2 * Int32.Parse(h);
            if (m == "30")
            {
                ind += 1;
            }
            return ind;
        }

        public int pasar_Hora_Final_Ind()
        {
            string[] hora_dividida = this.Hora_cita.Split(':');
            String h = hora_dividida[0];
            String m = hora_dividida[1];

            int ind = 0;
            ind += 2 * Int32.Parse(h);
            if (m == "30")
            {
                ind += 1;
            }

            ind += Horas[this.pasar_Codigo_Ind()];

            return ind;
        }

        public int get_Precio()
        {
            return Precio[this.pasar_Codigo_Ind()];
        }

        public int get_Tiempo()
        {
            return Horas[this.pasar_Codigo_Ind()];
        }

        public void toString()
        {
            Console.WriteLine("id:" + this.ID + " nombre: " + this.Nombre_cliente + " servicios: " + this.Codigo_servicio +
                              " hora: " + this.Hora_cita + " dia: " + this.Dia_cita);
        }
    }
}
