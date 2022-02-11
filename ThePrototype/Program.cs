var pilot = 0;
do
{
    Console.Write("Pilot, please enter a number between 0 and 100: ");
    pilot = Convert.ToInt32(Console.ReadLine());
} while (pilot < 0 && pilot > 100);
Console.WriteLine("Your value has been selected. Please wait. . . ");
Thread.Sleep(500);
Console.Clear();
Console.Write("Hello, hunter. ");
var guess = 0;
var tries = 0;
do
{
    Console.Write("Please enter your guess: ");
    guess = Convert.ToInt32(Console.ReadLine());
    tries++;
    if(guess < pilot)
        Console.WriteLine("Too low. Try again.");
    if(guess > pilot)
        Console.WriteLine("Too high. Try again.");
} while (guess != pilot);
Console.WriteLine($"Wow, you were exactly right! It only took you {tries} to get the number {pilot}.");
