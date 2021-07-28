// C# program to print all repeating elements
using System;
using System.Collections.Generic;
using System.Linq;

class GFG
{
static void countDuplicate(int []arr, int n)
{
	Dictionary<int, int> map = new Dictionary<int, int>();
	for (int i = 0 ; i < n; i++)
	{
		if(map.ContainsKey(arr[i]))
		{
			var val = map[arr[i]];
			map.Remove(arr[i]);
			map.Add(arr[i], val + 1);
		}
		else
		{
			map.Add(arr[i], 1);
		}
	}

    int counter = 0;
	foreach(KeyValuePair<int, int> e in map)
	{
		if (e.Value > 1)
		{
            counter = counter + 1;
		}
	}
    Console.Write(counter);
}

public static void Main(String[] args)
{
	int n = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[n];
    foreach (int i in Enumerable.Range(0, n))
    {
    int input = Convert.ToInt32(Console.ReadLine());
    numbers[i] = input;
    }
	countDuplicate(numbers, n);
}
}

// This code is contributed by PrinciRaj1992
