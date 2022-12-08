// Напишите программу,которая заполнит спирально массив 4 на 4.

int size = 5;
int[,] snakeArray = new int[size,size];

int sizeSnakeArrayN = size;//стороны прямоугольника
int sizeSnakeArrayM = size;

int topLeftCorner=0;
int topRightCorner=0;
int lowerLeftCorner=0;
int lowerRightCorner=0;

int k=1;
int i=1;
int j=0;
snakeArray[0,0]=1;

while (k <= size*size)
{
    snakeArray[i,j]=k;
    Console.Write(snakeArray[0,0]);
    if (i == topLeftCorner && j < sizeSnakeArrayM-lowerLeftCorner-1)
        j++;
    else if (j ==sizeSnakeArrayM-lowerLeftCorner-1 && i < sizeSnakeArrayN-topRightCorner-1)
        i++;
    else if (i == sizeSnakeArrayN-topRightCorner-1 && j > lowerRightCorner)
        j--;
    else
        i++;

    if (i== topLeftCorner+1 && j == lowerRightCorner && lowerRightCorner != sizeSnakeArrayM-lowerLeftCorner-1)
        {
            topLeftCorner++;
            topRightCorner++;
            lowerLeftCorner++;
            lowerRightCorner++;
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