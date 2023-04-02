﻿// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 111); 
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
void SredneArifmKagdogoColum(int[,] matrix )
{   string rezultat="";
    double sum=0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    { sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            {//Console.Write($"--{matrix[i, j]} \t");
            //Console.Write($"--{i}");
            sum+=matrix[i, j];
            }
            sum=Math.Round((sum/matrix.GetLength(0)),2);
            Console.Write($"{sum} \t");//
    }  
        
}


Console.Clear();
string rez="";
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
SredneArifmKagdogoColum(matrix);
//Console.Write(ElementMatrix(matrix,k1,k2));

