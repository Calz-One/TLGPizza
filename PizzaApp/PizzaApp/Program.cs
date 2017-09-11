using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;
using System.Data;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Establishes the file to be read
            XmlTextReader reader = new XmlTextReader(@"C:\Users\Student\Source\Repos\TLGPizza\PizzaApp\datagrams\Datagram.xml");

            // For each tag within the XML:
            ShowElements(reader);

        }

        static void ShowElements(XmlTextReader reader)
        {
            // For each tag within the XML:
            while (reader.Read())
            {
                // For all elements, not including whitespace
                if (reader.NodeType.ToString() != "Whitespace")
                {
                    //render element information
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"{reader.Name}:{reader.NodeType}");
                    if (reader.Value.Length > 0)
                    {
                        sb.Append($":{reader.Value}");
                    }
                    // if the element has attributes
                    if (reader.HasAttributes)
                    {
                        // Render attribute information
                        while (reader.MoveToNextAttribute())
                        {
                            sb.Append($" | {reader.Name}: {reader.Value}");
                        }
                    }
                    Console.WriteLine(sb);
                }

            }
        }
    }
}
