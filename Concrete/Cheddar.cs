using _01_.Abstract;
using _01_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Concrete
{
    class Cheddar : Ingredient , ISliceable
    {
        public override string Description { get { return "Cheddar"; } }
        public  int SlicesToHave { get; set; } = 8;
    }
}
