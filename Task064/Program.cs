// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void ShowNumbers(int m, int n)
{
    if (m == n + 1)
        return;
    Console.Write($"{m} ");
    ShowNumbers(m + 1, n);
}

ShowNumbers(0, 10);
Console.WriteLine();
ShowNumbers(-5, 5);
Console.WriteLine();
ShowNumbers(-18, 0);