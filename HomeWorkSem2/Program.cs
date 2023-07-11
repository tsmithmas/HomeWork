// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// string numberB = Convert.ToString(numberA);
// Console.WriteLine("Вторая цифра этого числа: " + numberB[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// if (numberA >= 100)
// {
//     string numberB = Convert.ToString(numberA);
//     Console.WriteLine("Третья цифра этого числа: " + numberB[2]);
// }
// else
// {
//     Console.WriteLine("К сожалению, третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write( a + " - Отдыхаем, это выходной день!");
        }
        else
        {
            Console.Write( a + " - Это день рабочих будней");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить. Пожалуйста начните заново.");
    }
    return"";
}

