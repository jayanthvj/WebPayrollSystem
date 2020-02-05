/**
 * CLASS = School,Student,Details
 * Version=1.0
 * Date=16-12-2019
 * Author= Jayanth
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirutualOveride
{
    class School
    {
        public virtual void show()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }
    }

    class Student : School
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.ReadLine();
        }
    }

    class Instution
    {
        public static void Main()
        {
            Student firstobject = new Student();
            firstobject.show();
            School secondObject = new Student();
            secondObject.show();
        }
    }
}