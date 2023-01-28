//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Enter the number");
int numberN = Convert.ToInt32 (Console.ReadLine());
int currentNumber = 1;

while (currentNumber <= numberN)
{
    if(currentNumber%2==0)
    System.Console.WriteLine(currentNumber);
    currentNumber++;
}
