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

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int numberC = Convert.ToInt32(Console.ReadLine());

// if(numberA > numberB)
// {
//     if(numberA > numberC)
//     {
//          Console.Write(numberA + " самое большое число! ");
//     }
//     else
//     {
//          Console.Write(numberB + " самое большое число! ");
//     }
// }
// else
// {
//     if(numberB > numberC)
//     {
//          Console.Write(numberB + " самое большое число! ");
//     }
//     else
//     {
//          Console.Write(numberC + " самое большое число! ");
//     }
// }

// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// if(numberA % 2==1)
// {
//     Console.WriteLine(numberA + " нечетное число!");
// }
// else
// {
//     Console.WriteLine(numberA + " четное число!");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int numberA = 1; numberA <= N; numberA++)
{
    if(numberA % 2 == 0)
    Console.Write(numberA + " ");
}