﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Funciones : Form
    {
        Manejador_XML funcionesXML = new Manejador_XML();
        
        //List<string> _names = new List<string>();

        ///// <summary>
        ///// Contains column data arrays.
        ///// </summary>
        //List<double[]> _dataArray = new List<double[]>();

        public Funciones()
        {
            InitializeComponent();
            this.CenterToScreen();


            //List<string> nombre_columnas = funcionesXML.get_columns(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");
            //List<List<string>> informacion = funcionesXML.readXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");
            //List<Agente> informacion = p.read_agenteXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml", "Agentes");
            //List<string> nombre_columnas = p.get_columns_agentes(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml");
            //dataGridView1.DataSource = set_tabla(nombre_columnas, informacion);

        }
        
        public DataTable set_tabla_agentes(List<string> nombreColumnas, List<Agente> informacion)
        {
            // Create the output table.
            DataTable d = new DataTable();

            // Loop through all process names.
            for (int i = 0; i < nombreColumnas.Count; i++)
            {
                // Add the program name to our columns.
                d.Columns.Add(nombreColumnas[i]);
            }

            for (int j = 0; j < informacion.Count; j++)
                {

                    Agente agente = informacion[j];
                    Console.WriteLine("---------------");

                  // Keep adding rows until we have enough.
                    while (d.Rows.Count < informacion.Count)
                    {
                        d.Rows.Add();
                    }

                    d.Rows[j][0] = agente.ID1;
                    d.Rows[j][1] = agente.Nombre;
                    d.Rows[j][2] = agente.Servicios[0];
                    d.Rows[j][3] = agente.Servicios[1];
                    d.Rows[j][4] = agente.Servicios[2];

            }
            
            return d;
        }

        public DataTable set_tabla_ordenes(List<string> nombreColumnas, List<Orden> informacion)
        {
            // Create the output table.
            DataTable d = new DataTable();

            // Loop through all process names.
            for (int i = 0; i < nombreColumnas.Count; i++)
            {
                // Add the program name to our columns.
                d.Columns.Add(nombreColumnas[i]);
            }

            for (int j = 0; j < informacion.Count; j++)
            {

                Orden orden = informacion[j];
                Console.WriteLine("---------------");

                // Keep adding rows until we have enough.
                while (d.Rows.Count < informacion.Count)
                {
                    d.Rows.Add();
                }

                d.Rows[j][0] = orden.ID1;
                d.Rows[j][1] = orden.Nombre;
                d.Rows[j][2] = orden.Servicio;
            }

            return d;
        }

        private void logica_labels(string accion)
        {
            resetOpciones();
            Console.WriteLine(accion);
            switch (accion)
            {
                case "mostrar agentes":
                    Console.WriteLine("mostrar agentes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Agentes";
                    picture_amarillo.Visible = true;
                    mostrarAgentes.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
                    List<Agente> informacion = funcionesXML.read_agenteXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml", "Agentes");
                    List<string> nombre_columnas = funcionesXML.get_columns_agentes(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml");
                    tabla_info.DataSource = set_tabla_agentes(nombre_columnas, informacion); 
                    break;
                case "mostrar ordenes":
                    Console.WriteLine("mostrar ordenes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Ordenes";
                    picture_naranja.Visible = true;
                    mostrarOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
                    List<Orden> informacion_ordenes = funcionesXML.read_clienteXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\clientes.xml", "Clientes");
                    List<string> nombre_columnas_ordenes = funcionesXML.get_columns_ordenes(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\clientes.xml");
                    tabla_info.DataSource = set_tabla_ordenes(nombre_columnas_ordenes, informacion_ordenes);
                    break;
                case "repartir ordenes":
                    Console.WriteLine("repartir ordenes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Repartir ordenes";
                    repartirOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    picture_verde.Visible = true;
                    break;

                case "ayuda":
                    Console.WriteLine("ayuda");
                    Ayuda.Image = global::WindowsFormsApp1.Properties.Resources.ayuda;
                    ayuda_colores.Visible = true;
                    break;

            }
        }

        private void resetOpciones()
        {
            mostrarAgentes.Image = null;
            mostrarOrdenes.Image = null;
            repartirOrdenes.Image = null;

            this.titulo_tabla.Visible = false;

            picture_amarillo.Visible = false;
            picture_naranja.Visible = false;
            picture_verde.Visible = false;

            titulo_tabla.ResetText();
            tabla_info.DataSource = null;

        }
        private void boton_temporal_Click(object sender, EventArgs e)
        {
            string texto = this.textBox_temporal.Text;
            logica_labels(texto);
        }

    }




}
