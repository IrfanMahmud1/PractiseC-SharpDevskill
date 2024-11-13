uint a = 0b101;
uint b = ~a;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(Convert.ToString(b,toBase:2));

int c = 10;
int d = 1;
int e = c << d;
int f = c >> d;
int g = c & d;
int h = c | d;
int i = c ^ d;

Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(i);