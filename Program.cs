// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = rand.Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortRowsDescending(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    for(int i = 0; i < numRows; i++)
    {
        int[] row = new int[numCols];
        for (int j = 0; j < numCols; j++)
        {
            row[j] = array[i, j];
        }

        Array.Sort(row, (a, b) => b.CompareTo(a));

        for (int j = 0; j < numCols; j++)
        {
            array[i, j] = row[j];
        }
    }
}


Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Console.WriteLine("Generated array: ");
Show2dArray(myArray);

SortRowsDescending(myArray);
Console.WriteLine("Modified array :");
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        
            array[i,j] = rand.Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int FindRowWithMinSum(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < numCols; j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}    

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Console.WriteLine("Generated array: ");
Show2dArray(myArray);

int minSumRowIndex = FindRowWithMinSum(myArray);
Console.WriteLine($"Row with the smallest sum of elements: {minSumRowIndex + 1} ");

 */    


// Задача 58: Задайте две матрицы. Напишите 
// программу, которая будет находить произведение двух матриц.

/*

int[,] matrixA = 
{
    {2, 9, 3},
    {3, 2, 4},
    {2, 6, 8}
};

int[,] matrixB = 
{
    {3, 4, 2},
    {3, 3, 6},
    {1, 9, 7}
};

int rowsA = matrixA.GetLength(0);
int colsA = matrixA.GetLength(1);
int colsB = matrixB.GetLength(1);

int[,] resultMatrix = new int[rowsA, colsB];

for (int i = 0; i < rowsA; i++)
    {
       for (int j = 0; j < colsB; j++)
       {
            int sum = 0;
            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

Console.WriteLine("Result Matrix:");
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            Console.Write(resultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }

*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

/*

int[,,] threeDimensionalArray = GenerateUniqueArray(2, 2, 2, 10, 99);

Console.WriteLine("3D array with indices:");
PrintArrayWithIndices(threeDimensionalArray);

int[,,] GenerateUniqueArray(int xSize, int ySize, int zSize, int minValue, int maxValue)
{
    int[,,] array = new int[xSize, ySize, zSize];
    Random rand = new Random();
    bool[] usedValues = new bool[maxValue - minValue + 1];

    for (int x = 0; x < xSize; x++)
    {
        for (int y = 0; y < ySize; y++)
        {
            for (int z = 0; z < zSize; z++)
            {
                int value;
                do
                {
                    value = rand.Next(minValue, maxValue + 1);
                }
                while (usedValues[value - minValue]);

                usedValues[value - minValue] = true;
                array[x, y, z] = value;
            }
        }
    }

    return array;
}

void PrintArrayWithIndices(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"array[{x}, {y}, {z}] = {array[x, y, z]}");
            }
        }
    }
}

*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив

/*

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a quantity of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] spiralArray = GenerateSpiralArray(rows, cols);

int maxValue = rows * cols;
int maxDigits = maxValue.ToString().Length;

     
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(spiralArray[i, j].ToString().PadLeft(maxDigits, '0') + "\t");
        }
        Console.WriteLine();
    }
    

int[,] GenerateSpiralArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    int num = 1;

    int left = 0, right = cols - 1, top = 0, bottom = rows - 1;

    while (num <= rows * cols)
    {
        for (int i = left; i <= right && num <= rows * cols; i++)
        {
            array[top, i] = num++;
        }
        top++;

    
        for (int i = top; i <= bottom && num <= rows * cols; i++)
        {
            array[i, right] = num++;
        }
        right--;

           
        for (int i = right; i >= left && num <= rows * cols; i--)
        {
            array[bottom, i] = num++;
        }
        bottom--;

           
        for (int i = bottom; i >= top && num <= rows * cols; i--)
        {
                array[i, left] = num++;
        }
        left++;
    }

        return array;
}        

*/








