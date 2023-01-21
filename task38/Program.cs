// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] GenerateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(1, 300);
    return arr;
}
int Difference(int[] array)
{
    int minimum = array[0];
    int maximum = array[0];
    int diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimum) minimum = array[i];
        if (array[i] > maximum) maximum = array[i];
    }
    diff = maximum - minimum;
    return diff;
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] mass = GenerateArray(length);
Console.WriteLine($"Массив [{String.Join(", ", mass)}]");
Console.Write($"Разница между максимальным и минимальным элементами массива равна {Difference(mass)}.");