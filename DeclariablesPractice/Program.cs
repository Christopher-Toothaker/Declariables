// See https://aka.ms/new-console-template for more information
string myActualName = "(unintelligible)";
string myHumanName = "Chris";
int notMyAge = 23;
int myAge = 28;
bool isHuman = false;
decimal pi = 3.14159m;
double convertFtoC = -40;
char aLetter = 'z';

Console.WriteLine($"My name is {myActualName}, but people have a hard time with it, so I just go by {myHumanName}.");
Console.WriteLine($"I'm totally a human and not an alien (this is, of course, {isHuman}).");
Console.WriteLine($"People say I look { notMyAge}, but are surprised when they learn I'm {myAge}.");
Console.WriteLine($"I like the human dessert pie because it shares its name with a univeral constant, {pi}.");
Console.WriteLine($"I'm done with the alien bit. Here are the other two: {convertFtoC}, {aLetter}.");