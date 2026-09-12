using System;
using System.Linq;

namespace Console {
internal class Program {

  #region Task 1

  // Сформировать одномерный (длиной n) и двумерный (длиной n на m)
  // массивы по заданному правилу, где k – случайное число:
  private static double Task1Function(int n, int k) {
    return (Math.Pow(-1, k) * Math.Sqrt(n)) / (2 + Math.Pow(n, 2));
  }
  
  public static double[] Task1N(int n) {
    var result = new double[n];
    var random = new Random();

    for (int i = 0; i < n; i++) {
      result[i] = Task1Function(i, random.Next(1, 10));
    }
    
    return result;
  }

  public static double[,] Task1NM(int n, int m) {
    var result = new double[n, m];
    var random = new Random();

    for (int i = 0; i < n; i++) {
      for (int j = 0; j < m; j++) {
        result[i, j] = Task1Function(i, random.Next(1, 10));
      }
    }
    
    return result;
  }

  public static void Task1() {
    var arr_1 = Task1N(10);
    var arr_2 = Task1NM(10, 10);

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

  #endregion

  #region Task 2

  // Заданы два массива А и В. Подсчитать в них количество элементов,
  // кратных двум и первым на печать вывести массив, имеющий
  // наибольшее их количество.
  private static void Task2() {
    var arr_1 = Task1N(10);
    var arr_2 = Task1N(15);
    
    int count_1 = 0;
    int count_2 = 0;
    int max_length = arr_1.Length > arr_2.Length ? arr_1.Length : arr_2.Length;
    
    for (int i = 0; i < max_length; i++) {
      if (i < arr_1.Length && arr_1[i] % 2 == 0) {
        count_1++;
      }

      if (i < arr_2.Length && arr_2[i] % 2 == 0) {
        count_2++;
      }
    }

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

  #endregion

  #region Task 3

  // Задан двухмерный массив целых чисел A размером N на M. Найти
  // произведение элементов, расположенных на главной диагонали.
  private static void Task3() {
    var arr = Task1NM(3, 3);
    double result = 1;
    
    for (int i = 0; i < 3; i++) {
      result *= arr[i, i];
    }
    
    System.Console.WriteLine($"Результат умножения чисел по главной диагонали: {result}");
  }

  #endregion

  #region Task 4

  // Сортировка элементов массива слияниями
  private static int[] MergeSort(int[] array) {
    if (array.Length <= 1)
      return array;

    int mid = array.Length / 2;

    int[] left = new int[mid];
    int[] right = new int[array.Length - mid];

    Array.Copy(array, 0, left, 0, mid);
    Array.Copy(array, mid, right, 0, array.Length - mid);

    left = MergeSort(left);
    right = MergeSort(right);

    return Merge(left, right);
  }

  private static int[] Merge(int[] left, int[] right) {
    int[] result = new int[left.Length + right.Length];

    int i = 0;
    int j = 0;
    int k = 0;

    while (i < left.Length && j < right.Length) {
      if (left[i] <= right[j]) {
        result[k++] = left[i++];
      }
      else {
        result[k++] = right[j++];
      }
    }

    while (i < left.Length) {
      result[k++] = left[i++];
    }

    while (j < right.Length) {
      result[k++] = right[j++];
    }

    return result;
  }

  private static void Task4() {
    var arr = Task1N(10).Select(x => (int)(x * 100)).ToArray();
    arr = MergeSort(arr);

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
        "0. Выход\n" +
        "Выбор: "
      );

      var raw_action = System.Console.ReadLine();

      if (!int.TryParse(raw_action, out var action)) {
        System.Console.WriteLine("Введено неверное значение!");
        continue;
      }

      switch (action) {
        case 1:
          Task1();
          break;
        case 2:
          Task2();
          break;
        case 3:
          Task3();
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
    }
  }
}
}