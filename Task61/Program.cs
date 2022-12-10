// Напишите программу,которая заполнит спирально массив 4 на 4.

int size = 5;
int[,] snakeArray = new int[size,size];

int sizeSnakeArrayN = size;//стороны прямоугольника
int sizeSnakeArrayM = size;

int iBeginning=0;
int iFinal=0;
int jBeginning=0;
int jFinal=0;

int k=1;
int i=0;
int j=0;

while (k <= size*size)
{
    snakeArray[i,j] = k;
    if (i == iBeginning && j < sizeSnakeArrayM-jFinal-1)
        j++;
    else if (j ==sizeSnakeArrayM-jFinal-1 && i < sizeSnakeArrayN-iFinal-1)
        i++;
    else if (i == sizeSnakeArrayN-iFinal-1 && j > jBeginning)
        j--;
    else
        i--;

    if ( i==iBeginning+1 && j==jBeginning && jBeginning!=sizeSnakeArrayM-jFinal-1)
    {
        iBeginning++;
        iFinal++;
        jBeginning++;
        jFinal++;
    }
    k++;
}

WriteMatrix(snakeArray);

void WriteMatrix (int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<10)
                Console.Write($"0{array[i,j]} ");
            else
                Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}