using _01_.Abstract;
using _01_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_.Concrete
{
    class Chef
    {
        Stock stock;

        public Chef()
        {
            stock = new Stock();
        }


        public void BuyAndStockMeatball(double meatbaalQuantity, Market market, params IngredientTypes[] ingredientsToBuy)
        {
            foreach (var item in ingredientsToBuy)
            {
                for (int i = 0; i < meatbaalQuantity; i++)
                {
                    for (int j = market.Products.Count - 1; j >= 0; j--)
                    {
                        Ingredient product = market.Products[j];
                        if (product.GetType().Name == item.ToString())
                        {
                            stock.Meatballs.Enqueue((Meatball)product);
                            Console.WriteLine($"Taze {i + 1}. {product.Description}'ı aldık.");
                            market.Products.Remove(product);
                            break;
                        }
                    }
                }
            }
        }

        public void BuyAndStockTomato(double TomatoSlice, Market market, params IngredientTypes[] ingredientsToBuy)
        {

            Tomato tomato = new Tomato();
            double k = TomatoSlice, i = 1;

            foreach (var item in ingredientsToBuy)
            {
                for (int j = market.Products.Count - 1; j >= 0; j--)
                {
                    Ingredient product = market.Products[j];
                    if (product.GetType().Name == item.ToString())
                    {
                        if (k /tomato.SlicesToHave  < 0)
                        {
                            j -= market.Products.Count;
                        }
                        else
                        {
                            stock.Tomatoes.Enqueue((Tomato)product);
                            Console.WriteLine($"Taze {i}. {product.Description}'ı aldık.");
                            market.Products.Remove(product);
                            k -= tomato.SlicesToHave;
                            i++;
                        }
                    }
                }
            }
        }
        public void BuyAndStockLettuce(double LettuceSlice, Market market, params IngredientTypes[] ingredientsToBuy)
        {
            Lettuce lettuce = new Lettuce();
            double k = LettuceSlice, i = 1;

            foreach (var item in ingredientsToBuy)
            {
                for (int j = market.Products.Count - 1; j >= 0; j--)
                {
                    Ingredient product = market.Products[j];
                    if (product.GetType().Name == item.ToString())
                    {
                        if (k / lettuce.SlicesToHave < 0)
                        {
                            j -= market.Products.Count;
                        }
                        else
                        {
                            stock.Lettuces.Enqueue((Lettuce)product);
                            Console.WriteLine($"Taze {i}. {product.Description}'ı aldık.");
                            market.Products.Remove(product);
                            k -= lettuce.SlicesToHave;
                            i++;
                        }
                    }
                }
            }
        }

        public void BuyAndStockCheddar(double CheddarSlice, Market market, params IngredientTypes[] ingredientsToBuy)
        {
            Cheddar cheddar = new Cheddar();
            double k = CheddarSlice, i = 1;

            foreach (var item in ingredientsToBuy)
            {
                for (int j = market.Products.Count - 1; j >= 0; j--)
                {
                    Ingredient product = market.Products[j];
                    if (product.GetType().Name == item.ToString())
                    {
                        if (k / cheddar.SlicesToHave < 0)
                        {
                            j -= market.Products.Count;
                        }
                        else
                        {
                            stock.Cheddars.Enqueue((Cheddar)product);
                            Console.WriteLine($"Taze {i}. {product.Description}'ı aldık.");
                            market.Products.Remove(product);
                            k -= cheddar.SlicesToHave;
                            i++;
                        }
                    }
                }
            }
        }
        public void BuyAndStockBread(Market market, params IngredientTypes[] ingredientsToBuy)
        {
            foreach (var item in ingredientsToBuy)
            {
                for (int j = market.Products.Count - 1; j >= 0; j--)
                {
                    Ingredient product = market.Products[j];
                    if (product.GetType().Name == item.ToString())
                    {
                        stock.Breads.Enqueue((Bread)product);
                        Console.WriteLine($"Taze {product.Description}'ı aldık.");
                        market.Products.Remove(product);
                        break;
                    }
                }

            }

        }
        public void BuyAndStockKetchup(bool requirementKetchup, Market market, params IngredientTypes[] ingredientsToBuy)
        {
            if (requirementKetchup == true)
            {
                foreach (var item in ingredientsToBuy)
                {
                    for (int j = market.Products.Count - 1; j >= 0; j--)
                    {
                        Ingredient product = market.Products[j];
                        if (product.GetType().Name == item.ToString())
                        {
                            stock.Ketchup.Enqueue((Ketchup)product);
                            Console.WriteLine($"Taze {product.Description}'ı aldık.");
                            market.Products.Remove(product);
                            break;
                        }
                    }

                }

            }
            else
            {
                Console.WriteLine("Müşteri istemediği için Ketchup almadık.");
            }

        }
        public void BuyAndStockMayonnaise(bool requirementMayonnaise, Market market, params IngredientTypes[] ingredientsToBuy)
        {

            if (requirementMayonnaise == true)
            {
                foreach (var item in ingredientsToBuy)
                {
                    for (int j = market.Products.Count - 1; j >= 0; j--)
                    {
                        Ingredient product = market.Products[j];
                        if (product.GetType().Name == item.ToString())
                        {
                            stock.Mayonnaise.Enqueue((Mayonnaise)product);
                            Console.WriteLine($"Taze {product.Description}'ı aldık.");
                            market.Products.Remove(product);
                            break;
                        }
                    }

                }

            }
            else
            {
                Console.WriteLine("Müşteri istemediği için Mayonez almadık.");
            }
        }
        public void BuyAndStockBarbequeSauce(bool requirementBarbequeSauce, Market market, params IngredientTypes[] ingredientsToBuy)
        {


            if (requirementBarbequeSauce == true)
            {
                foreach (var item in ingredientsToBuy)
                {
                    for (int j = market.Products.Count - 1; j >= 0; j--)
                    {
                        Ingredient product = market.Products[j];
                        if (product.GetType().Name == item.ToString())
                        {
                            stock.BarbequeSauces.Enqueue((BarbequeSauce)product);
                            Console.WriteLine($"Taze {product.Description}'ı aldık.");
                            market.Products.Remove(product);
                            break;
                        }
                    }

                }

            }
            else
            {
                Console.WriteLine("Müşteri istemediği için BBQ almadık.");
            }
        }
        public Meatball GetMeatball()
        {
            Meatball meatball;
            do
            {
                if (stock.Meatballs.Count > 0)
                {
                    meatball = stock.Meatballs.Dequeue();
                }
                else
                {
                    Console.WriteLine("Meatball kalmamış");
                    return null;
                }
            } while (meatball.IsFresh == false);
            return meatball;
        }

        public void Cook(params Meatball[] meatballs)
        {
            foreach (var meatball in meatballs)
            {
                if (meatball != null)
                {
                    meatball.IsCooked = true;
                    Console.WriteLine("Köfteyi pişirdik");
                }
                else
                {
                    Console.WriteLine("Pişireyim de köfte nerede?!");
                }
            }
        }

        public Cheddar GetCheddar()
        {
            Cheddar cheddar;
            do
            {
                if (stock.Cheddars.Count > 0)
                {
                    cheddar = stock.Cheddars.Dequeue();
                }
                else
                {
                    Console.WriteLine("Cheddar kalmamış");
                    return null;
                }
            } while (cheddar.IsFresh == false);
            return cheddar;
        }
        public Tomato GetTomato()
        {
            Tomato tomato;
            do
            {
                if (stock.Tomatoes.Count > 0)
                {
                    tomato = stock.Tomatoes.Dequeue();
                }
                else
                {
                    Console.WriteLine("Domates Yok");
                    return null;
                }
            } while (tomato.IsFresh == false);
            return tomato;
        }

        public Lettuce GetLettuce()
        {
            Lettuce lettuce;
            do
            {
                if (stock.Lettuces.Count > 0)
                {
                    lettuce = stock.Lettuces.Dequeue();
                }
                else
                {
                    Console.WriteLine("Marul Yok");
                    return null;
                }
            } while (lettuce.IsFresh == false);
            return lettuce;
        }
        public void SliceAndStock(ISliceable sliceableItem, int sliceQuantity, double product)
        {
            if (sliceableItem != null)
            {
                if (sliceableItem.SlicesToHave >= sliceQuantity)
                {
                    switch (((Ingredient)sliceableItem).Description)
                    {
                        case "Cheddar":
                            for (int i = 0; i < product; i++)
                            {
                                for (int j = 0; j < sliceQuantity; j++)
                                {
                                    CheddarSlice cheddarSlice = new CheddarSlice();
                                    cheddarSlice.BestBeforeDate = ((Ingredient)sliceableItem).BestBeforeDate;
                                    stock.CheddarSlices.Enqueue(cheddarSlice);
                                    sliceableItem.SlicesToHave--;
                                    if (j == sliceQuantity - 1)
                                    {
                                        Console.WriteLine($"{i + 1}. {((Ingredient)sliceableItem).Description} Dilimlendi.");
                                    }
                                }
                            }
                            break;
                        case "Tomato":
                            for (int i = 0; i < product; i++)
                            {
                                for (int j = 0; j < sliceQuantity; j++)
                                {
                                    TomatoSlice tomatoSlice = new TomatoSlice();
                                    tomatoSlice.BestBeforeDate = ((Ingredient)sliceableItem).BestBeforeDate;
                                    stock.TomatoSlices.Enqueue(tomatoSlice);
                                    sliceableItem.SlicesToHave--;
                                    if (j == sliceQuantity - 1)
                                    {
                                        Console.WriteLine($"{i + 1}. {((Ingredient)sliceableItem).Description} Dilimlendi.");
                                    }
                                }
                            }
                            break;

                        case "Lettuce":
                            for (int i = 0; i < product; i++)
                            {
                                for (int j = 0; j < sliceQuantity; j++)
                                {
                                    LettuceSlice lettuceSlice = new LettuceSlice();
                                    lettuceSlice.BestBeforeDate = ((Ingredient)sliceableItem).BestBeforeDate;
                                    stock.LettuceSlices.Enqueue(lettuceSlice);
                                    sliceableItem.SlicesToHave--;
                                    if (j == sliceQuantity - 1)
                                    {
                                        Console.WriteLine($"{i + 1}. {((Ingredient)sliceableItem).Description} Dilimlendi.");
                                    }
                                }
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Bu parçadan {sliceableItem.SlicesToHave} adet parça çıkabilir");
                }
            }
            else
            {
                Console.WriteLine("Neyi keseyim?");
            }
        }

        public CheddarSlice GetCheddarSlice()
        {
            CheddarSlice cheddarSlice;
            do
            {
                if (stock.CheddarSlices.Count > 0)
                {
                    cheddarSlice = stock.CheddarSlices.Dequeue();
                }
                else
                {
                    Console.WriteLine("CheddarSlice kalmamış");
                    return null;
                }
            } while (cheddarSlice.IsFresh == false);
            return cheddarSlice;
        }
        public TomatoSlice GetTomatoSlice()
        {
            TomatoSlice tomatoSlice;
            do
            {
                if (stock.TomatoSlices.Count > 0)
                {
                    tomatoSlice = stock.TomatoSlices.Dequeue();
                }
                else
                {
                    Console.WriteLine("TomatoSlice kalmamış");
                    return null;
                }
            } while (tomatoSlice.IsFresh == false);
            return tomatoSlice;

        }
        public LettuceSlice GetLettuceSlise()
        {
            LettuceSlice lettuceSlice;
            do
            {
                if (stock.LettuceSlices.Count > 0)
                {
                    lettuceSlice = stock.LettuceSlices.Dequeue();
                }
                else
                {
                    Console.WriteLine("LettuceSlice kalmamış");
                    return null;
                }
            } while (lettuceSlice.IsFresh == false);
            return lettuceSlice;

        }
        public Ketchup GetKetchup()
        {
            Ketchup ketchup;
            do
            {
                if (stock.Ketchup.Count > 0)
                {
                    ketchup = stock.Ketchup.Dequeue();

                }
                else
                {
                    Console.WriteLine("Ketchup kalmamış");
                    return null;
                }
            } while (ketchup.IsFresh == false);
            return ketchup;

        }
        public BarbequeSauce GetBbqSauce()
        {
            BarbequeSauce barbequeSauce;
            do
            {
                if (stock.BarbequeSauces.Count > 0)
                {
                    barbequeSauce = stock.BarbequeSauces.Dequeue();
                }
                else
                {
                    Console.WriteLine("BBQ sos kalmamış");
                    return null;
                }
            } while (barbequeSauce.IsFresh == false);
            return barbequeSauce;
        }

        public Mayonnaise GetMayonnaise()
        {
            Mayonnaise mayonnaise;
            do
            {
                if (stock.Mayonnaise.Count > 0)
                {
                    mayonnaise = stock.Mayonnaise.Dequeue();
                }
                else
                {
                    Console.WriteLine("Mayonez kalmamış");
                    return null;
                }

            } while (mayonnaise.IsFresh == false);
            return mayonnaise;
        }

        public Bread GetBread()
        {
            Bread bread;
            do
            {
                if (stock.Breads.Count > 0)
                {
                    bread = stock.Breads.Dequeue();
                }
                else
                {
                    Console.WriteLine("Bread kalmamış");
                    return null;
                }
            } while (bread.IsFresh == false);
            return bread;
        }

        public void SliceInHalf(Bread bread)
        {
            if (bread != null)
            {
                bread.IsSlicedInHalf = true;
                Console.WriteLine("Ekmek bölündü");
            }
            else
            {
                Console.WriteLine("Neyi böleceğiz? ekmek yoksa pasta?!!");
            }
        }
        public void Wait()
        {
        }

        

        public Hamburger PrepareBurger(Hamburger hamburger, bool bread, double meatball, double lettuce, double cheddar, double tomato, bool bbq, bool kethcup, bool mayonnaise)
        {

            Console.WriteLine((bread == true) ? "Ekmek Hazır" : "Ekmeksiz Olmaz");
            Console.WriteLine((meatball > 0) ? "Köfte Eklendi" : "Köftesiz Hazırlanıyor. Zaten Marketten Alınmadı");
            Console.WriteLine((lettuce > 0) ? "Marul Eklendi" : "Marulsuz Hazırlanıyor. Zaten Marketten Alınmadı");
            Console.WriteLine((cheddar > 0) ? "Cheddar Eklendi" : "Cheddarsız Hazırlanıyor. Zaten Marketten Alınmadı");
            Console.WriteLine((tomato > 0) ? "Domates Eklendi" : "Domatessiz Hazırlanıyor. Zaten Marketten Alınmadı");
            Console.WriteLine((bbq == true) ? "BBQ Eklendi" : "BBQ İstenmediği İçin Eklemedik. Zaten Marketten Alınmadı");
            Console.WriteLine((kethcup == true) ? "Ketçap Eklendi" : "Ketçap İstenmediği İçin Eklemedik. Zaten Marketten Alınmadı");
            Console.WriteLine((mayonnaise == true) ? "Mayonez Eklendi" : "Mayonez İstenmediği İçin Eklemedik. Zaten Marketten Alınmadı");
            Console.WriteLine("Hamburger Hazır Afiyet Olsun :) ");
            return hamburger;



        }

        public Hamburger GetOrder(double meatballCount, double cheddarSliceCount, double lettuceSliceCount, double tomatoSliceCount, bool hasKetchup, bool hasMayonnaise, bool hasBarbequeSauce)
        {
            Hamburger hamburger = new Hamburger(meatballCount,
                                                cheddarSliceCount,
                                                lettuceSliceCount,
                                                tomatoSliceCount,
                                                hasKetchup,
                                                hasMayonnaise,
                                                hasBarbequeSauce
                                                );
            return hamburger;
        }
    }
}
