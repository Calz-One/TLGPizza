using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Selects the files from a directory
            //string[] fileEntries = Directory.GetFiles(@"C:\Users\Student\Source\Repos\TLGPizza\PizzaApp\datagrams");

            // loads the content of the first file
            //var root = XElement.Load(fileEntries[0]);
            //string stringRoot = (string)root;

            XmlTextReader reader = new XmlTextReader(@"C:\Users\Student\Source\Repos\TLGPizza\PizzaApp\datagrams\Datagram.xml");

            while (reader.Read())
            {
                // Do some work here on the data.
                if (reader.Name == "Customer")
                {
                    if (reader.HasAttributes)
                    {

                        while (reader.MoveToNextAttribute()) // Read the attributes.
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");

                        //Console.WriteLine(reader.Name);
                        //Console.WriteLine(reader.NodeType);
                    }
                }
            }
            Console.ReadLine();

            // Queries that file
            //IEnumerable<XElement> query = from el in root.Elements("Datagram")
            //            select el;

            //// Writes out the contents of that query
            //foreach (XElement el in query)
            //{
            //    Console.WriteLine("Inside the loop");
            //    Console.WriteLine(el);
            //}

        }
    }
}
