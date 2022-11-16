// Задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел 
// размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// найти максимальное число и его индекс, среднее арифметическое. 
// Вывести эту информацию на экран.

int[,] GetTable(int row, int col, int min, int max)
{
    int[,] table = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            table[i, j] = new Random().Next(min, max + 1);
        }
    }
    return table;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write(tab[i, j] + " ");
        }
        Console.WriteLine();
    }
}



