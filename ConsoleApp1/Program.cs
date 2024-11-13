void inputPocess1()
{
    string line = Console.ReadLine();
    string[] lineParts = line.Split(',', ' ');

    for (int i = 0; i < lineParts.Length; i++)
    {
        lineParts[i] = lineParts[i].Trim();
    }
    int[] numbers = new int[lineParts.Length];

    int idx = 0;
    foreach (string i in lineParts)
    {
        if (!string.IsNullOrWhiteSpace(i))
        {
            numbers[idx++] = int.Parse(i);
        }
    }
    int sum = 0;
    foreach (int i in numbers)
    {
        sum += i;
    }
    Console.WriteLine(sum);
}

void inputProcess2()
{
    int n = int.Parse(Console.ReadLine());

    int[] nums = new int[n];
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        nums[i] = int.Parse(Console.ReadLine());
        sum += nums[i];
    }
    Console.WriteLine(sum);
}

void inputProcess3()
{

      //      7
      //    5 2 3 
      //  9 2 3 4 5
      //8 2 3 4 5 6 7
      //  7 2 3 4 5
      //    6 2 3
      //      5

    int oddSum = 0;
    while (true)
    {
        string line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line))
        {
            break;
        }
        string[] input = line.Trim().Split(',', ' ');

        for (int i = 0; i < input.Length; i++)
        {
            input[i] = input[i].Trim();
            int num = int.Parse(input[i]);
            if (num % 2 != 0)
            {
                oddSum += num;
            }
        }

    }
    Console.WriteLine(oddSum);
}

inputProcess3();