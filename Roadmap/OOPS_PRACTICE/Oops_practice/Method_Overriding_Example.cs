using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_practice
{
    
    public class Method_Overriding_Example
    {
        public class Vehicle
        {
            public virtual void Engine()
            {
                Console.WriteLine("THE   ENGINE OF  60 RPM :");

            }
            public void Brake()
            {

                Console.WriteLine("The Barakes Are of  Gas  Breaks ..");
            }


        }
        public class Tata : Vehicle
        {
            public override void Engine()
            {
                Console.WriteLine("THE   ENGINE OF  80 RPM :");
            }
            public void MusicSystem()
            {
                Console.WriteLine("The Music System is of  Sony  Music System ..");
            }

        }



        static void Main(String[] args) 
        {
           Method_Overriding_Example ov = new Method_Overriding_Example();
            Console.WriteLine("Method Overriding Example:");
           
            Tata t = new Tata();
            t.Engine(); // Calls the overridden method in the derived class
            t.Brake(); // Calls the inherited method from the base class
            t.MusicSystem(); // Calls the method in the derived class
        }

    }
}
