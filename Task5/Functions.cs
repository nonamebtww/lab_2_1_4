using System.Text;

namespace Task5 {
public class Functions {
  public static string[][] CreateArray(
    string car_brand,
    string car_model,
    string car_capacity,
    string car_year,
    
    string plane_model,
    string plane_capacity,
    string plane_engine,
    
    string house_address,
    string house_area,
    string house_rooms,
    string house_floors,
    string house_year
  ) {
    return new[] {
      new[] {
        car_brand, car_model, car_capacity, car_year
      },
      new[] {
        plane_model, plane_capacity, plane_engine
      },
      new[] {
        house_address, house_area, house_rooms, house_floors, house_year
      }
    };
  }

  public static string ShowArray(string[][] arr) {
    if (arr.Length != 3 || arr[0].Length != 4 || arr[1].Length != 3 || arr[2].Length != 5) {
      return null;
    }
    
    StringBuilder builder = new StringBuilder();
    
    builder.Append("Данные\n");
    builder.Append("==============================\n\n");

    builder.Append("1. Грузовой автомобиль\n");
    builder.Append($"   Марка: {arr[0][0]}\n");
    builder.Append($"   Модель: {arr[0][1]}\n");
    builder.Append($"   Грузоподъёмность: {arr[0][2]}\n");
    builder.Append($"   Год выпуска: {arr[0][3]}\n");
    builder.Append($"   Количество полей: {arr[0].Length}\n\n");

    builder.Append("2. Грузовой самолёт\n");
    builder.Append($"   Модель: {arr[1][0]}\n");
    builder.Append($"   Грузоподъёмность: {arr[1][1]}\n");
    builder.Append($"   Количество двигателей: {arr[1][2]}\n");
    builder.Append($"   Количество полей: {arr[1].Length}\n\n");

    builder.Append("3. Жилой дом\n");
    builder.Append($"   Адрес: {arr[2][0]}\n");
    builder.Append($"   Площадь: {arr[2][1]}\n");
    builder.Append($"   Комнаты: {arr[2][2]}\n");
    builder.Append($"   Этажи: {arr[2][3]}\n");
    builder.Append($"   Год постройки: {arr[2][4]}\n");
    builder.Append($"   Количество полей: {arr[2].Length}\n");

    return builder.ToString();
  }
}
}