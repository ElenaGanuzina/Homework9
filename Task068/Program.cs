﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    
    else if (m > 0 && n == 0)
        return Ack(m - 1, 1);

    else if (m > 0 && n > 0)
        return Ack(m - 1, Ack(m, n - 1));
    
    else 
        return n + 1;

}

Console.WriteLine(Ack(0, 0));
Console.WriteLine(Ack(4, 0));
Console.WriteLine(Ack(2, 1));
Console.WriteLine(Ack(3, 2));
Console.WriteLine(Ack(3, 3));