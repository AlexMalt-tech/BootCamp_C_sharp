public static class Machine
{

public static void ShowArray(int[]array)
{
    System.Console.WriteLine($"{String.Join(", ", array)}");
}

public static void SortCollection(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int pos = i;
         for (int j = i+1; j < array.Length; j++)
         {
            if (array[j] < array[pos]) pos = j;
         }
        int temp = array[i];
        array[i] = array[pos];
        array[pos] = temp;
    }
}
}
