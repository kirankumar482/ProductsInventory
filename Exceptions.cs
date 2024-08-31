using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsInventory
{
    public class ProductNotFoundException: Exception
    {
        public ProductNotFoundException(string msg):base (msg) { }
    }

    public class EmptyInventoryException: Exception
    {
        public EmptyInventoryException(string msg) : base(msg) { }
    }
}
