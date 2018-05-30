using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
   
    public class Program
    {


        public List<List<string>> readXML(string archivo,string TagName)
        {
          
            List<List<string>> datos_objeto = new List<List<string>>();
            XmlDocument doc = new XmlDocument();
            doc.Load(archivo);
            XmlNodeList xmlnode = doc.GetElementsByTagName(TagName);
      

            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                XmlNodeList nodes_servicios = xmlnode[i].ChildNodes;
                    
                for (int j = 0; j <= nodes_servicios.Count - 1; j++)
                {
                    XmlNodeList nodes = nodes_servicios[j].ChildNodes;
                    List<string> elemento = new List<string>();

                    for (int k = 0; k <= nodes.Count - 1; k++)
                    {
                        List<string> datos = new List<string>();
                        datos.Add(nodes.Item(k).InnerText.Trim());
                        elemento.Add(nodes.Item(k).InnerText.Trim());
                        
                    }
                    datos_objeto.Add(elemento);
                }
            }

            imprimirLista_listas(datos_objeto);
            return datos_objeto;
        }

        public List<string> get_columns(string archivo,string TagName)
        {
            List<string> nombre_columnas = new List<string>();


            XmlTextReader xmlReader = new XmlTextReader(archivo);
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name != "Servicios")
                    {
                        if (!nombre_columnas.Contains(xmlReader.Name))
                        {
                            nombre_columnas.Add(xmlReader.Name);
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
        //private void imprimirLista_listas(List<List<List<string>>> lista)
        //{
        //    for (int i = 0; i < lista.Count; i++)
        //    {
        //        Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");

        //        for (int j = 0; j < lista[i].Count; j++)
        //        {
        //            for (int k = 0; k < lista[i][j].Count; k++)
        //            {
        //                Console.WriteLine("/" + lista[i][j][k]);
        //            }
        //        }

        //    }
        //}

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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
            //Program p = new Program();
            //p.readXML(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");
            //p.get_columns(@"\Users\Karen\Documents\IA\Proyecto2\WindowsFormsApp1\servicios.xml", "Servicios");


        }

    }

   

}
