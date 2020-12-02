using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // handles cart functions for an order

    public class ShoppingCartService : IShoppingCartService
    {
        private int i = 1;

        public void AddProductToCart(List<IPhysicalProduct> physicalCart, List<IDigitalProduct> digitalCart,
            IBaseProduct product)
        {
            switch (product)
            {
                case IPhysicalProduct p:
                    physicalCart.Add(p);
                    AddedToCartMessage(p);
                    break;

                case IDigitalProduct p:
                    digitalCart.Add(p);
                    AddedToCartMessage(p);
                    break;

                default:
                    Console.WriteLine("Invalid Product");
                    break;
            }
        }

        public void RemoveProductFromCart(List<IPhysicalProduct> physicalCart, List<IDigitalProduct> digitalCart,
            IBaseProduct product)
        {
            switch (product)
            {
                case IPhysicalProduct p:
                    physicalCart.Remove(p);
                    RemovedFromCartMessage(p);
                    break;

                case IDigitalProduct p:
                    digitalCart.Remove(p);
                    RemovedFromCartMessage(p);
                    break;

                default:
                    Console.WriteLine("Invalid Product");
                    break;
            }
        }

        public double CheckOut(List<IPhysicalProduct> physicalCart, List<IDigitalProduct> digitalCart, double totalSum)
        {
            Console.WriteLine("\nChecking out order");
            Console.WriteLine(" Summary of your selected items:");
            totalSum = SummarizeCart(physicalCart, totalSum);
            totalSum = SummarizeCart(digitalCart, totalSum);
            Console.WriteLine($"Cost: {totalSum}kr (not including freight cost)");
            return totalSum;
        }


        private double SummarizeCart(IEnumerable<IBaseProduct> cart, double totalSum)
        {
            foreach (var item in cart)
            {
                Console.WriteLine($"    {i}. {item.Title}");
                i++;
                totalSum += item.Price;
            }

            return totalSum;
        }


        private static void AddedToCartMessage(IBaseProduct product)
        {
            Console.WriteLine($"Added {product.Title} to shoppingcart ");
        }

        private static void RemovedFromCartMessage(IBaseProduct product)
        {
            Console.WriteLine($"Removed {product.Title} from shoppingcart ");
        }
    }
}