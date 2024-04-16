namespace SecNine.Exercises.Entities
{
    public class Client
    {
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public DateTime BirthDate { get; private set; }

        public Client()
        {
            
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return ($"Nome: {Name}\n" +
            $"Email: {Email}\n" +
            $"Birth Date: {BirthDate}");
        }
    }
}
