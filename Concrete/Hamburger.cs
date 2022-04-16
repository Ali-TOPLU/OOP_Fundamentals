using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Concrete
{
    class Hamburger
    {
        public Hamburger(double maxMeatballCount,
                         double maxCheddarSliceCount,
                         double maxLettuceSliceCount,
                         double maxTomatoSliceCount,
                         bool hasKetchup,
                         bool hasMayonnaise,
                         bool hasBarbequeSouce
                         )
        {
            Meatballs = new List<Meatball>();
            CheddarSlices = new List<CheddarSlice>();
            LettuceSlice = new List<LettuceSlice>();
            TomatoSlice = new List<TomatoSlice>();
            MaxTomatoSliceCount = Convert.ToInt32( maxTomatoSliceCount);
            MaxCheddarSliceCount = Convert.ToInt32(maxCheddarSliceCount);
            MaxMeatballCount = Convert.ToInt32(maxMeatballCount);
            MaxLettuceSliceCount = Convert.ToInt32(maxLettuceSliceCount);
            HasKetchup = hasKetchup;
            HasMayonnaise = hasMayonnaise;
            HasBarbequeSouce = hasBarbequeSouce;
        }

        public bool BreadReady { get; set; } = false;
        public List<Meatball> Meatballs { get; set; }
        public int MaxMeatballCount { get; set; }
        public List<CheddarSlice> CheddarSlices { get; set; }
        public int MaxCheddarSliceCount { get; set; }
        public List<LettuceSlice> LettuceSlice { get; set; }
        public int MaxLettuceSliceCount { get; set; }
        public List<TomatoSlice> TomatoSlice { get; set; }
        public int MaxTomatoSliceCount { get; set; }
        public bool HasBarbequeSouce { get; set; } = false;
        public bool HasMayonnaise { get; set; } = false;
        public bool HasKetchup { get; set; } = false;


    }
}
