// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000;
int num2 = (number / 1000) % 10;
int num4 = (number % 100) / 10;
int num5 = number % 10;

int checkNumber = number / 10000;

if (checkNumber < 1) Console.WriteLine("Введите пятизначное число!");

if (number < 0) number = number*(-1);

if (num1 == num5 && num2 == num4) Console.WriteLine("Полиндром!");
else Console.WriteLine("Не полиндром!");
