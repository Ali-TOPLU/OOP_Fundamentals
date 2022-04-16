using _01_.Abstract;
using _01_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Concrete
{
    class Lettuce : Ingredient, ISliceable
    {
        public int SlicesToHave { get; set; } = 10;
        public override string Description { get { return "Lettuce"; } }
    }
}
