var array = new[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
var smallest = int.MaxValue;
var total = 0;
foreach(var num in array)
{
    total += num;
    if(num < smallest)
        smallest = num;
}
Console.WriteLine($"Smallest value in first array is {smallest}. Average is {(float)total/array.Length}.");
