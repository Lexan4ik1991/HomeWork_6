// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)




double[,] array = new double[2, 2];
double[] n = new double[2];

void InputCoefficients()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Ecuation (double[,] array)
{
  n[0] = (array[1,1] - array[0,1]) / (array[0,0] - array[1,0]);
  n[1] = n[0] * array[0,0] + array[0,1];
  return n;
}

void OutputResponse(double[,] array)
{
  if (array[0,0] == array[1,0] && array[0,1] == array[1,1]) 
  {
    Console.Write("Прямые совпадают");
  }
  else if (array[0,0] == array[1,0] && array[0,1] != array[1,1]) 
  {
    Console.Write("Прямые параллельны");
  }
  else 
  {
    Ecuation (array);
    Console.Write($"Точка пересечения прямых: ({n[0]}, {n[1]})");
  }
}

InputCoefficients();
OutputResponse(array);
