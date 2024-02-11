// See https://aka.ms/new-console-template for more information
int flagA = 0, flagB = 0;
int a=0, b=0;

do
{
    Console.WriteLine("Введите количество гвоздей от 1 до 10:");

    a = Convert.ToInt32(Console.ReadLine());
    if ((a < 1)|| (a > 10))
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Некорректные данные, повторите ввод");
        Console.ResetColor();
        }
    else 
    {
        flagA = 1;
    }
}
while (flagA == 0);

do
{
    Console.WriteLine("Введите количество ударов от 1 до 5:");

    b = Convert.ToInt32(Console.ReadLine());
    if ((b < 1) || (b > 5))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Некорректные данные, повторите ввод");
        Console.ResetColor();
    }
    else
    {
        flagB = 1;
    }
}
while (flagB == 0);

for (int i = 0; i < a; i++) 
{
    Console.WriteLine("Забиваем {0} гвоздь", i+1);
    for (int j = 0; j < b; j++) 
    {
        Console.WriteLine("Производим {0} удар", j+1);
    }
}

Console.WriteLine("Все гвозди забиты!");