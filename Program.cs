// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumbers(int n)
{
    if(n==1) return n.ToString();
    else
    {
        return n + PrintNumbers(n -1);
    }
}

void Main()
{
    Console.Write("Введите чсло N: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($" N = {n} -> {PrintNumbers(n)}");
}

Main();