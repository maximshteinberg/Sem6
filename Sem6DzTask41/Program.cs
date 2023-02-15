// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] GetNumbers(string text)
{
    Console.Write(text);
    return Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
}

void Count(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count ++;
        }
    }
    System.Console.Write($"Количество чисел больше нуля {count}");
}

int[] num = GetNumbers("Введите числа через запятую: ");
PrintArray(num);
Count(num);


// int Promt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int[] Inputarray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Promt($"Введите {i + 1}-й элемент: ");
//     }
//     return array;


// }

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"a[{i}] = {array[i]}; ");
//     }
// }

// int CountPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
        
//     }
//     return count;
// }

// int Lenght = Promt("Введите количество элементов > ");
// int[] array;
// array = Inputarray(Lenght);
// PrintArr(array);
// System.Console.WriteLine($"Количество чисел больше 0 : {CountPositiveNumbers(array)}");