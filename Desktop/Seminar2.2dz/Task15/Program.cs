// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1==6 || num1==7)
{   
    System.Console.WriteLine($"{num1}-> да");
}
else
{
    System.Console.WriteLine($"{num1}-> нет");
}
