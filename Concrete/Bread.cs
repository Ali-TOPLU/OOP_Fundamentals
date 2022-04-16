using _01_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Concrete
{
    class Bread : Ingredient
    {
        public override string Description { get { return "Bread"; } }
        public bool IsSlicedInHalf { get; set; } = false;
    }
}
