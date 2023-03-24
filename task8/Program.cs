Console.Clear(); // очистка консоли
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i=1;
while(n>=i)
{
  if ((i % 2) == 0) 
  Console.WriteLine(i);   
  i++;
}


 