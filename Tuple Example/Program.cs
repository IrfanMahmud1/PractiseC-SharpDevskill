
(int, string) x = (5, "Irfan");
Console.WriteLine(x.Item1);
Console.WriteLine(x.Item2);
x.Item1 = 100;
x.Item2 = "Mahmud";

Console.WriteLine(x.Item1);
Console.WriteLine(x.Item2);

(int age, string name) y = (5, "Irfan");

y.age = 200;
y.name = "Kuro";

(int, double) Calculate(out string s ,params int[] num)
{
    var sum = 0;
    foreach (int i in num)
    {
        sum += i;
    }
    s = "good";
    return (sum, sum / num.Length);
}

string s;

(int sum,double avg) res = Calculate(out s, 1, 5, 8, 20);

Console.WriteLine(res.sum);
Console.WriteLine(res.avg);
Console.WriteLine(s);
