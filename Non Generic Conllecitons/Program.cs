using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add("Irfan");
arrayList.Add(30);
arrayList.Add('4');
arrayList.Add(30.6);

for (int i = 0; i < arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}

Stack stack = new Stack();
stack.Push("IRfan");
stack.Push(5.36);
stack.Push(500);
Console.WriteLine(stack.Peek());    

dynamic hashtable = new Hashtable();
hashtable.Add("Irfan",25);
hashtable.Add(25, "Irfan");
hashtable["Irfan"] = 30;
foreach (var item in hashtable)
{
    Console.WriteLine(item);
}
