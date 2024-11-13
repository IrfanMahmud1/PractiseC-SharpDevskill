int? x = null;

if(x.HasValue)
{
    Console.WriteLine(x.Value);
}

bool? flag = false;

flag = false;

if(flag.HasValue)
{
    Console.WriteLine(flag.Value);
}

string? s = null;

Console.WriteLine(s);