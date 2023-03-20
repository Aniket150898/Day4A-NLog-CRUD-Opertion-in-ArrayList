namespace NlogDemoFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Everyone!!!Performs NLog & CRUD operation in ArrayList & Dictionary");
            AddNumber obj = new AddNumber();
            obj.Sum(2, 3);
            Console.WriteLine("This is a Logger Demo");
            Console.ReadKey();
        }
    }
}