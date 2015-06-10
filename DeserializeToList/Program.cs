using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DeserializeToList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. Deserialize InitialPlayers into a container class
            string inputXmlPath1 = @".\InputXml.xml";
            using (StreamReader reader = new StreamReader(inputXmlPath1))
            {
                XmlSerializer playerListSerializer = new XmlSerializer(typeof(PlayerList));
                PlayerList playerList = (PlayerList)playerListSerializer.Deserialize(reader);
            }

            // 02. Deserialize players into List<Player>
            using (StreamReader reader = new StreamReader(inputXmlPath1))
            {
                XmlSerializer playerListSerializer = new XmlSerializer(typeof(List<FinalPlayer>), new XmlRootAttribute("PlayerList"));
                List<FinalPlayer> playerList = (List<FinalPlayer>)playerListSerializer.Deserialize(reader);
            }
        }
    }
}
