using SecTen.Entities;
using System.Linq.Expressions;

Console.WriteLine("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Product {i + 1} data: ");
    Console.WriteLine("Common, used or imported (c/u/i)? ");
    string resp = Console.ReadLine().ToLower().Trim();

    Console.WriteLine("Enter name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Enter price: ");
    double price = double.Parse(Console.ReadLine());

    switch (resp)
    {
        case "c":

            list.Add(new Product(name, price));

            break;

        case "i":

            Console.WriteLine("Enter Customs fee: ");
            list.Add(new ImportedProduct(name, price, double.Parse(Console.ReadLine())));

            break;

        case "u":

            Console.WriteLine("Enter Manufacture date: ");
            list.Add(new UsedProduct(name, price, DateTime.Parse(Console.ReadLine())));

            break;
    }
}

Console.WriteLine("PRICE TAGS: ");
foreach (Product product in list)
{
    Console.WriteLine(product.PriceTag());
}
