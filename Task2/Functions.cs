using System;

namespace Task2 {
public class Functions {
  // Заданы два массива А и В. Подсчитать в них количество элементов,
  // кратных двум и первым на печать вывести массив, имеющий
  // наибольшее их количество.
  public static Tuple<int, int> CountMultipleOf2(double[] arr_1, double[] arr_2) {
    var count_1 = 0;
    var count_2 = 0;
    var max_length = Math.Max(arr_1.Length, arr_2.Length);
    
    for (var i = 0; i < max_length; i++) {
      if (i < arr_1.Length && arr_1[i] % 2 == 0) {
        count_1++;
      }

      if (i < arr_2.Length && arr_2[i] % 2 == 0) {
        count_2++;
      }
    }

    return new Tuple<int, int>(count_1, count_2);
  }
}
}