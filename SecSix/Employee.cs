namespace SecSix
{
    public class Employee
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
        }
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;

            Console.WriteLine($"Usuário cadastrado sob o ID {Id}");
        }

        public decimal UpdateSalary (Guid id, decimal salary, decimal percent)
        {
            decimal vrPercent = salary * (percent/100);
            salary += vrPercent;
            return salary;
        }

        public decimal ReturnSalary (Guid id)
        {
            return Salary;
        }




    }
}
