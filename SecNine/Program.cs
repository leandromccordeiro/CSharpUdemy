using SecNine.Entities;
using SecNine.Exercises.Entities;
using SecNine.Exercises.Enums;

//Console.WriteLine("TRIP");

//Post post = new Post();

//Comment comment1 = new Comment("Have a nice trip!");
//Comment comment2 = new Comment("Wow that's awesome!");

//Post p1 = new Post(
//    DateTime.Parse("21/06/2018 13:05:44"),
//    "Traveling to New Zealand",
//    "I'm going to visit this wonderful country!",
//    12);
//p1.AddComment(comment1);
//p1.AddComment(comment2);

//Console.WriteLine(p1);


Client client = new Client("Leandro Cordeiro", "cliente@cliente.com", DateTime.Parse("20/03/1990"));
Console.WriteLine("--------------Data Order--------------");
Order order = new Order(DateTime.Parse("12/04/2024"), Enum.Parse<OrderStatus>("2"), client);


Console.WriteLine("Quantos produtos deseja incluir para o atual pedido? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"--- Pedido nº {i + 1}");
    Console.WriteLine($"Entre com o nome do produto:");
    string productName = Console.ReadLine();
    Console.WriteLine("Entre com o preço: ");
    double price = double.Parse(Console.ReadLine());

    Product product = new Product("productName", price);
    Console.WriteLine("Informe a quantidade: ");
    int quantity = int.Parse(Console.ReadLine());

    OrderItem item = new OrderItem(quantity, price, product);

    order.AddItem(item);
}

Console.WriteLine();

Console.WriteLine(order.ToString());
