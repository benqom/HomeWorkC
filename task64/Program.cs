// See https://aka.ms/new-console-template for more information

void f (int n)
{
  if (n == 0)  return;
  Console.Write("{0,4}",n);  
  f(n - 1);
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
f(n);
//Console.WriteLine(f(n));
/*
f(5) -> f(4) + "5 "
          |
          f(3) + "4 "
            |
            f(2) + "3 "
              |
              f(1) + "2 "
                |
                "1 "
*/