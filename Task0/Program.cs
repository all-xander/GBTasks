using static System.Console;
WriteLine("Возведение числа в квадрат.");
Write("Введите число: ");

int a = int.Parse(ReadLine()!);
WriteLine($"Квадрат числа {a} равен {a*a}");
