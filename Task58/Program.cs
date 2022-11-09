// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}
void Mult(int[,]mA, int[,]mB)
{
    if(mA.GetLength(1) == mB.GetLength(0))
    {
        int[,]mR=new int[mA.GetLength(0),mB.GetLength(1)];
        for (int i = 0; i < mA.GetLength(0); i++)
            {
                for (int j = 0; j < mB.GetLength(1); j++)
                {
                    for (int k = 0; k < mA.GetLength(1); k++)
                    {
                        mR[i,j] += mA[i,k] * mB[k,j];
                    }
                    Console.Write($"{mR[i, j]} \t");
                }
                Console.WriteLine();
            }
    }
    else{Console.WriteLine("Перемножить нельзя");}
}
Console.Write("Введите кол-во строк первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n, m];
Console.WriteLine();
Console.WriteLine("первая матрица: ");
InputMatrix(matrix1);
Console.Write("Введите кол-во строк второй матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[a, b];
Console.WriteLine();
Console.WriteLine("вторая матрица: ");
InputMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
Mult(matrix1, matrix2);

