using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class person
    {
       private string FirstName;// private is use to hide data from other user /class,
       public string MiddleName;
       public string LsatName;

       public void SetFirstName(string FirstName)
        {
            if (FirstName.Length >= 2) 
            {
               this.FirstName= FirstName;
            }
        }

        public string GetFirstName() // this method is used to access  private  class though this method
        {
            return FirstName;
        }
       public string GetFullName()
        {
            string FullName = FirstName+" "+MiddleName+" "+LsatName;
            return FullName;
        }

    }
}
