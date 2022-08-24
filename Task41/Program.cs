// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Укажите какое количество чисел будем проверять: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
Console.Write("Пожалуйста введите число: ");
for (int i = 0; i < a; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (i < a - 1) Console.Write("Следующее: ");
    else Console.WriteLine();
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

int PosCount(int[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] > 0) count++;
    }
    return count;
}

PrintArray(array);
int result = PosCount(array);
Console.WriteLine($"Количество чисел больше 0-> {result}");

