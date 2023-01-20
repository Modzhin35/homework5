// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int [] GenerateArr (int size, int min, int max)
{
    int [] array = new int [size];
    for(int i=0; i<size; i++) array[i]=new Random().Next(min, max);
    return array;
}
int SummaOdd (int [] arr)
{
    int summa = 0;
    for(int i=0; i<arr.Length; i++) if(arr[i]%2!=0) summa+=arr[i];
    return summa;
}
Console.WriteLine("Введите размер массива, минимальное и максимальное значение его элементов:");
int length = Convert.ToInt32(Console.ReadLine());
int minElement = Convert.ToInt32(Console.ReadLine());
int maxElement = Convert.ToInt32(Console.ReadLine());
int [] genArray = GenerateArr(length, minElement, maxElement);
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", genArray)}]");
Console.Write($"Сумма элементов массива, стоящих на нечетных позициях = {SummaOdd(genArray)}");