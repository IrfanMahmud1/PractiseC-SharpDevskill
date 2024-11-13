
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
Console.WriteLine();
Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add("Irfan", 25);
dictionary.Add("Mahmud", 24);
dictionary.Add("Ashik", 26);
dictionary["Ashik"] = 22;
foreach (var item in dictionary)
{
    Console.WriteLine($"key : {item.Key} Value: {item.Value}");
}
Console.WriteLine();
HashSet<string> hashset =  new HashSet<string>();
hashset.Add("Irfan");
hashset.Add("Mahmud");
hashset.Add("Ashik");
hashset.Add("Babu");
hashset.Add("Irfan");

foreach (var item in hashset)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Stack<string> stack = new Stack<string>();
stack.Push("One");
stack.Push("Two");
stack.Push("Three");
stack.Push("Four");

string ans = stack.Pop();
Console.WriteLine(stack.Peek());
Console.WriteLine(ans);
var length = stack.Count;
for (int i = 0; i < length; i++)
{
    Console.WriteLine(stack.Pop());
}

Queue<int> queue = new Queue<int>();
queue.Enqueue(2);
queue.Enqueue(4);
queue.Enqueue(6);
queue.Enqueue(7);
Console.WriteLine(queue.Peek());
var r = queue.Dequeue();
var length1 = queue.Count;
for (int i = 0; i < length1; i++)
{
    Console.WriteLine(queue.Dequeue());
}

SortedList<string,int> sortedList = new SortedList<string,int>();
sortedList.Add("Raza", 25);
sortedList.Add("Pasha", 30);
sortedList.Add("Rubel", 35);

foreach (var s in sortedList)
{
    Console.WriteLine($"Key: {s.Key}  Value: {s.Value}");
}

LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddLast(5);
linkedList.AddFirst(500);

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
