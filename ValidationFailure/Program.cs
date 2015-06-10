using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ValidationFailure
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputXmlPath1 = @".\InputXml.xml";
            StreamReader streamReader = new StreamReader(inputXmlPath1);
            string rawXml = streamReader.ReadToEnd();

            // 01. Returns an empty list
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(rawXml)))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Player>), new XmlRootAttribute("PlayerList"));
                    var result = (List<Player>)serializer.Deserialize(memoryStream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);    
                }
            }

            // 02. Throws exception when the XML is not as expected
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(rawXml)))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Player>), new XmlRootAttribute("PlayerList"));
                    serializer.UnknownElement += serializer_UnknownElement;
                    var result = (List<Player>)serializer.Deserialize(memoryStream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }

            Console.ReadLine();
        }

        static void serializer_UnknownElement(object sender, XmlElementEventArgs e)
        {
            throw new ArgumentException(string.Format("Unknown element: {0}", e.Element.LocalName));
        }
    }
}
