// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(111, 999);
    return array;
}
int CountEven(int[] arr)
{
    int sumEven = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) sumEven++;
    return sumEven;
}
Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] mass = GenerateArr(length);
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", mass)}]");
Console.Write($"Количество четных элементов массива = {CountEven(mass)}.");