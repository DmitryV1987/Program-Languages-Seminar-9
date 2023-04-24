using System;

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//1. Проверяем случай, когда m и n равны. В этом случае сумма элементов равна любому из этих чисел.
//2. Если m > n, то меняем их местами. Теперь m <= n.
//3. Суммируем все натуральные числа от m до n (включая m и n). Для этого мы вызываем функцию SumOfNaturalNumbersInRange рекурсивно, передавая в качестве аргументов m+1 и n. Когда дойдём до случая, когда m == n, то вернём это число.

class Program {
    static void Main(string[] args) {
        int m = 4;
        int n = 8;
        int sum = SumOfNaturalNumbersInRange(m, n);
        Console.WriteLine("The sum of natural numbers from {0} to {1} is {2}", m, n, sum);
    }

    static int SumOfNaturalNumbersInRange(int m, int n) {
        if (m == n) { // если m и n равны, то возвращаем любое из этих чисел (для упрощения вычислений)
            return m;
        } else if (m > n) { // если m > n, то меняем местами m и n
            int temp = m;
            m = n;
            n = temp;
        }
        // теперь m <= n

        // суммируем все натуральные числа от m до n (включая m и n)
        return m + SumOfNaturalNumbersInRange(m + 1, n);
    }
}