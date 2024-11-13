using System.Text;

StringBuilder stringbuilder = new StringBuilder("I am Irfan Mahmud ");
stringbuilder = stringbuilder.Append(",i am from Bangladesh");
stringbuilder = stringbuilder.AppendLine(" and i love programming");

stringbuilder = stringbuilder.Replace('a','x');
stringbuilder = stringbuilder.Insert(5,"stmo");
stringbuilder = stringbuilder.Remove(5,3);

for (int i = 0; i < stringbuilder.Length; i++)
{
    stringbuilder[i] = 'I';
}

Console.WriteLine(stringbuilder.ToString());