//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 //и на выходе показывает вторую цифру этого числа.
//

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;
int secondDigit = number  / 10 % 10;

Console.WriteLine($"{secondDigit}");