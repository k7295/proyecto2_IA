using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Geneticos
{
    class Individuo
    {
        public int[] Data { get; set; }


        public Individuo(int[] Data)
        {
            this.Data = Data;
        }

        private double promedio(Agente[] lista_agentes, Pedido[] lista_pedidos)
        {
            double cant_agentes = lista_agentes.Length;
            double cant_pedidos = lista_pedidos.Length;
            double gananciaTotal = 0;


            for (int i = 0; i < cant_pedidos; i++)
            {
                gananciaTotal += lista_pedidos[i].get_Precio();
            }

            return gananciaTotal / cant_agentes;
        }

        private double desviacion_estandar(Agente[] lista_agentes, Pedido[] lista_pedidos)
        {
            int cant_agentes = lista_agentes.Length;
            int cant_pedidos = lista_pedidos.Length;
            double sumatoria = 0;
            double promedio = this.promedio(lista_agentes, lista_pedidos);

            double valor_no_asignadas = 0;
            int cont_no_asginadas = 0;

            int[] suma_coste = this.crear_Array(cant_agentes);

            for (int i = 0; i < cant_pedidos; i++)
            {
                if (this.Data[i] != -1)
                {
                    suma_coste[this.Data[i]] += lista_pedidos[i].get_Precio();
                }
                else
                {
                    valor_no_asignadas += lista_pedidos[i].get_Precio() / 2;
                    cont_no_asginadas++;
                }

            }

            for (int i = 0; i < cant_agentes; i++)
            {
                sumatoria += Math.Pow(suma_coste[i] - promedio, 2);

            }

            sumatoria /= cant_agentes;

            if (cont_no_asginadas != 0)
            {
                valor_no_asignadas /= cont_no_asginadas;
            }


            sumatoria = Math.Sqrt(sumatoria);


            sumatoria += valor_no_asignadas;



            return sumatoria;
        }

        public double get_Fitness(Agente[] lista_agentes, Pedido[] lista_pedidos)
        {
            return desviacion_estandar(lista_agentes, lista_pedidos);
        }

        private int[] crear_Array(int tamaño)
        {
            int[] arreglo = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = 0;
            }
            return arreglo;
        }
    }
}
