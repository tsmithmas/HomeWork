﻿// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if(numberA > numberB)
// {
//     Console.Write(numberA + " больше чем " + numberB);
// }
// else
// {
//      Console.Write(numberB + " , больше чем " + numberA);
// }

// Задача 4: Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    if(numberA > numberC)
    {
         Console.Write(numberA + " самое большое число! ");
    }
    else
    {
         Console.Write(numberB + " самое большое число! ");
    }
}
else
{
    if(numberB > numberC)
    {
         Console.Write(numberB + " самое большое число! ");
    }
    else
    {
         Console.Write(numberC + " самое большое число! ");
    }
}