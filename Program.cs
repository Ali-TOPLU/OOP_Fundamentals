using _01_.Abstract;
using _01_.Concrete;
using _01_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            double meatbaalQuantity, cheddarQuantity, lettuceQuantity, tomatoQuantity, moreQuantity = 0;
            bool requirementBread = true, requirementKetchup = false, requirementMayonnaise = false, requirementBarbequeSauce = false;
            string response;
            Chef chef = new Chef();
            #region OrderReceivedByCustomer
            Console.WriteLine("Hamburgerinizde kaç köfte olsun?");
            meatbaalQuantity = Convert.ToInt32(Console.ReadLine());
            if (meatbaalQuantity > 0)
            {
                moreQuantity = meatbaalQuantity;
            }
            Console.WriteLine("Hamburgerinizde kaç dilim domates olsun ?");
            tomatoQuantity = Convert.ToInt32(Console.ReadLine());
            if (tomatoQuantity > moreQuantity)
            {
                moreQuantity = tomatoQuantity;
            }
            Console.WriteLine("Hamburgerinizde kaç dilim marul olsun ?");
            lettuceQuantity = Convert.ToInt32(Console.ReadLine());
            if (lettuceQuantity > moreQuantity)
            {
                moreQuantity = lettuceQuantity;
            }
            Console.WriteLine("Hamburgerinizde kaç dilim cheddar peyniri olsun?");
            cheddarQuantity = Convert.ToInt32(Console.ReadLine());
            if (cheddarQuantity > moreQuantity)
            {
                moreQuantity = cheddarQuantity;
            }
            Console.WriteLine("Hamburgerinize ketçap ister misiniz?  e/h");
            response = Console.ReadLine();
            if (response == "e")
            {
                requirementKetchup = true;
            }
            Console.WriteLine("Hamburgerinize mayonez ister misiniz?  e/h");
            response = Console.ReadLine();
            if (response == "e")
            {
                requirementMayonnaise = true;
            }
            Console.WriteLine("Hamburgerinize BBQ ister misiniz?  e/h");
            response = Console.ReadLine();
            if (response == "e")
            {
                requirementBarbequeSauce = true;
            }
            #endregion


            Market market = new Market(moreQuantity);

            #region BuyAndStock

            
            chef.BuyAndStockBread(market, IngredientTypes.Bread);
            chef.BuyAndStockMeatball(meatbaalQuantity, market, IngredientTypes.Meatball);
            chef.BuyAndStockTomato(tomatoQuantity, market, IngredientTypes.Tomato);
            chef.BuyAndStockLettuce(lettuceQuantity, market, IngredientTypes.Lettuce);
            chef.BuyAndStockCheddar(cheddarQuantity, market, IngredientTypes.Cheddar);
            chef.BuyAndStockKetchup(requirementKetchup, market, IngredientTypes.Ketchup);
            chef.BuyAndStockMayonnaise(requirementMayonnaise, market, IngredientTypes.Mayonnaise);
            chef.BuyAndStockBarbequeSauce(requirementBarbequeSauce, market, IngredientTypes.BarbequeSauce);
            #endregion
            Hamburger hamburger = chef.GetOrder(meatbaalQuantity,
                                                cheddarQuantity,
                                                lettuceQuantity,
                                                tomatoQuantity,
                                                requirementKetchup,
                                                requirementMayonnaise,
                                                requirementBarbequeSauce);
            #region GetFromStock
            Bread bread = chef.GetBread();
            chef.SliceInHalf(bread);
            Meatball meatball = chef.GetMeatball();
            chef.Cook(meatball);
            Cheddar cheddar;
            if (cheddarQuantity > 0)
            {
                cheddar = chef.GetCheddar();
                chef.SliceAndStock(cheddar, cheddar.SlicesToHave , (cheddarQuantity / cheddar.SlicesToHave));
            }
            Tomato tomato;
            if (tomatoQuantity > 0)
            {
                tomato = chef.GetTomato();
                chef.SliceAndStock(tomato, tomato.SlicesToHave, (tomatoQuantity / tomato.SlicesToHave));
            }
            Lettuce lettuce;
            if (lettuceQuantity > 0)
            {
                lettuce = chef.GetLettuce();
                chef.SliceAndStock(lettuce, lettuce.SlicesToHave, (lettuceQuantity / lettuce.SlicesToHave));
            }
            BarbequeSauce bbq;
            if (requirementBarbequeSauce) bbq = chef.GetBbqSauce();
            Mayonnaise mayonnaise;
            if (requirementMayonnaise) mayonnaise = chef.GetMayonnaise();
            Ketchup ketchup;
            if (requirementKetchup) ketchup = chef.GetKetchup();
            #endregion


            Hamburger hamburgerToServe = chef.PrepareBurger(hamburger,
                                                            requirementBread,
                                                            meatbaalQuantity,
                                                            lettuceQuantity,
                                                            cheddarQuantity,
                                                            tomatoQuantity,
                                                            requirementBarbequeSauce,
                                                            requirementKetchup,
                                                            requirementMayonnaise);
            Console.ReadLine();

        }
    }
}
