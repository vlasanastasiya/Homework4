﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Zadacha24()
{
       Console.WriteLine("Введите число");
       int numberA = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите число");
       int numberB = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine($"число {numberA} в степени {numberB} равно {Power(numberA, numberB)}");
}

int Power(int numberA, int numberB)
{
      int result = 1;
      if (numberA ==0) return 1;
      for(int i = 1; i <= numberB; i++)  
      {
      result *= numberA;
      
}
return result;
}
Zadacha24();
