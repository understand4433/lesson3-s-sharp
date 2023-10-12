// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
int readInt(string message)
{
    System.Console.WriteLine(message); // Получаем данные из строки.
    string value = Console.ReadLine();// Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value); // Возрвращаем переменную в int.
}
int N = readInt("Введите положительное число: ");
if (N > 0)
{
    int index = 0;
    while (index < N)
    {
        index++;
        System.Console.WriteLine(index * index);
    }
}
else System.Console.WriteLine("Число введено неверно. Введите положительное число:");