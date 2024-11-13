string input = Console.ReadLine();

string[] inputParts = input.Split(',', ' ');

for (int i = 0; i < inputParts.Length; i++)
{
    inputParts[i]  = inputParts[i].Trim();
}

string ans = "";
int a = int.Parse(inputParts[0]);
int b = int.Parse(inputParts[1]);
int c = int.Parse(inputParts[2]);

while(c >= 0)
{
    string val = (a / b).ToString();
    ans += val;
    if(c == int.Parse(inputParts[2]))
        ans += ".";
    a = (a % b) < b ? (a % b) * 10 : a % b;
    c--;
}
Console.WriteLine(ans);