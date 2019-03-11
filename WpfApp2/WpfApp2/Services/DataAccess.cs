using WpfApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Services
{
    public class DataAccess
    {
        string[] firstNames = new string[] { "Bob", "Sue", "Carla", "Frank", "Monique", "Carlton", "Miguel", "Daniel", "Santiago", "John", "Robert" };
        string[] lastNames = new string[] { "Smith", "Jones", "Garcia", "Miller", "Thomas", "Lee", "Taylor", "Wilson", "Martinez", "Davis", "Hernandez" };
        
        public List<PersonModel> GetPeople(int total = 10)
        {
            List<PersonModel> output = new List<PersonModel>();
            for (int i = 0; i < total; i++)
            {
                output.Add(GetPerson(i + 1));
            }
            return output;
        }

        private PersonModel GetPerson(int id)
        {
            PersonModel output = new PersonModel();

            output.PersonId = id;
            output.FirstName = firstNames.GetValue(id).ToString();
            output.LastName = lastNames.GetValue(id).ToString();
            
            return output;
        }

    }
}
