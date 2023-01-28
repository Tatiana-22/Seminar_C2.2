// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Enter the numbers");
int number1 = Convert.ToInt32 (Console.ReadLine());
int number2 = Convert.ToInt32 (Console.ReadLine());

if (number1 > number2)
{
    System.Console.WriteLine("Большое число " + number1 );
}
else
{
    System.Console.WriteLine("Большое число " + number2);
}

