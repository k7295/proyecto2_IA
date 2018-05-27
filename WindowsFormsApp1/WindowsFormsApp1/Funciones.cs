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
        /// <summary>
        /// Contains column names.
        /// </summary>
        List<string> _names = new List<string>();

        /// <summary>
        /// Contains column data arrays.
        /// </summary>
        List<double[]> _dataArray = new List<double[]>();

        public Funciones()
        {
            InitializeComponent();

            // Example column.
            _names.Add("Cat");
            // Three numbers of cat data.
            _dataArray.Add(new double[]
            {
                1.0,
                2.2,
                3.4
            });

            // Another example column.
            _names.Add("Dog");
            // Add three numbers of dog data.
            _dataArray.Add(new double[]
            {
                3.3,
                5.0,
                7.0
            });
            // Render the DataGridView.
            dataGridView1.DataSource = GetResultsTable();
        }

        /// <summary>
        /// This method builds a DataTable of the data.
        /// </summary>
        public DataTable GetResultsTable()
        {
            // Create the output table.
            DataTable d = new DataTable();

            // Loop through all process names.
            for (int i = 0; i < this._dataArray.Count; i++)
            {
                // The current process name.
                string name = this._names[i];

                // Add the program name to our columns.
                d.Columns.Add(name);

                // Add all of the memory numbers to an object list.
                List<object> objectNumbers = new List<object>();

                // Put every column's numbers in this List.
                foreach (double number in this._dataArray[i])
                {
                    objectNumbers.Add((object)number);
                }

                // Keep adding rows until we have enough.
                while (d.Rows.Count < objectNumbers.Count)
                {
                    d.Rows.Add();
                }

                // Add each item to the cells in the column.
                for (int a = 0; a < objectNumbers.Count; a++)
                {
                    d.Rows[a][i] = objectNumbers[a];
                }
            }
            return d;
        }
    }
        //    public Funciones()
        //    {
        //        InitializeComponent();
        //        this.CenterToScreen();
        //    }

        //    private void logica_labels(string accion)
        //    {   
        //        resetOpciones();
        //        switch (accion)
        //        {
        //            case "mostrar agentes":
        //                Console.WriteLine("mostrar agentes");
        //                picture_amarillo.Visible = true;
        //                mostrarAgentes.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
        //                DataTable dt = new DataTable("Northwind");
        //                DataColumn dc = new DataColumn("ProductID", typeof(int));

        //                break;
        //            case "mostrar servicios":
        //                Console.WriteLine("mostrar servicios");
        //                picture_naranja.Visible = true;
        //                mostrarServicios.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
        //                break;
        //            case "repartir ordenes":
        //                Console.WriteLine("repartir ordenes");
        //                repartirOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.verde;
        //                picture_verde.Visible = true;
        //                break;

        //        }
        //    }

        //    private void resetOpciones()
        //    {
        //        mostrarAgentes.Image = null;
        //        mostrarServicios.Image = null;
        //        repartirOrdenes.Image = null;

        //        picture_amarillo.Visible = false;
        //        picture_naranja.Visible = false;
        //        picture_verde.Visible = false;

        //    }
        //    private void boton_temporal_Click(object sender, EventArgs e)
        //    {
        //       string texto = this.textBox_temporal.Text;
        //       logica_labels(texto);
        //    }

        //}
}
