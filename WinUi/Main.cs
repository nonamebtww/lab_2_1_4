using System;
using System.Windows.Forms;

namespace WinUi {
public partial class Main : Form {
  private string[][] objects;

  public Main() {
    InitializeComponent();
  }

  private void btnCreateArray_Click(object sender, EventArgs e) {
    objects = new[] {
      new[] {
        txtCarBrand.Text, txtCarModel.Text, txtCarCapacity.Text, txtCarYear.Text
      },
      new[] {
        txtPlaneModel.Text, txtPlaneCapacity.Text, txtPlaneEngines.Text
      },
      new[] {
        txtHouseAddress.Text, txtHouseArea.Text, txtHouseRooms.Text, txtHouseFloors.Text, txtHouseYear.Text
      }
    };

    MessageBox.Show(
      "Массив массивов успешно сформирован!",
      "Готово",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information
    );
  }

  private void btnOutput_Click(object sender, EventArgs e) {
    if (objects == null) {
      MessageBox.Show("Сначала сформируйте массив.");
      return;
    }

    rtbOutput.Clear();

    rtbOutput.AppendText("МАССИВ МАССИВОВ\n");
    rtbOutput.AppendText("==============================\n\n");

    rtbOutput.AppendText("1. Грузовой автомобиль\n");
    rtbOutput.AppendText($"   Марка: {objects[0][0]}\n");
    rtbOutput.AppendText($"   Модель: {objects[0][1]}\n");
    rtbOutput.AppendText($"   Грузоподъёмность: {objects[0][2]}\n");
    rtbOutput.AppendText($"   Год выпуска: {objects[0][3]}\n");
    rtbOutput.AppendText($"   Количество полей: {objects[0].Length}\n\n");

    rtbOutput.AppendText("2. Грузовой самолёт\n");
    rtbOutput.AppendText($"   Модель: {objects[1][0]}\n");
    rtbOutput.AppendText($"   Грузоподъёмность: {objects[1][1]}\n");
    rtbOutput.AppendText($"   Количество двигателей: {objects[1][2]}\n");
    rtbOutput.AppendText($"   Количество полей: {objects[1].Length}\n\n");

    rtbOutput.AppendText("3. Жилой дом\n");
    rtbOutput.AppendText($"   Адрес: {objects[2][0]}\n");
    rtbOutput.AppendText($"   Площадь: {objects[2][1]}\n");
    rtbOutput.AppendText($"   Комнаты: {objects[2][2]}\n");
    rtbOutput.AppendText($"   Этажи: {objects[2][3]}\n");
    rtbOutput.AppendText($"   Год постройки: {objects[2][4]}\n");
    rtbOutput.AppendText($"   Количество полей: {objects[2].Length}\n");
  }
}
}