public class TypeCast{

   public static void Main(string[] args){
//            Type Casting
 int t = (int)3.5;

            float g = (float)6;
            Console.WriteLine("Float Value of " + g + "IS : " + g.ToString("F1"));


            //1) Implicit Casting = char to int to long to float to double
int no1 = 9;
            double no2 = (double)no1;

            Console.WriteLine("Integer value: " + no1);
            Console.WriteLine("Double value: " + no2.ToString("F1"));


            char dadu = 'H';
            int didi = dadu;
            Console.WriteLine(dadu);
            Console.WriteLine(didi);




            Console.WriteLine(t);
            Console.WriteLine(f);

            float sb = 3.5F;
            double sd = sb;
            Console.WriteLine("Float  Value Is : " + sb.ToString("F1"));
            Console.WriteLine("Float  Value Is: " + sd.ToString("F2"));

            // 2)  Explicit Casting =    
            int x = (int)7.58;
            Console.WriteLine(x);
            float x1 = (float)8;
            Console.WriteLine(x1.ToString("F1"));



            // anothe way of Typecasting explicit
            Console.WriteLine("----------------");
            Console.WriteLine("Now printing x2");
            float x2 = Convert.ToInt32(7.55);
            Console.WriteLine("x2 value is: " + x2);
            Console.WriteLine("----------------");






            string srxx = "This Is an   Shubham's Code Editor";
            Console.WriteLine(srxx);


            Console.ReadLine();

}
}