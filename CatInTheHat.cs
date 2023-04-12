Console.WriteLine("Введите букву котика");

int catNumber;
int minLatinCharCode = 97;
int maxLatinCharCode = 122;
string input;
char cat;
int catCode = 0;
cat = (char)catCode;

while (true)
{
    input = Console.ReadLine();
    if (input == null)
    {
        continue;
    };
    if (input.Equals("exit"))
    {
        return;
    };

    if (input.Length == 1)
    {
        cat = input.ToLower()[0];
        catCode = (int)cat;
    };

    if (input.Length > 1 || input.Length <= 0 || catCode < minLatinCharCode || catCode > maxLatinCharCode)
    {
        Console.WriteLine("Введена неверная буква котика, попробуйте ещё раз");
    }
    else
    {
        break;
    }
}
catNumber = catCode - minLatinCharCode + 1;
double catInHatHeight = 2000000d;
double totalHeight = totalCatHeight(catInHatHeight * 0.4, catNumber);
Console.WriteLine($"Высота всех котиков {string.Format("{0:f3}", totalHeight)}, всего котиков {catNumber}");
double totalCatHeight(double height, int catNumber)
{
    int number = catNumber - 1;
    return number == 0 ?
        height :
        height + totalCatHeight(height * 0.4, number);
}