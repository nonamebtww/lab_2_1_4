namespace WinUi
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblPlane;
        private System.Windows.Forms.Label lblHouse;

        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarCapacity;
        private System.Windows.Forms.TextBox txtCarYear;

        private System.Windows.Forms.TextBox txtPlaneModel;
        private System.Windows.Forms.TextBox txtPlaneCapacity;
        private System.Windows.Forms.TextBox txtPlaneEngines;

        private System.Windows.Forms.TextBox txtHouseAddress;
        private System.Windows.Forms.TextBox txtHouseArea;
        private System.Windows.Forms.TextBox txtHouseRooms;
        private System.Windows.Forms.TextBox txtHouseFloors;
        private System.Windows.Forms.TextBox txtHouseYear;

        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblCar = new System.Windows.Forms.Label();
            this.lblPlane = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();

            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarCapacity = new System.Windows.Forms.TextBox();
            this.txtCarYear = new System.Windows.Forms.TextBox();

            this.txtPlaneModel = new System.Windows.Forms.TextBox();
            this.txtPlaneCapacity = new System.Windows.Forms.TextBox();
            this.txtPlaneEngines = new System.Windows.Forms.TextBox();

            this.txtHouseAddress = new System.Windows.Forms.TextBox();
            this.txtHouseArea = new System.Windows.Forms.TextBox();
            this.txtHouseRooms = new System.Windows.Forms.TextBox();
            this.txtHouseFloors = new System.Windows.Forms.TextBox();
            this.txtHouseYear = new System.Windows.Forms.TextBox();

            this.btnCreateArray = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();

            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Text = "Лабораторная работа — Массив массивов";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Car label
            this.lblCar.Text = "Грузовой автомобиль";
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Bold);
            this.lblCar.Location = new System.Drawing.Point(30, 20);
            this.lblCar.AutoSize = true;

            // Plane label
            this.lblPlane.Text = "Грузовой самолёт";
            this.lblPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Bold);
            this.lblPlane.Location = new System.Drawing.Point(310, 20);
            this.lblPlane.AutoSize = true;

            // House label
            this.lblHouse.Text = "Жилой дом";
            this.lblHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Bold);
            this.lblHouse.Location = new System.Drawing.Point(590, 20);
            this.lblHouse.AutoSize = true;

            // Car fields
            CreateTextBox(txtCarBrand, "Марка", 30, 60);
            CreateTextBox(txtCarModel, "Модель", 30, 100);
            CreateTextBox(txtCarCapacity, "Грузоподъёмность", 30, 140);
            CreateTextBox(txtCarYear, "Год выпуска", 30, 180);

            // Plane fields
            CreateTextBox(txtPlaneModel, "Модель", 310, 60);
            CreateTextBox(txtPlaneCapacity, "Грузоподъёмность", 310, 100);
            CreateTextBox(txtPlaneEngines, "Двигатели", 310, 140);

            // House fields
            CreateTextBox(txtHouseAddress, "Адрес", 590, 60);
            CreateTextBox(txtHouseArea, "Площадь", 590, 100);
            CreateTextBox(txtHouseRooms, "Комнаты", 590, 140);
            CreateTextBox(txtHouseFloors, "Этажи", 590, 180);
            CreateTextBox(txtHouseYear, "Год постройки", 590, 220);

            // Buttons
            this.btnCreateArray.Text = "Сформировать массив";
            this.btnCreateArray.Location = new System.Drawing.Point(30, 270);
            this.btnCreateArray.Size = new System.Drawing.Size(220, 40);
            this.btnCreateArray.Click += new System.EventHandler(
                this.btnCreateArray_Click);

            this.btnOutput.Text = "Вывести данные";
            this.btnOutput.Location = new System.Drawing.Point(270, 270);
            this.btnOutput.Size = new System.Drawing.Size(180, 40);
            this.btnOutput.Click += new System.EventHandler(
                this.btnOutput_Click);

            // Output
            this.rtbOutput.Location = new System.Drawing.Point(30, 340);
            this.rtbOutput.Size = new System.Drawing.Size(820, 270);
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Font = new System.Drawing.Font("Consolas", 10F);

            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblPlane);
            this.Controls.Add(this.lblHouse);

            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarCapacity);
            this.Controls.Add(this.txtCarYear);

            this.Controls.Add(this.txtPlaneModel);
            this.Controls.Add(this.txtPlaneCapacity);
            this.Controls.Add(this.txtPlaneEngines);

            this.Controls.Add(this.txtHouseAddress);
            this.Controls.Add(this.txtHouseArea);
            this.Controls.Add(this.txtHouseRooms);
            this.Controls.Add(this.txtHouseFloors);
            this.Controls.Add(this.txtHouseYear);

            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.rtbOutput);

            this.ResumeLayout(false);
        }

        private void CreateTextBox(
            System.Windows.Forms.TextBox textBox,
            string placeholder,
            int x,
            int y)
        {
            textBox.Location = new System.Drawing.Point(x, y);
            textBox.Size = new System.Drawing.Size(220, 25);
            textBox.Text = placeholder;
            this.Controls.Add(textBox);
        }
    }
}