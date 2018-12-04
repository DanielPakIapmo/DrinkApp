using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkApp
{
    public abstract class Drink
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public decimal Cost { get; set; }
        public string DrinkSummary { get; set; }

        public virtual void PrintDrinkSummary()
        {

        }
    }
}
