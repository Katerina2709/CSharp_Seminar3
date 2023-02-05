// Задача 23 Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите любое число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
   Console.Write("Число не соответствует условию"); 
}
else
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {number}: ");
    Console.Write("\n");

    for (int i = 1; i <= number; i++)
    {
      Console.Write($"{i}  ->  "); 
      Console.Write("\t");
      Console.WriteLine($"{Math.Pow(i, 3)}");
    } 
}

