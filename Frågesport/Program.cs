using System;
using System.Threading; 


int x = 0;

Console.WriteLine($"How many girlfriends have i had?");

Thread.Sleep(1000);
Console.WriteLine($"A=1 B=3 C=0");

string answer; 
answer = Console.ReadLine();
answer = answer.ToLower();


if (answer == "a")
{

}
else if (answer == "b")
{
}
else if (answer == "c")
{
    x++;
}
else
{
    x -= 2;
}

Console.WriteLine($"What do i like the most?");

Thread.Sleep(1000);
Console.WriteLine($"A=Sports B=Games C=Music ");

string answer_1;
answer_1 = Console.ReadLine();

if (answer_1 == "a")
{
}
else if (answer_1 == "b")
{
    x++;
}
else if (answer_1 == "c")
{
}
else
{
    x -= 2;
}

Console.WriteLine($"When is my birthdate?");

Thread.Sleep(1000);
Console.WriteLine($"A=17 march B=14 march C=11 march");

string answer_2;
answer_2 = Console.ReadLine();


if (answer_2 == "a")
{
}
else if (answer_2 == "b")
{
    x++;
}
else if (answer_2 == "c")
{
}
else
{
    x -= 2;
}

Thread.Sleep(1000);
Console.WriteLine($"The score {x + 10}");

Thread.Sleep(1000);
Console.WriteLine($"Sike this is your real score --> {x}");

Thread.Sleep(1000);
if (x < 0)
{
    Console.WriteLine($"Damn you aint a real one");
}
else if (x == 3)
{
    Console.WriteLine($"SHEEEEESH you are a real friend");
}
else if (x > 0 || x < 3)
{
    Console.WriteLine($"Youre aight friend");
}

Console.ReadLine();
