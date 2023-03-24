// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите 5-х значное число: ");
string a = Console.ReadLine();
if ((a[0] ==a[4]) & (a[1]==a[3]) )
Console.WriteLine("да");
else
Console.WriteLine("нет");

