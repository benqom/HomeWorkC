Console.Clear(); // очистка консоли
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{ if (a > c )
  Console.WriteLine(a); 
  else
  Console.WriteLine(c);
}
else if(b>c)
 Console.WriteLine(b);
 else
 Console.WriteLine(c);

