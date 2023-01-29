/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
​Например, задан массив:
​1 4 7 2
​5 9 2 3
​8 4 2 4
​1 7 -> такого числа в массиве нет */

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);

//----------------------------------------------------------------------

int Number(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Метод на поиск значения по введенным индексам элемента:
int SearchElement(int a, int b)
{
    int line = a;
    int column = b;
    int result = array[line, column];
    return result;
}

//Метод печатающий массив со звездочками, кроме искомого элемента:
void PrintMatrixStar(int[,] matrix, int a, int b)
{
    int line = a;
    int column = b;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == line && j == column) Console.Write(matrix[i, j] + " "); else {Console.Write("*" + " ");}
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int line = Number("Введите позицию искомого элемента по строке: ");
int column = Number("Введите позицию искомого элемента по столбцу: ");

if(line > ROWS-1 || column > COLUMNS-1)
{
    Console.WriteLine();
    Console.WriteLine("Такого элемента нет");
    return;
}

Console.WriteLine();
PrintMatrixStar(array, line, column);

int elementValue = SearchElement(line, column);
Console.WriteLine();
Console.WriteLine($"Значение элемента по введенным позициям: {elementValue}");