/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/


void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,100);

}

void PrintArray (int [] array)
{
foreach (var el in array)
 Console.Write($"{el} ");
  Console.WriteLine();
}
int Max(int[] array)
{
    int max = array[0];
  
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

int Min(int[] array)
{
 int min = array[0];  
 for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Max(array);
Min (array);
int diff = Max(array) - Min (array);
Console.WriteLine ($"{Max(array)} - {Min (array)} = {diff}");

