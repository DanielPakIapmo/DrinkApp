using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp.ClassLibrary
{
    public class Juice : Drink
    {
        public Juice()
        {
            Name = "Juice";
            Temperature = "Cold";
            Cost = 1.00M;

        }
        public string Temperature { get; set; }
        public string Flavor { get; set; }
    }
}
