// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

// int number = new Random().Next(10, 100); // эта функция не включает последнее число, 
// //но вкл первое [10,100)
// Console.WriteLine(number);

// if (number / 10 > number % 10)
// {
//     Console.WriteLine($"Max number is {number / 10}");
// }
// else
// {
//     Console.WriteLine($"Max number is {number % 10}");
// }


// 12. Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Insert the first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number2 % number1 == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine($"Не кратное, остаток от деления {number2 % number1}");
// }


// Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int num1 = number / 100;
// int num2 = number % 10;

// Console.WriteLine($"Final result: {num1}{num2}");


// 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// // 161 -> да

// Console.WriteLine("Insert a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Да, кратно");
// }
// else
// {
//     Console.WriteLine("Нет, не кратно");
// }



// 16. Напишите программу, которая принимает на вход два числа и
//  проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Insert the first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());


// if (number2 == number1 * number1)
// {
//     Console.WriteLine($"{number2} is a square of {number1}");
// }
// else if (number1 == number2 * number2)
// {
//     Console.WriteLine($"{number1} is a square of {number2}");
// }
// else
// {
//     Console.WriteLine("These numbers are not squares of each other");
// }

// //другой вариант предыдущей задачи

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == Math.Pow(num2, 2) || num2 == Math.Pow(num1, 2))
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// сочетние хороших методов:)

Console.WriteLine("Insert the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == Math.Pow(num2, 2) || num2 == Math.Pow(num1, 2))
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Числа не являются квадратом друг другу");
}
