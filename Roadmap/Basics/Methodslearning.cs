




 static void Greet(string name)
 {

     Console.WriteLine(" Hello Boss Your Name IS : " + name);
 }

 // function To calculate the Average OF   Numbers
 static float Average(int No1, int No2, int No3)
 {

     float sum = No1 + No2 + No3;
     return sum / 3;

 }

 static float Average(int No1, int No2)
 {
     float sum = (No1 + No2) / 2;
     return sum;

 }


public class Methodslearning{

 public static void Main(string[] args)
 {

    Greet("Shubham");
Greet("Chaudhari");

float temp = Average(9, 3, 0);
Console.WriteLine(temp);

Console.WriteLine(Average(2, 6, 8));
Console.WriteLine(Average(3, 3, 3));
Console.WriteLine(Average(2, 6));

Console.ReadLine();
}