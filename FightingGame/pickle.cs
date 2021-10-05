using System;
using System.Threading;


public class healthy
{
    public static void health(int health)
    {
        if (health < 0)
        {
            Console.WriteLine("Picklechu died HA noob. RIP that pickle-rat ayeee.");
            Thread.Sleep(2000);
            Console.WriteLine("Anyways, you win.. or something.");
            Thread.Sleep(2000);
            Console.WriteLine("Ye sure..");
            Thread.Sleep(2000);
            Console.WriteLine(". . .");
            Thread.Sleep(2000);
            Console.WriteLine("Congrats i guess.");
            Thread.Sleep(2000);
            Console.WriteLine("[Press Enter to Continue]");
            Console.ReadLine();
        }

    }
}

public class pickle
{
    public static void picklechu(int health)
    {
        Console.WriteLine(@"
       \:.             .:/
        \``._________.''/ 
         \             / 
 .--.--, / .':.   .':. \
/__:  /  | '::' . '::' |
   / /   |`.   ._.   .'|
  / /    |.'         '.|
 /___-_-,|.\  \   /  /.|
      // |''\.;   ;,/ '|
      `==|:=         =:|
         `.          .'
           :-._____.-:
          `''       `''
            ");
        Console.WriteLine($"{health} HP");
    }
}

public class fight1
{
    public static int faighto1(string answer, int hp)
    {

        if (answer == "baguette")
        {
            Console.WriteLine("You used Baguette! It was not effective! You take the almighty baguette of doom and forcefully probe Picklechu with it. Picklechu enjoys the situation a little too much and suffers 5 damage.");
            hp -= 10;
        }

        if (answer == "talk no jutsu")
        {
            Console.WriteLine("You used Talk no Jutsu! It was Super Effective! You tell Picklechu about how you had to adapt your new lifestyle because your bus one day started arriving one minute earlier. Picklechu suffers 30 damage.");
            hp -= 30;

        }

        return hp;

    }
}