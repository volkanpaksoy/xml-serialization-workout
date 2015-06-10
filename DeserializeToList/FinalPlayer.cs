using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DeserializeToList
{
    [XmlType("Player")]
    public class FinalPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalGoalsScored { get; set; }
        public double AverageGoalsPerGame { get; set; }
    }
}
