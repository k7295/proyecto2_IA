using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;


namespace WindowsFormsApp1
{

    public partial class Funciones : Form
    {
<<<<<<< HEAD
        Manejador_XML funcionesXML = new Manejador_XML();
        
=======


        Program funcionesXML = new Program();
>>>>>>> edwin
        //List<string> _names = new List<string>();
        System.Windows.Forms.Timer timRun = new System.Windows.Forms.Timer();
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer sSynth = new SpeechSynthesizer();

        GrammarBuilder gBuilder;
        PromptBuilder pBuild = new PromptBuilder();
        Thread agent;
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

<<<<<<< HEAD
        }
        
        public DataTable set_tabla_agentes(List<string> nombreColumnas, List<Agente> informacion)
=======
            Choices commands = new Choices();
            commands.Add(new string[] { "show agents", "show services", "begin orders","help" });
            gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);

            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);

            recEngine.SetInputToDefaultAudioDevice();

            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            agent = new Thread(agenteVoz);
            agent.Start();
        }

        public void agenteVoz()
        {
            DateTime localDate = DateTime.Now;

            pBuild.AppendText("Waiting for instructions");
            sSynth.Speak(pBuild);
            pBuild.ClearContent();

            recEngine.RecognizeAsync();


            while (true)
            {
                DateTime localDatenew = DateTime.Now;
                if ((localDatenew - localDate).TotalSeconds > 5)
                {
                    break;
                }
            }
            recEngine.RecognizeAsyncStop();
            agenteVoz();
        }

        public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs er)
        {

            switch (er.Result.Text)
            {
                case "show agents":
                    Console.WriteLine("mostrar agentes");
                    titulo_tabla.Text = "Agentes";
                    picture_amarillo.Visible = true;
                    mostrarAgentes.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;


                    break;
                case "show services":
                    Console.WriteLine("mostrar servicios");
                    titulo_tabla.Text = "Servicios";
                    picture_naranja.Visible = true;
                    mostrarServicios.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
                    List<string> nombre_columnas = funcionesXML.get_columns(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");
                    List<List<string>> informacion = funcionesXML.readXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");
                    dataGridView1.DataSource = set_tabla(nombre_columnas, informacion);
                    break;
                case "begin orders":
                    Console.WriteLine("repartir ordenes");
                    titulo_tabla.Text = "Repartir ordenes";
                    repartirOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    picture_verde.Visible = true;
                    break;
                case "help":
                    Ayuda.Image = global::WindowsFormsApp1.Properties.Resources.ayuda;
                    ayuda_colores.Visible = true;
                    pBuild.AppendText("The instructions are, show agents, show services, and begin orders");
                    sSynth.Speak(pBuild);
                    pBuild.ClearContent();
                    break;


            }
           


        }


        public DataTable set_tabla(List<string> nombreColumnas, List<List<string>> informacion)
>>>>>>> edwin
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

        private void mostrarAgentes_Click(object sender, EventArgs e)
        {
            string texto = this.textBox_temporal.Text;
            logica_labels(texto);
        }

    }




}
