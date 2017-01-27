using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcept.Constructor
{
    /// <summary>
    /// A private constructor is a special instance constructor. It is generally used in classes that contain static members only. If a class has one or more private constructors and no public constructors, other classes (except nested classes) cannot create instances of this class. For example:
    ///     class NLog
    ///{
    ///    // Private Constructor:
    ///    private NLog() { }

    ///    public static double e = Math.E;  //2.71828...
    ///}
    ///
    /// The declaration of the empty constructor prevents the automatic generation of a default constructor. Note that if you do not use an access modifier with the constructor it will still be private by default. However, the private modifier is usually used explicitly to make it clear that the class cannot be instantiated.
    /// Private constructors are used to prevent creating instances of a class when there are no instance fields or methods, such as the Math class, or when a method is called to obtain an instance of a class. If all the methods in the class are static, consider making the complete class static.
    /// </summary>
    class PrivateConstructor
    {
        // you can have a private multiple private constructor in same class and also public constructor at the same time
        private PrivateConstructor()
        {
            Console.WriteLine("Private Constructor called");
        }

        private PrivateConstructor(int a, int b, int c)
        {

        }

        // you can call the private constructor vie constructor chanining like below
        public PrivateConstructor(int a, int b):this()
        {
            Console.WriteLine("Value of a = {0} and Value of b = {1}", a, b);
        }

        // u can access the private constructor member and create the object of this class from same class
        //static void Main(string[] args)
        //{
        //    PrivateConstructor objPrivateConst = new PrivateConstructor();
        //    PrivateConstructor objPublicConst = new PrivateConstructor(10, 30);
        //    Console.ReadLine();
        //}
    }

    // you can not inherit the class having private constructor
    class CallingClasss //: PrivateConstructor
    {
        static void Main(string[] args)
        {
            // U can create the object of the class having private constructor from other classes which type of constructor is set a private like default, parameterize etc.
            //PrivateConstructor objPrivateConst = new PrivateConstructor(); // uncomment this like will give error
            PrivateConstructor objPublicConst = new PrivateConstructor(10, 30);
            Console.ReadLine();
        }
    }
}
