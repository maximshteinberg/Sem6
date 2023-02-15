metka:
System.Console.WriteLine("Введите числа: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// if (ARRAY.Length>3)
// {
//     System.Console.WriteLine("Введите 3 числа: ");

// }

if (array.Length=3) 
{
    System.Console.WriteLine("Массив введен неправильно ");
    goto metka;
}


if ((array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[2] + array[0] > array[1]))
{
    System.Console.WriteLine("Такой треугольник существует");
}
else 
{
    System.Console.WriteLine("Треугольник не существует ");
}

// metka:
// System.Console.WriteLine("Введите числа: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// if(array.Length!= 3)
// {
//     System.Console.WriteLine("Массив введён некоректно ");
//     goto metka;
// }

// if ((array[0] + array[1]) > array[2] && (array[1] + array[2]) > array[0] && (array[0] + array[2] > array[1]))
// {
// System.Console.WriteLine("Такой треугольник существует ");
// }
// else{
//     System.Console.WriteLine("Такой треугольник не существует ");
// }