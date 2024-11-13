
List<int> list = new List<int>();
list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
list.Remove(2);
foreach (var item in list)
{
    Console.WriteLine(item);
}

Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add("Irfan", 25);
dictionary.Add("Mahmud", 24);
dictionary.Add("Ashik", 26);
dictionary["Ashik"] = 22;
foreach (var item in dictionary)
{
    Console.WriteLine($"key : {item.Key} Value: {item.Value}");
}

