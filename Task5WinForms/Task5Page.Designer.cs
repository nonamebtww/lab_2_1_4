namespace Task5WinForms
{
    partial class Task5Page
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task5Page));
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
            this.lbl_task = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCar, 2);
            this.lblCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCar.Location = new System.Drawing.Point(3, 59);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(294, 59);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Грузовой автомобиль";
            this.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPlane, 2);
            this.lblPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlane.Location = new System.Drawing.Point(303, 59);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(294, 59);
            this.lblPlane.TabIndex = 1;
            this.lblPlane.Text = "Грузовой самолёт";
            this.lblPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblHouse, 2);
            this.lblHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHouse.Location = new System.Drawing.Point(603, 59);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(294, 59);
            this.lblHouse.TabIndex = 2;
            this.lblHouse.Text = "Жилой дом";
            this.lblHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarBrand.Location = new System.Drawing.Point(175, 137);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(100, 20);
            this.txtCarBrand.TabIndex = 3;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarModel.Location = new System.Drawing.Point(175, 196);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtCarModel.TabIndex = 4;
            // 
            // txtCarCapacity
            // 
            this.txtCarCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarCapacity.Location = new System.Drawing.Point(175, 255);
            this.txtCarCapacity.Name = "txtCarCapacity";
            this.txtCarCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCarCapacity.TabIndex = 5;
            // 
            // txtCarYear
            // 
            this.txtCarYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarYear.Location = new System.Drawing.Point(175, 314);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(100, 20);
            this.txtCarYear.TabIndex = 6;
            // 
            // txtPlaneModel
            // 
            this.txtPlaneModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaneModel.Location = new System.Drawing.Point(475, 137);
            this.txtPlaneModel.Name = "txtPlaneModel";
            this.txtPlaneModel.Size = new System.Drawing.Size(100, 20);
            this.txtPlaneModel.TabIndex = 7;
            // 
            // txtPlaneCapacity
            // 
            this.txtPlaneCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaneCapacity.Location = new System.Drawing.Point(475, 196);
            this.txtPlaneCapacity.Name = "txtPlaneCapacity";
            this.txtPlaneCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtPlaneCapacity.TabIndex = 8;
            // 
            // txtPlaneEngines
            // 
            this.txtPlaneEngines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaneEngines.Location = new System.Drawing.Point(475, 255);
            this.txtPlaneEngines.Name = "txtPlaneEngines";
            this.txtPlaneEngines.Size = new System.Drawing.Size(100, 20);
            this.txtPlaneEngines.TabIndex = 9;
            // 
            // txtHouseAddress
            // 
            this.txtHouseAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseAddress.Location = new System.Drawing.Point(775, 137);
            this.txtHouseAddress.Name = "txtHouseAddress";
            this.txtHouseAddress.Size = new System.Drawing.Size(100, 20);
            this.txtHouseAddress.TabIndex = 10;
            // 
            // txtHouseArea
            // 
            this.txtHouseArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseArea.Location = new System.Drawing.Point(775, 196);
            this.txtHouseArea.Name = "txtHouseArea";
            this.txtHouseArea.Size = new System.Drawing.Size(100, 20);
            this.txtHouseArea.TabIndex = 11;
            // 
            // txtHouseRooms
            // 
            this.txtHouseRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseRooms.Location = new System.Drawing.Point(775, 255);
            this.txtHouseRooms.Name = "txtHouseRooms";
            this.txtHouseRooms.Size = new System.Drawing.Size(100, 20);
            this.txtHouseRooms.TabIndex = 12;
            // 
            // txtHouseFloors
            // 
            this.txtHouseFloors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseFloors.Location = new System.Drawing.Point(775, 314);
            this.txtHouseFloors.Name = "txtHouseFloors";
            this.txtHouseFloors.Size = new System.Drawing.Size(100, 20);
            this.txtHouseFloors.TabIndex = 13;
            // 
            // txtHouseYear
            // 
            this.txtHouseYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseYear.Location = new System.Drawing.Point(775, 373);
            this.txtHouseYear.Name = "txtHouseYear";
            this.txtHouseYear.Size = new System.Drawing.Size(100, 20);
            this.txtHouseYear.TabIndex = 14;
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateArray.Location = new System.Drawing.Point(3, 475);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(144, 53);
            this.btnCreateArray.TabIndex = 15;
            this.btnCreateArray.Text = "Сформировать массив";
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOutput.Location = new System.Drawing.Point(153, 475);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(144, 53);
            this.btnOutput.TabIndex = 16;
            this.btnOutput.Text = "Вывести данные";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // rtbOutput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbOutput, 3);
            this.rtbOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbOutput.Location = new System.Drawing.Point(3, 534);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.rtbOutput, 2);
            this.rtbOutput.Size = new System.Drawing.Size(441, 113);
            this.rtbOutput.TabIndex = 17;
            this.rtbOutput.Text = "";
            // 
            // lbl_task
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_task, 2);
            this.lbl_task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_task.Location = new System.Drawing.Point(603, 472);
            this.lbl_task.Name = "lbl_task";
            this.tableLayoutPanel1.SetRowSpan(this.lbl_task, 3);
            this.lbl_task.Size = new System.Drawing.Size(294, 178);
            this.lbl_task.TabIndex = 18;
            this.lbl_task.Text = resources.GetString("lbl_task.Text");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblCar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlane, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbOutput, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtHouseYear, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtHouseFloors, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtHouseRooms, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtHouseArea, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHouseAddress, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPlaneEngines, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPlaneCapacity, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPlaneModel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCarYear, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCarCapacity, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCarModel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCarBrand, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHouse, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateArray, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnOutput, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_task, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 650);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 59);
            this.label1.TabIndex = 19;
            this.label1.Text = "Бренд";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 59);
            this.label2.TabIndex = 20;
            this.label2.Text = "Модель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 59);
            this.label3.TabIndex = 21;
            this.label3.Text = "Грузоподъёмность";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 59);
            this.label4.TabIndex = 22;
            this.label4.Text = "Год выпуска";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(303, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 59);
            this.label5.TabIndex = 23;
            this.label5.Text = "Модель";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(303, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 59);
            this.label6.TabIndex = 24;
            this.label6.Text = "Грузоподъёмность";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(303, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 59);
            this.label7.TabIndex = 25;
            this.label7.Text = "Количество двигателей";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(603, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 59);
            this.label8.TabIndex = 26;
            this.label8.Text = "Адрес";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(603, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 59);
            this.label9.TabIndex = 27;
            this.label9.Text = "Площадь";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(603, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 59);
            this.label10.TabIndex = 28;
            this.label10.Text = "Комнаты";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(603, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 59);
            this.label11.TabIndex = 29;
            this.label11.Text = "Этажи";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(603, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 59);
            this.label12.TabIndex = 30;
            this.label12.Text = "Год постройки";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task5Page
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Task5Page";
            this.Size = new System.Drawing.Size(900, 650);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_task;

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