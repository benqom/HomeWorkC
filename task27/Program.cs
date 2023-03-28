// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int s=0,digital=0;
while(n>0)
{ digital=n%10;
  s+=digital;
  n=n/10;
}
Console.Write(s);