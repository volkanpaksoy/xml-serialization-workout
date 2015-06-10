using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RemoveXmlNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                Id = 102,
                FirstName = "Danny",
                LastName = "TopScorer",
                AverageGoalsPerGame = 3.5,
                TotalGoalsScored = 150
            };


            /*
            // Version 1: With the default namespaces
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            XmlWriterSettings settings = new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true, Encoding = Encoding.UTF8 };
            StringBuilder output = new StringBuilder();
            
            XmlWriter writer = XmlWriter.Create(output, settings);
            serializer.Serialize(writer, player);
            
            Console.WriteLine(output.ToString());
            Console.ReadLine();
            */

            
            // Version 2: Without the default namespaces
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            XmlWriterSettings settings = new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true, Encoding = Encoding.UTF8 };
            StringBuilder output = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(output, settings);
            
            XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            serializer.Serialize(writer, player, xns);
            
            Console.WriteLine(output.ToString());
            Console.ReadLine();
        }
    }
}
