//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_practice
//{


//    interface IAnimal
//    {
//        public void animalSound(); // interface method (does not have a body)
//       // interface method (does not have a body)
//    }

//    interface IBird
//    {
//        public void animalSound2(); // interface method (does not have a body)
//        // interface method (does not have a body)
//    }

//    public class  Pig : IAnimal, IBird
//    {
//        public void animalSound()
//        {
//            // The body of animalSound() is provided here
//            Console.WriteLine("The pig says: wee wee");
//        }
//        public void animalSound2()
//        {
//            // The body of animalSound() is provided here
//            Console.WriteLine("The bird says: chirp chirp");
//        }
//    }
//    public class Interface_Example
//    {
//        static void Main(string[] args)
//        {
//            Pig myPig = new Pig(); // Create a Pig object
//            Console.WriteLine("Interface Example:");
//            myPig.animalSound();  // Call the interface method
//            myPig.animalSound2();  // Call the interface method
//        }
//    }
//}
