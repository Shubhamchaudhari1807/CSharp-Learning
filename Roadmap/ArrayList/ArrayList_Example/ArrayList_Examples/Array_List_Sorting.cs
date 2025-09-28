// C# program to illustrate
// sorting of ArrayList
using System;
using System.Collections;

public class Array_List_Sorting
{
    static public void Main()
    {

        // Creating ArrayList
        ArrayList My_array = new ArrayList();

        // Adding elements in the 
        // My_array ArrayList
        // This ArrayList contains 
        // elements of the same types
        My_array.Add(1);
        My_array.Add(6);
        My_array.Add(40);
        My_array.Add(10);
        My_array.Add(5);
        My_array.Add(3);
        My_array.Add(2);
        My_array.Add(4);

        // ArrayList before sorting
        

        foreach (var elements in My_array)
        {
            Console.WriteLine(elements);
        }

        // Sort the elements of the ArrayList
        // Using sort() method
        My_array.Sort();

        // ArrayList after sorting
        
        foreach (var elements in My_array)
        {
            Console.WriteLine(elements);
        }
    }
}