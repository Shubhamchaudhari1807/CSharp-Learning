public class StringOperation{
public static void Main(string[] args)
 {
 



Console.WriteLine("\n----------------  Splitting --------------------");




 string fruitData = "Apple,Mango, Banama, Orange";
 string[] fruits = fruitData.Split(',');

 Console.WriteLine("Fruit List Data: " + fruitData);
 Console.WriteLine("Fruit List:");

 // ✅ Removed the Console.ReadLine() from inside the loop
 foreach (string fruit in fruits)
 {
     Console.WriteLine(" - " + fruit.Trim());
 }





 Only one final ReadLine at the end to hold the console window open



  Console.WriteLine("\n----------------  Replacing --------------------");
 string original = " I Am  Shubham";
 string updated = original.Replace("I Am  Shubham", "I Am Developer Shubham");
 Console.WriteLine(original);
 Console.WriteLine(updated);


 Console.WriteLine("\n----------------  Trimming  --------------------");

 string str = "   Hello  I Am Shubham    ";
 string updated_str = str.Trim();
 Console.WriteLine(str);
 Console.WriteLine(updated_str);

 Console.WriteLine("\n----------------  Concatenation  --------------------");

 string firstName = "SHUBHAM";
 string lastName = "CHAUDHARI";
 string fullName = firstName + " " + lastName;
 Console.WriteLine(fullName);

  Console.ReadLine();
}
}