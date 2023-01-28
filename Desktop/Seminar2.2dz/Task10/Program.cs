// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1/10;
int result = num2%10;

System.Console.WriteLine($"{num1}->{result}");
