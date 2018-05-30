using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
   
    public class Program
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

        private void crear_agentesXML()
        {
            XmlTextWriter writer = new XmlTextWriter(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Agentes");
            for (int i = 0; i <= nombre_agentes.Count - 1; i++)
            {
                createNode(i.ToString(), nombre_agentes[i], servicios_x_agentes(), writer);
            }
               
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("XML File created ! ");
        } 

        private void createNode(string pID, string pName, List<string> pServicios, XmlTextWriter writer)
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
                writer.WriteStartElement("Codigo");
                writer.WriteString(pServicios[i]);
                writer.WriteEndElement();
            }
               
            writer.WriteEndElement();
            writer.WriteEndElement();
        }



        public List<List<Agente>> read_agenteXML(string archivo,string TagName)
        {
          
            List<List<Agente>> datos_objeto = new List<List<Agente>>();
            XmlDocument doc = new XmlDocument();
            doc.Load(archivo);
            XmlNodeList xmlnode = doc.GetElementsByTagName(TagName);
      

            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                XmlNodeList nodes_agentes = xmlnode[i].ChildNodes;
                    
                for (int j = 0; j <= nodes_agentes.Count - 1; j++)
                {
                    XmlNodeList nodes = nodes_agentes[j].ChildNodes;
                    List<Agente> elemento = new List<Agente>();
                    Agente agente = new Agente();

                    for (int k = 0; k <= nodes.Count - 1; k++)
                    {
                        
                        XmlNodeList nodes_servicios = nodes[k].ChildNodes;
                        List<string> datos = new List<string>();
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
                                //Console.WriteLine(nodes_servicios.Item(l).InnerText.Trim());
                                servicioxagente.Add(nodes_servicios.Item(l).InnerText.Trim());

                            }
                            agente.Servicios = servicioxagente;
                        }

                    }
                    agente.toString();
                    elemento.Add(agente);
                    datos_objeto.Add(elemento);
                }
            }

            imprimirLista_agentes(datos_objeto);
            return datos_objeto;
        }

        //public List<List<string>> read_XML(string archivo, string TagName)
        //{

        //    List<List<string>> datos_objeto = new List<List<string>>();
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(archivo);
        //    XmlNodeList xmlnode = doc.GetElementsByTagName(TagName);


        //    for (int i = 0; i <= xmlnode.Count - 1; i++)
        //    {
        //        XmlNodeList nodes_servicios = xmlnode[i].ChildNodes;

        //        for (int j = 0; j <= nodes_servicios.Count - 1; j++)
        //        {
        //            XmlNodeList nodes = nodes_servicios[j].ChildNodes;
        //            List<string> elemento = new List<string>();

        //            for (int k = 0; k <= nodes.Count - 1; k++)
        //            {
        //                List<string> datos = new List<string>();
        //                datos.Add(nodes.Item(k).InnerText.Trim());
        //                elemento.Add(nodes.Item(k).InnerText.Trim());

        //            }
        //            datos_objeto.Add(elemento);
        //        }
        //    }

        //    imprimirLista_listas(datos_objeto);
        //    return datos_objeto;
        //}

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

            imprimirLista(nombre_columnas);
            return nombre_columnas;

        }

        public void imprimirLista(List<string> lista) {
            for (int i = 0; i < lista.Count; i++)
            {
                   Console.WriteLine("/" + lista[i]);
            }
        }

        public void imprimirLista_agentes(List<List<Agente>> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {   

                for (int j = 0; j < lista[i].Count; j++)
                {
                    lista[i][j].ToString();
                }
            }
        }

        public void imprimirLista_listas(List<List<string>> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");

                for (int j = 0; j < lista[i].Count; j++)
                {
                   
                        Console.WriteLine("/" + lista[i][j]);
                 
                }

            }
        }

        public List<string> servicios_x_agentes()
        {
            
            List<string> serviciosAgente = new List<string>();
            Console.WriteLine(serviciosAgente.Count);
            while(serviciosAgente.Count < 4)
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
            Program p = new Program();
            //p.crear_agentesXML();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Principal());

            //p.servicios_x_agentes();
            p.read_agenteXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml", "Agentes");
            p.get_columns_agentes(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\agentes.xml");
            //p.add_servicios_XML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");


        }

    }

   

}
