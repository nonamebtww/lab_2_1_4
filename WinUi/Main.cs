using System;
using System.Windows.Forms;
using Task5;

namespace WinUi {
public partial class Main : Form {
  private string[][] _objects;

  public Main() {
    InitializeComponent();
  }

  private void btnCreateArray_Click(object sender, EventArgs e) {
    _objects = Functions.CreateArray(
      txtCarBrand.Text, txtCarModel.Text, txtCarCapacity.Text, txtCarYear.Text,
      txtPlaneModel.Text, txtPlaneCapacity.Text, txtPlaneEngines.Text,
      txtHouseAddress.Text, txtHouseArea.Text, txtHouseRooms.Text, txtHouseFloors.Text, txtHouseYear.Text
    );

    MessageBox.Show(
      "Массив массивов успешно сформирован!",
      "Готово",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information
    );
  }

  private void btnOutput_Click(object sender, EventArgs e) {
    if (_objects == null || _objects.Length == 0) {
      MessageBox.Show("Сначала сформируйте массив.");
      return;
    }

    var result = Functions.ShowArray(_objects);

    if (string.IsNullOrEmpty(result)) {
      MessageBox.Show("Введены неверные значения!");
      return;
    }

    rtbOutput.Clear();
    rtbOutput.AppendText(result);
  }
}
}