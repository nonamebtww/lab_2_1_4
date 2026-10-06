using System;
using System.Linq;
using GeneralConsole;
using FunctionsTask1=Task1.Functions;
using FunctionsTask4=Task4.Functions;

namespace Task4Console {
public class Ui {
  public static void Task4Ui() {
    int[] arr;

    while (true) {
      try {
        var n = Helpers.ReadInt("n");

        arr = FunctionsTask1.Create1DArray(n).Select(x => (int)(x * 100)).ToArray();

        arr.Print1DArray("Исходный массив");

        arr = FunctionsTask4.MergeSort(
          arr
        );

        break;
      }
      catch {
        Console.WriteLine("Введено неверное значение!");
      }
    }

    arr.Print1DArray("\nОтсортированный массив");
  }
}
}