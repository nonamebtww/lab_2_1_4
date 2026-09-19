using System;

namespace Task1 {
public static class Functions {
  // Сформировать одномерный (длиной n) и двумерный (длиной n на m)
  // массивы по заданному правилу, где k – случайное число:
  private static double Formula(int n, int k) {
    if (n == 0) {
      throw new ArgumentException("n cannot be 0", nameof(n));
    }
    
    return (Math.Pow(-1, k) * Math.Sqrt(n)) / (2 + Math.Pow(n, 2));
  }
  
  public static double[] Create1DArray(int n) {
    var result = new double[n];
    var random = new Random();

    for (int i = 0; i < n; i++) {
      result[i] = Formula(i + 1, random.Next(1, 10));
    }
    
    return result;
  }

  public static double[,] Create2DArray(int n, int m) {
    var result = new double[n, m];
    var random = new Random();

    for (int i = 0; i < n; i++) {
      for (int j = 0; j < m; j++) {
        result[i, j] = Formula(i + 1, random.Next(1, 10));
      }
    }
    
    return result;
  }
}
}