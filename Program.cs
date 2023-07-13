
/* //Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

int number = 5;

int result = number * number;

Console.WriteLine(result); */

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


// Если number_f == number_s * number_s, то напечать "равно"