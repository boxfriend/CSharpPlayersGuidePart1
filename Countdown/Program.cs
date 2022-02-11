void Countdown(int i)
{
    Console.WriteLine(i);

    if (i <= 0)
        return;

    Countdown(i - 1);
}

Console.WriteLine("Begin counting down from 10: ");
Countdown(10);
Console.WriteLine("Countdown complete");
