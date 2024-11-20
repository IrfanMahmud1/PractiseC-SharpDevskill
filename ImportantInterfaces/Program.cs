// See https://aka.ms/new-console-template for more information
using ImportantInterfaces;

//Console.WriteLine("Hello, World!");

//List<string> list = new List<string>(); 

//People<string> people = new People<string>();
//people.Add("Irfan");
//people.Add("Mahmud");
//people.Add("Ashik");


//foreach (var item in people)
//{
//    Console.WriteLine(item);
//}



//Number<object> number = new Number<object>();
//number.Add(3);
//number.Add("Four");
//number.Add(26.36);
//number.Add(true);
//number.Add('I');

//foreach (var item in number)
//{
//    Console.WriteLine(item);
//}


//using ContentReader contentReader = new ContentReader("Demo.txt");
//var content = contentReader.GetContent(20);

//Console.WriteLine(content);
//content = contentReader.GetContent(20);
//Console.WriteLine(content);

Product product = new Product();
product.Name = "Laptop";
product.Description = "Portable";
product.Category = "Electronics";
product.Price = 30000;

Product product1 = (Product)product.Clone();
Console.WriteLine(product1.Name);
Console.WriteLine(product1.Description);
Console.WriteLine(product1.Category);
Console.WriteLine(product1.Price);
