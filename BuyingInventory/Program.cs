var rope = 10;
var torches = 15;
var climbEq = 25;
var water = 1;
var machete = 20;
var canoe = 200;
var food = 1;
Console.WriteLine("Welcome to the shop! What is your name? ");
var name = Console.ReadLine();
Console.WriteLine("The following items are available: ");
Console.WriteLine($"1 - Rope {rope,20}g");
Console.WriteLine($"2 - Torches {torches,20}g");
Console.WriteLine($"3 - Climbing Equipment {climbEq,20}g");
Console.WriteLine($"4 - Clean Water {water,20}g");
Console.WriteLine($"5 - Machete {machete,20}g");
Console.WriteLine($"6 - Canoe {canoe,20}g");
Console.WriteLine($"7 - Food Supplies {food,20}g");
Console.Write("What number would you like to buy? ");
var purchase = Convert.ToInt32(Console.ReadLine());
var price = purchase switch
{
    1 => rope,
    2 => torches,
    3 => climbEq,
    4 => water,
    5 => machete,
    6 => canoe,
    7 => food,
    _ => 0
};

if (!String.IsNullOrWhiteSpace(name) && name.ToLower() == "box") price /= 2;
Console.WriteLine($"That will be {price} gold. Have a nice day {name}!");
