// Сформируйте 3хмерный массив из неповторяющихся 2хзначных чисел.Напишите программу, которая будет
//построчно выводить массивб добовляя индекс каждого эл-та.

int rows = ReadInt("Enter the number of rows in the array: ");
int columns = ReadInt("Enter the number of columns in the array: ");
int page = ReadInt("Enter the number of page in the array: ");

int[,,] array3D = new int[rows,columns,page];
FillArrayNonRecurringRandomNumbers(array3D);
WriteArray3D(array3D);
WriteArray3DWithIndex(array3D);

void FillArrayNonRecurringRandomNumbers(int[,,] array)
{
    int[] tempArray = new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
    for (int i=0; i<tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(10,100);
        int number = tempArray[i];
        if (i>=1)
        {
            for (int j=0; j<i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10,100);
                    number = tempArray[i];
                    j=0;
                }
            }
        }
    }
    
    int temp = 0;
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            for (int k=0; k< array.GetLength(2); k++)
            {
                array[i,j,k] = tempArray[temp];
                temp++;
            }
        }
    }
}

void WriteArray3D (int[,,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            for (int k=0; k< array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k]+ " ");
            } 
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void WriteArray3DWithIndex (int[,,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            for (int k=0; k< array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})  ");
            } 
            Console.WriteLine();
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
