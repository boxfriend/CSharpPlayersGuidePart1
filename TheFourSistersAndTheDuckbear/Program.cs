Console.WriteLine("How many chocolate eggs are available to split between the four sisters?");
var eggs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sisters may each have {eggs/4} eggs with {eggs%4} left over for the duckbear!");
