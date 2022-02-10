Console.WriteLine("What kind of thing are we talking about?");
var a = Console.ReadLine(); //stores text from console
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
var b = Console.ReadLine(); //also stores text from console

var c = "Doom"; //Removed redundant "of"
var d = "3000"; //number but as a string
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
/* this last line could be better with interpolation but i don't think that was covered yet */