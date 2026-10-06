using System;
using GeneralConsole;
using FunctionsTask1=Task1.Functions;

namespace Task1Console {
public static class Ui {
  public static void Task1Ui() {
    double[] arr_1;
    double[,] arr_2;

    while (true) {
      try {
        var n = Helpers.ReadInt("n");
        var m = Helpers.ReadInt("m");

        arr_1 = FunctionsTask1.Create1DArray(n);
        arr_2 = FunctionsTask1.Create2DArray(n, m);
        
        break;
      }
      catch {
        Console.WriteLine("Введено неверное значение!");
      }
    }
    
    arr_1.Print1DArray("Одномерный массив");
    arr_2.Print2DArray("Двумерный массив");
  }
}
}