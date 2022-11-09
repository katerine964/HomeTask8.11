// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = 32+k*3+j*2+i*4;
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
int[,,] matrix = new int[2, 2,2];
InputMatrix(matrix);
