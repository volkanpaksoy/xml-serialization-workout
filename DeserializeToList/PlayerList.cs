using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DeserializeToList
{
    [XmlRoot]
    public class PlayerList
    {
        [XmlElement("Player")]
        public List<InitialPlayer> Players { get; set; }
    }
}
