using System;
using System.Linq;

using FunctionsTask1 = Task1.Functions;
using FunctionsTask2 = Task2.Functions;
using FunctionsTask3 = Task3.Functions;
using FunctionsTask4 = Task4.Functions;

namespace Console {
internal class Program {

  public static void Task1Ui() {
    var n = ReadInt("n");
    var m = ReadInt("m");
    
    var arr_1 = FunctionsTask1.Create1DArray(n);
    var arr_2 = FunctionsTask1.Create2DArray(n, m);

    System.Console.Write("Одномерный массив: ");
    foreach (var i in arr_1) {
      System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
    
    System.Console.Write("Двумерный массив: ");
    foreach (var i in arr_2) {
      System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
  }

  private static void Task2Ui() {
    var n = ReadInt("n");
    
    var arr_1 = FunctionsTask1.Create1DArray(n);
    var arr_2 = FunctionsTask1.Create1DArray(n);
    var (count_1, count_2) = FunctionsTask2.CountMultipleOf2(arr_1, arr_2);
    
    System.Console.Write("Массив с наибольшим кол-во чисел кратным 2: ");
    bool show_1 = count_1 > count_2;
    for (int i = 0; i < (show_1 ? arr_1.Length : arr_2.Length); i++) {
      System.Console.Write($"{(show_1 ? arr_1[i] : arr_2[i])} ");
    }
    System.Console.WriteLine();

    System.Console.Write("Другой массив: ");
    for (int i = 0; i < (show_1 ? arr_2.Length : arr_1.Length); i++) {
      System.Console.Write($"{(show_1 ?  arr_2[i] : arr_1[i])} ");
    }
  }

  private static void Task3Ui() {
    var n = ReadInt("n");
    var m = ReadInt("m");
    
    var arr = FunctionsTask1.Create2DArray(n, m);
    var result = FunctionsTask3.MultiplyMainDiagonal(arr);
    
    System.Console.WriteLine($"Результат умножения чисел по главной диагонали: {result}");
  }

  #region Task 4

  private static void Task4() {
    var n =  ReadInt("n");
    
    var arr = FunctionsTask4.MergeSort(
      FunctionsTask1.Create1DArray(n).Select(x => (int)(x * 100)).ToArray()
    );

    System.Console.Write("Отсортированный массив: ");
    foreach (var i in arr) {
      System.Console.Write($"{i} ");
    }
  }

  #endregion
  
  public static void Main(string[] args) {
    while (true) {
      System.Console.Write(
        "Выберите действие\n" +
        "1. Задание 1\n" +
        "2. Задание 2\n" +
        "3. Задание 3\n" +
        "4. Задание 4\n" +
        "0. Выход\n"
      );
      
      switch (ReadInt("действие")) {
        case 1:
          Task1Ui();
          break;
        case 2:
          Task2Ui();
          break;
        case 3:
          Task3Ui();
          break;
        case 4:
          Task4();
          break;
        case 0:
          return;
        default:
          System.Console.WriteLine("Выбраное неверное действие!");
          break;
      }

      System.Console.WriteLine("Нажмите любую клавишу для продолженния...");
      System.Console.ReadKey();
    }
  }

  #region Helpers

  private static int ReadInt(string param) {
    int x;
      
    while (true) {
      System.Console.Write($"Введите {param}: ");
      
      if (!int.TryParse(System.Console.ReadLine(), out x)) {
        System.Console.WriteLine("Вы ввели неверное число!");
      }
        
      break;
    }

    return x;
  }

  #endregion
}
}