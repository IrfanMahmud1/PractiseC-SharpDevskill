using System.Runtime.CompilerServices;
using System.Text;

//File.Create("Demo.txt");
//File.WriteAllText("Demo.txt","Hello from C#");

//File.WriteAllLines("Demo.txt", ["Irfan", "Mahmud"]);


//if (File.Exists("Demo.txt"))
//{
//    File.Delete("Demo.txt");
//}
//else
//{
//    File.WriteAllText("Demo.txt", "Hello from C#");
//    string text1 = File.ReadAllText("Demo.txt");
//    Console.WriteLine(text1);
//}



//FileInfo fileInfo = new FileInfo("Demo.txt");
//if (fileInfo.Exists)
//{
//    fileInfo.Delete();
//}

//using FileStream fileStream = File.Open("Demo.txt",FileMode.OpenOrCreate);
//string text = "Hello ";
//fileStream.Write(Encoding.UTF8.GetBytes(text));

//Directory.CreateDirectory("Videos/Training");
string currentPath = Directory.GetCurrentDirectory();

Console.WriteLine(currentPath);

//Directory.SetCurrentDirectory(Path.Combine(currentPath,"Videos","Training"));

//File.Create("Class 1");

//Directory.Delete(Path.Combine(currentPath, "Videos", "Training"),true);

DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(currentPath, "Videos", "Training"));
if (directoryInfo.Exists)
{
    Directory.Delete(Path.Combine(currentPath, "Videos", "Training"),true);
}
DirectoryInfo directoryInfo1 = new DirectoryInfo(Path.Combine(currentPath));
var directories = directoryInfo1.EnumerateDirectories();
foreach (var d in directories)
{
    Console.WriteLine(d.FullName);
}

var files = directoryInfo1.GetFiles();
foreach (var d in files)
{
    Console.WriteLine(d.FullName);
}