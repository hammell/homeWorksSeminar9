// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetGapNumber(int start, int end)
{
  string res;

  if (start == end)
  {
    res = start.ToString();
  }
  else
  {
    res = end.ToString() + "," + GetGapNumber(start, end - 1);
  }
  return res;
}

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

string result;

if (num == 1)
{
  result = num.ToString();
}
else
{
  result = GetGapNumber(1, num);
}

Console.WriteLine($"Gap = {result}");