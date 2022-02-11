var arr = new int[5];
for(var i = 0; i < arr.Length; i++)
{
    Console.Write($"Please Enter a value for index {i}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

var arrCopy = new int[arr.Length];
for(var i = 0;i < arr.Length;i++) 
    arrCopy[i] = arr[i];

Console.WriteLine("Duplication successful. Printing confirmation:");
for(var i =0;i<arr.Length;i++)
    Console.WriteLine($"Original: {arr[i]} : Duplicate {arrCopy[i]}");
