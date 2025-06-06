 // opeators 
 /*Arithematic  =  Maathematical Operations perform karne ke liye 
  * Assignment  =  For  assigning the value to Variables 
  * Comaprison  =   To compare between  Two values 
  * Logical  Operators  =   It is used to    perform Ligical Operation
  * 
  * 



 */

 // Operators  Example 
 
Public class Operators{

 public static void Main(string[] args)
 {



  Console.WriteLine("Enter two  Numbers  to  Perform  Operators  Operations :   ");
  int No1 = Convert.ToInt32(Console.ReadLine());
  int No2 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("---------- Arithematic Operators---------------");
  Console.WriteLine("The Value OF   No1 + No2  is : " + (No1 + No2));
  Console.WriteLine("The Value OF   No1 _ No2  is : " + (No1 - No2));
  Console.WriteLine("The Value OF   No1 * No2  is : " + (No1 * No2));
  Console.WriteLine("The Value OF   No1 / No2  is : " + (No1 / No2));
  Console.WriteLine("The Value OF   No1 % No2  is : " + (No1 % No2));


  Console.WriteLine("----------------------------------------------");
  Console.WriteLine("----------  Assignment   Operators---------------");

  int No3 = 8;
  int No4 = No3;
  No4 += 2;
  Console.WriteLine(" The Valuue OF No4 Is  after Performing Operation Is :" + No4);
  Console.WriteLine("----------------------------------------------");

  Console.WriteLine("----------  Logical   Operators---------------");
  Console.WriteLine("=========== AND (&&) Operators ========");
  Console.WriteLine(true && false);
  Console.WriteLine(true && true);
  Console.WriteLine(false && false);
  Console.WriteLine("===========================================");

  Console.WriteLine("=========== OR (||) Operators ========");
  Console.WriteLine(true || false);
  Console.WriteLine(true || true);
  Console.WriteLine(false || false);
  Console.WriteLine("===========================================");

  Console.WriteLine("=========== NOT (!) Operators ========");
  Console.WriteLine(!true);
  Console.WriteLine(!false);
  Console.WriteLine("===========================================");

  Console.WriteLine("=========== Comparision Operators ========");
  Console.WriteLine(324 > 555);
  Console.WriteLine(324 >= 555);
  Console.WriteLine(324 < 555);
  Console.WriteLine(324 <= 555);
  Console.WriteLine(324 != 555);
  Console.WriteLine(324 == 555);
  Console.WriteLine("===========================================");

  //  Math Class 
  Console.WriteLine("----------------Math Class --------------------");
  int a = Math.Max(45, 55);
  Console.WriteLine(a);

  double sq = Math.Sqrt(25);

  Console.WriteLine(sq);
  int n = Convert.ToInt32(Math.Sqrt(36));
  Console.WriteLine(n);

  int abs = Math.Abs(-89);
  Console.WriteLine(abs);

  Console.WriteLine("===========================================");


}
}
