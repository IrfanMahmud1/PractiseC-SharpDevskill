int[,] ages1 = new int[2, 2]
{
    {10, 20 }, {20, 30}
};
ages1[0,0] = 10;
ages1[0,1] = 20;
ages1[1,0] = 30;
ages1[1,1] = 40;

int[,] ages = new int[2, 2]
{
    {10, 20 }, {20, 30}
 };


foreach (int age in ages)
{
    Console.WriteLine(age);
}
Console.WriteLine(ages.Length);

foreach (int age in ages)
{
    Console.WriteLine(age);
}
Console.WriteLine(ages.Length);

int[][][] ja = new int[2][][];

ja[0] = new int[2][];
ja[0][0] = new int[3];
ja[0][0][0] = 1;
ja[0][0][1] = 2;
ja[0][0][2] = 3;
ja[0][1] = new int[2];
ja[0][1][0] = 4;
ja[0][1][1] = 5;

ja[1] = new int[2][];
ja[1][0] = new int[3];
ja[1][0][0] = 6;
ja[1][0][1] = 7;
ja[1][0][2] = 8;
ja[1][1] = new int[2];
ja[1][1][0] = 9;
ja[1][1][1] = 10;


for (int i = 0; i < ja.Length; i++)
{
    for (int j = 0; j < ja[i].Length; j++)
    {
        for (int k = 0; k < ja[i][j].Length; k++)
        {
            Console.Write(ja[i][j][k] + " ");
        }
        Console.WriteLine();
    }
}

foreach (int[][] i in ja)
{
    foreach (int[] j in i)
    {
        foreach (int k in j)
        {
            Console.Write(k);
        }
        Console.WriteLine();
    }
}
