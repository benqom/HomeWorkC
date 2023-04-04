// See https://aka.ms/new-console-template for more information
void InputMatrix(int[,] matrix)
{   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
             matrix[i, j] = new Random().Next(1, 10); 
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
void MultiMatrix(int[,] matrix, int[,] matrix1)
{ int[,] rez_matr = new int[matrix.GetLength(0), matrix1.GetLength(1)];
    
   
//multi
  for (int row = 0; row < matrix1.GetLength(0); row++) {
        for (int col = 0; col < matrix1.GetLength(1); col++) {
            // Multiply the row of A by the column of B to get the row, column of product.
            for (int inner = 0; inner < matrix1.GetLength(1); inner++) {
                rez_matr[row,col] += matrix[row,inner] * matrix1[inner,col];
            }
            //Console.WriteLine(rez_matr[row,col] );
        }
      
    }
    for (int row=0;row<rez_matr.GetLength(0);row++)
    {
        for (int col=0;col<rez_matr.GetLength(1);col++)
          Console.Write($"{rez_matr[row,col]} \t" );
          Console.Write($"\t ");    
    }
}
Console.Clear();
Console.Write("Введите размерность 1 матрицы: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите размерность 2 матрицы: ");
int[] size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
InputMatrix(matrix);
InputMatrix(matrix1);
PrintMatrix(matrix);
PrintMatrix(matrix1);
MultiMatrix(matrix, matrix1);
