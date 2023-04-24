using System;

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//Функция `Ackermann` реализует формулу Аккермана с помощью рекурсии. Если `m` или `n` равны нулю, то значение вычисляется по соответствующей формуле. Если `m` и `n` больше нуля, то значение рекурсивно вычисляется по формуле `A(m-1, A(m, n-1))`. 

class MainClass {
  public static int Ackermann(int m, int n) {
    if (m == 0) {
      return n + 1;
    } else if (n == 0) {
      return Ackermann(m - 1, 1);
    } else {
      return Ackermann(m - 1, Ackermann(m, n - 1));
    }
  }

  public static void Main(string[] args) {
    int m = 2;
    int n = 3;
    Console.WriteLine("A({0},{1}) = {2}", m, n, Ackermann(m, n));

    m = 3;
    n = 2;
    Console.WriteLine("A({0},{1}) = {2}", m, n, Ackermann(m, n));
  }
}