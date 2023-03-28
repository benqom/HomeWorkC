// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.  Hельзя использовать функцию Math.Pow()!
//3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите  число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  степень число: ");
int m = Convert.ToInt32(Console.ReadLine());
int i=1,s=1;
while (i<=m)
{   s*=a;
    i++;
}
Console.WriteLine(s);
