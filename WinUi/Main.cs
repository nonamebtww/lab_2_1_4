using System.Windows.Forms;
using Task5WinForms;

namespace WinUi {
public partial class Main : Form {
  public Main() {
    InitializeComponent();
    ShowPage(new Task5Page());
  }

  #region Helpers

  private void ShowPage(UserControl page) {
    body.Controls.Clear();
    body.Controls.Add(page);
    page.Dock = DockStyle.Fill;
  }

  #endregion
}
}