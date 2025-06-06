
Public class ReadInput{

    public static void Main(string[] args)
 {
 Console.WriteLine("HELlO ...   Enter Your Name Here ...");
 string name = Console.ReadLine();

 Console.WriteLine("Hi  There !,   I am   "+name);



 Console.WriteLine("How   many Candies Do  You Want from me !..");
   string  candies = Console.ReadLine();

 Console.WriteLine("You wwill get  4 more Candies : " +
     (Convert.ToInt32(candies) + 4));


 Console.ReadLine(); 
}

}