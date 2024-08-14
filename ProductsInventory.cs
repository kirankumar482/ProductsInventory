namespace ProductsInventory
{
    public class ProductsInventory
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's build a crud locally");

            ProductsService service = new ProductsService();

            Console.WriteLine("Enter Option");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Items");
            Console.WriteLine("3. Update Item");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Search Item");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    service.AddItem();
                    break;
                case 2:
                    service.ViewItems();
                    break;
                case 3:
                    service.UpdateItem();
                    break;
                case 4:
                    service.DeleteItem();
                    break;
                case 5:
                    service.SearchItem();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

}

