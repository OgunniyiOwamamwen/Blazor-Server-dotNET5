using System;
using System.Collections.Generic;
using eShopping.Business.Models;
using eShopping.UseCase.PluginInterfaces.DataStore;

namespace eShopping.UseCase.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {

        private readonly IProductRepository _productRepository;

        public SearchProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return _productRepository.GetProducts();
        }
        //
        public IEnumerable<Product> Execute(string filter)
        {
            return _productRepository.GetProducts(filter);
        }
    }
}