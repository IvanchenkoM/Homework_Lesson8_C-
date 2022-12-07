// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//строку с наименьшей суммой эл-тов.

bool circle = true;

while (circle)
{
    int rows = ReadInt("Enter the number of rows in the rectangular array: ");
    int columns = ReadInt("Enter the number of columns in the rectangular array: ");
    if (rows != columns)
    {
        int [,] numbers = new int[rows,columns];
        FillMatrixRandomNumbers(numbers);
        Console.WriteLine("Your array:");
        WriteMatrix(numbers);

        int sumRow = 0;
        int[] sumMinRows = new int[rows];
        for (int i=0; i < numbers.GetLength(0); i++)
            {
                for (int j=0; j < numbers.GetLength(1); j++)
                {
                    sumRow += numbers[i,j];
                    sumMinRows[i] = sumRow;
                }
                sumRow = 0;
            }
        
        int minSum = sumMinRows[0];
        for (int i=1; i < sumMinRows.Length; i++)
        {
            if (minSum > sumMinRows[i])
                minSum = sumMinRows[i];
        }

        for (int i=0; i < sumMinRows.Length; i++)
        {
            if (minSum == sumMinRows[i])
                Console.WriteLine($"In the {i+1}th row has the smallest sum of elements.");
        }
        break;
    }
    else if (rows == columns)
    {
        Console.WriteLine("In a rectangular array, the number of rows isn't equal to the number of colums. Try again.");
        continue;
    } 
}

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
