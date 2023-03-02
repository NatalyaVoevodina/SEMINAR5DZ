﻿/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

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
int SumOddElements(int[] array)
{
  int sum = array[0];
  for (int i = 0; i < array.Length; i++)
    if ( i %2 != 0)
       sum += array[i];

return sum;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine ($"Сумма элементов нечетых позиций в сгенеррированном массиве = {SumOddElements(array)}");