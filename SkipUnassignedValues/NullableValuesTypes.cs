using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipUnassignedValues
{
    public class NullableValuesTypesPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TotalGoalsScored { get; set; }
        public double? AverageGoalsPerGame { get; set; }
        public NullableValuesTypesTeam Team { get; set; }
    }

    public class NullableValuesTypesTeam
    {
        public string Name { get; set; }
        public int ?YearEstablished { get; set; }
    }
}
