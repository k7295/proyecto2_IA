using System;
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
        Program funcionesXML = new Program();
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
            //dataGridView1.DataSource = set_tabla(nombre_columnas, informacion);
          
        }
        
        public DataTable set_tabla(List<string> nombreColumnas, List<List<string>> informacion)
        {
            // Create the output table.
            DataTable d = new DataTable();

            // Loop through all process names.
            for (int i = 0; i < nombreColumnas.Count; i++)
            {
                // Add the program name to our columns.
                d.Columns.Add(nombreColumnas[i]);

                for (int j = 0; j < informacion[i].Count; j++)
                {

                    string info_servicio = informacion[i][j];
                    Console.WriteLine("---------------");
                    Console.WriteLine(info_servicio);
                   // Keep adding rows until we have enough.
                    while (d.Rows.Count < informacion[i].Count)
                    {
                        d.Rows.Add();
                    }

                    d.Rows[j][i] = info_servicio;
 
                }
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
                    titulo_tabla.Text = "Agentes";
                    picture_amarillo.Visible = true;
                    mostrarAgentes.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
                
                    break;
                case "mostrar servicios":
                    Console.WriteLine("mostrar servicios");
                    titulo_tabla.Text = "Servicios";
                    picture_naranja.Visible = true;
                    mostrarServicios.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
                    List<string> nombre_columnas = funcionesXML.get_columns(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");
                    List<List<string>> informacion = funcionesXML.readXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");
                    dataGridView1.DataSource = set_tabla(nombre_columnas, informacion);
                    break;
                case "repartir ordenes":
                    Console.WriteLine("repartir ordenes");
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
            mostrarServicios.Image = null;
            repartirOrdenes.Image = null;

            picture_amarillo.Visible = false;
            picture_naranja.Visible = false;
            picture_verde.Visible = false;

            titulo_tabla.ResetText();
            dataGridView1.DataSource = null;

        }
        private void boton_temporal_Click(object sender, EventArgs e)
        {
            string texto = this.textBox_temporal.Text;
            logica_labels(texto);
        }

    }




}
