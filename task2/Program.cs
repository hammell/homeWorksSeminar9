// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SummGapNumber(int start, int end)
{
    if (end >= start)
    {
        end = end + SummGapNumber(start, end - 1);
    }
    return end;
}



Console.WriteLine("Здраствуйте, введите, пожалуйста, значение N : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Здраствуйте, введите, пожалуйста, значение M : ");
int number2 = Convert.ToInt32(Console.ReadLine());


int result = SummGapNumber(number1, number2);
Console.WriteLine($"Сумма чисел промежутка от {number1} до {number2}: {result}");