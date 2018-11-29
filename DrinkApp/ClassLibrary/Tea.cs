using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp.ClassLibrary
{
    public class Tea : Drink
    {
        public Tea()
        {
            Name = "Tea";
            Cost = 2.00M;
        }
        public string Temperature { get; set; }
        public bool Sugar { get; set; }
        public string AmountofSugar { get; set; }

    }
}
