// /*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// */

// // получить числа с консоли
// int GetNumber(string message)
// {
//    int result = 0;
//    while (true)
//    {
//       Console.WriteLine(message);
//       if (int.TryParse(Console.ReadLine(), out result))
//       {
//          break;
//       }
//       else
//       {
//          Console.WriteLine("Ввели не число");
//       }
//    }
//    return result;
// }

// // задать матрицу и заполнить ее числами
// int[,] GetMatrix(int m, int n)
// {
//    int[,] matrix = new int[m, n];
//    Random rnd = new Random();
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = rnd.Next(1, 10);
//       }
//    }
//    return matrix;
// }

// // распечатать матрицу
// void PrintMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write($"{matrix[i, j]} ");
//       }
//       Console.WriteLine();
//    }
// }

// void Poisk(int[,] matrix)
// {
//    int x = GetNumber("Введите номер строки элемента");
//    int y = GetNumber("Введите номер столбца элемента");
//    int num = 0;
//    string result = $"такого элемента нет";
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          if (i == x && j == y)
//          {
//             num = matrix[x - 1, y - 1];
//             result = $"Искомый элемент = {num}";
//          }
//          else if (x < 0 || y < 0 || x > matrix.GetLength(0) || y > matrix.GetLength(1))
//          {
//             break;
//          }
//       }
//    }
//    Console.WriteLine(result);
// }

// int m = GetNumber("Введите количество строк");
// int n = GetNumber("Введите количество столбцов");

// int[,] matrix = GetMatrix(m, n);
// PrintMatrix(matrix);
// Poisk(matrix);











/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

// получить числа с консоли
int GetNumber(string message)
{
   int result = 0;
   while (true)
   {
      Console.WriteLine(message);
      if (int.TryParse(Console.ReadLine(), out result) && result > 0)
      {
         break;
      }
      else
      {
         Console.WriteLine("Ввели не число");
      }
   }
   return result;
}

// задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
   int[,] matrix = new int[m, n];
   Random rnd = new Random();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = rnd.Next(1, 10);
      }
   }
   return matrix;
}

// распечатать матрицу
void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write($"{matrix[i, j]} ");
      }
      Console.WriteLine();
   }
}

void Poisk(int[,] matrix)
{
   int x = GetNumber("Введите номер строки элемента");
   int y = GetNumber("Введите номер столбца элемента");

   if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
   {
      Console.WriteLine($"такого элемента нет");
   }
   else
   {
      Console.WriteLine($"Искомый элемент = {matrix[x - 1, y - 1]}");
   }
}

int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");

int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
Poisk(matrix);
