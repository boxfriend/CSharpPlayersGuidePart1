Console.WriteLine("How many provinces do you have?");
var provinces = Int32.Parse(Console.ReadLine());
Console.WriteLine("How many duchies do you have?");
var duchies = Int32.Parse(Console.ReadLine());
Console.WriteLine("How many estates do you have?");
var estates = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Congrats, you have {estates + (duchies * 3) + (provinces * 6)} points!");
