// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Enter the numbers");
int number1 = Convert.ToInt32 (Console.ReadLine());
int number2 = Convert.ToInt32 (Console.ReadLine());
int number3 = Convert.ToInt32 (Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    System.Console.WriteLine("Большое число " + number1);
}
else if (number2 > number1 && number2 > number3)
{
    System.Console.WriteLine("Большое число " + number2);
}
else
{
    System.Console.WriteLine("Большое число " + number3);
}

