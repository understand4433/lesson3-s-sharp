// Задача2:
//  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int readQuater(string message)
{
    System.Console.WriteLine(message); // Получаем данные из строки.
    string value = Console.ReadLine();// Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value); // Возрвращаем переменную в int.
}
int quater = readQuater("Введите номер четверти:");
if (quater > 0 && quater <= 5)
{
    if (quater == 1)
    {
        System.Console.WriteLine("X>0 и Y>0");
    }
    if (quater == 2)
    {
        System.Console.WriteLine("X<0 и Y>0");
    }
    if (quater == 3)
    {
        System.Console.WriteLine("X<0 и Y<0");
    }
    if (quater == 4)
    {
        System.Console.WriteLine("X>0 и Y<0");
    }
}
else System.Console.WriteLine("Данные введены неверно.");