Console.WriteLine ("введите количество строк");
int linesVol = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("введите количество столбцов");
int columnsVol = Convert.ToInt32 (Console.ReadLine());
double [,] numbers = new double [linesVol, columnsVol];
FillArrayRandomNumbers (numbers);
PrintArray (numbers);
void FillArrayRandomNumbers (double [,] array)
{
    for (int i = 0; i < array.GetLength (0); i ++)
    {
        for (int k = 0; k < array.GetLength (1); k++)
        {
            array [i,k] = Convert.ToDouble (new Random(). Next (-100,100)) / 10;
        }
    }
}
void PrintArray (double [,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        Console.Write ("[ ");
        for (int k = 0; k < array.GetLength (1); k++)
    {
        Console.Write (array [i, k] + " ");
    }
Console.Write ("]");
Console.WriteLine ("");
    }
}