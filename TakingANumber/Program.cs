int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForNumberInRange(string text, int min, int max)
{
    var result = Int32.MaxValue;
    while (result < min || result > max)
    {
        Console.Write(text);
        result = Convert.ToInt32(Console.ReadLine());
    }

    return result;
}

var result = AskForNumber("What is the airspeed of an unladen swalllow? ");
Console.WriteLine("Is that African or European?");
Thread.Sleep(100);
Console.Clear();

result = AskForNumberInRange("Give me a number between 0 and 100: ", 0, 100);
Console.WriteLine($"You input {result}");
