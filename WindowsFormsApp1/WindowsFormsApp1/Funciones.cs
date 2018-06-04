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
using WindowsFormsApp1.Geneticos;

namespace WindowsFormsApp1
{

    public partial class Funciones : Form
    {
        Manejador_XML funcionesXML = new Manejador_XML();
        // static string direccion = @"E:\GitHubProyectos\proyecto2_IA\WindowsFormsApp1";
        static string direccion = @"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1";
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
            colores_iniciales();
            Choices commands = new Choices();
            commands.Add(new string[] { "show agents", "show orders", "begin orders", "instructions" });
            gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);

            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);

            recEngine.SetInputToDefaultAudioDevice();

            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            agent = new Thread(agenteVoz);
            agent.Start();
            agent.Abort();


            // List<Agente> informacion = p.read_agenteXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml", "Agentes");
            // List<string> nombre_columnas = p.get_columns_agentes(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml");
            ///dataGridView1.DataSource = set_tabla(nombre_columnas, informacion);

           

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
            resetOpciones();
            switch (er.Result.Text)
            {
                case "show agents":
                    Console.WriteLine("mostrar agentes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Agents";
                    mostrarAgentes.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
                    picture_amarillo.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
                    //List<Agente> informacion = funcionesXML.read_agenteXML(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\agentes.xml", "Agentes");
                    //List<string> nombre_columnas = funcionesXML.get_columns_agentes(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\agentes.xml");
                    List<Agente> informacion = funcionesXML.read_agenteXML(direccion+@"\agentes.xml", "Agentes");
                    List<string> nombre_columnas = funcionesXML.get_columns_agentes(direccion + @"\agentes.xml");
                    tabla_info.DataSource = set_tabla_agentes(nombre_columnas, informacion);
                    break;
                case "show orders":
                    Console.WriteLine("mostrar ordenes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Orders";
                    mostrarOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
                    picture_naranja.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
                    List<Pedido> informacion_ordenes = funcionesXML.read_clienteXML(direccion + @"\clientes.xml", "Clientes");
                    List<string> nombre_columnas_ordenes = funcionesXML.get_columns_ordenes(direccion + @"\clientes.xml");
                    tabla_info.DataSource = set_tabla_ordenes(nombre_columnas_ordenes, informacion_ordenes);
                    break;
                case "begin orders":
                    Console.WriteLine("repartir ordenes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Repartir ordenes";
                    repartirOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    picture_verde.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    int cant = 50;
                    Agente[] lista_a = funcionesXML.read_agenteXML(direccion + @"\agentes.xml", "Agentes").ToArray();
                    Pedido[] lista_p = funcionesXML.read_clienteXML(direccion + @"\clientes.xml", "Clientes").ToArray();
                    Genetico g = new Genetico(lista_a, lista_p, cant);
                    Individuo i = g.obtener_Mejor();
                    Console.WriteLine(i.get_Fitness(lista_a, lista_p));
                    List<Agente> lista_agentes = g.deme_agentes();
                    List<string> nombre_columnas_repartir = new List<string>(new string[] { "ID", "Nombre", "Ordenes", "Comision", "Hora" });
                    tabla_info.DataSource = set_tabla_repatir(nombre_columnas_repartir, lista_agentes);
                    break;
                case "instructions":
                    repartirOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    picture_verde.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    pBuild.AppendText("The instructions are, show agents, show services, and begin orders");
                    sSynth.Speak(pBuild);
                    pBuild.ClearContent();
                    break;


            }



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
                    d.Rows[j][2] = agente.Cod_Servicios[0];
                    d.Rows[j][3] = agente.Cod_Servicios[1];
                    d.Rows[j][4] = agente.Cod_Servicios[2];

            }
            
            return d;
        }

        public DataTable set_tabla_repatir(List<string> nombreColumnas, List<Agente> informacion)
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
                d.Rows[j][2] = agente.getPedidos(agente.Ordenes);
                d.Rows[j][3] = agente.comision_total();
                d.Rows[j][4] = agente.horas_total();


            }

            return d;
        }

        public DataTable set_tabla_ordenes(List<string> nombreColumnas, List<Pedido> informacion)
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

                Pedido orden = informacion[j];
                Console.WriteLine("---------------");

                // Keep adding rows until we have enough.
                while (d.Rows.Count < informacion.Count)
                {
                    d.Rows.Add();
                }

                d.Rows[j][0] = orden.id;
                d.Rows[j][1] = orden.Nombre_cliente;
                d.Rows[j][2] = orden.Codigo_servicio;
                d.Rows[j][3] = orden.Dia_cita;
                d.Rows[j][4] = orden.Hora_cita;
            }

            return d;
        }

        private void logica_labels(string accion)
        {
            
            resetOpciones();
            Console.WriteLine(accion);
            switch (accion)
            {
                case "show agents":
                    Console.WriteLine("mostrar agentes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Agentes";
                    mostrarAgentes.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
                    picture_amarillo.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
                    //List<Agente> informacion = funcionesXML.read_agenteXML(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\agentes.xml", "Agentes");
                    //List<string> nombre_columnas = funcionesXML.get_columns_agentes(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\agentes.xml");
                    List<Agente> informacion = funcionesXML.read_agenteXML(direccion+@"\agentes.xml", "Agentes");
                    List<string> nombre_columnas = funcionesXML.get_columns_agentes(direccion + @"\agentes.xml");
                    
                    tabla_info.DataSource = set_tabla_agentes(nombre_columnas, informacion);
                   
                    
                    break;
                case "show orders":
                    Console.WriteLine("mostrar ordenes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Ordenes";
                    mostrarOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
                    picture_naranja.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
                    //List<Orden> informacion_ordenes = funcionesXML.read_clienteXML(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\clientes.xml", "Clientes");
                    //List<string> nombre_columnas_ordenes = funcionesXML.get_columns_ordenes(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\clientes.xml");
                    List<Pedido> informacion_ordenes = funcionesXML.read_clienteXML(direccion + @"\clientes.xml", "Clientes");
                    List<string> nombre_columnas_ordenes = funcionesXML.get_columns_ordenes(direccion + @"\clientes.xml");
                    tabla_info.DataSource = set_tabla_ordenes(nombre_columnas_ordenes, informacion_ordenes);
                    break;

                case "begin orders":
                    Console.WriteLine("repartir ordenes");
                    this.titulo_tabla.Visible = true;
                    titulo_tabla.Text = "Repartir ordenes";
                    repartirOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    picture_verde.Image = global::WindowsFormsApp1.Properties.Resources.verde;
                    int cant = 100;
                    Agente[] lista_a = funcionesXML.read_agenteXML(direccion + @"\agentes.xml", "Agentes").ToArray();
                    Pedido[] lista_p = funcionesXML.read_clienteXML(direccion + @"\clientes.xml", "Clientes").ToArray();
                    Genetico g = new Genetico(lista_a, lista_p, cant);
                    Individuo i = g.obtener_Mejor();
                    Console.WriteLine(i.get_Fitness(lista_a, lista_p));
                    List<Agente> lista_agentes = g.deme_agentes();
                    List<string> nombre_columnas_repartir = new List<string>(new string[] { "ID","Nombre","Ordenes","Comision","Hora"});
                    tabla_info.DataSource = set_tabla_repatir(nombre_columnas_repartir,lista_agentes);
                    break;

                case "instructions":
                    Console.WriteLine("ayuda");
                    Ayuda.Image = global::WindowsFormsApp1.Properties.Resources.ayuda;
                    ayuda_colores.Visible = true;
                    break;

            }
        }

        private void resetOpciones()
        {
            colores_iniciales();
            this.titulo_tabla.Visible = false;
            titulo_tabla.ResetText();
            tabla_info.DataSource = null;

        }

        public void colores_iniciales()
        {
            mostrarAgentes.Image = global::WindowsFormsApp1.Properties.Resources.amarillo_pastel;
            picture_amarillo.Image = global::WindowsFormsApp1.Properties.Resources.amarillo_pastel;

            mostrarOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.naranja_pastel;
            picture_naranja.Image = global::WindowsFormsApp1.Properties.Resources.naranja_pastel;

            repartirOrdenes.Image = global::WindowsFormsApp1.Properties.Resources.verde_pastel;
            picture_verde.Image = global::WindowsFormsApp1.Properties.Resources.verde_pastel;

        }
        private void boton_temporal_Click(object sender, EventArgs e)
        {
            string texto = this.textBox_temporal.Text;
            logica_labels(texto);
        }

    }




}
