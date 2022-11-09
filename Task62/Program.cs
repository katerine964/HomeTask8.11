// See https://aka.ms/new-console-template for more information

void Snake(int[,]array)
{
    int s=1;
    for(int j=0; j<array.GetLength(1)-1; j++)
    {
        array[0,j]=s;
        s++;
    }
    for(int i=0; i<array.GetLength(0); i++)
    {
        array[i,array.GetLength(1)-1]=s;
        s++;
    }
    for(int j=array.GetLength(1)-2; j>=0; j--)
    {
        array[array.GetLength(0)-1,j]=s;
        s++;
    }
    for(int i=array.GetLength(0)-2; i>0; i--)
    {
        array[i,0]=s;
        s++;
    }
    int a=1;
    int b=1;
    while (s<array.GetLength(0)*array.GetLength(1))
    {
        while(array[a,b+1]==0)
        {
            array[a,b]=s;
            s++;
            b++;
        }
        while(array[a+1,b]==0)
        {
            array[a,b]=s;
            s++;
            a++;
        }
        while(array[a,b-1]==0)
        {
            array[a,b]=s;
            s++;
            b--;
        }
        while(array[a-1,b]==0)
        {
            array[a,b]=s;
            s++;
            a--;
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]==0)
            {
                array[i,j]=s;
            }
        }
    }
}
void InputMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
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
Console.WriteLine("массив: ");
Snake(matrix);
InputMatrix(matrix);