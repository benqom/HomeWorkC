//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите 3-х значное число: ");
string a = Console.ReadLine();
if (a.Length<3)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine(a[1]);