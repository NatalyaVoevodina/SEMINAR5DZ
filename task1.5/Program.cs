//*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.*/


void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(99, 1000);

}

void PrintArray (int [] array)
{
foreach (var el in array)
 Console.Write($"{el} ");
  Console.WriteLine();
}

int CountEvNum(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
      count++;
      ;
  return count;
}

int[] array = new int [8];
FillArray(array);
PrintArray (array);
Console.WriteLine ($"количество четых чисел в сгенеррированном массиве -> {CountEvNum(array)}");


