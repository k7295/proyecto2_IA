﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
   
    public class Manejador_XML
    {
        List<string> servicios = new List<string>(new string[] { "ICE", "ICG", "ILA", "RCE", "RCG", "RLA" }) ;
        List<string> nombre_agentes = new List<string>(new string[] { "Fulano Mengano","Colton Ramos","Stuart Mcguire",
                                                       "Hoyt Wilkerson","Nissim Dennis","Dalton Serrano","Daquan Waters",
                                                       "Byron Roman","Caldwell Soto","Rudyard Fitzgerald","Kato Gardner",
                                                       "Cody Cantu","Eric Duke","Rogan Fleming","Hop Nixon","Caldwell Brooks",
                                                       "Julian Roman","Dustin Mercado","Wylie Mcneil","Elmo Buck","Callum Lambert","Cedric Cooke",
                                                       "Kaseem Weber","Armando Waters","Victor Camacho","Gabriel Roach","Graham Wise",
                                                       "Ferris Carroll","Edan Alvarez","Caleb Floyd","Hoyt Jefferson","Russell Vega",
                                                       "Clark Salinas","Geoffrey Lawson","Ignatius Stewart","Tyrone Bradshaw",
                                                       "Quinlan Lott","Odysseus Howe","Kibo Zamora","Preston Wallace","Andrew Talley","Thor Bean",
                                                       "Upton Hardy","Xanthus Garner","Lewis Mack","Alfonso Tanner","Francis Hansen","Xanthus Ochoa","Wesley Campos",
                                                       "Chester Sparks","Ferris Nunez","Baxter Schmidt","Len Barr","Quinn Sloan","Cedric Brewer","Craig Bryan",
                                                       "Aquila Tanner","Cade Nolan","Elmo Mcclain","Carter Reeves","Yasir Wolf","Otto Simmons","Timon Faulkner",
                                                       "Craig Craft","Kyle Skinner","Joel Burton","Lars Small","Ulysses Carson","Aladdin Valentine","Donovan Kramer","Silas Scott",
                                                       "Jesse Lancaster","Warren Norman","Kadeem Odonnell","Jesse Cross","Denton Coffey","Orson Justice","Fulton Carter","Emerson Payne","Brett Forbes",
                                                       "Chaney Stark","Prescott Guerra","Boris Hartman","Nash White",
                                                       "Merritt Blake","Hyatt Foreman","Allistair Wells","Coby Miranda","Colorado Lynch","Shad Joyce","Cole Merrill","Neville Case","Valentine Munoz",
                                                       "Raphael Valenzuela","Tobias Wiggins","Gabriel Short","Zeph Santiago","Dennis Young","Xavier Morrow"});
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
            XmlTextWriter writer = new XmlTextWriter(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\agentes.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Agentes");
            for (int i = 0; i < nombre_agentes.Count; i++)
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
            List<string> nombre_clientes = RandomNombres(nombre_agentes);
            XmlTextWriter writer = new XmlTextWriter(@"\Users\Karen\Documents\IA\ProyectoII\proyecto2_IA\WindowsFormsApp1\clientes.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Clientes");
            
            for (int i = 0; i < nombre_clientes.Count; i++)
            {
                int index = rnd.Next(0, 5);
                createNodeCliente(i.ToString(), nombre_clientes[i], servicios.ElementAt(index), writer);
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

        private void createNodeCliente(string pID, string pName, string pServicios, XmlTextWriter writer)
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
                            agente.ID1 = nodes.Item(k).InnerText.Trim();
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
                            agente.Servicios = servicioxagente;
                        }

                    }
                    agente.toString();
                    lista_agentes.Add(agente);
                   
                }
            }

            imprimirLista_agentes(lista_agentes);
            return lista_agentes;
        }

        public List<Orden> read_clienteXML(string archivo, string TagName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(archivo);
            XmlNodeList xmlnode = doc.GetElementsByTagName(TagName);
            List<Orden> lista_ordenes = new List<Orden>();

            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                XmlNodeList nodes_ordenes = xmlnode[i].ChildNodes;

                for (int j = 0; j <= nodes_ordenes.Count - 1; j++)
                {
                    XmlNodeList nodes = nodes_ordenes[j].ChildNodes;

                    Orden orden = new Orden();

                    for (int k = 0; k <= nodes.Count - 1; k++)
                    {

                        if (nodes.Item(k).Name == "ID")
                        {
                            orden.ID1 = nodes.Item(k).InnerText.Trim();
                        }
                        if (nodes.Item(k).Name == "Nombre")
                        {
                            orden.Nombre = nodes.Item(k).InnerText.Trim();
                        }
                        if (nodes.Item(k).Name == "Codigo_de_Servicio")
                        {
                            orden.Servicio = nodes.Item(k).InnerText.Trim();
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

        public void imprimirLista_orden(List<Orden> lista)
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

            //p.servicios_x_agentes();
            //p.read_clienteXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\clientes.xml", "Clientes");
            //p.get_columns_ordenes(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\clientes.xml");
            //p.add_servicios_XML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");


        }

    }

   

}
