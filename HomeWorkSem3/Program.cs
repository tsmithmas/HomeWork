// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число пятизначное число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine(number + " - это число палиндром");
//     }
//     else
//     {
//         Console.WriteLine(number + " - это число не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели " + number + " , это не пятизначное число. Пожалуйста начните заново!");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int xA = ReadInt("Введите координату X первой точки: ");
// int yA = ReadInt("Введите координату Y первой точки: ");
// int zA = ReadInt("Введите координату Z первой точки: ");
// int xB = ReadInt("Введите координату X второй точки: ");
// int yB = ReadInt("Введите координату Y второй точки: ");
// int zB = ReadInt("Введите координату Z второй точки: ");

// int resultX = xB - xA;
// int resultY = yB - yA;
// int resultZ = zA - zB;

// double length = Math.Sqrt(resultX * resultX + resultY * resultY + resultZ * resultZ);
// Console.WriteLine("Длина отрезка между точками = " + length);

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число N: ");

Console.WriteLine(number + " -> " );

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
