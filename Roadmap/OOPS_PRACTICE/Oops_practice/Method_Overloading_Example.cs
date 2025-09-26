//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_practice
//{
    


//    public class Method_Overloading_Example
//    {
//        // 1) Changinng  Number Of  Parameters
//        public static int Add(int a, int b)
//        {
//           int sum = a + b;
//            return sum;
//        }

//        public static int Add(int a, int b, int c)
//        {
//            int sum = a + b + c;
//            return sum;
//        }

//        // 2) Changing Data Types
//        public double Add(double a, double b)
//        {
//            double sum = a + b;
//            return sum;
//        }

//        // 3) Changing Sequence Of Data Types
//        public void Identity(string name, int id)
//        {
//         Console.WriteLine("Name: " + name + "Id : "+id);
           
//        }
//        public void Identity( int id,string name)
//        {
//            Console.WriteLine("Id : " + id + "Name: " + name);
//        }



//        static void Main(String[] args)
//        { 
//          Method_Overloading_Example mo = new Method_Overloading_Example();

//            Console.WriteLine("Method Overloading Example:");

//            Console.WriteLine("Sum of 2 integers as  Parameters: "); // Calls the first Add method

//            int sum1 = Add(5, 6);
//            Console.WriteLine(sum1);

//            Console.WriteLine("Sum of 3 integers as  Parameters: ");
//            int sum2 = Add(5, 6, 7); // Calls the second Add method
//            Console.WriteLine(sum2);

//            Console.WriteLine("Sum of 2 double as  Parameters: " + mo.Add(33.5, 33.5));
//            // Calls the third Add method

//            Console.WriteLine("Identity method with different sequence of parameters: ");
//            Console.WriteLine("Calls the first Identity method  of  type  3rd  overloading : ");

//            mo.Identity("John", 101); // Calls the first Identity method  of  type  3rd  overloading 


//            Console.WriteLine("Calls the Second Identity method  of  type  3rd  overloading : ");
//            mo.Identity(102, "Shubham"); // Calls the second Identity method of type 3rd overloading

//        }


//    }
//}
