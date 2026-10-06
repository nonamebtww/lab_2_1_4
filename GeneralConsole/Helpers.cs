using System;

namespace GeneralConsole {
public static class Helpers {
  public static int ReadInt(string param) {
    int x;

    while (true) {
      Console.Write($"Введите {param}: ");

      if (!int.TryParse(Console.ReadLine(), out x)) {
        Console.WriteLine("Вы ввели неверное число!");
      }

      break;
    }

    return x;
  }

  public static void Print1DArray<T>(this T[] arr, string name) {
    Console.Write($"{name}: ");

    Console.Write("[");

    foreach (var item in arr) {
      Console.Write($"\t{item:F4}\t");
    }

    Console.Write("]\n");
  }

  public static void Print2DArray<T>(this T[,] arr, string name) {
    Console.Write($"{name}:\n");

    for (var i = 0; i < arr.GetLength(0); i++) {
      Console.Write("[");

      for (var j = 0; j < arr.GetLength(1); j++) {
        Console.Write($"\t{arr[i, j]:F4}\t");
      }

      Console.Write("]\n");
    }
  }
}
}