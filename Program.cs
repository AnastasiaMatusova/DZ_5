// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int countEven = 0;
int index = 0;
while (index < array.Length)
{
    array[index] = new Random().Next(100, 1000);
    Console.Write(array[index] + "\t");
    if (array[index] % 2 == 0) countEven += 1;
    index++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {countEven}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива ");
int s = Convert.ToInt32(Console.ReadLine());
int[] a = new int[s];
int sumUnevenIndex = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(-99, 100);
    Console.Write(a[i] + "\t");
}
for (int i = 1; i < a.Length; i += 2)
{
    sumUnevenIndex += a[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumUnevenIndex}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Write("Введите размер массива ");
int sizeDoubleArray = Convert.ToInt32(Console.ReadLine());
double[] arrayD = new double[sizeDoubleArray];

for (int indx = 0; indx < arrayD.Length; indx++)
{
    arrayD[indx] = new Random().Next(0, 100);
    Console.Write(arrayD[indx] + "\t");
}
double minElement = arrayD[0];
double maxElement = arrayD[0];
for (int indx = 1; indx < arrayD.Length; indx++)
{
    if (arrayD[indx] < minElement)
    {
        minElement = arrayD[indx];
    }
    if (arrayD[indx] > maxElement)
    {
        maxElement = arrayD[indx];
    } 
}
double diff = maxElement - minElement;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({maxElement}) и минимальным ({minElement}) элементов массива: {diff}");