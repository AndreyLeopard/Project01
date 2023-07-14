
using System.Diagnostics.Metrics;

void Task0()
{
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

int number = 5;

int result = number * number;

Console.WriteLine(result);
}

void Task1()
{
    // Написать программу, коорая на вход принимает два числа и проверяет, является ли первое число квадратом второго
    /*  a = 5; b = 25 -> да
    a = 2 b = 10 -> нет
    a = 9; b = -3 -> нет
    a = -3 b = 9 -> да */

    Console.WriteLine("Введите первое число:");
    int number_f = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    int number_s = Convert.ToInt32(Console.ReadLine());

    // == сравнение; number ==5 - равно ли переменная значению 5?
    if (number_f == number_s * number_s)
    {
        Console.WriteLine("Первая переменная является квадратом второй");
    }
    else
    {
        Console.WriteLine("Первая переменная НЕ является квадратом второй");
    }
    }

    
// Если number_f == number_s * number_s, то напечать "равно"



/* 3. Напишите программу, которая будет выдавать название дня недели по задному номеру.
    3 -> Среда
    5 -> Пятница */

    Console.WriteLine("Введите дня недели:");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day == 1)
    {
        Console.WriteLine("Пн");
    }
    else if (day == 2)
    {
        Console.WriteLine("Вт");
    }
    else if (day == 3)
    {
        Console.WriteLine("Ср");
    }
    else if (day == 4)
    {
        Console.WriteLine("Чт");
    }
    else if (day == 5)
    {
        Console.WriteLine("Пт");
    }
    else if (day == 6)
    {
        Console.WriteLine("Сб");
    }
    else if (day == 7)
    {
        Console.WriteLine("Вс"); */
}



// 5. Напишите программу вычисления значения функции возвездения числа в квадрат. 
/*  4 -> 16
-3 -> 9
-7 -> 49 */

int Power(int number)
{
    int result = number * number;
    return result;
} 

void Task5()
{
Console.WriteLine("Ведите число");
int num = Convert.ToInt32(Console.ReadLine());
// int result = Power(num);
Console.WriteLine(Power(num));
}




void Task7()
{
//7. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые  фчисла в прмоежутке от -N до N.
// 4 -> "-4,-3,-2-1,0,1,2,3,4"
// 2-> "-2,-1,0,1,2"
    
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    num = Math.Abs(num);

    int counter = -num;

    while (counter <= num)
    {
        Console.Write(counter + " ");
        counter++;
    }
}