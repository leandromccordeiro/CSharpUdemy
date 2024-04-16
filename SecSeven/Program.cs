

//Console.WriteLine("Enter quantity lines: ");
//int quantityLines = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter quantity column: ");
//int quantityColumns = int.Parse(Console.ReadLine());

//int[,] matriz = new int[quantityLines, quantityColumns];


//for (int i = 0; i < quantityColumns; i++)
//{
//    Console.WriteLine($"Informe a linha {i+1}, com dados separados com traço");
//    var line = Console.ReadLine().Split("-");

//    for (int j = 0; j < quantityLines; j++)
//    {
//        matriz[j, i] = int.Parse(line[j]);
//    }

//}

//Console.WriteLine("------------------------------------");
//for(int j = 0; j < quantityColumns; ++j)
//{
//    for (int i = 0;i < quantityLines; i++)
//    {
//        Console.Write($"{matriz[i, j]} - ");
//    }
//    Console.WriteLine();

//}


//using SecSeven.Entities;
//using SecSeven.Entities.Enums;

//Console.WriteLine("inicio do programa: ");
//Order order = new Order
//{
//    Id = Guid.NewGuid(),
//    Moment = DateTime.Now,
//    Status = OrderStatus.PendigPayment
//};

//Console.WriteLine(order);

//string txt = OrderStatus.PendigPayment.ToString(); - Conversão de tipo ENUM para string.
//OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); - Conversão de tipo para ENUM

