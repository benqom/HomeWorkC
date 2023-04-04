// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
void InputMatrix(int[,] matrix)
{   double j22=0.00;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1,20); 
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
int[,] SortSmalRowMatr(int[,] matrix)
{   
  int[,] A = new int[matrix.GetLength(0), matrix.GetLength(1)];
  int m=0;int i=0; int j=0;
  int k1=A.GetLength(0);
  int n=A.GetLength(1)-1;
  A=matrix;
    for(int k=0;k<k1;k++)
  {
    for (i=n;i>=0;i--)
    {   for(j =n; j>n-i;j--)
        { //Console.WriteLine("--"+A[k,j]+"  "+j+"\t");
        if(A[k,j]>A[k,j-1]) 
        {m=A[k,j];        A[k,j]=A[k,j-1];        A[k,j-1]=m;        } 
        }  

    }
  }      
 Console.WriteLine("+++++++++++"); 
 PrintMatrix(A);          
 return A;   
}
Console.Clear();
Console.Write("Введите размерность1-go массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
SortSmalRowMatr(matrix);
//Console.WriteLine($"[{string.Join(", ", SortSmalRowMatr(matrix))}]");
//PrintMatrix(matrix);
//Console.WriteLine($"[{string.Join(", ", matrix)}]");

/*int[,] A = {{1,2,9,10,5},{2,2,22,1,44}};
int m=0;
int k1=A.GetLength(0);
int n=A.GetLength(1)-1;
Console.WriteLine("row"+k1+"col"+n);
for(int k=0;k<k1;k++)
{
 for (int i=n;i>=0;i--)
 {   for(int j =n; j>n-i;j--)
    { Console.WriteLine("--"+A[k,j]+"  "+j+"\t");
        if(A[k,j]>A[k,j-1]) 
        {m=A[k,j];        A[k,j]=A[k,j-1];        A[k,j-1]=m;        } 
    }  

 }
}
foreach(int i in A)
    Console.Write($"{i}\t");
Console.WriteLine($"[{string.Join(", ", A)}]");
//Console.WriteLine($"[{string.Join(", ", matrix)}]");
*/