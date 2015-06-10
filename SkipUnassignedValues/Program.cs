using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SkipUnassignedValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using classes in InitialModel.cs
            var serializer = new XmlSerializer(typeof(List<InitialPlayer>));
            var initialPlayer1 = new InitialPlayer() { Id = 1, FirstName = "John", LastName = "Smith", TotalGoalsScored = 50, AverageGoalsPerGame = 0.7, Team = new InitialTeam() { Name = "Arsenal" } };
            var initialPlayer2 = new InitialPlayer() { Id = 2, FirstName = "Jack" };
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, new List<InitialPlayer>() { initialPlayer1, initialPlayer2 });
                Console.WriteLine(writer.ToString());
            }
            Console.ReadLine();
            
            // Using classes in FinalModel.cs
            serializer = new XmlSerializer(typeof(List<FinalPlayer>));
            var finalPlayer1 = new FinalPlayer() { Id = 1, FirstName = "John", LastName = "Smith", TotalGoalsScored = 50, AverageGoalsPerGame = 0.7, Team = new FinalTeam() { Name = "Arsenal" } };
            var finalPlayer2 = new FinalPlayer() { Id = 2, FirstName = "Jack" };
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, new List<FinalPlayer>() { finalPlayer1, finalPlayer2 });
                Console.WriteLine(writer.ToString());
            }
            Console.ReadLine();

            // Using classes in NullableValuesTypes.cs
            serializer = new XmlSerializer(typeof(List<NullableValuesTypesPlayer>));
            var nullableValuesTypesPlayer1 = new NullableValuesTypesPlayer() { Id = 1, FirstName = "John", LastName = "Smith", TotalGoalsScored = 50, AverageGoalsPerGame = 0.7, Team = new NullableValuesTypesTeam() { Name = "Arsenal" } };
            var nullableValuesTypesPlayer2 = new NullableValuesTypesPlayer() { Id = 2, FirstName = "Jack" };
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, new List<NullableValuesTypesPlayer>() { nullableValuesTypesPlayer1, nullableValuesTypesPlayer2 });
                Console.WriteLine(writer.ToString());
            }
            Console.ReadLine();
        }
    }
}
