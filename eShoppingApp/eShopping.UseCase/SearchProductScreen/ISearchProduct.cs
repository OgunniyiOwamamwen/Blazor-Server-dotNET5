using System;
using System.Collections.Generic;
using eShopping.Business.Models;

namespace eShopping.UseCase.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute();
        IEnumerable<Product> Execute(string filter);
    }
}
