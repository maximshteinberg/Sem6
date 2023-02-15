// arr[i] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue);
// arr[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble());

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
    }
    return array;
}


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


void ReverseArray(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 + i];
        arr[arr.Length - 1 + i] = temp;
    }
}

var array = GenerateArray(10, 0, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);


