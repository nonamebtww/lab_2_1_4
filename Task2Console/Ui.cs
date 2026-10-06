using System;
using System.Linq;
using GeneralConsole;
using FunctionsTask1=Task1.Functions;
using FunctionsTask2=Task2.Functions;

namespace Task2Console {
public class Ui {
  public static void Task2Ui() {
    double[] arr_1, arr_2;

    while (true) {
      try {
        var n = Helpers.ReadInt("n");

        arr_1 = FunctionsTask1.Create1DArray(n).Select(x => x * 100).ToArray();
        arr_2 = FunctionsTask1.Create1DArray(n).Select(x => x * 100).ToArray();

        arr_1.Print1DArray("Массив A");
        arr_2.Print1DArray("Массив B");

        break;
      }
      catch {
        Console.WriteLine("Введено неверное значение!");
      }
    }

    var tuple = FunctionsTask2.CountMultipleOf2(arr_1, arr_2);
    var count_1 = tuple.Item1;
    var count_2 = tuple.Item2;

    Console.Write("Массив с наибольшим кол-во чисел кратным 2: ");
    var show_1 = count_1 > count_2;
    for (var i = 0; i < (show_1 ? arr_1.Length : arr_2.Length); i++) {
      Console.Write($"{(show_1 ? arr_1[i] : arr_2[i])} ");
    }
    Console.WriteLine();

    Console.Write("Другой массив: ");
    for (var i = 0; i < (show_1 ? arr_2.Length : arr_1.Length); i++) {
      Console.Write($"{(show_1 ? arr_2[i] : arr_1[i])} ");
    }
  }
}
}