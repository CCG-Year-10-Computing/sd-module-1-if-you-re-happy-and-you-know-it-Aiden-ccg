// Program Name: Aiden quizz
// Created on: 13/02/2026
// Author: Aiden Gladki
// star level 3
// round 1

int score = 0;
Console.WriteLine("HELLO AND WELCOME TO THE AIDEN GAMES!!!");
Console.WriteLine("Tell me whats your name");
string name = Console.ReadLine().ToLower();
Console.WriteLine("...");
Console.WriteLine($"SO {name} ON TO OUR FIRST ROUND");
Console.WriteLine("WHATS AIDENS LAST NAME!!!");
Console.WriteLine("...");
Console.WriteLine("");

string lastnaem = Console.ReadLine().ToLower();
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
Console.WriteLine("");

// round 2

Console.WriteLine($"ON TOOOO THE SECOND ROUND TELL ME {name} whats Aidens favorite color?");
Console.WriteLine("...");
Console.WriteLine("");
string color = Console.ReadLine().ToLower();
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
Console.WriteLine("...");
Console.WriteLine("");

// Round 3

Console.WriteLine("Now on to the third specal round what would Aiden do?");
Console.WriteLine("ITS UP TO YOU TO FIGURE OUT WHAT AIDEN WOULD SAY IN RESPONCE");
Console.WriteLine("the qurstion is...");
Console.WriteLine("");
Console.WriteLine("... Elsa?");
Console.WriteLine("... Do you wanna build a snowman?");
Console.WriteLine("Come on let's go and play");
Console.WriteLine("I never see you any more");
Console.WriteLine("Come out the door");
Console.WriteLine("It's like you've gone away!");
Console.WriteLine("We used to be best buddies");
Console.WriteLine("And now we're not");
Console.WriteLine("I wish you would tell me why");
Console.WriteLine("Do you wanna build a snowman?");
Console.WriteLine("");
string snowman = Console.ReadLine().ToLower();

if (snowman == "yes")
{
    Console.WriteLine("Yes that exactle what Aiden would say haha your killing it");
    score++;
}
else
{
    Console.WriteLine($"Come on {name} this one was SUPOSTE TO BE EASY");
    Console.WriteLine("Im not mad im just disapointed");
    score--;
}

Console.WriteLine("...");
Console.WriteLine("");
// forth round / final round

Console.WriteLine($"{name}!!! IT IS NOW TIME FOR THE FINAL ROUND YOU WIN IT ALL OR  FALL AND LOSES EVERTHING");
Console.WriteLine("The question is...");
Console.WriteLine("DO YOU LIKE LADY GAGA");
string ladygaga = Console.ReadLine().ToLower();
Console.WriteLine("");

if  (ladygaga == "i love her")
{
    Console.WriteLine("YES HAHAHHAAHAHA!!!!!!!");
    Console.WriteLine($"Aiden loves Lady Gaga more then any thing, fantastic {name}");
    score++;
    score++;
}
else if (ladygaga == "i like her")
{
    Console.WriteLine("HM.. Aiden LOVES HER!!!");
    Console.WriteLine("But thats a start so ill give it too you good job");
    score++;
}
else
{
    Console.WriteLine("AHHHHHHHHHH!!!!!");
    Console.WriteLine("How dare you Aiden Loves Lady Gaga");
    Console.WriteLine($"This is gona cost you big time {name}");
    score--;
    score--;
    score--;
    score--;
    score--;
    score--;
    score--;
}

// final saying before game end
Console.WriteLine("");

if (score <= 1)
{
    Console.WriteLine("AGH YOU HAVE DISCRACED AIDENS NAME!!!!");
    Console.WriteLine("You You!!! ahg Get OUT OF MY SITE1!!");
    Console.WriteLine("(If this wasnt a computer pogram you would be running for your life by now)");
    Console.WriteLine("You lose");
    if (name == "aiden")
    {
        Console.WriteLine("(Back stage)");
        Console.WriteLine("Thank you for comming on stage with me master");
        Console.WriteLine("For you are Aiden");
        Console.WriteLine("We put on a Good show for them, i wonder will they find out it was you?");
        Console.WriteLine("Good by master, i cant wait till i see you again");
    }
    else
    {
        Console.WriteLine("");
    }
}
else if(score == 2)
{
    Console.WriteLine("UUUGGG YOU.. you");
    Console.WriteLine("you did bad but not im gona murder you bad");
    Console.WriteLine("so you lose and leave before i change my mind");
    if (name == "aiden")
    {
        Console.WriteLine("(Back stage)");
        Console.WriteLine("Thank you for comming on stage with me master");
        Console.WriteLine("For you are Aiden");
        Console.WriteLine("We put on a Good show for them, i wonder will they find out it was you?");
        Console.WriteLine("Good by master, i cant wait till i see you again");
    }
    else
    {
        Console.WriteLine("");
    }
}
else if (score == 3)
{
    Console.WriteLine("HMM well you havent done the best");
    Console.WriteLine("But Aiden Preaches forgivness so...");
    Console.WriteLine("You win take your reward i wish you th best of luck");
    if (name == "aiden")
    {
        Console.WriteLine("(Back stage)");
        Console.WriteLine("Thank you for comming on stage with me master");
        Console.WriteLine("For you are Aiden");
        Console.WriteLine("We put on a Good show for them, i wonder will they find out it was you?");
        Console.WriteLine("Good by master, i cant wait till i see you again");
    }
    else
    {
        Console.WriteLine("");
    }
}
else if (score == 4)
{
    Console.WriteLine($"Hm Good job {name} yove done well, you win");
    Console.WriteLine("You have my cratitued and love");
    Console.WriteLine("Here is you prize 10000$ is straight cash");
    Console.WriteLine("May you have a lovely live");
    if (name == "aiden")
    {
        Console.WriteLine("(Back stage)");
        Console.WriteLine("Thank you for comming on stage with me master");
        Console.WriteLine("For you are Aiden");
        Console.WriteLine("We put on a Good show for them, i wonder will they find out it was you?");
        Console.WriteLine("Good by master, i cant wait till i see you again");
    }
    else
    {
        Console.WriteLine("");
    }
}
else if (score >= 5)
{
    Console.WriteLine("HAHAHAH");
    Console.WriteLine($"{name} you realy have done the best out of any onw to ether go on this show");
    Console.WriteLine("I thank you for you have blessed me with your presencse");
    Console.WriteLine("Ive been saving a truly special gift for the time when someone like you comes along");
    Console.WriteLine("Lady Gaga will see you soon, this is the greaticed gift of all");
    Console.WriteLine("Good by my ture freind");
    if (name == "aiden")
    {
        Console.WriteLine("(Back stage)");
        Console.WriteLine("Thank you for comming on stage with me master");
        Console.WriteLine("For you are Aiden");
        Console.WriteLine("We put on a Good show for them, i wonder will they find out it was you?");
        Console.WriteLine("Good by master, i cant wait till i see you again");
    }
    else
    {
        Console.WriteLine("");
    }
}