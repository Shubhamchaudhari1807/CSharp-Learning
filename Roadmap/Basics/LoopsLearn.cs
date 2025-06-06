public class LoopsLearn{

public static void Main(string[] args)
{

//Loops In a C #

int i = 0;
while (i < 5)
{

    Console.WriteLine(i + 1);
    i++;
}
int j = 0;
do
{
    Console.WriteLine(j + 1);
    j++;
} while (j > 3);

for (int k = 0; k < 5; k++)
{
    //if (k == 0) { 
    //continue;
    //}

    Console.WriteLine(k);
}

Console.ReadLine();

}
}