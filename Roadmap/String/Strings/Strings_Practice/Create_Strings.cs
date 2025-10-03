//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Strings_Practice
//{
//    public class Create_Strings
//    {
//        static void Main()
//        {
//            // Creating String using string literal
//            string str = "Shubhu loves C# ";
//            Console.WriteLine("Method 1: " + str);


//            // Creating String using concatenation
//            string str2 = str + " And learn Fullstack Development";
//            Console.WriteLine(str2);

//            // Creating a string using a constructor
//            char[] create_Strings_ways = { 'S', 'H', 'U', 'B', 'H', 'A', 'M' };
//            string full_ctrs_String = new string(create_Strings_ways);
//            Console.WriteLine(full_ctrs_String);

//            // Creating a string using a property or a method
//            String s = "Geeks For Geeks";

//            // Index of 
//            int start = s.IndexOf(" ") + 1;
//            int end = s.IndexOf(" ", start) - start;
//            string str4 = s.Substring(start, end);
//            Console.WriteLine("Method 4: " + str4);

//            // Creating a string using formatting
//            int i = 1;
//            int j = 2;
//            int sum = i + j;
//            String str5 = string.Format("Addition of {0} with {1} is {2}"
//                                      , i, j, sum);
//            Console.WriteLine("Method 5: " + str5);


//        }
//    }
//}
