using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp.ClassLibrary
{
    public class Coffee : Drink
    {
        public Coffee()
        {
            Name = "Coffee";
            Cost = 3.00M;
        }

        public string Temperature { get; set; }
        public bool Cream { get; set; }
        public string AmountofCream { get; set; }
        public bool Sugar { get; set; }
        public string AmountofSugar { get; set; }
    }
}
 