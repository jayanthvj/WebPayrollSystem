using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class  Institution
    {
        public Institution()
        {
            Console.WriteLine("welcome to institution");
            
        }

    }
    public class School : Institution
    {
        string firstSchool, secondSchool;
        public  School() : base()
        {
            Console.WriteLine("Enter a name of Firstschool");
            firstSchool = Console.ReadLine();
            Console.WriteLine("Enter a name of Secondschool");
            secondSchool = Console.ReadLine();
        }
        public void Getdata()
        {
            Console.WriteLine("the name of firstschool is {0}", firstSchool);
            Console.WriteLine("the name of secondschool is {0}", secondSchool);
        }
    }
    class Mainporgram
    {
        static void Main(string[] args)
        {
            Institution Object = new Institution();
            School sl = new School();
            sl.Getdata();
            
            Console.ReadLine();
        }
    }
}
