namespace WinUi
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.body = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.body.ColumnCount = 1;
            this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.body.Location = new System.Drawing.Point(0, 0);
            this.body.Name = "body";
            this.body.RowCount = 1;
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.body.Size = new System.Drawing.Size(784, 411);
            this.body.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.body);
            this.MinimumSize = new System.Drawing.Size(400, 225);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TableLayoutPanel body;

        #endregion
    }
}