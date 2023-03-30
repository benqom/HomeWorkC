// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999); // [100; 999]
}

int CountNoChetSumElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 2) != 0)
            count+=array[i]; 
    }
    return count;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях {CountNoChetSumElement(array)}");
//Console.WriteLine($"Сумма отрицательных элементов равна {SumNegativeNumbers(array)}");