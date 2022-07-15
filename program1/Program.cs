using System;//program on data Hiding/tutorial 7

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();     //here we set/save data in a variable.
            person person1 = new person();


            //if (FirstName.Length >= 2)      //set a condition when  the data can get entry /save in           second variable.
            //{
            //    person1.FirstName = FirstName;     // here we recall this data/get  this data calling      data variable name.
            //}

            string name = person1.GetFirstName();//hiden class is get/ access though the method.

            person1.SetFirstName(FirstName);
            person1.MiddleName = "Islam";
            person1.LsatName = "Khan";
            string FullName = person1.GetFullName();
            Console.WriteLine(FullName);
                    
        }
    }
}
