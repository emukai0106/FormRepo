
namespace CarDatabase
{
    partial class DeleteManufacturer
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
            this.ShowTopFormButton = new System.Windows.Forms.Button();
            this.DateTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.DateTimeWaveLabel = new System.Windows.Forms.Label();
            this.MaxDateTimeTextbox = new System.Windows.Forms.TextBox();
            this.MinDateTimeLabel = new System.Windows.Forms.Label();
            this.MinDateTimeTextbox = new System.Windows.Forms.TextBox();
            this.MaxDateTimeLabel = new System.Windows.Forms.Label();
            this.IdGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxIdTextbox = new System.Windows.Forms.TextBox();
            this.MinIdTextbox = new System.Windows.Forms.TextBox();
            this.IdWaveLabel = new System.Windows.Forms.Label();
            this.MaxIdLabel = new System.Windows.Forms.Label();
            this.MinIdLabel = new System.Windows.Forms.Label();
            this.DeleteManufacturerButton = new System.Windows.Forms.Button();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.DateTimeGroupBox.SuspendLayout();
            this.IdGroupBox.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowTopFormButton
            // 
            this.ShowTopFormButton.Location = new System.Drawing.Point(12, 12);
            this.ShowTopFormButton.Name = "ShowTopFormButton";
            this.ShowTopFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowTopFormButton.TabIndex = 0;
            this.ShowTopFormButton.Text = "トップ画面へ";
            this.ShowTopFormButton.UseVisualStyleBackColor = true;
            this.ShowTopFormButton.Click += new System.EventHandler(this.ShowTopFormButtonClick);
            // 
            // DateTimeGroupBox
            // 
            this.DateTimeGroupBox.Controls.Add(this.DateTimeWaveLabel);
            this.DateTimeGroupBox.Controls.Add(this.MaxDateTimeTextbox);
            this.DateTimeGroupBox.Controls.Add(this.MinDateTimeLabel);
            this.DateTimeGroupBox.Controls.Add(this.MinDateTimeTextbox);
            this.DateTimeGroupBox.Controls.Add(this.MaxDateTimeLabel);
            this.DateTimeGroupBox.Location = new System.Drawing.Point(412, 12);
            this.DateTimeGroupBox.Name = "DateTimeGroupBox";
            this.DateTimeGroupBox.Size = new System.Drawing.Size(251, 74);
            this.DateTimeGroupBox.TabIndex = 2;
            this.DateTimeGroupBox.TabStop = false;
            this.DateTimeGroupBox.Text = "更新日時";
            // 
            // DateTimeWaveLabel
            // 
            this.DateTimeWaveLabel.AutoSize = true;
            this.DateTimeWaveLabel.Location = new System.Drawing.Point(117, 49);
            this.DateTimeWaveLabel.Name = "DateTimeWaveLabel";
            this.DateTimeWaveLabel.Size = new System.Drawing.Size(22, 15);
            this.DateTimeWaveLabel.TabIndex = 2;
            this.DateTimeWaveLabel.Text = "～";
            // 
            // MaxDateTimeTextbox
            // 
            this.MaxDateTimeTextbox.Location = new System.Drawing.Point(145, 46);
            this.MaxDateTimeTextbox.Name = "MaxDateTimeTextbox";
            this.MaxDateTimeTextbox.Size = new System.Drawing.Size(100, 22);
            this.MaxDateTimeTextbox.TabIndex = 4;
            // 
            // MinDateTimeLabel
            // 
            this.MinDateTimeLabel.AutoSize = true;
            this.MinDateTimeLabel.Location = new System.Drawing.Point(8, 28);
            this.MinDateTimeLabel.Name = "MinDateTimeLabel";
            this.MinDateTimeLabel.Size = new System.Drawing.Size(37, 15);
            this.MinDateTimeLabel.TabIndex = 0;
            this.MinDateTimeLabel.Text = "下限";
            // 
            // MinDateTimeTextbox
            // 
            this.MinDateTimeTextbox.Location = new System.Drawing.Point(11, 46);
            this.MinDateTimeTextbox.Name = "MinDateTimeTextbox";
            this.MinDateTimeTextbox.Size = new System.Drawing.Size(100, 22);
            this.MinDateTimeTextbox.TabIndex = 1;
            // 
            // MaxDateTimeLabel
            // 
            this.MaxDateTimeLabel.AutoSize = true;
            this.MaxDateTimeLabel.Location = new System.Drawing.Point(142, 28);
            this.MaxDateTimeLabel.Name = "MaxDateTimeLabel";
            this.MaxDateTimeLabel.Size = new System.Drawing.Size(37, 15);
            this.MaxDateTimeLabel.TabIndex = 3;
            this.MaxDateTimeLabel.Text = "上限";
            // 
            // IdGroupBox
            // 
            this.IdGroupBox.Controls.Add(this.MaxIdTextbox);
            this.IdGroupBox.Controls.Add(this.MinIdTextbox);
            this.IdGroupBox.Controls.Add(this.IdWaveLabel);
            this.IdGroupBox.Controls.Add(this.MaxIdLabel);
            this.IdGroupBox.Controls.Add(this.MinIdLabel);
            this.IdGroupBox.Location = new System.Drawing.Point(155, 12);
            this.IdGroupBox.Name = "IdGroupBox";
            this.IdGroupBox.Size = new System.Drawing.Size(251, 74);
            this.IdGroupBox.TabIndex = 1;
            this.IdGroupBox.TabStop = false;
            this.IdGroupBox.Text = "メーカーID";
            // 
            // MaxIdTextbox
            // 
            this.MaxIdTextbox.Location = new System.Drawing.Point(144, 46);
            this.MaxIdTextbox.Name = "MaxIdTextbox";
            this.MaxIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.MaxIdTextbox.TabIndex = 4;
            // 
            // MinIdTextbox
            // 
            this.MinIdTextbox.Location = new System.Drawing.Point(10, 46);
            this.MinIdTextbox.Name = "MinIdTextbox";
            this.MinIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.MinIdTextbox.TabIndex = 1;
            // 
            // IdWaveLabel
            // 
            this.IdWaveLabel.AutoSize = true;
            this.IdWaveLabel.Location = new System.Drawing.Point(116, 49);
            this.IdWaveLabel.Name = "IdWaveLabel";
            this.IdWaveLabel.Size = new System.Drawing.Size(22, 15);
            this.IdWaveLabel.TabIndex = 2;
            this.IdWaveLabel.Text = "～";
            // 
            // MaxIdLabel
            // 
            this.MaxIdLabel.AutoSize = true;
            this.MaxIdLabel.Location = new System.Drawing.Point(7, 28);
            this.MaxIdLabel.Name = "MaxIdLabel";
            this.MaxIdLabel.Size = new System.Drawing.Size(37, 15);
            this.MaxIdLabel.TabIndex = 0;
            this.MaxIdLabel.Text = "下限";
            // 
            // MinIdLabel
            // 
            this.MinIdLabel.AutoSize = true;
            this.MinIdLabel.Location = new System.Drawing.Point(141, 28);
            this.MinIdLabel.Name = "MinIdLabel";
            this.MinIdLabel.Size = new System.Drawing.Size(37, 15);
            this.MinIdLabel.TabIndex = 3;
            this.MinIdLabel.Text = "上限";
            // 
            // DeleteManufacturerButton
            // 
            this.DeleteManufacturerButton.Location = new System.Drawing.Point(533, 92);
            this.DeleteManufacturerButton.Name = "DeleteManufacturerButton";
            this.DeleteManufacturerButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteManufacturerButton.Size = new System.Drawing.Size(130, 74);
            this.DeleteManufacturerButton.TabIndex = 4;
            this.DeleteManufacturerButton.Text = "メーカー情報削除";
            this.DeleteManufacturerButton.UseVisualStyleBackColor = true;
            this.DeleteManufacturerButton.Click += new System.EventHandler(this.DeleteManufacturerButtonClick);
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameLabel);
            this.NameGroupBox.Controls.Add(this.NameTextbox);
            this.NameGroupBox.Location = new System.Drawing.Point(155, 92);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(251, 74);
            this.NameGroupBox.TabIndex = 3;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "メーカー名";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(8, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(67, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "メーカー名";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(11, 46);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(234, 22);
            this.NameTextbox.TabIndex = 1;
            // 
            // DeleteManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.ShowTopFormButton);
            this.Controls.Add(this.DateTimeGroupBox);
            this.Controls.Add(this.IdGroupBox);
            this.Controls.Add(this.DeleteManufacturerButton);
            this.Name = "DeleteManufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メーカー情報削除";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteManufacturerFormClosing);
            this.DateTimeGroupBox.ResumeLayout(false);
            this.DateTimeGroupBox.PerformLayout();
            this.IdGroupBox.ResumeLayout(false);
            this.IdGroupBox.PerformLayout();
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShowTopFormButton;
        private System.Windows.Forms.GroupBox DateTimeGroupBox;
        private System.Windows.Forms.Label DateTimeWaveLabel;
        private System.Windows.Forms.TextBox MaxDateTimeTextbox;
        private System.Windows.Forms.Label MinDateTimeLabel;
        private System.Windows.Forms.TextBox MinDateTimeTextbox;
        private System.Windows.Forms.Label MaxDateTimeLabel;
        private System.Windows.Forms.GroupBox IdGroupBox;
        private System.Windows.Forms.TextBox MaxIdTextbox;
        private System.Windows.Forms.TextBox MinIdTextbox;
        private System.Windows.Forms.Label IdWaveLabel;
        private System.Windows.Forms.Label MaxIdLabel;
        private System.Windows.Forms.Label MinIdLabel;
        private System.Windows.Forms.Button DeleteManufacturerButton;
        private System.Windows.Forms.GroupBox NameGroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
    }
}