Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
var row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
var column = Convert.ToInt32(Console.ReadLine());

//gross variables instead of collection but there aren't collections in Consolas. 
//at least not yet
var pos1 = $"({row-1},{column})";
var pos2 = $"({row}, {column+1})";
var pos3 = $"({row + 1},{column})";
var pos4 = $"({row}, {column - 1})";
Console.WriteLine("Defenses are being deployed to:");
Console.WriteLine(pos1);
Console.WriteLine(pos2);
Console.WriteLine(pos3);
Console.WriteLine(pos4);
Console.Beep();
