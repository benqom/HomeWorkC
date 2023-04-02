// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такой позиции нет.
//Например, задан массив:
// 1  4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции нет
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-100, 111); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
string ElementMatrix(int[,] matrix, int z1, int  u1)
{      
    string rezultat="";
    if ((z1)>matrix.GetLength(0) )
     {   rezultat="Такого элемента нет";    return rezultat;}
    else if((u1)>matrix.GetLength(1))
    {rezultat="Такого элемента нет";        return rezultat;}
    else
    {
    rezultat=matrix[z1,u1].ToString();
    return rezultat;
    }
}
Console.Clear();
string rez="";
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите строку столбец: ");
int[] size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int k1=size1[0];int k2=size1[1];
InputMatrix(matrix);
PrintMatrix(matrix);
//rez=ElementMatrix(matrix,k1,k2);Console.Write(rez);
Console.Write(ElementMatrix(matrix,k1,k2));
