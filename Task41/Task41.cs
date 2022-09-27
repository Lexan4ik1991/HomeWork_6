// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите число количество чисел: ");
int quanty = Convert.ToInt32(Console.ReadLine());
int[] array = new int[quanty];

void InputNumbers(int quanty)
{
for (int i = 0; i < quanty; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int QuantyNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) 
    {
    count ++;;
    } 
  }
  return count;
}

InputNumbers(quanty);

Console.WriteLine($"Введено чисел > 0: {QuantyNumbers(array)} ");