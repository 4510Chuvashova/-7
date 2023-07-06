Console.WriteLine ("введите номер строки");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("введите номер столбца");
int m = Convert.ToInt32 (Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers (numbers);

if (n > numbers.GetLength (0) || m > numbers.GetLength (1))
{
    Console.WriteLine ("такого элемента нет");
}
else 
{
    Console.WriteLine ($"значение элемента {n} строки и {m} стоолбца равно {numbers [n-1, m-1]}");
}
PrintArray (numbers);

void FillArrayRandomNumbers (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int s = 0; s < array.GetLength (1); s++)
        {
            array [i,s] = new Random (). Next (-100,100) / 10;
        }
    }
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        Console.Write ("[");
        for (int s = 0; s < array.GetLength (1); s++)
        {
            Console.Write (array [i,s] + " ");
        }
        Console.Write ("]");
        Console.WriteLine (" ");
    }
}