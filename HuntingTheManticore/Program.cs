var manticoreHealth = 10;
var consolasHealth = 15;
var roundSeparator = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
var roundNumber = 1;

Console.Title = "Hunting the Manticore";
var distance = GetNumberInRange("Player 1, enter the secret distance of the Manticore between 0 and 100: ");
Console.Clear();
Console.WriteLine("Player 2, prepare to defend the city!");

while (manticoreHealth > 0 && consolasHealth > 0)
{
    DisplayRound(roundNumber, consolasHealth, manticoreHealth);
    roundNumber++;
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(roundSeparator);
if (manticoreHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Victory! The Manticore has been destroyed! The city of Consolas is safe.");
} else if (consolasHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Unfortunately our heroes have lost. . .");
}
Console.ForegroundColor= ConsoleColor.White;

void DisplayRound(int round, int cityHealth, int enemyHealth)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(roundSeparator);
    Console.WriteLine($"STATUS: Round: {round,3}  City: {cityHealth}/15  Manticore: {enemyHealth}/10");
    var damage = GetDamageAmount(round);
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    var range = GetNumberInRange("Enter desired cannon range: ");

    var beep = range == distance ? 1000 : 200;
    Console.Beep(beep, 200);
    if(range == distance)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("That was a DIRECT HIT!");
        DamageManticore(damage);
        return;
    }

    var miss = range > distance ? "OVERSHOT" : "UNDERSHOT";
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"That round {miss} the target.");
    DamageCity(1);
}

 int GetDamageAmount(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
        return 10;
    else if (round % 3 == 0 || round % 5 == 0)
        return 3;
    else
        return 1;
}

int GetNumberInRange(string text)
{
    Console.Write(text);
    var num = Convert.ToInt32(Console.ReadLine());

    return num > 0 && num < 100 ? num : GetNumberInRange(text);
}

void DamageManticore (int damage) => manticoreHealth -= damage;
void DamageCity(int damage) => consolasHealth -= damage;
