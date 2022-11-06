Console.WriteLine("Введите число:");

int d = int.Parse(Console.ReadLine()!);

if (d == 1 || d == 2 || d == 3 || d == 4 || d == 5)
{
    Console.WriteLine("Будний день");
}
else
if (d == 6 || d == 7)
{
    Console.WriteLine("Выходной");
}
else
    Console.WriteLine("В неделе всего семь дней");

