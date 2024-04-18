namespace OutventoryFight;

public class Quit
{
   static public void Quitting()
   {
        string quitChoice;
        Console.Clear();
        Console.WriteLine("Well thats sad");
        Console.WriteLine("Are you sure?");
        quitChoice = Console.ReadLine();
        if (quitChoice == "yes")
        {
         restart = "no";     
        }
        else if (quitChoice == "no")
        {
            Console.Clear();
            restart = "yes";
        }
        else if(quitChoice != "yes" || quitChoice != "no")
        {
            Console.WriteLine("You imbecile! You foolishly foolih fool!!");
            Console.WriteLine("How do you not understand a simple yes no question??!!!");
        }
        else
        {
            // nah
        }
   }
}
