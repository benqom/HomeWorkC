// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3.03 7.85 22.13 2.05 78.48] -> 76.43

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
       array[i] = Math.Round(new Random().NextDouble() * 100, 2);
}

double DeltawithMinMaxelement(double[] array)
{
    double max = array[0];
    double min = array[0];
    double Delta1=0.0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
            max=array[i];
         if (array[i]<min)
            min=array[i];
      
    }
    //Console.WriteLine("max"+max);    Console.WriteLine("min"+min);
    Delta1=max-min;
    return Delta1;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(": ", array)}]");
Console.WriteLine($"Pазницу между максимальным и минимальным элементов массива. {DeltawithMinMaxelement(array)}");
//Console.WriteLine($"Сумма отрицательных элементов равна {SumNegativeNumbers(array)}");
