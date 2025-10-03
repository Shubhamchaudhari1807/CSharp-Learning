﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Practice
{
    public class Verbatin_String_UseCase
    {
        static void Main() 
        {

            // If you use the below commented
            // the part then this will give
            // Unrecognized escape sequence error
            // string S1 = "\\welcome \to GeeksforGeeks \ portal \";
            // Console.WriteLine("String 1 is :{0}", S1);

            // By using @ in the given string 
            // it runs smoothly because
            // @ symbol tells the compiler to
            // ignore all escape sequences
            string S2 = @"\\welcome \to GeeksforGeeks \ portal \";
            Console.WriteLine("String 2 is: {0}", S2);

            // printing new line character in string literal
            // but it will make the string to break  
            // into a new line, see output
            string S3 = "This is \n C# non verbatim string";
            Console.WriteLine("String 3 is :{0}", S3);

            // By using @ symbol /n does not processed
            string S4 = @"This is \n C# verbatim string";
            Console.WriteLine("String 4 is :{0}", S4);

            // printing a string literal contains 
            // tabs and new line without using 
            // any escape sequence
            Console.WriteLine(@"Without Tab Sequence and New Line Character
                               C          C++      Java       Python");

        }
    }
}
