//int n = int.Parse(Console.ReadLine());

//double[] vect = new double[n];

//for  (int i = 0; i < n; i++)
//{
//    vect[i] = double.Parse(Console.ReadLine());
//}


//using SecSix;
//Console.WriteLine("Quantos produtos? ");

//int n = int.Parse(Console.ReadLine());
//Product[] vect = new Product[n];

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Informe o nome do produto");
//    string nome = Console.ReadLine();
//    Console.WriteLine("Informe o valor do produto");
//    decimal valor = decimal.Parse(Console.ReadLine());
//    Console.WriteLine("Informe a quantidade do produto");
//    int quantidade = int.Parse(Console.ReadLine());

//    vect[i] = new Product()
//    {
//        Name = nome,
//        Price = valor,
//        Quantidade = quantidade,
//    };
//}

using SecSix;

List<string> names = new List<string>();
List<decimal> salary = new List<decimal>();
List<Guid> ids = new List<Guid>();
decimal vrPercen = 0.00m;

Employee employee = new Employee();

Console.WriteLine("How many employees should be included?");
int quantity = int.Parse(Console.ReadLine());

for (int x = 0; x < quantity; x++)
{
    Console.WriteLine("Enter the employee's name:");
    employee.Name = Console.ReadLine();
    Console.WriteLine("Enter the emplyee's salary: ");
    employee.Salary = decimal.Parse(Console.ReadLine());
    names.Add(employee.Name);
    salary.Add(employee.Salary);
    ids.Add(employee.Id);
}

Console.WriteLine(names[0]  + " " + salary[0] + " " + ids[0]);

Console.WriteLine("Do you want to increase your salary (y/n)?");
string resp = Console.ReadLine().ToLower().Trim();
if (resp.Equals("y"))
{
    Console.WriteLine("Enter percent:");
    vrPercen = decimal.Parse(Console.ReadLine());
    employee.Salary = employee.UpdateSalary(ids[0], salary[0], vrPercen);
    Console.WriteLine($"The new salary is: {employee.ReturnSalary(ids[0])} ");
}




