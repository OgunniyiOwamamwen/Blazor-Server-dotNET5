using System;
using eShopping.Business.Models;

namespace eShopping.UseCase.SearchProductScreen
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}
