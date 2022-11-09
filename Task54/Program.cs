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
void Order(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
       int t;
       for (int j = 0; j < array.GetLength(1); j++)
       {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if(array[i,j]<array[i,k])
                {
                    t = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k]=t;
                }
                else {array[i,k]=array[i,k];} 
            }
        Console.Write($"{array[i,j]} \t");    
       }
       
       Console.WriteLine();
    }
    
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
Console.WriteLine();
Console.WriteLine("Изначальный массив: ");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными строками: ");
Order(matrix);
Console.WriteLine();