using System;

namespace Task3 {
public class Functions {
  // Задан двухмерный массив целых чисел A размером N на M. Найти
  // произведение элементов, расположенных на главной диагонали.
  public static double MultiplyMainDiagonal(double[,] arr) {
    if (arr.Length == 0) {
      return 0;
    }
    
    var rows = arr.GetLength(0);
    var columns = arr.GetLength(1);

    if (rows == 1 || columns == 1) {
      return arr[0, 0];
    }
    
    double result = 1;
    var max_length = Math.Min(rows, columns);
    
    for (int i = 0; i < max_length; i++) {
      result *= arr[i, i];
    }

    return result;
  }
}
}