// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int num;
while (!int.TryParse(Console.ReadLine()!, out num))
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите число:");
}

int SecondNumb(int num)
{
    int number = num / 10;
    int number2 = number % 10;
    return number2;
}
Console.WriteLine("Количество десятков в числе:");
Console.WriteLine(SecondNumb(num));
