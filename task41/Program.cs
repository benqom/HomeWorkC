//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите кол-во элементов ввода: ");
int n = Convert.ToInt32(Console.ReadLine());
int k=0,count=0;
while(n>0)
{ Console.Write("Введите кол-во элементов ввода: ");
 k = Convert.ToInt32(Console.ReadLine());
 if (k>0)
 count+=1;
 n--;
}
Console.Write("Кол-во положительных  элементов ввода: "+count);