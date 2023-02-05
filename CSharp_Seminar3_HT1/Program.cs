// Задача 19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write ("Введите пятизначное число: ");
int numb5 = Convert.ToInt32(Console.ReadLine());

// число может быть отрицательным,поэтому возьмем его модуль
numb5 = Math.Abs(numb5);

if (( numb5 < 10000) || ( numb5 > 99999)) 
{  
    Console.WriteLine("Число не соответствует условию");
}
else
{    
   int[] numbers = new int[5]; 
   for (int i = 4; i >= 0; i--)
   {
       numbers[i] = numb5 % 10;
       numb5 = numb5 / 10;
   }
      if ((numbers[0] == numbers[4]) && (numbers[1] == numbers[3]))
      Console.WriteLine("Число является полиндромом");
   else 
      Console.WriteLine("Число не является полиндромом");
}