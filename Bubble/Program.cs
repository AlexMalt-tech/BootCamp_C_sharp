using System;
using System.Collections.ObjectModel;
// Создать массив и сортировать его по возрастанию

int[] numSet = new int[9];

for (int i = 0; i < numSet.Length; i++)
{
	numSet[i] = new Random().Next(1, 100);
}

System.Console.WriteLine(String.Join(", ", numSet));