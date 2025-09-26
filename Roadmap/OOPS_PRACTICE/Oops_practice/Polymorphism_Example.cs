//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_practice
//{
    
//    public class Animal
//            {
//        public virtual void sound()
//        {
//            Console.WriteLine("Animal sound");
//        }
//    }

//    public class Dog : Animal
//    {
//        public override void sound()
//        {
//            Console.WriteLine("Dog barks");
//        }
//    }
//    public class Cat : Animal
//    {
//        public override void sound()
//        {
//            Console.WriteLine("Cat meows");
//        }
//    }
//    public class Polymorphism_Example
//    {
//        static void Main(string[] args)
//        {
//            Animal myAnimal= new Animal();
//            myAnimal = new Dog();
//            myAnimal.sound();  // Output: Dog barks
//            myAnimal = new Cat();
//            myAnimal.sound();  // Output: Cat meows
//        }

//    }
//}
