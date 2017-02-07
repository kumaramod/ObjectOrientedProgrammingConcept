using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcept.Polymorphism
{
    /// <summary>
    /// https://www.codeproject.com/articles/771455/diving-in-oop-day-polymorphism-and-inheritance-ear
    /// </summary>

    public class Overloading
    {
        public void DisplayOverload(int a)
        {
            System.Console.WriteLine("DisplayOverload " + a);
        }

        // in below both method only one type (out or ref) are same type method.
        private void DisplayOverload(out int a)
        {
            a = 100;
        }
        //public void DisplayOverload(ref int a)
        //{

        //}

        public void DisplayOverload(string a)
        {
            System.Console.WriteLine("DisplayOverload " + a);
        }
        public void DisplayOverload(string a, int b)
        {
            System.Console.WriteLine("DisplayOverload " + a + b);
        }

        // a method can't have same parameter name
        //public void DisplayOverload(int a, int a)
        //{

        //}

        //Use of reference variable
        private string name = "Amod";
        public void displayNameByRef()
        {
            displayNameByRef1(ref name);
            Console.WriteLine(name);
        }

        public void displayNameByRef1(ref string x)
        {
            Console.WriteLine(x);
            x = "Amod Kumar";
            Console.WriteLine(name);
            name = "Amod Kumar AK";
        }

        //Use of value type variable
        private string city = "Patna";
        public void displayNameByValue()
        {
            displayNameByValue1(city);
            Console.WriteLine(city);
        }

        public void displayNameByValue1(string x)
        {
            Console.WriteLine(x);
            x = "Patna Bihar";
            Console.WriteLine(city);
            x = "Patna Bihar PB";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Overloading overload = new Overloading();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);

            overload.displayNameByRef();
            overload.displayNameByValue();
            Console.ReadKey();
        }
    }


}
