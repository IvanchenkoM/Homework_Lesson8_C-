// Задайте две матрицы. Напишите программу, которая будет находить
//произведение двух матриц.

bool circle = true;

while (circle)
{
    int rowsFirstMatrix = ReadInt("Enter the number of rows in the first matrix: ");
    int columnsFirstMatrix = ReadInt("Enter the number of columns in the first matrix: ");
    int rowsSecondMatrix = ReadInt("Enter the number of rows in the socond matrix: ");
    int columnsSecondMatrix = ReadInt("Enter the number of columns in the second matrix: ");
    if (columnsFirstMatrix == rowsSecondMatrix)
    {
        int [,] firstMatrix = new int[rowsFirstMatrix,columnsFirstMatrix];
        int [,] secondMatrix = new int[rowsSecondMatrix,columnsSecondMatrix];
        int [,] resultMatrix = new int[firstMatrix.GetLength(1),secondMatrix.GetLength(0)];
        FillMatrixRandomNumbers(firstMatrix);
        FillMatrixRandomNumbers(secondMatrix);
        Console.WriteLine("Your first matrix:");
        WriteMatrix(firstMatrix);
        Console.WriteLine("Your second matrix:");
        WriteMatrix(secondMatrix);

        for (int i=0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j=0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int k=0; k < secondMatrix.GetLength(0); k++)
                    {
                        resultMatrix[i,j] += firstMatrix[i,k]*secondMatrix[k,j];
                    }
                }              
            }
        
        Console.WriteLine("Your result matrix:");
        WriteMatrix(resultMatrix);      
        break;
    }
    else if (columnsFirstMatrix != rowsSecondMatrix)
    {
        Console.WriteLine("For matrix multiplication, the number of columns in the first matrix"+ Environment.NewLine + "must be equal to the number of rows in the second matrix." + Environment.NewLine + "Retype new numbers.");
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
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
