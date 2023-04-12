Console.WriteLine("Введите букву котика");

int catNumber;
string input;
char cat = '0';

while (true)
{
    input = Console.ReadLine();
    if (input == null)
    {
        continue;
    }

    input = input.ToLower();

    if (input.Equals("exit"))
    {
        return;
    }

    cat = input.Length == 1 ? input[0] : cat;

    if (cat >= 'a' && cat <= 'z')
    {
        catNumber = cat - 'a' + 1;
        break;
    }
    else
    {
        Console.WriteLine("Введена неверная буква котика, попробуйте ещё раз");
    }
}

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