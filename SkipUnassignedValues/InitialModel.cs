using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipUnassignedValues
{
    public class InitialPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalGoalsScored { get; set; }
        public double AverageGoalsPerGame { get; set; }
        public InitialTeam Team { get; set; }
    }

    public class InitialTeam
    {
        public string Name { get; set; }
        public int YearEstablished { get; set; }
    }
}
