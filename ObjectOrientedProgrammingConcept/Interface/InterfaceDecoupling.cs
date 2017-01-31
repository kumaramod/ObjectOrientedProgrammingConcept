using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcept.Interface
{
    public interface IShip
    {
        void ShipName();
    }

    public class AirJet : IShip
    {
        public void ShipName()
        {
            Console.WriteLine("Airject");
        }
    }

    public class Spice : IShip
    {
        public void ShipName()
        {
            Console.WriteLine("Spice");
        }
    }

    public class objectCreater
    {
        public static IShip CreateObject(int animalType)
        {
            if (animalType == 1)
            {
                return new AirJet();
            }
            else if (animalType == 2)
            {
                return new Spice();
            }
            else
            {
                return null;
            }
        }
    }



    //Another way and examples..................................................................

    interface IPerson
    {
        void ShowCountry();
    }
 
    class IndianPerson:IPerson
    {
        public void ShowCountry()
        {
            Console.WriteLine("I am Indian Person");
        }
    }
    class USPerson :IPerson
    {
        public void ShowCountry()
        {
            Console.WriteLine("I am US Person");
        }
    }
 
    class PersonSupplyer
    {
        public static IPerson ReturnPerson(String country)
        {
            if (country == "INDIA")
                return new IndianPerson();
            else if (country == "US")
                return new USPerson();
            else
                return null;
        }
    }

    /// <summary>
    /// Now, what is Advantage of that?
    ///The main advantage of this design is client is totally unaware about concrete class representation. Because,  ersonsupplyer class is making abstraction over my concrete class.
    ///The second advantage is , if we add one more person class in my middle layer then no need to change any code in client layer. Just it’s enough to inform client developer which parameter need to supply to get object of newly added class.
    ///The third advantage is we can control new keyword in our client code. As only in one place we are creating new keyword.
    /// </summary>
    class InterfaceDecoupling
    {
        static void Main()
        {
            //Way to achive decupling
            IShip objAirjet = objectCreater.CreateObject(1);
            objAirjet.ShipName();


            // 2nd example of decoupling
            IPerson objPerson = PersonSupplyer.ReturnPerson("INDIA");
            objPerson.ShowCountry();
            Console.ReadLine();
        }
    }
}
