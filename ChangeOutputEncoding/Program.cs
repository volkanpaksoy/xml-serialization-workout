using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ChangeOutputEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Using default output encoding
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            Player player = new Player() { Id = 102, FirstName = "Danny", LastName = "TopScorer", AverageGoalsPerGame = 3.5, TotalGoalsScored = 150 };
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            XmlWriterSettings settings = new XmlWriterSettings() { OmitXmlDeclaration = false, Indent = true, Encoding = Encoding.UTF8 };
            StringBuilder output = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(output, settings);
            XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            serializer.Serialize(writer, player, xns);
            Console.WriteLine(output.ToString());
            Console.ReadLine();
            */

            /* Produces the following output:
            <?xml version="1.0" encoding="utf-16"?>
            <Player>
              <Id>102</Id>
              <FirstName>Danny</FirstName>
              <LastName>TopScorer</LastName>
              <TotalGoalsScored>150</TotalGoalsScored>
              <AverageGoalsPerGame>3.5</AverageGoalsPerGame>
            </Player>
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Using custom output encoding
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            StringWriterWithEncoding utf8StringWriter = new StringWriterWithEncoding(Encoding.UTF8);
            Player player = new Player() { Id = 102, FirstName = "Danny", LastName = "TopScorer", AverageGoalsPerGame = 3.5, TotalGoalsScored = 150 };
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            XmlWriterSettings settings = new XmlWriterSettings() { OmitXmlDeclaration = false, Indent = true, Encoding = Encoding.UTF8 };
            XmlWriter writer = XmlWriter.Create(utf8StringWriter, settings);
            XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            serializer.Serialize(writer, player, xns);
            Console.WriteLine(utf8StringWriter.ToString());
            Console.ReadLine();

            /* Produces the following output:
            <?xml version="1.0" encoding="utf-8"?>
            <Player>
              <Id>102</Id>
              <FirstName>Danny</FirstName>
              <LastName>TopScorer</LastName>
              <TotalGoalsScored>150</TotalGoalsScored>
              <AverageGoalsPerGame>3.5</AverageGoalsPerGame>
            </Player>
             */
        }
    }
}
