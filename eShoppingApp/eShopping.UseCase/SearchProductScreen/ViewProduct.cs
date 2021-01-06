using System;
using eShopping.Business.Models;
using eShopping.UseCase.PluginInterfaces.DataStore;

namespace eShopping.UseCase.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository _productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return _productRepository.GetProduct(id);
        }
    }
}
