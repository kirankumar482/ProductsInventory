namespace ProductsInventory
{
    public class ProductsMenu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's build a crud locally");

            ProductsService service = new ProductsService();

            int id;
            string name, description;
            double price;
            bool key = true;

            while (key)
            {
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. View Items");
                Console.WriteLine("3. Update Item");
                Console.WriteLine("4. Delete Item");
                Console.WriteLine("5. Get Item");
                Console.WriteLine("6. Search Item");
                Console.WriteLine("7. Exit");

                Console.WriteLine("Enter Option");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter product name:");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter product description: ");
                        description = Console.ReadLine();

                        Console.WriteLine("Enter product price:");
                        price = double.Parse(Console.ReadLine());

                        Product product = new Product(name, description, price);
                        service.AddItem(product);
                        break;
                    case 2:
                        try
                        {
                            service.ViewItems();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter existing product ID:");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter updated product name:");
                        name = Console.ReadLine();

                        Console.WriteLine("Enter updated product description: ");
                        description = Console.ReadLine();

                        Console.WriteLine("Enter updated product price:");
                        price = double.Parse(Console.ReadLine());

                        try
                        {
                            service.UpdateItem(id, price, name, description);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter existing product ID:");
                        id = int.Parse(Console.ReadLine());
                        try
                        {
                            service.DeleteItem(id);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter existing product ID:");
                        id = int.Parse(Console.ReadLine());
                        try
                        {
                            Console.WriteLine(service.GetItem(id));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Enter existing product name:");
                        name = Console.ReadLine();
                        try
                        {
                            List<Product> products = service.SearchItem(name);
                            products.ForEach(p => Console.WriteLine(p));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 7:
                        key = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;                    
                }
            }
        }
    }

}

