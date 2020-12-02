using System;
using System.Collections.Generic;
using System.Text;

namespace CodePatternsInlamning
{
    // handles cart functions for an order
    public interface IShoppingCartService
    {
        void AddProductToCart(List<IPhysicalProduct> physicalCart, List<IDigitalProduct> digitalCart,
            IBaseProduct product);

        double CheckOut(List<IPhysicalProduct> physicalCart, List<IDigitalProduct> digitalCart, double totalSum);

        void RemoveProductFromCart(List<IPhysicalProduct> physicalCart, List<IDigitalProduct> digitalCart,
            IBaseProduct product);
    }
}