Console.WriteLine("Введите целое число");
int n = 0;
while (true)
{
    try
    {
        string input = Console.ReadLine();
        if (input.Equals("exit"))
        {
            return;
        }
        n = Convert.ToInt32(input);
        break;
    }
    catch
    {
        Console.WriteLine("Введено неверное число, попробуйте ещё раз");
    }    
}
long sumCubes = SumCubes(n);
Console.WriteLine($"Сумма кубов числа {n} = {sumCubes}");
string msg = IsSquare(n) ?
    "является правильным квадратом":
    "не является правильным квадратом";
Console.WriteLine($"Число {n} {msg}");

long SumCubes(int n)
{
    int powerValue = 3;
    long sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += (long)Math.Pow(i, powerValue);
    }

    return sum;

}

bool IsSquare(int n)
{
    return Math.Sqrt(n) % 1 == 0;
}