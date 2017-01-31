using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConcept.Interface
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Dog:IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Cat: IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meaw");
        }
    }

    class Interface
    {
        //static void Main()
        //{
        //    //IAnimal animal = new IAnimal(); //Cann't create the instance of Interface and abstract class
        //    //animal.Speak();

        //    IAnimal animalDog = new Dog();
        //    animalDog.Speak();

        //    IAnimal animalCat = new Cat();
        //    animalCat.Speak();
        //    Console.ReadLine();
        //}
    }
}
