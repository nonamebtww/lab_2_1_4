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
    if (!int.TryParse(car_capacity, out var i_car_c) || i_car_c <= 0 ||
        !int.TryParse(plane_capacity, out var i_plane_c) || i_plane_c <= 0 ||
        !int.TryParse(plane_engine, out var i_plane_e) || i_plane_e <= 0 ||
        !int.TryParse(house_area, out var i_house_a) || i_house_a <= 0 ||
        !int.TryParse(house_area, out var i_house_r) || i_house_r <= 0 ||
        !int.TryParse(house_area, out var i_house_f) || i_house_f <= 0) {
      return null;
    }

    if (!int.TryParse(car_year, out var i_car_y) || i_car_y <= 1965 || i_car_y >= 2026) {
      return null;
    }

    if (!int.TryParse(house_year, out var i_house_y) || i_house_y <= 1965 || i_house_y >= 2026) {
      return null;
    }

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

    var builder = new StringBuilder();

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