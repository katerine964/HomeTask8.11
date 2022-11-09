// See https://aka.ms/new-console-template for more information
Console.Write("Введите кол-во строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, 2*n-1];
matrix[0,n-1]=1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < n; k++)
            {
                matrix[k,0]=0+matrix[k-1,1];
                matrix[k,2*n-2]=0+matrix[k-1,2*n-3];
                for (int l = 1; l < 2*n-2; l++)
                {
                    
                    matrix[k,l]=matrix[k-1,l-1]+matrix[k-1,l+1];
                }
            }
            if(matrix[i,j]==0)
            {
                Console.Write(" ");
            }
            else
                Console.Write(matrix[i,j]);
        }
        Console.WriteLine();
    }

