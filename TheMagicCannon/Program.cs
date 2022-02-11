for(var i = 1; i <= 100; i++)
{
    var type = "";
    if (i % 3 == 0 && i % 5 == 0)
        type = "Combined blast!";
    else if (i % 3 == 0)
        type = "Fire!";
    else if (i % 5 == 0)
        type = "Electric!";
    else
        type = "Normal";
    Console.ForegroundColor = type switch
    {
        "Combined blast!" => ConsoleColor.Blue,
        "Fire!" => ConsoleColor.Red,
        "Electric!" => ConsoleColor.Yellow,
        _ => ConsoleColor.White
    };
    Console.WriteLine($"{i}: {type}");
    Thread.Sleep(10);
}