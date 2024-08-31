
namespace ProductsInventory
{
    internal class ProductsService
    {
        public List<Product> list = ProductRepo.products;
        internal void AddItem(Product product)
        {
            list.Add(product);
            Console.WriteLine("Added "+product);
        }
        internal void DeleteItem(int productId)
        {
            Product p = null;
            foreach (Product product in list)
            {
                if (product.Id == productId)
                {
                    p = product;
                    break;
                }
            }

            if (p != null)
            {
                list.Remove(p);
                Console.WriteLine("Deleted");
            }
            else
            {
                throw new ProductNotFoundException("Product not found");
            }
        }

        internal Product GetItem(int id)
        {
            foreach (Product product in list)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            throw new ProductNotFoundException("Product Not Found with given Id");
        }

        internal List<Product> SearchItem(string productName)
        {
            List<Product> filtered= list?.FindAll((p)=> p.Name.Equals(productName));
            if(filtered.Count == 0)
            {
                throw new ProductNotFoundException("Product Not Found with that name");
            }
            return filtered;
        }
        internal void UpdateItem(int productId, double price, string name, string des)
        {
            foreach(Product p in list)
            {
                if (p.Id == productId)
                {
                    p.Price = price;
                    p.Name = name;
                    p.Description = des;
                    Console.WriteLine("Updated");
                    return;
                }
            }
            throw new ProductNotFoundException("Product Not Found with given Id");  
        }

        internal void ViewItems()
        {
            if(list.Count == 0)
            {
                throw new EmptyInventoryException("Empty Inventory");
            }
            list.ForEach(p => Console.WriteLine(p));
        }
    }
}

//ForEach only to workout operations without modyfying them
//list.ForEach(item => {
//    if (item.Id == id)
//    {
//        return item;
//    }
//});