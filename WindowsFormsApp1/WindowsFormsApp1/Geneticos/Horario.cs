using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Geneticos
{
    class Horario
    {
        bool[][][] horario;


        public Horario(int cant_agentes)
        {
            this.horario = generarHorario(cant_agentes);
        }


        public bool horasLibres(int ind_agente, Pedido p)
        {
            int dia_indice = p.pasar_Dia_Ind();

            int hora_inicio_indice = p.pasar_Hora_Inicio_Ind();
            int hora_final_indice = p.pasar_Hora_Final_Ind();

            bool[][] agente_horario = horario[ind_agente];

            bool[] dia_horario = agente_horario[dia_indice];




            for (int i = hora_inicio_indice; i < hora_final_indice; i++)
            {
                if (dia_horario[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void marcarHoras(int ind_agente, Pedido p)
        {
            int dia_indice = p.pasar_Dia_Ind();
            int hora_inicio_indice = p.pasar_Hora_Inicio_Ind();
            int hora_final_indice = p.pasar_Hora_Final_Ind();

            for (int i = hora_inicio_indice; i < hora_final_indice; i++)
            {
                this.horario[ind_agente][dia_indice][i] = true;
            }
        }

        private bool[][][] generarHorario(int cant_agentes)
        {
            int cant_dias_semana = 7;
            int cant_media_horas_semana = 48;

            bool[][][] Horario = new bool[cant_agentes][][];
            for (int i = 0; i < cant_agentes; i++)
            {

                Horario[i] = new bool[cant_dias_semana][];
                for (int j = 0; j < cant_dias_semana; j++)
                {

                    Horario[i][j] = new bool[cant_media_horas_semana];
                    for (int k = 0; k < cant_media_horas_semana; k++)
                    {
                        Horario[i][j][k] = false;
                    }
                }
            }
            return Horario;
        }
    }
}
