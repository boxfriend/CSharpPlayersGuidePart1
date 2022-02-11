Console.WriteLine("Input Height: ");
var height = Convert.ToSingle(Console.ReadLine()); //that's right, no null checks or even a TryParse because i'm doing exactly what the book says
//whoops the book actually said to use Convert but I'm using Parse so I'm *technically* not doing what the book says
Console.WriteLine("Input Base: ");
var length = Convert.ToSingle(Console.ReadLine());
Console.WriteLine($"The area of your triangle is {(length * height)/2}");
