using _01_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Concrete
{
    class Market
    {
        public List<Ingredient> Products { get; set; }

        /// <summary>
        /// Rafları boş bir market oluşturur
        /// </summary>
        public Market()
        {
            Products = new List<Ingredient>();
        }

        /// <summary>
        /// Market oluşurken içinde kaçar adet ürün istediğinizi parametre olarak girebilirsiniz
        /// </summary>
        /// <param name="qty"></param>
        public Market(double qty)
        {
            Products = new List<Ingredient>();
            FillMarket(qty);
        }


        public void FillMarket(double quantity) //ingredient parametresi alarak , tipine göre de alım yapılabilir
        {
            for (int i = 0; i < quantity; i++)
            {
                BarbequeSauce barbequeSauce = new BarbequeSauce();
                barbequeSauce.BestBeforeDate = DateTime.Now.AddYears(1);
                Products.Add(barbequeSauce);                

                Bread bread = new Bread();
                bread.BestBeforeDate = DateTime.Now.AddDays(2);
                Products.Add(bread);

                Cheddar cheddar = new Cheddar();
                cheddar.BestBeforeDate = DateTime.Now.AddMonths(1);
                Products.Add(cheddar);

                CheddarSlice cheddarSlice = new CheddarSlice();
                cheddarSlice.BestBeforeDate = DateTime.Now.AddMonths(1);
                Products.Add(cheddarSlice);

                Meatball meatball = new Meatball();
                meatball.BestBeforeDate = DateTime.Now.AddDays(7);
                Products.Add(meatball);
                
                TomatoSlice tomatoSlice = new TomatoSlice();
                tomatoSlice.BestBeforeDate = DateTime.Now.AddDays(3);
                Products.Add(tomatoSlice);
                
                LettuceSlice lettuceSlice = new LettuceSlice();
                lettuceSlice.BestBeforeDate = DateTime.Now.AddDays(3);
                Products.Add(lettuceSlice);

                Mayonnaise mayonnaise = new Mayonnaise();
                mayonnaise.BestBeforeDate = DateTime.Now.AddMonths(3);
                Products.Add(mayonnaise);

                Ketchup ketchup = new Ketchup();
                ketchup.BestBeforeDate = DateTime.Now.AddMonths(6);
                Products.Add(ketchup);

                Tomato tomato = new Tomato();
                tomato.BestBeforeDate = DateTime.Now.AddDays(7);
                Products.Add(tomato);

                Lettuce lettuce = new Lettuce();
                lettuce.BestBeforeDate = DateTime.Now.AddDays(7);
                Products.Add(lettuce);

               
            }
        }
    }
}
