
/*
Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int n = 9;
int[,] fillingASpiralArray = new int[n, n];
Console.WriteLine();
int temp = 1;
int i = 0;
int j = 0;

while (temp <= fillingASpiralArray.GetLength(0) * fillingASpiralArray.GetLength(1))
{
  fillingASpiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < fillingASpiralArray.GetLength(1) - 1 )
    j++;
  else if (i < j && i + j >= fillingASpiralArray.GetLength(0) - 1 )
    i++;
  else if (i >= j && i + j > fillingASpiralArray.GetLength(1) - 1 )
    j--;
  else
    i--;
}

PrintArray(fillingASpiralArray);

// Метод, который печатает массив
void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
        Console.Write(array[i, j] + "\t");
      else Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
}
