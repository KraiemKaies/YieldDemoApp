using System;
using System.Collections.Generic;

namespace YieldDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strat of the App");
            var people = DataAccess.GetPeople();
            foreach (var p in people)
            {
                Console.WriteLine($"Read { p.FirstName} {p.LastName}");
            }
            Console.WriteLine("End of the App");
        }
    }
    public class DataAccess
    {
        public static IEnumerable<PersonModel> GetPeople()
        {
            List<PersonModel> output = new List<PersonModel>();
            output.Add(new PersonModel("Tim", "Corey"));
            output.Add(new PersonModel("Sue", "Storm"));
            output.Add(new PersonModel("Jane", "Smith"));
            return output;
        }
    }
}
