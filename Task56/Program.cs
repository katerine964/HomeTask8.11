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
void Func(int[,]matrix)
{
    int sum = int.MaxValue;;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int t = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            t=t+matrix[i, j];
        }
        if (t < sum)
        {
            sum = t;
            index = i;
        }
    }
    Console.WriteLine("Строка c наименьшей суммой: "+(index+1));
    Console.WriteLine();
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
Func(matrix);
        
