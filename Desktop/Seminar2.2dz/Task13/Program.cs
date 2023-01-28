// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int num1 = Convert.ToInt32(Console.ReadLine());
int capacity = bitDepth(num1);

if (capacity<= 2)
{
    System.Console.WriteLine($"{num1} -> третьей цифры нет");
}
else
{ 
    int num3;
    if(capacity > 3)
    {
        num3 = num1/Convert.ToInt32(Math.Pow(10, capacity-3)); 
        num3 = num3 % 10; 
        System.Console.WriteLine($"{num1} -> {num3}");
    
    }
    else
    {
        num3 = num1 % 10; 
        System.Console.WriteLine($"{num1} -> {num3}");
    }
}

int bitDepth(int number)
{
    var count=0;
    while(number>0)
    {
        number = number/10;
        count++;
    }
    return count;
}
