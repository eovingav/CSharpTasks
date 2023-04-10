Console.WriteLine("Введите букву котика");

string alphabet = "abcdefghijklmnopqrstuvwxyz";
string input;
while (true)
{
    input = Console.ReadLine();
    if (input == null)
    {
        continue;
    }
    if (input.Equals("exit"))
    {
        return;
    }
    if (input.Length > 1 || input.Length <= 0 || alphabet.IndexOf(input.ToLower()) < 0)
    {
        Console.WriteLine("Введено неверное число, попробуйте ещё раз");
    }
    else
    {
        break;
    }
}
char cat = input.ToLower()[0];
int catNumber = alphabet.IndexOf(cat) + 1;
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