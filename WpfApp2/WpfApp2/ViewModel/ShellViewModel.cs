using WpfApp2;
using WpfApp2.Models;
using WpfApp2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp2.ViewModel
{
    public class ShellViewModel
    {

        //public List<PersonModel> People { get; set; }
        public ObservableCollection<PersonModel> People { get; set; }

        public ShellViewModel()
        {
            Console.WriteLine("With");
            DataAccess da = new DataAccess();
            People = new ObservableCollection<PersonModel>(da.GetPeople());
            Console.WriteLine(People.Count);
            foreach (var item in People)
            {
                Console.WriteLine(item.FirstName.ToString());
            }
        }
    }
}
