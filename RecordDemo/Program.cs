namespace RecordDemo
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    //record is a fancy class
    //Immutable/ the values cannot be changed
    //record act like value types instead of a refference type like a class

    public record Record1 (string firstName, string lastName)
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public class Class1 (string firstName, string lastName)
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}