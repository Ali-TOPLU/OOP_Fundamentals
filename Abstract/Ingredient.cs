using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Abstract
{
    public abstract class Ingredient
    {
        public abstract string Description { get; }
        public DateTime BestBeforeDate { get; set; }
        public bool IsFresh
        {
            get
            {
                if (BestBeforeDate > DateTime.Now) return true;
                else return false;
            }
        }
    }
}
