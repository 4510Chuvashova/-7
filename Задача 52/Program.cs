Console.WriteLine ("введите количество строк");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("ведите количество столбцов");
int m = Convert.ToInt32 (Console.ReadLine());
int [,] numbers = new int [n,m];
FillArrayRandomNumbers(numbers);

for (int j =0; j < numbers.GetLength (1); j++)
{
    double average = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        average = (average +numbers [i,j]);
    }
    average = average / n;
    Console.Write (average + ";");
}
Console.WriteLine ();
PrintArray (numbers);

void FillArrayRandomNumbers (int [,]Array)
{
    for (int i =0; i < Array.GetLength (0); i++)
    {
        for (int j = 0; j < Array.GetLength (1); j++)
        {
            Array [i,j] = new Random ().Next (0, 10);
        }
    }
}
void PrintArray (int [,] Array)
{
    for (int i =0; i < Array.GetLength (0); i++)
    {
        Console.Write ("[");
        for (int j = 0; j < Array.GetLength (1); j++)
        {
            Console.Write (Array [i,j]+ " ");
        }
        Console.Write ("]");
        Console.WriteLine ("");
    }
}