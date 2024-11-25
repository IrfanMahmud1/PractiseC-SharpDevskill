var input1 = Console.ReadLine().Split(' ');
var input2 = Console.ReadLine().Split(' ');

var n = int.Parse(input1[0]);
var t = int.Parse(input1[1]);
var time = t;
var mx = 0;
var ans = 0;
if(n == 1 && int.Parse(input2[0]) <= time)
{
    Console.WriteLine(1);
    return;
}
for (int i = 0; i < n - 1; i++)
{
    var a = int.Parse(input2[i]);
    var b = int.Parse(input2[i + 1]);
    
    if (a <= time)
    {
        mx++;
        time -= a;
        if (i == n - 2 && b <= time)
        {
            mx++;
            ans = Math.Max(ans, mx);
        }
        if (b > time)
        {
            ans = Math.Max(ans, mx);
            if(a + b <= t)
            {
                mx = 1;
            }
            else
            {
                mx = 0;
            }
            time = t;
        }
    }
}
Console.WriteLine(ans);
