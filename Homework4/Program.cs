// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter number : ");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);
int temp = 0;

while(temp < num)
{
    temp++;
    if (temp%2==0)
    {
        Console.Write(temp);
        Console.Write(", ");
    }
    
}
