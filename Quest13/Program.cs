
Console.WriteLine("Введите число:");
// 1.Ввод числа
int num;
if(!int.TryParse(Console.ReadLine()!, out num))
{
    Console.WriteLine("Неверный ввод");
    return;
}
// 2.Преобразование его в строку
 string str = Convert.ToString(num);
 //3.Условие - если в строке больше 2 символов тогда - третья цифра это символ с индексом 2 в строке 
 //(аналогично массивам индексация в строке начинается с 0) 
    if (str.Length > 2)
    {
        Console.WriteLine("третья цифра - " + str[2]);
    }
    // иначе - вывод о том что третьей цифры нет
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
