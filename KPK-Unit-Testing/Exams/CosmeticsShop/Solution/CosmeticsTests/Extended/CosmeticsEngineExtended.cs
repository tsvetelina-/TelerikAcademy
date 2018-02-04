using Cosmetics.Contracts;
using Cosmetics.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsTests
{
    internal class CosmeticsEngineExtended : CosmeticsEngine
    {
        public CosmeticsEngineExtended(ICosmeticsFactory factory, IShoppingCart shoppingCart, ICommandParser commandParser) 
            : base(factory, shoppingCart, commandParser)
        {
        }

        public IDictionary<string,ICategory> GetCategories
        {
            get
            {
                return this.categories;
            }
        }

        public IDictionary<string, IProduct>GetProducts
        {
            get
            {
                return this.products;
            }
        }

    }
}
