using System;
using System.Threading;

int health;
health = 100;
int playerhealth;
playerhealth = 150;
string answer;
answer = "";



//Picklechu appears
pickle.picklechu(health, playerhealth);
Console.WriteLine("A wild Picklechu appeared!");
Console.WriteLine();
Thread.Sleep(2000);

//First round
Console.WriteLine("What will you do? [Baguette , Talk no Jutsu , Chainsaw , Run]");
answer = Console.ReadLine().ToLower();

Console.WriteLine();
health = fight.fight1(answer, health);

Thread.Sleep(3000);

Console.WriteLine("Picklechu threw a pickle at you. You suffered some damage.");
playerhealth = fight.PicklechuATK(playerhealth);

Thread.Sleep(4000);

pickle.picklechu(health, playerhealth);
healthy.heal(health);
healthy.heal2(playerhealth);

Thread.Sleep(2000);


//Second round
Console.WriteLine("What will you do? [Squirrel , Anime figurine , AK-47 , Run]");
answer = Console.ReadLine().ToLower();

Console.WriteLine();
health = fight.fight2(answer, health);

Thread.Sleep(3000);

Console.WriteLine("Picklechu threw a pickle at you. You suffered some damage.");
playerhealth = fight.PicklechuATK(playerhealth);

Thread.Sleep(4000);

pickle.picklechu(health, playerhealth);
healthy.heal(health);
healthy.heal2(playerhealth);

Thread.Sleep(2000);


//Third round
Console.WriteLine("What will you do? [Obama , Ugandan Knuckles , The Rock , Run]");
answer = Console.ReadLine().ToLower();

Console.WriteLine();
health = fight.fight3(answer, health);

Thread.Sleep(3000);

Console.WriteLine("Picklechu threw a pickle at you. You suffered some damage.");
playerhealth = fight.PicklechuATK(playerhealth);

Thread.Sleep(4000);

pickle.picklechu(health, playerhealth);
healthy.heal(health);
healthy.heal2(playerhealth);

Thread.Sleep(2000);


//Round 4
Console.WriteLine("What will you do? [Trump , Milk , Shopping cart , Run]");
answer = Console.ReadLine().ToLower();

Console.WriteLine();
health = fight.fight3(answer, health);

Thread.Sleep(3000);

Console.WriteLine("Picklechu threw a pickle at you. You suffered some damage.");
playerhealth = fight.PicklechuATK(playerhealth);

Thread.Sleep(4000);

pickle.picklechu(health, playerhealth);
healthy.heal(health);
healthy.heal2(playerhealth);

Thread.Sleep(2000);


//Round 5
Console.WriteLine("What will you do? [Bazooka , Bagel , Math , Run]");
answer = Console.ReadLine().ToLower();

Console.WriteLine();
health = fight.fight3(answer, health);

Thread.Sleep(3000);

Console.WriteLine("Picklechu threw a pickle at you. You suffered some damage.");
playerhealth = fight.PicklechuATK(playerhealth);

Thread.Sleep(4000);

pickle.picklechu(health, playerhealth);
healthy.heal(health);
healthy.heal2(playerhealth);

Thread.Sleep(2000);


Console.ReadLine();

