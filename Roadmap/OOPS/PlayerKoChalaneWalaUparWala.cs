public class PlayerKoChalaneWalaUparWala{


public static void Main(string[] args){


 Player tommy = new Player();

 Console.WriteLine("----------- Player Class----------");
 Console.WriteLine(tommy.player_name);
 Console.WriteLine("----- Playyer data Members are Calling ");

 
 Console.WriteLine(tommy.player_Health);
 tommy.setHealth(100);
 Console.WriteLine(tommy.player_Health);


 // tommy.showDetails();
 // Console.WriteLine("----- Playyer ShowDetai  ls MEthods  are Calling ");

 Console.WriteLine(tommy.getHealth());

 Console.ReadLine();

}


}