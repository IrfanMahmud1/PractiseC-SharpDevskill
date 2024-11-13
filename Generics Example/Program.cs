using Generics_Example;

Coordinate<int,double> coordinate = new Coordinate<int,double>();

coordinate.X = 5;
coordinate.Y = 6.5;

BubbleSort bubbleSort = new BubbleSort();
var result = bubbleSort.Sort(7, 2, 1, 9, 4, 8, 3);

foreach (var item in result)
{
    Console.Write(item + " ");
}
Console.WriteLine();
//BubbleSort<double> bubbleSort2 = new BubbleSort<double>();
//var result2 = bubbleSort2.Sort(7.2, 2.3, 1.5, 9.2, 4.5, 8.1, 3.6);

//foreach (var item in result2)
//{
//    Console.Write(item + " ");
//}