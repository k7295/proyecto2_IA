using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Geneticos
{
    class Genetico
    {
        Agente[] lista_agentes;
        Pedido[] lista_pedidos;

        Individuo[] poblacion;
        Random rand = new Random();


        public Genetico(Agente[] lista_agentes, Pedido[] lista_pedidos, int num_poblacion)
        {
            this.lista_agentes = lista_agentes;
            this.lista_pedidos = lista_pedidos;
            this.poblacion = crear_Poblacion(num_poblacion);
            this.evolucion(1000);
        }

        private bool[] generar_patron_random(int tam)
        {
            bool[] patron = new bool[tam];
            for (int i = 0; i < tam; i++)
            {
                patron[i] = this.rand.Next(2) == 0;
            }
            return patron;
        }

        private Individuo crear_Individuo_Aleatorio()
        {
            int[] suma_horas = this.crear_Array(this.lista_agentes.Length);
            int[] data = new int[this.lista_pedidos.Length];




            for (int i = 0; i < data.Length; i++)
            {
                Pedido p = lista_pedidos[i];
                ArrayList lista_tipos_servicios = this.obtener_Listas_Agentes_Tipos();
                ArrayList lista_actuales = this.obtener_Lista_Unico_Servicio(lista_tipos_servicios, p.Codigo_servicio);

                Horario h = new Horario(this.lista_agentes.Length);

                bool listo = false;
                while (!listo)
                {
                    if (lista_actuales.Count != 0)
                    {
                        int indice_agente_random = (int)lista_actuales[this.rand.Next(lista_actuales.Count)];
                        if (suma_horas[indice_agente_random] + p.get_Tiempo() <= 40)
                        {
                            if (h.horasLibres(indice_agente_random, p))
                            {
                                suma_horas[indice_agente_random] += p.get_Tiempo();
                                data[i] = indice_agente_random;
                                h.marcarHoras(indice_agente_random, p);
                                listo = true;
                            }
                            else
                            {
                                data[i] = -1;
                                listo = true;
                            }
                        }
                        else
                        {
                            lista_actuales.RemoveAt(indice_agente_random);
                        }
                    }
                    else
                    {
                        data[i] = -1;
                        listo = true;
                    }
                }

            }
            return new Individuo(data);
        }

        private Individuo[] crear_Poblacion(int cant)
        {
            Individuo[] poblacion = new Individuo[cant];
            for (int i = 0; i < cant; i++)
            {
                poblacion[i] = this.crear_Individuo_Aleatorio();
            }
            return poblacion;
        }

        private ArrayList obtener_Listas_Agentes_Tipos()
        {
            ArrayList lista_total = new ArrayList();

            ArrayList lista_ICE = new ArrayList();
            ArrayList lista_ICG = new ArrayList();
            ArrayList lista_ILA = new ArrayList();
            ArrayList lista_RCE = new ArrayList();
            ArrayList lista_RCG = new ArrayList();
            ArrayList lista_RLA = new ArrayList();

            for (int i = 0; i < lista_agentes.Length; i++)
            {
                if (lista_agentes[i].puede_Servicio("ICE"))
                {
                    lista_ICE.Add(i);
                }
                if (lista_agentes[i].puede_Servicio("ICG"))
                {
                    lista_ICG.Add(i);
                }
                if (lista_agentes[i].puede_Servicio("ILA"))
                {
                    lista_ILA.Add(i);
                }
                if (lista_agentes[i].puede_Servicio("RCE"))
                {
                    lista_RCE.Add(i);
                }
                if (lista_agentes[i].puede_Servicio("RCG"))
                {
                    lista_RCG.Add(i);
                }
                if (lista_agentes[i].puede_Servicio("RLA"))
                {
                    lista_RLA.Add(i);
                }
            }

            lista_total.Add(lista_ICE);
            lista_total.Add(lista_ICG);
            lista_total.Add(lista_ILA);
            lista_total.Add(lista_RCE);
            lista_total.Add(lista_RCG);
            lista_total.Add(lista_RLA);

            return lista_total;
        }

        private ArrayList obtener_Lista_Unico_Servicio(ArrayList lista_total, String p_tipo)
        {
            switch (p_tipo)
            {
                case "ICE":
                    return (ArrayList)lista_total[0];
                case "ICG":
                    return (ArrayList)lista_total[1];
                case "ILA":
                    return (ArrayList)lista_total[2];
                case "RCE":
                    return (ArrayList)lista_total[3];
                case "RCG":
                    return (ArrayList)lista_total[4];
                case "RLA":
                    return (ArrayList)lista_total[5];
                default:
                    return new ArrayList();
            }
        }

        private bool cruce_valido_choque_horario(Individuo padre1, Individuo padre2, bool[] patron, bool mutacion, int ind_mutacion)
        {
            Horario h = new Horario(lista_agentes.Length);

            int[] data1 = padre1.Data;
            int[] data2 = padre2.Data;
            int tamaño = padre1.Data.Length;

            bool elije;
            for (int i = 0; i < tamaño; i++)
            {
                elije = patron[i];
                if (mutacion && i == ind_mutacion)
                {
                    elije = !elije;
                }
                int[] data_actual;
                if (elije)
                {
                    data_actual = data1;
                }
                else
                {
                    data_actual = data2;
                }

                if (data_actual[i] != -1)
                {
                    if (h.horasLibres(data_actual[i], lista_pedidos[i]))
                    {
                        h.marcarHoras(data_actual[i], lista_pedidos[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool cruce_valido_max_horas(Individuo padre1, Individuo padre2, bool[] patron, bool mutacion, int ind_mutacion)
        {
            Horario h = new Horario(lista_agentes.Length);

            int[] data1 = padre1.Data;
            int[] data2 = padre2.Data;
            int tamaño = padre1.Data.Length;

            int[] horas_actuales = this.crear_Array(this.lista_agentes.Length);

            bool valido = true;
            bool elije;

            for (int i = 0; i < tamaño; i++)
            {
                elije = patron[i];
                if (mutacion && i == ind_mutacion)
                {
                    elije = !elije;
                }
                int[] data_actual;

                if (elije)
                {
                    data_actual = data1;
                }
                else
                {
                    data_actual = data2;
                }


                if (data_actual[i] != -1)
                {
                    horas_actuales[data_actual[i]] += this.lista_pedidos[i].get_Tiempo();
                }


                if (horas_actuales[data1[i]] > 40)
                {
                    valido = false;
                }

                if (!valido)
                {
                    return false;
                }
            }
            return true;
        }

        public Individuo cruce(Individuo padre1, Individuo padre2, bool[] patron, bool mutacion, int ind_mutacion)
        {
            int[] data1 = padre1.Data;
            int[] data2 = padre2.Data;
            int tamaño = padre1.Data.Length;

            int[] nueva_data = new int[tamaño];
            bool elije;


            for (int i = 0; i < tamaño; i++)
            {

                elije = patron[i];
                if (mutacion && i == ind_mutacion)
                {
                    elije = !elije;
                }
                int[] data_actual;

                if (elije)
                {

                    data_actual = data1;
                }
                else
                {
                    data_actual = data2;
                }

                nueva_data[i] = data_actual[i];


            }
            return new Individuo(nueva_data);
        }

        public int calcularPeor(List<Individuo> lista)
        {
            int ind = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[ind].get_Fitness(this.lista_agentes, this.lista_pedidos) > lista[i].get_Fitness(this.lista_agentes, this.lista_pedidos))
                {
                    ind = i;
                }
            }
            return ind;
        }

        private List<Individuo> obtener_N_Mejores(int cant)
        {
            List<Individuo> mejores = new List<Individuo>();
            int peor_en_lista = 0;
            for (int i = 1; i < this.poblacion.Length; i++)
            {
                if (mejores.Count < cant)
                {
                    mejores.Add(this.poblacion[i]);
                }
                else
                {
                    if (this.poblacion[i].get_Fitness(this.lista_agentes, this.lista_pedidos) < mejores[peor_en_lista].get_Fitness(this.lista_agentes, this.lista_pedidos))
                    {
                        mejores[peor_en_lista] = poblacion[i];
                        peor_en_lista = calcularPeor(mejores);
                    }
                }
            }
            return mejores;
        }

        private void next_Generacion()
        {
            Individuo[] nueva_Generacion = new Individuo[this.poblacion.Length];
            bool[] patron = this.generar_patron_random(this.poblacion.Length);

            int tercio = this.poblacion.Length / 3;
            // Console.Out.WriteLine("soy un tercio " + tercio);
            List<Individuo> mejores = obtener_N_Mejores(tercio);

            for (int i = 0; i < tercio; i++)
            {
                nueva_Generacion[i] = mejores[i];
            }

            for (int i = tercio; i < nueva_Generacion.Length; i++)
            {
                bool listo = false;
                while (!listo)
                {
                    Individuo padre1 = this.seleccion();
                    Individuo padre2 = this.seleccion();

                    bool mutacion = this.rand.Next(0, 100) == 0;
                    int indice_mutacion = rand.Next(padre1.Data.Length);
                    if (cruce_valido_max_horas(padre1, padre2, patron, mutacion, indice_mutacion))
                    {
                        if (cruce_valido_choque_horario(padre1, padre2, patron, mutacion, indice_mutacion))
                        {
                            Individuo hijo = cruce(padre1, padre2, patron, mutacion, indice_mutacion);
                            nueva_Generacion[i] = hijo;
                            listo = true;
                        }
                    }
                }
            }
            this.poblacion = nueva_Generacion;
        }

        public void evolucion(int cant_generacion)
        {
            for (int i = 0; i < cant_generacion; i++)
            {
                this.next_Generacion();
            }
        }

        public Individuo seleccion()
        {
            double peor_fitness = this.poblacion[0].get_Fitness(this.lista_agentes, this.lista_pedidos);
            for (int i = 1; i < poblacion.Length; i++)
            {
                double otro_fitness = poblacion[i].get_Fitness(this.lista_agentes, this.lista_pedidos);
                if (otro_fitness >= peor_fitness)
                {
                    peor_fitness = otro_fitness;
                }
            }

            peor_fitness += 1;

            double[] arreglo_rangos = new double[this.poblacion.Length];
            double acumulado = 0;

            for (int i = 0; i < poblacion.Length; i++)
            {
                double nuevo_fitness = peor_fitness - this.poblacion[i].get_Fitness(this.lista_agentes, this.lista_pedidos);
                acumulado += nuevo_fitness;

                arreglo_rangos[i] = acumulado;
            }

            double pivote_random = rand.NextDouble() * acumulado;

            int cont = 0;
            while (!(pivote_random <= arreglo_rangos[cont]))
            {
                cont++;
            }
            return this.poblacion[cont];
        }

        public Individuo obtener_Mejor()
        {
            Individuo mejor = this.poblacion[0];
            for (int i = 1; i < poblacion.Length; i++)
            {
                Individuo otro = poblacion[1];
                if (otro.get_Fitness(this.lista_agentes, this.lista_pedidos) < mejor.get_Fitness(this.lista_agentes, this.lista_pedidos))
                {
                    mejor = otro;
                }
            }
            return mejor;
        }



        //Funcion de Karen 
        public List<Agente> deme_agentes()
        {
            List<Agente> lista = new List<Agente>();
            Individuo mejor = this.obtener_Mejor();
            for (int i = 0; i < this.lista_agentes.Length; i++)
            {
                lista.Add(this.lista_agentes[i]);
            }
            
            for (int i = 0; i < mejor.Data.Length; i++)
            {
                Console.WriteLine(mejor.Data[i]);
                if (mejor.Data[i] != -1)
                {   
                    lista[mejor.Data[i]].add_Orden(this.lista_pedidos[i]);
                    
                }
            }
            return lista;
        }

        //private Orden pasar_Pedido_Orden(Pedido p)
        //{
        //    Orden o = new Orden(p.id.ToString(), p.nombre_cliente, p.codigo_servicio, p.hora_cita, p.dia_cita);
        //    return o;
        //}

        private int[] crear_Array(int tamaño)
        {
            int[] arreglo = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = 0;
            }
            return arreglo;
        }


        //static void Main(string[] args)
        //{
        //    Pedido p1 = new Pedido(00, "Jorge", "RCE", "9:30", "Lunes");
        //    Pedido p2 = new Pedido(01, "Mario", "ICE", "15:30", "Martes");
        //    Pedido p3 = new Pedido(03, "Carlos", "ILA", "19:30", "Miercoles");
        //    Pedido p4 = new Pedido(04, "Fausto", "RLA", "5:30", "Jueves");
        //    Pedido p5 = new Pedido(05, "Marcos", "ICG", "00:30", "Viernes");
        //    Pedido p6 = new Pedido(06, "Jorge", "RCE", "9:30", "Lunes");
        //    Pedido p7 = new Pedido(07, "Mario", "ICE", "15:30", "Martes");
        //    Pedido p8 = new Pedido(08, "Carlos", "ILA", "19:30", "Miercoles");
        //    Pedido p9 = new Pedido(09, "Fausto", "RLA", "5:30", "Jueves");
        //    Pedido p10 = new Pedido(10, "Marcos", "ICG", "00:30", "Viernes");
        //    Pedido p11 = new Pedido(11, "Jorge", "RCE", "9:30", "Lunes");
        //    Pedido p12 = new Pedido(12, "Mario", "ICE", "15:30", "Martes");
        //    Pedido p13 = new Pedido(13, "Carlos", "ILA", "19:30", "Miercoles");
        //    Pedido p14 = new Pedido(14, "Fausto", "RLA", "5:30", "Jueves");
        //    Pedido p15 = new Pedido(15, "Marcos", "ICG", "00:30", "Viernes");

        //    Pedido[] lista_p = { p1, p2, p3, p4, p5 };

        //    bool[] data1 = { false, false, false, true, true, true };
        //    bool[] data2 = { true, true, true, false, false, false };
        //    bool[] data3 = { true, false, true, false, true, false };
        //    bool[] data4 = { true, true, true, true, true, true };

        //    Agente a1 = new Agente("", data4);
        //    Agente a2 = new Agente("", data4);
        //    Agente a3 = new Agente("", data4);
        //    Agente a4 = new Agente("", data4);
        //    Agente a5 = new Agente("", data4);
        //    Agente a6 = new Agente("", data4);
        //    Agente a7 = new Agente("", data4);
        //    Agente a8 = new Agente("", data4);
        //    Agente a9 = new Agente("", data4);
        //    Agente a10 = new Agente("", data4);
        //    Agente a11 = new Agente("", data4);

        //    Agente[] lista_a = { a1, a2, a3 /*,a4,a5,a6,a7,a8,a9,a10,a11*/};


        //    int cant = 100;
        //    Genetico g = new Genetico(lista_a, lista_p, cant);



        //    Console.Out.WriteLine("------------------------------------");
        //    Individuo i = g.obtener_Mejor();
        //    Console.Out.WriteLine(i.Data[0]);
        //    Console.Out.WriteLine(i.Data[1]);
        //    Console.Out.WriteLine(i.Data[2]);
        //    Console.Out.WriteLine(i.Data[3]);
        //    Console.Out.WriteLine(i.Data[4]);
        //    Console.Out.WriteLine("------------------------------------");

        //    Console.Out.WriteLine(i.get_Fitness(lista_a, lista_p));
        //    g.deme_agentes()[0].toString();


        //    Console.In.Read();

        //}
    }
}
