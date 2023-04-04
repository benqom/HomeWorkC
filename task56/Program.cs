// See https://aka.ms/new-console-template for more information
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 100); 
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
void SumRowMintMatrix(int[,] matrix)
{  int[,] res_sum = new  int[matrix.GetLength(0),1] ; 
   int sum=0; int str_max=0;
   for (int i = 0; i < matrix.GetLength(0); i++)
    {   sum=0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {    sum+=matrix[i, j];   
        //    Console.Write($"{matrix[i, j]} \t"+sum);
        
        }
        //Console.WriteLine("----------");
        res_sum[i,0]=sum;
    }
    sum=res_sum[0,0];
    for (int i = 0; i < res_sum.GetLength(0); i++)
    {
      if (res_sum[i,0]<sum)
        {   sum=res_sum[i,0];        str_max=i;}
        
    // Console.WriteLine(res_sum[i,0]);
    }  
    str_max++;
Console.WriteLine("строка с наименьшей суммой элементов"+str_max);
}
Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
SumRowMintMatrix(matrix);
//Console.Write(ElementMatrix(matrix,k1,k2));

