using System;
using System.Collections.Generic;
using System.Linq;
using eShopping.Business.Models;
using eShopping.UseCase.PluginInterfaces.DataStore;

namespace eShopping.DataStore.DataCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
              new  Product{Id = 123, Brand = "Tree Hut", Name = "GLYCERIN, POLYSORBATE 20, SILICA", Price =23.54, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/TreeHut.png", Description ="100% PURE NATURAL SHEA BUTTER - Premium deep moisturizer that wonderfully softens and smooths dry cracked skin.SAFFLOWER SEED OIL, AVACADO OIL, SWEET ALMOND OIL, MACADAMIA SEED OIL, ORANGE OIL - Amazing skin conditioners that prevents dryness and provides your skin a refined healthy"},
              new  Product{Id = 124, Brand = "M3 Naturals", Name = "M3 Naturals Brown Sugar Scrub Infused", Price =12.21, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/M3Naturals.png", Description ="PREMIUM BROWN SUGAR SCRUB SOUFFLE – Our formula is focused around the potent effect of fine brown sugar granules which are rich in glycolic acid. This acid along with the potent antioxidants helps to keep your skin healthy, vibrant and refreshing."},
              new  Product{Id = 125, Brand = "FACIAL SCRUB", Name = "Rebels Refinery Activated Charcoal Face Scrub", Price =35.24, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/FACIAL-SCRUB.png", Description ="FACIAL SCRUB for men helps remove dead skin cells and treat clogged pores that cause blackheads; Use as a pre-shave exfoliator to help with ingrown hairs from shaving."},
              new  Product{Id = 126, Brand = "Linenspa", Name = "Linenspa All-Season White Down Alternative Quilted Comforter", Price =65.67, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/Linenspa.png", Description ="Ultra-soft, all-season microfiber comforter with 8 built-in corner and side loops to secure your favorite duvet cover.Microfiber down alternative fill has a 300 gsm fill weight; Provides the cozy comfort of down without the feathers, odor, and sharp quills"},
              new  Product{Id = 127, Brand = "Dafinner", Name = "Dafinner Red/Beige Reversible Down Alternative Comforter", Price =46.78, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/Dafinner.png", Description ="100% Washed & Brushed Polyester Microfiber Fabric / 100% Polyester & Lyocel Blend Microfiber Filling.EXTREMELY SOFT & COZY - Crafted by double brushed & pre-washed microfiber cover - softer, more breathable, more moisture-wicking than Egyptian"},
              new  Product{Id = 128, Brand = "Basics Bag", Name = "60-Inch Lightweight Tripod with Bag", Price =78.33, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/Amazon%20Basics.png", Description ="Lightweight tripod with adjustable-height legs and rubber feet.Compatible with most video cameras, digital cameras, still cameras, GoPro devices, smartphone adapters (not included), and scopes."},
              new  Product{Id = 129, Brand = "TACKLIFE", Name = "Lightweight Tripod 55-Inch, Aluminum Travel/Camera/Phone Tripod with Carry Bag", Price =99.73, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/TACKLIFE.png", Description ="HIGHER ADJUSTABLE HEIGHT - 55 inches lightweight tripod is 5 inches longer than other normal tripods for your desired height, which could help you get more wonderful scenery; It can collapse to shorter height 16 inches with 3-section and flip-lever leg locks."},
              new  Product{Id = 130, Brand = "Basics Desk", Name = "Foldable Standing Computer Desk", Price =120.45, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/Amazon%20Basics.png", Description ="Foldable standing desk with adjustable height and lower secondary storage shelf.Removable wood desktop and lightweight steel frame.Folds completely down for easy storage or transport"},
              new  Product{Id = 131, Brand = "Mr IRONSTONE", Name = "Mr IRONSTONE 31.5” Folding Computer Desk, Small Writing Desk Easy ", Price =132.86, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/IRONSTONE.png", Description ="1-Minute Easy Assembling - Simple structure folding writing Desk, You can install the office desk within 1 minute, no extra tools needed. Just open the metal frame and snap the desktop on it, then the.installation is complete.No Assembly Foldable Desk is a great gift choice."},
              new  Product{Id = 132, Brand = "Cleaning Cloth", Name = "White, and Yellow Microfiber Cleaning Cloth", Price =137.54, ImageLink ="https://raw.githubusercontent.com/OgunniyiOwamamwen/FreeCodeCamp/master/blazor/product/CleaningCloth.png", Description ="Ultra soft, non-abrasive microfiber cloths will not scratch paints, coats or other surfaces.Cleans with or without chemical cleaners, leaves lint and streak free results Absorbs eight times its own weight.Pack comes with three different towel colors (blue, yellow, and white)Rinse and reuse 100's of times"}
             };

        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }           

         public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return _products;
            return _products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }
    }
}
