// //*********************************************************************************************
// //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

        Console.WriteLine("Введите значение N:");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {N} до 1:");
        for (int i = N; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine(); 

// //*********************************************************************************************
// //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение M:");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int L = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = M; i <= L; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма натуральных чисел от {M} до {L} равна: {sum}");

        Console.ReadLine(); 

// //*********************************************************************************************
//    //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"Значение функции Аккермана A({m}, {n}) равно: {result}");

Console.ReadLine(); 


static int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}



