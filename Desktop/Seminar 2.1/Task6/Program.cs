//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Enter the number");
int number = Convert.ToInt32 (Console.ReadLine());

if (number%2==0)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}

