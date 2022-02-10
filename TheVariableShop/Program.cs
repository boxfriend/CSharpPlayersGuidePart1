byte b = 0;
short s = 0;
int i = 0;
long l = 0;
sbyte sb = 0;
ushort us = 0;
uint ui = 0;
ulong ul = 0;
char ch = 'a';
string str = "aaaaa";
float f = 0.0f;
double d = 0.0;
decimal dm = 0;

Console.WriteLine($"Byte {b}\nShort {s}\nInt {i}\nLong {l}\nSByte {sb}\nUShort {us}\nUInt {ui}\nULong {ul}\nChar {ch}\nString {str}\nFloat {f}\nDouble {d}\nDecimal {dm}");

/* THE VARIABLE SHOP RETURNS */
b = byte.MaxValue;
s = short.MaxValue;
i = int.MaxValue;
l = long.MaxValue;
sb = sbyte.MaxValue;
us = ushort.MaxValue;
ui = uint.MaxValue;
ul = ulong.MaxValue;
ch = char.MaxValue;
str = "zzzzzzzz";
f = float.MaxValue;
d = double.MaxValue;
dm = decimal.MaxValue;

Console.WriteLine($"Byte {b}\nShort {s}\nInt {i}\nLong {l}\nSByte {sb}\nUShort {us}\nUInt {ui}\nULong {ul}\nChar {ch}\nString {str}\nFloat {f}\nDouble {d}\nDecimal {dm}");
