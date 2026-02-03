using System.Threading.Channels;

namespace LabØvelse5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 1
            int[] tall = { 9, 0, 6, 0, 4, 7, 5, 3, 1, 2 };
            int sum = 0;
            for(int i = 0; i < tall.Length; i++)
            {
                sum = sum + tall[i];
                Console.WriteLine(i);
            }

            int maks = 0;

            foreach(int i in tall) 
            {
                if(i > maks)
                {
                    maks = i;
                }
            }

            // Øvelse 2
            List<Product> products = new List<Product>(10);
            products.Add(new Product { Id = 0, Name = "Screwtape Letters", Category = "Book", Price = 3.9m});
            products.Add(new Product { Id = 1, Name = "Nissan Micra", Category = "Car", Price = 200009m });
            products.Add(new Product { Id = 2, Name = "JBL Headset", Category = "Electronics", Price = 50.9m });
            products.Add(new Product { Id = 3, Name = "Holy Bible", Category = "Book", Price = 22.9m });
            products.Add(new Product { Id = 4, Name = "Bread", Category = "Food", Price = 2.9m });
            products.Add(new Product { Id = 5, Name = "Pizza", Category = "Food", Price = 7.9m });
            products.Add(new Product { Id = 6, Name = "Tesla X", Category = "Car", Price = 30000.9m });
            products.Add(new Product { Id = 7, Name = "Barber", Category = "Electronics", Price = 30.9m });
            products.Add(new Product { Id = 8, Name = "Office Chair", Category = "Furniture", Price = 40.9m });
            products.Add(new Product { Id = 9, Name = "Table", Category = "Furniture", Price = 45.9m });

            Console.WriteLine("Enter category: ");
            string input = Console.ReadLine();
            var prodQuery = from prod in products where prod.Category == input select prod;
            Console.WriteLine("Search results:");
            foreach(Product prod in prodQuery)
            {
                Console.WriteLine(prod.Name);
            }

            Console.WriteLine("Enter price range (min, max): ");
            decimal min = decimal.Parse(Console.ReadLine());
            decimal max = decimal.Parse(Console.ReadLine());

            prodQuery = from prod in products where prod.Price >= min && prod.Price <= max select prod;
            Console.WriteLine("Search results: ");
            foreach(Product prod in prodQuery)
            {
                Console.WriteLine(prod.Name);
            }

            Console.WriteLine("Enter price, and get all products exceeding that price: ");
            max = decimal.Parse(Console.ReadLine());

            prodQuery = from prod in products where prod.Price > max select prod;
            foreach(Product prod in prodQuery)
            {
                Console.WriteLine(prod.Name);
            }

            Console.WriteLine("Products sorted by price in ascending order: ");

            prodQuery = from prod in products orderby prod.Price ascending select prod;
            foreach(Product prod in prodQuery)
            {
                Console.WriteLine(prod.Name);
            }

            var result = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count()
                });

            Console.WriteLine("Different categories and the number of products in the given category: ");

            foreach (var item in result)
            {
                Console.WriteLine(item.Category + ":" + item.Count);
            }

            //Øvelse 3

            Console.WriteLine("shopping-menu");

            List<string> items = new List<string>();
            while (input != "quit")
            {
                Console.WriteLine("Commandos:\n add \n remove \n show \n show sorted \n search \n quit");
                Console.WriteLine();
                input = Console.ReadLine();
                switch (input)
                {
                    case ("add"):
                        Console.WriteLine("Add item: ");
                        items.Add(Console.ReadLine());
                        break;

                    case ("remove"):
                        Console.WriteLine("Remove item by name: ");
                        string item = Console.ReadLine();
                        items.Remove(item);
                        break;

                    case ("show"):
                        Console.WriteLine("Showing all items:");
                        foreach(string str in items)
                        {
                            Console.WriteLine(str);
                        }
                        break;

                    case ("show sorted"):
                        Console.WriteLine("Items sorted: ");
                        items.Sort();
                        foreach(string str in items)
                        {
                            Console.WriteLine(str);
                        }
                        break;

                    case ("search"):
                        Console.WriteLine("Enter search term: ");
                        string search = Console.ReadLine();

                        foreach(string str in items)
                        {
                            if(str.Contains(search))
                            {
                                Console.WriteLine(str);
                            }
                        }
                        break;
                }
            }
        }
    }
}