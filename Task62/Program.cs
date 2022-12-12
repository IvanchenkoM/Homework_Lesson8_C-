// Вывести первые N строк треугольника Паскаля.Сделать вывод в виде равнобедренного треугольника.

int rows = ReadInt("Enter the number of rows of Pascal's triangel you want to see: ");

if (rows == 0)
{
    Console.WriteLine("Please, enter a number of rows greater than 0");
}
else if (rows == 1)
{
    int one = 1;
    Console.WriteLine(one);
}
else if (rows > 1)
{
    int [][] triangel = new int [rows][];
    int temp = 1;
    for (int j=0; j < rows; j++)
    {
        triangel[j]= new int[temp];
        temp++;
    }
    
    triangel[0] = new int[1] {1};
    triangel[1] = new int[2] {1,1};

    for (int i=2; i < rows; i++)
    {
        triangel[i][0] = 1;
    }

    for (int i=2; i < rows; i++)
    {
        for (int j=1; j < triangel[i].Length; j++)
        {
            if (j == triangel[i].Length-1)
            {
                triangel[i][j] = 1;
            }
        }
    }

    for (int i=2; i<rows; i++)
    {
        for (int j=1; j < triangel[i].Length-1; j++)
        {
            triangel[i][j] = triangel[i-1][j-1]+triangel[i-1][j];
        }
    }
    /*for (int i=0; i < triangel.Length; i++)
    {
        for (int j=0; j < triangel[i].Length; j++)
        {
            Console.Write(triangel[i][j]+ " ");
        }
        Console.WriteLine();
    }*/

    char[][] writeTrg = new char[rows][];
    int count = 1;
    for (int i=0; i<rows; i++)
    {
        int[] help = new int[count];
        help = triangel[i];
        count++;
        string rowTriangel = string.Join(" ",help);
        int symbol = 0;
        foreach (var ch in rowTriangel)
        {
            symbol++;
        }
        writeTrg[i] = new char[symbol];
        writeTrg[i] = rowTriangel.ToCharArray(0,symbol);
    }
    int middle = 0;
    foreach (var ch in writeTrg[rows-1])
    {
        middle++;
    }
    int startingPoint = 0;
    if (middle%2 == 1)
    {    
        startingPoint = middle/2+7;
    }
    else
    {
        startingPoint = middle/2+6;
    }

    Console.WriteLine(startingPoint);
    int k =1;

    for (int i=0; i < writeTrg.Length; i++)
    {
        if (i<5)
        {
            Console.SetCursorPosition(startingPoint-i,i);
        
            for (int j=0; j < writeTrg[i].Length; j++)
            {
                Console.Write(writeTrg[i][j]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.SetCursorPosition(startingPoint-i-k,i);
            
            for (int j=0; j < writeTrg[i].Length; j++)
            {
                Console.Write(writeTrg[i][j]);
            }
            Console.WriteLine();
        }
        
    }

    /*int[] arrayX = new int[rows];
    for (int i=0; i<rows;i++)
    {
        int[] help = new int[rows];
        help = triangel[rows-1];
        string lastRowTriangel = string.Join(" ",help);
        int symbol = 0;
        foreach (var ch in lastRowTriangel)
        {
            symbol++;
        }
        Console.WriteLine(symbol);
        int startingPoint = 0;
        if (symbol%2 == 1)
        {    
            startingPoint = symbol/2+1;
            if (rows-(1-(rows*startingPoint))/(1-startingPoint) == 0)
            {
                double smthCalculation = Convert.ToDouble((1-(rows*startingPoint))/(1-startingPoint));
                double exactCalculation = Convert.ToDouble((i-smthCalculation)/(rows-smthCalculation));
                Math.Round(exactCalculation,0);
                int x = Convert.ToInt32(exactCalculation);
                arrayX[i]=x;
            }
            else
            {
                double smthCalculation = Convert.ToDouble((1-(rows*startingPoint))/(1-startingPoint));
                double exactCalculation = Convert.ToDouble((i-smthCalculation)/(rows-smthCalculation));
                Math.Round(exactCalculation,0);
                int x = Convert.ToInt32(exactCalculation);
                arrayX[i]=x;
            }
            
        }
        else if (symbol%2 == 0)
        {
            startingPoint = symbol/2;
            if (rows-(1-(rows*startingPoint))/(1-startingPoint) == 0)
            {
                double smthCalculation = Convert.ToDouble((1-(rows*startingPoint))/(1-startingPoint));
                Console.WriteLine(smthCalculation);
                double exactCalculation = Convert.ToDouble((i-smthCalculation)/(rows-smthCalculation));
                Math.Round(exactCalculation,0);
                int x = Convert.ToInt32(exactCalculation);
                arrayX[i]=x;
            }
            else
            {
                double smthCalculation = Convert.ToDouble((1-(rows*startingPoint))/(1-startingPoint));
                double exactCalculation = Convert.ToDouble((i-smthCalculation)/(rows-smthCalculation));
                Math.Round(exactCalculation,0);
                int x = Convert.ToInt32(exactCalculation);
                arrayX[i]=x;
            }
        }
        
        //Console.WriteLine(startingPoint);
        
        
    }

    for (int i=0;i<arrayX.Length;i++)
    {
        arrayX[i]= -arrayX[i];
    }

    for (int i=0;i<arrayX.Length;i++)
    {
        Console.Write(arrayX[i]+" ");
    }

    /*for (int i=0; i < triangel.Length; i++)
    {
        Console.SetCursorPosition(arrayX[i],i);
        
        for (int j=0; j < triangel[i].Length; j++)
        {
            Console.Write(triangel[i][j]+ " ");
        }
        Console.WriteLine();
    }*/
}




int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}