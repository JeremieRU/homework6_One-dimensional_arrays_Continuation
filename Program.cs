int TakeConsoleInt(string str = "")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}

int CountZeroPlus(int[] arr)
{
    int i = 0;
    int count = 0;
    while (i < arr.Length)
    {
        int x = arr[i] > 0 ? count += 1 : 0;
        i++;
    }
    return count;
}

double TakeConsoleDouble(string str = "Введите число: ")
{
    double _num;
    Console.Write(str);
    double.TryParse(Console.ReadLine()!, out _num);
    return _num;
}


switch (TakeConsoleInt("Введите номер задачи(41, 43): "))
{
    default:
        Console.Write("Введён некорректный номер задачи");
        break;
    case 41:
        Console.Write("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n0, 7, 8, -2, -2 -> 2\n1, -7, 567, 89, 223 -> 3\n");
        int[] array41 = new int[1];
        Console.Write("Введите числа через пробел: ");
        array41 = Console.ReadLine()!.Split(' ', ',').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
        Console.WriteLine($"[{String.Join(", ", array41)}] -> {CountZeroPlus(array41)}");
        break;
    case 43:
        Console.Write("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями\n\ny = k1 * x + b1, y = k2 * x + b2;\n\nзначения b1, k1, b2 и k2 задаются пользователем.\n\nb1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)\n");
        double b1 = TakeConsoleDouble("Введите b1: ");
        double b2 = TakeConsoleDouble("Введите b2: ");
        double k1 = TakeConsoleDouble("Введите k1: ");
        double k2 = TakeConsoleDouble("Введите k2: ");
        if (k1 == k2)
            if (b1 == b2 && k1 == k2)
                Console.WriteLine("Прямые совпадают");
            else
                Console.WriteLine("Прямые параллелmны");
        else
        {
            double y = (b1 - ((k2 * b2) / k2)) / (k2 - k1);
            double x = (y - b2) / k2;
            Console.WriteLine($"y = k1 * x + b1,\ny = k2 * x + b2;\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");
        }
        break;
}