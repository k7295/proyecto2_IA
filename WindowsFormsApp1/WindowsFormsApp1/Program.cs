using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
   
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void readXML()
        {
            List<string> nombre_columnas = new List<string>();
            List<List<List<string>>> datos_objeto = new List<List<List<string>>>();
            
            XmlDocument doc = new XmlDocument();
            String fileName = @"\Users\Karen\source\repos\WindowsFormsApp1\ejemplo.xml";
            doc.Load(fileName);
            XmlNodeList xmlnode = doc.GetElementsByTagName("bookstore");
            string str = null;

            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                XmlNodeList nodes_books = xmlnode[i].ChildNodes;
                    
                for (int j = 0; j <= nodes_books.Count - 1; j++)
                {
                    XmlNodeList nodes = nodes_books[j].ChildNodes;
                    List<List<string>> elemento = new List<List<string>>();

                    for (int k = 0; k <= nodes.Count - 1; k++)
                    {
                        List<string> datos = new List<string>();
                        datos.Add(nodes.Item(k).InnerText.Trim());
                        datos.Add(nodes.Item(k).Name);
                        if (nombre_columnas.Contains(nodes.Item(k).Name) == false)
                        {
                            nombre_columnas.Add(nodes.Item(k).Name);
                        }
                        elemento.Add(datos);
                        
                    }
                    datos_objeto.Add(elemento);
                }
            }

            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");
            // datos_objeto.Add(datos);
            imprimirLista_listas(datos_objeto);
            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");

            imprimirLista(nombre_columnas);

            
        }

        static void imprimirLista(List<string> lista) {
            for (int i = 0; i < lista.Count; i++)
            {
                   Console.WriteLine("/" + lista[i]);
            }
        }
        static void imprimirLista_listas(List<List<List<string>>> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''");

                for (int j = 0; j < lista[i].Count; j++)
                {
                    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                    for (int k = 0; k < lista[i][j].Count; k++)
                    {
                        Console.WriteLine("/" + lista[i][j][k]);
                    }
                }
                
            }
        }
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Principal());
            readXML();
            
        }
        
    }

   

}
