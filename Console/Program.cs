using Task1Console;

namespace Console {
internal class Program {

  public static void Main(string[] args) {
    while (true) {
      System.Console.Clear();

      System.Console.Write(
        "1. Задание 1\n" +
        "2. Задание 2\n" +
        "3. Задание 3\n" +
        "4. Задание 4\n" +
        "0. Выход\n" +
        "Выберите действие: "
      );

      switch (System.Console.ReadLine()) {
        case "1":
          Ui.Task1Ui();
          break;
        case "2":
          Task2Console.Ui.Task2Ui();
          break;
        case "3":
          Task3Console.Ui.Task3Ui();
          break;
        case "4":
          Task4Console.Ui.Task4Ui();
          break;
        case "0":
          return;
        default:
          System.Console.WriteLine("Выбраное неверное действие!");
          break;
      }

      System.Console.WriteLine("\nНажмите любую клавишу для продолженния...");
      System.Console.ReadKey();
    }
  }
}
}