double[,] inputTwoDimensionArray(int length, int secondLength)
{   Random random= new Random();
    double[,] mass = new double[length, secondLength];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = random.NextSingle() * 100 * Minus();
        }
            
    }
    return mass;
}

int ReadInt()
{
    Console.WriteLine("input number");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int Minus()
{
    Random random = new Random();
    if (random.Next(10) < 5) return 1;
    return -1;

}

void GetArrayAsString(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:0.##}", massive[i, j]));
        }
        Console.WriteLine();
    }
}


Task();
void Task()
{
    double[,] array = inputTwoDimensionArray(ReadInt(), ReadInt());
    GetArrayAsString(array);
}