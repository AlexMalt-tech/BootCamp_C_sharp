public static class Machine
{

	public static int[] MakeSet(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new Random().Next(1, 100);
		}

		return array;
	}

	public static void SortSet(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length - 1; j++)
			{
				if (array[j] > array[j+1])
				{
					int temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;
				}
			}
			
		}
	}

	public static void ShowSet(int[] array)
	{
		System.Console.WriteLine(String.Join(", ", array));
	}
}