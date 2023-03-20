namespace Dictionarycollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfoming CRUD operation in Dicitionary Collection!");
            Dictionary<string, int> myDictionary = new Dictionary<string, int>(); //Create a new item in Dictionary
            myDictionary.Add("apple", 3);
            myDictionary.Add("banana", 5);

            myDictionary["apple"] = 4; //Update value in a Dictionary of key Apple

            myDictionary.Remove("banana"); //Delete value of key from a Dictionary

            foreach (var value in myDictionary) //Reading An Dictionarycollection values
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}