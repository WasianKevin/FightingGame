using System;
using System.Threading;


public class healthy
{
    public static void heal(int health)
    {
        if (health < 0) { health = 0; }

        if (health == 0)
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
            System.Environment.Exit(0);
        }

    }
    public static void heal2(int playerhealth)
    {
        if (playerhealth < 0) { playerhealth = 0; }

        if (playerhealth == 0)
        {
            Console.WriteLine("You..lost..?");
            Thread.Sleep(1000);
            Console.WriteLine("Against..Picklechu?!");
            Thread.Sleep(2000);
            Console.WriteLine(". . .");
            Thread.Sleep(2000);
            Console.WriteLine(".   .   .");
            Thread.Sleep(2000);
            Console.WriteLine("I'm so disappointed..");
            Thread.Sleep(2000);
            Console.WriteLine("[Press Enter to Continue]");
            Console.ReadLine();
            System.Environment.Exit(0);
        }

    }

}

public class pickle
{
    public static void picklechu(int health, int Playerhealth)
    {
        if (health < 0) { health = 0; }
        Console.WriteLine(@"
       \:.             .:/
        \``._________.''/ 
         \             / 
         / .':.   .':. \
         | '::' . '::' |
         |`.   ._.   .'|
         |.'         '.|
 .--.--, |.\  \   /  /.|
/__:  /  |''\.;   ;,/ '|
   / /   |:           :|
  / /    |:           :|
 /___-_-,|:           :|
      // |:           :|
      `==|:=         =:|
         `.          .'
           :-._____.-:
          `''       `''
            ");
        Console.WriteLine($"{health} HP                     You have {Playerhealth} HP");
    }
}

public class fight
{
    public static int fight1(string answer, int hp)
    {

        if (answer == "baguette")
        {
            Console.WriteLine("You used Baguette! It was not effective! You throw the baguette at Picklechu and he suffers 5 damage.");
            hp -= 5;
        }

        if (answer == "talk no jutsu")
        {
            Console.WriteLine("You used Talk no Jutsu! It was Super Effective! You tell Picklechu about how you had to adapt your new lifestyle because your bus one day started arriving one minute earlier. Picklechu suffers 30 damage.");
            hp -= 30;

        }

        if (answer == "chainsaw")
        {
            Console.WriteLine("You chose the chainsaw! You grab the chainsaw and cut a hole in Picklechu's stomach. Picklechu suffers 45 damage.");
            hp -= 45;
        }

        if (answer == "run")
        {
            Console.WriteLine("You successfully fled from the battle.");
            Thread.Sleep(3000);
            System.Environment.Exit(0);
        }



        return hp;

    }

    //
    public static int PicklechuATK(int playerhealth)
    {
        Random generator = new Random();
        int pickdmg = generator.Next(19, 41);
        playerhealth -= pickdmg;

        return playerhealth;

    }

    public static int fight2(string answer, int hp)
    {

        if (answer == "squirrel")
        {
            Console.WriteLine("You used Squirrel! You pick up and throw a squirrel at Picklechu. Picklechu suffers 30 damage.");
            hp -= 30;
        }

        if (answer == "anime figurine")
        {
            Console.WriteLine("You used Anime figurine! You yeet the figurine and it hits Picklechu's eye. Picklechu suffers 15 damage.");
            hp -= 15;

        }

        if (answer == "ak-47")
        {
            Console.WriteLine("You chose AK-47! You pull out an AK-47 and wrecks Picklechu. Picklechu suffers 60 damage");
            hp -= 60;
        }

        if (answer == "run")
        {
            Console.WriteLine("You successfully fled from the battle.");
            Thread.Sleep(3000);
            System.Environment.Exit(0);
        }



        return hp;

    }

    public static int fight3(string answer, int hp)
    {

        if (answer == "obama")
        {
            Console.WriteLine("You used Obama! You call Obama and he drives over Picklechu. Picklechu suffers 40 damage.");
            hp -= 40;
        }

        if (answer == "ugandan knuckles")
        {
            Console.WriteLine("You used Ugandan Knuckles! Ugandan Knuckles asks Picklechu if he knows the way. Picklechu doesn't know the way. Picklechu suffers 50 damage.");
            hp -= 50;

        }

        if (answer == "the rock")
        {
            Console.WriteLine("You used The Rock! The Rock throws a bunch of rocks at Picklechu. Picklechu suffers 20 damage.");
            hp -= 20;
        }

        if (answer == "run")
        {
            Console.WriteLine("You successfully fled from the battle.");
            Thread.Sleep(3000);
            System.Environment.Exit(0);
        }



        return hp;

    }
    public static int fight4(string answer, int hp, int playerhealth)
    {

        if (answer == "trump")
        {
            Console.WriteLine("You used Trump! Trump kisses you and grants you 70 hp. He then kicks Picklechu and walk away. Picklechu suffers 20 damage.");
            hp -= 20;
            playerhealth += 70;

        }

        if (answer == "milk")
        {
            Console.WriteLine("You used Milk! What's that? Your long lost father shows up and notices the dangerous Picklechu. He jump-kicks Picklechu. Picklechu suffers 40 damage.");
            hp -= 40;

        }

        if (answer == "shopping cart")
        {
            Console.WriteLine("You used the shopping cart! You pull out a shopping cart from your back pocket and yeets it at Picklechu. Picklechu suffers 15 damage.");
            hp -= 15;
        }

        if (answer == "run")
        {
            Console.WriteLine("You successfully fled from the battle.");
            Thread.Sleep(3000);
            System.Environment.Exit(0);
        }



        return hp;

    }
    public static int fight5(string answer, int hp, int playerhealth)
    {

        if (answer == "bazooka")
        {
            Console.WriteLine("You used Bazooka! You launch a missile towards Picklechu and he blows up into pieces. Picklechu suffers 60 damage.");
            hp -= 60;

        }

        if (answer == "bagel")
        {
            Console.WriteLine("You used Bagel! Bagel..mm.. You toss the bagel to Picklechu and he eats it in one bite. Little does he know the bagel was poisonous. Picklechu suffers 45 damage.");
            hp -= 45;

        }

        if (answer == "math")
        {
            Console.WriteLine("You used Math! You decide to teach Picklechu the PQ-formula. Picklechu gets a seizure and suffers 50 damage.");
            hp -= 15;
        }

        if (answer == "run")
        {
            Console.WriteLine("You successfully fled from the battle.");
            Thread.Sleep(3000);
            System.Environment.Exit(0);
        }



        return hp;

    }


}