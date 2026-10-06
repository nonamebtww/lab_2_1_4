using System;
using GeneralConsole;
using FunctionsTask1=Task1.Functions;
using FunctionsTask3=Task3.Functions;

namespace Task3Console {
public class Ui {
  public static void Task3Ui() {
    double[,] arr;

    while (true) {
      try {
        var n = Helpers.ReadInt("n");
        var m = Helpers.ReadInt("m");

        arr = FunctionsTask1.Create2DArray(n, m);

        arr.Print2DArray("Исходный массив");

        break;
      }
      catch {
        Console.WriteLine("Введено неверное значение!");
      }
    }
    
    Console.WriteLine($"Результат умножения чисел по главной диагонали: {FunctionsTask3.MultiplyMainDiagonal(arr)}");
  }
}
}