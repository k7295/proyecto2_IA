using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.Geneticos;

namespace WindowsFormsApp1
{
   
    public class Manejador_XML
    {
         static string direccion = @"E:\GitHubProyectos\proyecto2_IA\WindowsFormsApp1";
       // static string direccion = @"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1";

        List<string> servicios = new List<string>(new string[] { "ICE", "ICG", "ILA", "RCE", "RCG", "RLA" }) ;
        List<string> dias_laborales = new List<string>(new string[] { "Lunes","Martes","Miercoles","Jueves","Viernes" });
        List<string> horas_laborales = new List<string>(new string[] { "7:00", "7:30", "8:00", "8:30", "9:00","9:30","10:00","10:30","11:00","11:30","1:00","1:30",
                                                            "2:00","2:30","3:00"});
        //List<string> nombre_agentes = new List<string>(new string[] { "Fulano Mengano","Colton Ramos","Stuart Mcguire",
        //                                               "Hoyt Wilkerson","Nissim Dennis","Dalton Serrano","Daquan Waters",
        //                                               "Byron Roman","Caldwell Soto","Rudyard Fitzgerald","Kato Gardner",
        //                                               "Cody Cantu","Eric Duke","Rogan Fleming","Hop Nixon","Caldwell Brooks",
        //                                               "Julian Roman","Dustin Mercado","Wylie Mcneil","Elmo Buck","Callum Lambert","Cedric Cooke",
        //                                               "Kaseem Weber","Armando Waters","Victor Camacho","Gabriel Roach","Graham Wise",
        //                                               "Ferris Carroll","Edan Alvarez","Caleb Floyd","Hoyt Jefferson","Russell Vega",
        //                                               "Clark Salinas","Geoffrey Lawson","Ignatius Stewart","Tyrone Bradshaw",
        //                                               "Quinlan Lott","Odysseus Howe","Kibo Zamora","Preston Wallace","Andrew Talley","Thor Bean",
        //                                               "Upton Hardy","Xanthus Garner","Lewis Mack","Alfonso Tanner","Francis Hansen","Xanthus Ochoa","Wesley Campos",
        //                                               "Chester Sparks","Ferris Nunez","Baxter Schmidt","Len Barr","Quinn Sloan","Cedric Brewer","Craig Bryan",
        //                                               "Aquila Tanner","Cade Nolan","Elmo Mcclain","Carter Reeves","Yasir Wolf","Otto Simmons","Timon Faulkner",
        //                                               "Craig Craft","Kyle Skinner","Joel Burton","Lars Small","Ulysses Carson","Aladdin Valentine","Donovan Kramer","Silas Scott",
        //                                               "Jesse Lancaster","Warren Norman","Kadeem Odonnell","Jesse Cross","Denton Coffey","Orson Justice","Fulton Carter","Emerson Payne","Brett Forbes",
        //                                               "Chaney Stark","Prescott Guerra","Boris Hartman","Nash White",
        //                                               "Merritt Blake","Hyatt Foreman","Allistair Wells","Coby Miranda","Colorado Lynch","Shad Joyce","Cole Merrill","Neville Case","Valentine Munoz",
        //                                               "Raphael Valenzuela","Tobias Wiggins","Gabriel Short","Zeph Santiago","Dennis Young","Xavier Morrow"});
        List<string> nombre_agentes = new List<string>(new string[] { "Fulano Mengano","Colton Ramos","Stuart Mcguire",
                                                       "Hoyt Wilkerson","Nissim Dennis","Dalton Serrano","Daquan Waters",
                                                       "Byron Roman","Caldwell Soto","Rudyard Fitzgerald","Kato Gardner",
                                                       "Cody Cantu","Eric Duke","Rogan Fleming","Hop Nixon","Caldwell Brooks",
                                                       "Julian Roman","Dustin Mercado","Wylie Mcneil","Elmo Buck","Callum Lambert","Cedric Cooke",
                                                       "Kaseem Weber","Armando Waters","Victor Camacho","Gabriel Roach","Graham Wise",
                                                       "Ferris Carroll","Edan Alvarez","Caleb Floyd","Hoyt Jefferson","Russell Vega",
                                                       "Clark Salinas","Geoffrey Lawson","Ignatius Stewart","Tyrone Bradshaw",
                                                       "Quinlan Lott","Odysseus Howe","Kibo Zamora","Preston Wallace","Andrew Talley","Thor Bean",
                                                       });
        Random rnd = new Random();

        private List<string> RandomNombres(List<string> list_nombres)
        {
      
            List<string> nombresClientes = new List<string>();
            while (nombresClientes.Count < 50)
            {
                int index = rnd.Next(0, 98);

                if (!nombresClientes.Contains(list_nombres.ElementAt(index)))
                {
                    nombresClientes.Add(list_nombres.ElementAt(index));
                }
            }
            
            imprimirLista(nombresClientes);
            return nombresClientes;
        }


        private void crear_agentesXML()
        {
            //XmlTextWriter writer = new XmlTextWriter(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\agentes.xml", System.Text.Encoding.UTF8);
            XmlTextWriter writer = new XmlTextWriter(direccion+@"\agentes.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Agentes");
            for (int i = 0; i < 30; i++)
            {
                createNodeAgente(i.ToString(), nombre_agentes[i], servicios_x_agentes(), writer);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            Console.WriteLine("XML File created !");
        }

        private void crear_ClienteXML()
        {
            //List<string> nombre_clientes = RandomNombres(nombre_agentes);
            //XmlTextWriter writer = new XmlTextWriter(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\clientes.xml", System.Text.Encoding.UTF8);
            XmlTextWriter writer = new XmlTextWriter(direccion+@"\clientes.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Clientes");
            
            for (int i = 0; i < nombre_agentes.Count; i++)
            {
                int index1 = rnd.Next(0, 5);
                int dias = rnd.Next(0, 4);
                int hora = rnd.Next(0, 15);
                createNodeCliente(i.ToString(), nombre_agentes[i], servicios.ElementAt(index1), dias_laborales.ElementAt(dias), horas_laborales.ElementAt(hora),writer);
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            Console.WriteLine("XML File created !");
        }
        private void createNodeAgente(string pID, string pName, List<string> pServicios, XmlTextWriter writer)
        {
            writer.WriteStartElement("Agente");
            writer.WriteStartElement("ID");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Nombre");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("Codigos_de_Servicios");
            for (int i = 0; i <= pServicios.Count - 1; i++)
            {
                writer.WriteStartElement("Codigo"+i);
                writer.WriteString(pServicios[i]);
                writer.WriteEndElement();
            }
               
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        private void createNodeCliente(string pID, string pName, string pServicios,string pDia,string pHora, XmlTextWriter writer)
        {
            writer.WriteStartElement("Cliente");
            writer.WriteStartElement("ID");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Nombre");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("Codigo_de_Servicio");
            writer.WriteString(pServicios);
            writer.WriteEndElement();
            writer.WriteStartElement("Dia");
            writer.WriteString(pDia);
            writer.WriteEndElement();
            writer.WriteStartElement("Hora");
            writer.WriteString(pHora);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }



        public List<Agente> read_agenteXML(string archivo,string TagName)
        {
          
            List<List<Agente>> datos_objeto = new List<List<Agente>>();
            XmlDocument doc = new XmlDocument();
            doc.Load(archivo);
            XmlNodeList xmlnode = doc.GetElementsByTagName(TagName);
            List<Agente> lista_agentes = new List<Agente>();

            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                XmlNodeList nodes_agentes = xmlnode[i].ChildNodes;
                    
                for (int j = 0; j <= nodes_agentes.Count - 1; j++)
                {
                    XmlNodeList nodes = nodes_agentes[j].ChildNodes;
                    
                    Agente agente = new Agente();

                    for (int k = 0; k <= nodes.Count - 1; k++)
                    {
                        
                        XmlNodeList nodes_servicios = nodes[k].ChildNodes;
                        List<string> servicioxagente = new List<string>();

                        if (nodes.Item(k).Name == "ID")
                        {
                            agente.ID1 = int.Parse(nodes.Item(k).InnerText.Trim());
                        }
                        if (nodes.Item(k).Name == "Nombre")
                        {
                            agente.Nombre = nodes.Item(k).InnerText.Trim();
                        }
                        if (nodes.Item(k).Name == "Codigos_de_Servicios")
                        {
                            for (int l = 0; l <= nodes_servicios.Count - 1; l++)
                            {
                           
                                servicioxagente.Add(nodes_servicios.Item(l).InnerText.Trim());

                            }

                            agente.Cod_Servicios = servicioxagente;
                            agente.Servicios_Disp = agente.obtener_servicios_bool(servicioxagente).ToArray();
                            
                            
                        }

                    }
                    agente.toString();
                    lista_agentes.Add(agente);
                   
                }
            }

            imprimirLista_agentes(lista_agentes);
            return lista_agentes;
        }

        public List<Pedido> read_clienteXML(string archivo, string TagName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(archivo);
            XmlNodeList xmlnode = doc.GetElementsByTagName(TagName);
            List<Pedido> lista_ordenes = new List<Pedido>();

            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                XmlNodeList nodes_ordenes = xmlnode[i].ChildNodes;

                for (int j = 0; j <= nodes_ordenes.Count - 1; j++)
                {
                    XmlNodeList nodes = nodes_ordenes[j].ChildNodes;

                    Pedido orden = new Pedido();

                    for (int k = 0; k <= nodes.Count - 1; k++)
                    {

                        if (nodes.Item(k).Name == "ID")
                        {
                            orden.id = nodes.Item(k).InnerText.Trim();
                        }
                        if (nodes.Item(k).Name == "Nombre")
                        {
                            orden.Nombre_cliente = nodes.Item(k).InnerText.Trim();
                        }
                        if (nodes.Item(k).Name == "Codigo_de_Servicio")
                        {
                            orden.Codigo_servicio = nodes.Item(k).InnerText.Trim();
                        }
                        if (nodes.Item(k).Name == "Dia")
                        {
                            orden.Dia_cita = nodes.Item(k).InnerText.Trim();
                           
                        }
                        if (nodes.Item(k).Name == "Hora")
                        {
                            orden.Hora_cita = nodes.Item(k).InnerText.Trim();
                        }

                    }
                    orden.toString();
                    lista_ordenes.Add(orden);

                }
            }
            Console.WriteLine("'''''''''''''''''''");
            imprimirLista_orden(lista_ordenes);
            return lista_ordenes;
        }

        public List<string> get_columns_agentes(string archivo)
        {
            List<string> nombre_columnas = new List<string>();


            XmlTextReader xmlReader = new XmlTextReader(archivo);
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name != "Agentes")
                    {
                        if (xmlReader.Name != "Agente")
                        {
                            if (xmlReader.Name != "Codigos_de_Servicios")
                            {
                                if (!nombre_columnas.Contains(xmlReader.Name))
                                {
                                    nombre_columnas.Add(xmlReader.Name);
                                }
                            }
                        }
                            
                            
                    }
                        
                }

            }

            Console.WriteLine("----------------------");
            imprimirLista(nombre_columnas);
            return nombre_columnas;

        }

        public List<string> get_columns_ordenes(string archivo)
        {
            List<string> nombre_columnas = new List<string>();
            XmlTextReader xmlReader = new XmlTextReader(archivo);

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name != "Clientes")
                    {
                        if (xmlReader.Name != "Cliente")
                        {
                            if (!nombre_columnas.Contains(xmlReader.Name))
                            {
                                nombre_columnas.Add(xmlReader.Name);
                            }
                        }


                    }

                }

            }

            Console.WriteLine("----------------------");
            imprimirLista(nombre_columnas);
            return nombre_columnas;

        }
        public void imprimirLista(List<string> lista) {
            for (int i = 0; i < lista.Count; i++)
            {
                   Console.WriteLine("/" + lista[i]);
            }
        }

        public void imprimirLista_agentes(List<Agente> lista)
        {
                for (int j = 0; j < lista.Count; j++)
                {
                    lista[j].ToString();
                }
        }

        public void imprimirLista_orden(List<Pedido> lista)
        {
            for (int j = 0; j < lista.Count; j++)
            {
                lista[j].ToString();
            }
        }

        public List<string> servicios_x_agentes()
        {
            
            List<string> serviciosAgente = new List<string>();
            Console.WriteLine(serviciosAgente.Count);
            while(serviciosAgente.Count < 3)
            {
                int index = rnd.Next(0, 5);
              
                if (!serviciosAgente.Contains(servicios.ElementAt(index)))
                {
                    serviciosAgente.Add(servicios.ElementAt(index));
                }
                
                
            }
            imprimirLista(serviciosAgente);
            return serviciosAgente;
            
        }
        static void Main()
        {
            
            Manejador_XML p = new Manejador_XML();
            p.crear_agentesXML();
            p.crear_ClienteXML();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());

            //p.servicios_x_agentes




            //Pedido p1 = new Pedido(00, "Jorge", "RCE", "9:30", "Lunes");
            //Pedido p2 = new Pedido(01, "Mario", "ICE", "15:30", "Martes");
            //Pedido p3 = new Pedido(03, "Carlos", "ILA", "19:30", "Miercoles");
            //Pedido p4 = new Pedido(04, "Fausto", "RLA", "5:30", "Jueves");
            //Pedido p5 = new Pedido(05, "Marcos", "ICG", "00:30", "Viernes");
            //Pedido p6 = new Pedido(06, "Jorge", "RCE", "9:30", "Lunes");
            //Pedido p7 = new Pedido(07, "Mario", "ICE", "15:30", "Martes");
            //Pedido p8 = new Pedido(08, "Carlos", "ILA", "19:30", "Miercoles");
            //Pedido p9 = new Pedido(09, "Fausto", "RLA", "5:30", "Jueves");
            //Pedido p10 = new Pedido(10, "Marcos", "ICG", "00:30", "Viernes");
            //Pedido p11 = new Pedido(11, "Jorge", "RCE", "9:30", "Lunes");
            //Pedido p12 = new Pedido(12, "Mario", "ICE", "15:30", "Martes");
            //Pedido p13 = new Pedido(13, "Carlos", "ILA", "19:30", "Miercoles");
            //Pedido p14 = new Pedido(14, "Fausto", "RLA", "5:30", "Jueves");
            //Pedido p15 = new Pedido(15, "Marcos", "ICG", "00:30", "Viernes");

            //Pedido[] lista_p = { p1, p2, p3, p4, p5 };

            //bool[] data1 = { false, false, false, true, true, true };
            //bool[] data2 = { true, true, true, false, false, false };
            //bool[] data3 = { true, false, true, false, true, false };
            //bool[] data4 = { true, true, true, true, true, true };

            //Agente a1 = new Agente("1", "", data4);
            //Agente a2 = new Agente("2", "", data4);
            //Agente a3 = new Agente("3", "", data4);
            //Agente a4 = new Agente("4", "", data4);
            //Agente a5 = new Agente("5", "", data4);
            //Agente a6 = new Agente("6", "", data4);
            //Agente a7 = new Agente("7", "", data4);
            //Agente a8 = new Agente("8", "", data4);
            //Agente a9 = new Agente("9", "", data4);
            //Agente a10 = new Agente("10", "", data4);
            //Agente a11 = new Agente("11", "", data4);

            //Agente[] lista_a = { a1, a2, a3 /*,a4,a5,a6,a7,a8,a9,a10,a11*/};
            //int cant =20;

            ////Agente[] lista_a = p.read_agenteXML(direccion + @"\agentes.xml", "Agentes").ToArray();
            ////Pedido[] lista_p = p.read_clienteXML(direccion + @"\clientes.xml", "Clientes").ToArray();
            //Genetico g = new Genetico(lista_a, lista_p, cant);
            //Individuo i = g.obtener_Mejor();
            //Console.WriteLine(i.get_Fitness(lista_a, lista_p));
            //List<Agente> lista_agentes = g.deme_agentes();
            //// Console.WriteLine("''''''''''''''''''''''''''''''''''''''''");
            //for (int j = 0; j < lista_agentes.Count; j++)
            //{
            //    Console.WriteLine("''''''''''''''''''''''''''''''''''''''''");
            //    lista_agentes[j].toString();
            //}

            //p.get_columns_ordenes(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\clientes.xml");
            //p.add_servicios_XML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");


        }

    }

   

}
