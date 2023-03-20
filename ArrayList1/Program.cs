using System.Collections;

namespace ArrayList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfoming CRUD operation in ArrayList!!");
            //1st type to Create ArrayList
            ArrayList arraylist = new ArrayList(); //Create An ArrayList
            arraylist.Add(1);
            arraylist.Add("Sky");
            arraylist.Add("Happy");
            arraylist.Add(7.8f);
            arraylist.Add(8.8);
            arraylist.Add(true);
            arraylist.Add(null);

            //Update arrylist
            arraylist.Insert(1, "First");
            arraylist.Insert(2, "Item");
            arraylist.Insert(3, 6.6f);
            //Deleteing some Values from arraylist
            arraylist.Remove(1);
            arraylist.Remove("Sky");


            Console.WriteLine("Printing Arraylist :-");
            foreach (var value in arraylist)  //Reading An ArrayList values
            {
                Console.WriteLine(value);
            }
            //1st type to Create ArrayList
            var myarraylist = new ArrayList() { 61, "Zombie", 3.8f, false, 5.5, null }; //Create An ArrayList

            //Update arrylist
            myarraylist.Insert(1, "First");
            myarraylist.Insert(2, "Item");
            myarraylist.Insert(3, 6.6f);
            //Deleteing some Values from arraylist
            myarraylist.Remove(5.5);
            myarraylist.Remove(false);

            foreach (var value in myarraylist) //Reading An ArrayList values
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();

        }
    }
}