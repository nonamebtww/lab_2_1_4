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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.SuspendLayout();
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCar.Location = new System.Drawing.Point(30, 20);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(194, 20);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Грузовой автомобиль";
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlane.Location = new System.Drawing.Point(310, 20);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(163, 20);
            this.lblPlane.TabIndex = 1;
            this.lblPlane.Text = "Грузовой самолёт";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHouse.Location = new System.Drawing.Point(590, 20);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(103, 20);
            this.lblHouse.TabIndex = 2;
            this.lblHouse.Text = "Жилой дом";
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(46, 81);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(100, 20);
            this.txtCarBrand.TabIndex = 3;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(46, 107);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtCarModel.TabIndex = 4;
            // 
            // txtCarCapacity
            // 
            this.txtCarCapacity.Location = new System.Drawing.Point(46, 133);
            this.txtCarCapacity.Name = "txtCarCapacity";
            this.txtCarCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtCarCapacity.TabIndex = 5;
            // 
            // txtCarYear
            // 
            this.txtCarYear.Location = new System.Drawing.Point(46, 159);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(100, 20);
            this.txtCarYear.TabIndex = 6;
            // 
            // txtPlaneModel
            // 
            this.txtPlaneModel.Location = new System.Drawing.Point(310, 81);
            this.txtPlaneModel.Name = "txtPlaneModel";
            this.txtPlaneModel.Size = new System.Drawing.Size(100, 20);
            this.txtPlaneModel.TabIndex = 7;
            // 
            // txtPlaneCapacity
            // 
            this.txtPlaneCapacity.Location = new System.Drawing.Point(310, 107);
            this.txtPlaneCapacity.Name = "txtPlaneCapacity";
            this.txtPlaneCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtPlaneCapacity.TabIndex = 8;
            // 
            // txtPlaneEngines
            // 
            this.txtPlaneEngines.Location = new System.Drawing.Point(310, 133);
            this.txtPlaneEngines.Name = "txtPlaneEngines";
            this.txtPlaneEngines.Size = new System.Drawing.Size(100, 20);
            this.txtPlaneEngines.TabIndex = 9;
            // 
            // txtHouseAddress
            // 
            this.txtHouseAddress.Location = new System.Drawing.Point(590, 81);
            this.txtHouseAddress.Name = "txtHouseAddress";
            this.txtHouseAddress.Size = new System.Drawing.Size(100, 20);
            this.txtHouseAddress.TabIndex = 10;
            // 
            // txtHouseArea
            // 
            this.txtHouseArea.Location = new System.Drawing.Point(590, 107);
            this.txtHouseArea.Name = "txtHouseArea";
            this.txtHouseArea.Size = new System.Drawing.Size(100, 20);
            this.txtHouseArea.TabIndex = 11;
            // 
            // txtHouseRooms
            // 
            this.txtHouseRooms.Location = new System.Drawing.Point(590, 133);
            this.txtHouseRooms.Name = "txtHouseRooms";
            this.txtHouseRooms.Size = new System.Drawing.Size(100, 20);
            this.txtHouseRooms.TabIndex = 12;
            // 
            // txtHouseFloors
            // 
            this.txtHouseFloors.Location = new System.Drawing.Point(590, 159);
            this.txtHouseFloors.Name = "txtHouseFloors";
            this.txtHouseFloors.Size = new System.Drawing.Size(100, 20);
            this.txtHouseFloors.TabIndex = 13;
            // 
            // txtHouseYear
            // 
            this.txtHouseYear.Location = new System.Drawing.Point(590, 185);
            this.txtHouseYear.Name = "txtHouseYear";
            this.txtHouseYear.Size = new System.Drawing.Size(100, 20);
            this.txtHouseYear.TabIndex = 14;
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(30, 270);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(220, 40);
            this.btnCreateArray.TabIndex = 15;
            this.btnCreateArray.Text = "Сформировать массив";
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(270, 270);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(180, 40);
            this.btnOutput.TabIndex = 16;
            this.btnOutput.Text = "Вывести данные";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbOutput.Location = new System.Drawing.Point(30, 340);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(663, 270);
            this.rtbOutput.TabIndex = 17;
            this.rtbOutput.Text = "";
            // 
            // lbl_task
            // 
            this.lbl_task.Location = new System.Drawing.Point(699, 340);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(189, 270);
            this.lbl_task.TabIndex = 18;
            this.lbl_task.Text = resources.GetString("lbl_task.Text");
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.lbl_task);
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
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа — Массив массивов";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
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