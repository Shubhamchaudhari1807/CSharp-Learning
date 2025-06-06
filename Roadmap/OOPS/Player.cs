 public class Player
{
    public string player_name = "Shubham";
    public int player_Health = 50;



    //public void showDetails()
    //{

    //    Console.WriteLine("Player Name : " + player_name);
    //    Console.WriteLine("Player Health : " + player_Health);

    //}


    public int getHealth() 
    {
    
    return player_Health;
    }
    public void setHealth(int h) 
    {
        player_Health = h;
    
    }
}