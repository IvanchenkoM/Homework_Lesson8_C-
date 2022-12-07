// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//эл-ты каждой строки двумерного массива.

int rows = ReadInt("Enter the number of rows in the array: ");
int columns = ReadInt("Enter the number of columns in the array: ");

int [,] numbers = new int[rows,columns];
FillMatrixRandomNumbers(numbers);
Console.WriteLine("Your array:");
WriteMatrix(numbers);

int maxNumberRow = 0;
for (int i=0; i < numbers.GetLength(0); i++)
    {
        for (int j=0; j < numbers.GetLength(1); j++)
        {
            for (int k=j+1; k < numbers.GetLength(1); k++)
            {
                if (numbers[i,j] < numbers[i,k])
                {
                    maxNumberRow = numbers[i,k];
                    numbers[i,k] = numbers[i,j];
                    numbers[i,j] = maxNumberRow;
                }
            }
        }
    }

WriteMatrix(numbers);

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void WriteMatrix (int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
