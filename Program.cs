/*
Задача

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
//Решение

Console.Write("Input number 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine("Max number is: " + number_1);
}
else
{
    Console.WriteLine("Max number is: " + number_2);
}
*/

/*
Тесты

PS D:\Home_Works\CS_HW_1> dotnet run
Input number 1: 5
Input number 2: 7
Max number is:7
PS D:\Home_Works\CS_HW_1> dotnet run
Input number 1: 2
Input number 2: 10
Max number is: 10
PS D:\Home_Works\CS_HW_1> dotnet run
Input number 1: -9
Input number 2: -3
Max number is: -3
*/

/*
Задача

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
//Решение
Console.Write("Input number 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 3: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int result = number_1;

if (result < number_2)
{
    result = number_2;
}

if (result < number_3)
{
    result = number_3;
}

Console.WriteLine("Max number is: " + result);
*/

/*
Тесты
PS D:\Home_Works\CS_HW_1> dotnet run
Input number 1: 2
Input number 2: 3
Input number 3: 7
Max number is: 7
PS D:\Home_Works\CS_HW_1> dotnet run
Input number 1: 44
Input number 2: 5
Input number 3: 78
Max number is: 78
PS D:\Home_Works\CS_HW_1> dotnet run
Input number 1: 22
Input number 2: 3
Input number 3: 9
Max number is: 22
*/

