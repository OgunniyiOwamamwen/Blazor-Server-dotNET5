using System;
using System.Collections.Generic;
using eShopping.Business.Models;

namespace eShopping.UseCase.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts(string filter = null);
       
    }
}
