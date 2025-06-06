Public class StringLearning{

    public static void Main(string[] args)
 {


            string hello = "hello I Am C # Coder  Shubham !";

            Console.WriteLine("The Length Of String Is : " + hello.Length);
            Console.WriteLine("The Upper Of String Is : " + hello.ToUpper());
            Console.WriteLine("The Lower Of String Is : " + hello.ToLower());
            Console.WriteLine("The Trim Of String Is : " + hello.Trim());

            //Console.WriteLine("The String Concatenation Works Like This: " + hello +
            //  " Hello Shubham, please Keep It Up! You are Going to Land a Job Very Soon :)");
            Console.WriteLine(string.Concat(hello, "You Are Good In Defence Knowlwdge ! "));


            //String InterPolation


            Console.WriteLine("Enter  The  Name And Number Of Candies that  You Want :  ");
            string name = Console.ReadLine();
            string candies = Console.ReadLine();
            Console.WriteLine($"Your Name Is {name}. You Will get {candies} Candies! ");


            //Indexing Concept

            string shubhu = "Hello shubhu Its Your Jayu ! ";
            Console.WriteLine(shubhu[4]);

            Console.WriteLine(shubhu.IndexOf("Its"));

            Console.WriteLine(shubhu.Substring(4));
            Console.WriteLine(shubhu.Substring(2));



            // Escape Sequence Characters ----
            Console.WriteLine("Hi Shubham \"You are  Liked By You Or Not \" ");



            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);




            if (age >= 18) { Console.WriteLine("You Can Drive, Vote And Having A PAN Card "); }

            else if (age < 17) { Console.WriteLine("Ajun Tar Bal BI Nahi AAlet Tula"); }

            else { Console.WriteLine("You Cannot  Drive, Vote And Having A PAN Card "); }

    Console.ReadLine();


}

}