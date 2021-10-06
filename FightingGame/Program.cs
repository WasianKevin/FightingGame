using System;
using System.Threading;

int health;
health = 100;
string answer;
answer = "";

pickle.picklechu(health);
Console.WriteLine("A wild Picklechu appeared!");
Console.WriteLine();
Thread.Sleep(2000);
Console.WriteLine("What will you do? [Baguette , Talk no Jutsu , Chainsaw , Run]");
answer = Console.ReadLine();
answer.ToLower();

Console.WriteLine();
health = fight1.faighto1(answer, health);
Thread.Sleep(5000);

pickle.picklechu(health);

Console.ReadLine();



