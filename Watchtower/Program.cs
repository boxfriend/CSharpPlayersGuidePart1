Console.WriteLine("Quick, which direction are they coming from?");
Console.Write("X: ");
var x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
var y = Convert.ToInt32(Console.ReadLine());

if (x + y == 0)
{
    Console.WriteLine("Dear god, they're already on top of us!");
    return;
}

string xDir = "";
if (x != 0)
    xDir = x > 0 ? "east" : "west";

string yDir = "";
if (y != 0)
    yDir = y > 0 ? "north" : "south";

Console.WriteLine($"They are coming from {yDir}{xDir}");
