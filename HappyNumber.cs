int n = 1111111;
bool isHappy = IsHappy(n);
Console.WriteLine($"число {n} является счастливым: {isHappy}");
bool IsHappy(int n)
{
    int sum = 0;
    int digitParse = n;
    List<int> repeated = new List<int>();
    while (true)
    {

        if (digitParse == 0 && (sum == 1 || repeated.Contains(sum)))
        {
            break;
        }

        if (digitParse == 0)
        {
            Console.WriteLine(sum);
            digitParse = sum;
            repeated.Add(sum);
            sum = 0;
        }
        sum += (int)Math.Pow(digitParse % 10, 2);
        digitParse /= 10;
    }

    return sum == 1;
}