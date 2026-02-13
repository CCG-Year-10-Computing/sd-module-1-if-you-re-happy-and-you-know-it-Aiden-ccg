// Program Name: Aiden quizz
// Created on: 13/02/2026
// Author: Aiden Gladki
// star level 2

int score = 0;
Console.WriteLine("HELLO AND WELCOME TO THE AIDEN GAMES!!!");
Console.WriteLine("Tell me whats your name");
string name = Console.ReadLine();
Console.WriteLine("...");
Console.WriteLine($"SO {name} ON TO OUR FIRST ROUND");
Console.WriteLine("WHATS AIDENS LAST NAME!!!");
Console.WriteLine("...");

string lastnaem = Console.ReadLine();
if (lastnaem == "gladki")
{
    Console.WriteLine($"Congardulation {name} you must know Aiden well");
    score++;
}
else
{
    Console.WriteLine($"Ohhhhh nice try well it is your first time so ill let fo off this time {name}");
}
Console.WriteLine("...");
Console.WriteLine($"ON TOOOO THE SECOND ROUND TELL ME {name} whats Aidens favorite color?");
Console.WriteLine("...");
string color = Console.ReadLine();
if (color == "purple")
{
    Console.WriteLine($"Ohhhh good job not many people know that {name}");
    score++;
}
else if (color == "red")
{
    Console.WriteLine($"Ohhhhh nice try well very close Aiden's favorite color is Purple, not red");
}
else
{
    Console.WriteLine("Haaa... tisk tisk tisk");
    Console.WriteLine($"Disapointing Aidens favorite color is Purple not {color}");
    score--;
}