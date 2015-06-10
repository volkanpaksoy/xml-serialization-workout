using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipUnassignedValues
{
    public class FinalPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DefaultValue(0)]
        public int TotalGoalsScored { get; set; }

        [DefaultValue(0)]
        public double AverageGoalsPerGame { get; set; }

        public FinalTeam Team { get; set; }
    }

    public class FinalTeam
    {
        public string Name { get; set; }

        [DefaultValue(0)]
        public int YearEstablished { get; set; }
    }
}
