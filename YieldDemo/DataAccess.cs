using System.Collections.Generic;

namespace YieldDemo
{
    public class DataAccess
    {
        public static IEnumerable<PersonModel> GetPeople()
        {
            //List<PersonModel> output = new List<PersonModel>();
            //output.Add(new PersonModel("Tim", "Corey"));
            //output.Add(new PersonModel("Sue", "Storm"));
            //output.Add(new PersonModel("Jane", "Smith"));
            //return output;

            yield return new PersonModel("Tim", "Corey");
            yield return new PersonModel("Sue", "Storm");
            yield return new PersonModel("Jane", "Smith");
        }
    }
}