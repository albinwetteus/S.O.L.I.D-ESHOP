using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    //This class handles the current shoppingsession for the customer
    public class Order : IOrder
    {
        private readonly IShoppingCartService _shoppingCartService;


        public ICustomer Customer { get; }
        public Guid OrderId { get; } = Guid.NewGuid();
        public bool IsPaid { get; set; } = false;
        public double TotalSumOfOrder { get; set; }
        public List<IPhysicalProduct> PhysicalCart { get; set; }
        public List<IDigitalProduct> DigitalCart { get; set; }


        public Order(ICustomer customer, IShoppingCartService shoppingCartService)
        {
            Customer = customer;
            PhysicalCart = new List<IPhysicalProduct>();
            DigitalCart = new List<IDigitalProduct>();
            _shoppingCartService = shoppingCartService;
        }


        public void AddProductToCart(IBaseProduct product)
        {
            _shoppingCartService.AddProductToCart(PhysicalCart, DigitalCart, product);
        }

        public void RemoveProductFromCart(IBaseProduct product)
        {
            _shoppingCartService.RemoveProductFromCart(PhysicalCart, DigitalCart, product);
        }

        public void CheckOut()
        {
            if (PhysicalCart.Count == 0 && DigitalCart.Count == 0)
            {
                Console.WriteLine("No product in cart");
                return;
            }

            TotalSumOfOrder = _shoppingCartService.CheckOut(PhysicalCart, DigitalCart, TotalSumOfOrder);
        }
    }
}