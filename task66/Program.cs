// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int f(int m,int n)
{   int sum=m;
    if (m==n) 
     return 0;
    else
     { m++;
     sum=m+f(m,n);
     return sum;
     }
    
}
Console.Clear();
Console.Write("Введите число:M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число:N ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m-1,n));
