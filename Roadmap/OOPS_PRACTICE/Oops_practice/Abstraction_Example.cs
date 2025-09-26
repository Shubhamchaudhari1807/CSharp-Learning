//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_practice
//{

//    // Abstract class
//    abstract class Animal2
//    {
//        // Abstract method (does not have a body)
//        public abstract void animalSound();
//        // Regular method
//        public void sleep()
//        {
//            Console.WriteLine("Zzz");
//        }
//    }

//    // Derived class (inherit from Animal)
//    class Pig : Animal2
//    {
//        public override void animalSound()
//        {
//            // The body of animalSound() is provided here
//            Console.WriteLine("The pig says: wee wee");
//        }
//    }


//    public class Abstraction_Example
//    {
//        static void Main(string[] args)
//        {
//            Pig myPig = new Pig(); // Create a Pig object
//            Console.WriteLine("Abstraction Example:");
//            myPig.animalSound();  // Call the abstract method
//            myPig.sleep();  // Call the regular method
//        }
//    }
//}
