// Задача 64

// int n = InputInt("Введите положительное число");
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Вы ввели отрцательное число");
// }
// Console.WriteLine(NaturalNumber(n, m));

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m + 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }


// Задача 66

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }


// Задача 68

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

 
