using Params_Modifier;

Geometry geometry = new Geometry();

double[] num = [2.4, 4.5, 8.0];
geometry.CalculateAverage(num);

Console.WriteLine(geometry.CalculateAverage('A', 4, 8));

int b = 5;
geometry.Display(ref b);
Console.WriteLine(b);

geometry.CalculateAverage(5);
int x, y, z;
geometry.CalculateAverage(out x,out y, out z);

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);