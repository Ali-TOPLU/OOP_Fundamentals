using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Concrete
{
    class Stock
    {
        public Stock()
        {
            Meatballs = new Queue<Meatball>();
            Cheddars = new Queue<Cheddar>();
            CheddarSlices = new Queue<CheddarSlice>();
            BarbequeSauces = new Queue<BarbequeSauce>();
            Breads = new Queue<Bread>();
            TomatoSlices = new Queue<TomatoSlice>();
            LettuceSlices = new Queue<LettuceSlice>();
            Mayonnaise = new Queue<Mayonnaise>();
            Ketchup = new Queue<Ketchup>();
            Lettuces = new Queue<Lettuce>();
            Tomatoes = new Queue<Tomato>();
        }

        public Queue<Meatball> Meatballs { get; set; }
        public Queue<Cheddar> Cheddars { get; set; }
        public Queue<CheddarSlice> CheddarSlices { get; set; }
        public Queue<BarbequeSauce> BarbequeSauces { get; set; }
        public Queue<Bread> Breads { get; set; }
        public Queue<TomatoSlice> TomatoSlices { get; set; }
        public Queue<LettuceSlice> LettuceSlices { get; set; }
        public Queue<Mayonnaise> Mayonnaise { get; set; }
        public Queue<Ketchup> Ketchup { get; set; }
        public Queue<Lettuce> Lettuces { get; set; }
        public Queue<Tomato> Tomatoes { get; set; }
    }
}
