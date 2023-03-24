// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите  число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=a)
{Console.WriteLine(i*i*i);
 i++;
}

