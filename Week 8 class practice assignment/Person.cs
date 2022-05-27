using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Patrick McKee
//May 26, 2022
//Classes Practice Assignment

namespace Week_8_class_practice_assignment
{
    public class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Job { get; set; }

        //methods (behavior)
        public void DisplayName()
        {
            Console.WriteLine("Hello, my name is {0} {1}",FirstName, LastName);

        }
        public void DisplayEmail()
        {
            Console.WriteLine("My email address is " + Email);

        }
        public void DisplayJob()
        {
            Console.WriteLine("My job title is {0}", Job);
        }
    }
}
