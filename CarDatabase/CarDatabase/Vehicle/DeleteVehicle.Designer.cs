
namespace CarDatabase
{
    partial class DeleteVehicle
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
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.MinIdLabel = new System.Windows.Forms.Label();
            this.MaxIdTextbox = new System.Windows.Forms.TextBox();
            this.maxModelYearLabel = new System.Windows.Forms.Label();
            this.MaxModelYearTextbox = new System.Windows.Forms.TextBox();
            this.minModelYearLabel = new System.Windows.Forms.Label();
            this.MinModelYearTextbox = new System.Windows.Forms.TextBox();
            this.MaxIdLabel = new System.Windows.Forms.Label();
            this.MinIdTextbox = new System.Windows.Forms.TextBox();
            this.DeleteVehicleButton = new System.Windows.Forms.Button();
            this.MaxDateTimeLabel = new System.Windows.Forms.Label();
            this.MaxDateTimeTextbox = new System.Windows.Forms.TextBox();
            this.MinDateTimeLabel = new System.Windows.Forms.Label();
            this.MinDateTimeTextbox = new System.Windows.Forms.TextBox();
            this.IdGroupBox = new System.Windows.Forms.GroupBox();
            this.IdWaveLabel = new System.Windows.Forms.Label();
            this.ModelYearGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelYearWaveLabel = new System.Windows.Forms.Label();
            this.DateTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.DateTimeWaveLabel = new System.Windows.Forms.Label();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ShowTopFormButton = new System.Windows.Forms.Button();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.IdGroupBox.SuspendLayout();
            this.ModelYearGroupBox.SuspendLayout();
            this.DateTimeGroupBox.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(11, 46);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(234, 22);
            this.NameTextbox.TabIndex = 1;
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
            // MaxIdTextbox
            // 
            this.MaxIdTextbox.Location = new System.Drawing.Point(144, 46);
            this.MaxIdTextbox.Name = "MaxIdTextbox";
            this.MaxIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.MaxIdTextbox.TabIndex = 4;
            this.MaxIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnlyKeyHundle);
            // 
            // maxModelYearLabel
            // 
            this.maxModelYearLabel.AutoSize = true;
            this.maxModelYearLabel.Location = new System.Drawing.Point(141, 28);
            this.maxModelYearLabel.Name = "maxModelYearLabel";
            this.maxModelYearLabel.Size = new System.Drawing.Size(37, 15);
            this.maxModelYearLabel.TabIndex = 3;
            this.maxModelYearLabel.Text = "上限";
            // 
            // MaxModelYearTextbox
            // 
            this.MaxModelYearTextbox.Location = new System.Drawing.Point(144, 46);
            this.MaxModelYearTextbox.Name = "MaxModelYearTextbox";
            this.MaxModelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.MaxModelYearTextbox.TabIndex = 4;
            this.MaxModelYearTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnlyKeyHundle);
            // 
            // minModelYearLabel
            // 
            this.minModelYearLabel.AutoSize = true;
            this.minModelYearLabel.Location = new System.Drawing.Point(7, 28);
            this.minModelYearLabel.Name = "minModelYearLabel";
            this.minModelYearLabel.Size = new System.Drawing.Size(37, 15);
            this.minModelYearLabel.TabIndex = 0;
            this.minModelYearLabel.Text = "下限";
            // 
            // MinModelYearTextbox
            // 
            this.MinModelYearTextbox.Location = new System.Drawing.Point(10, 46);
            this.MinModelYearTextbox.Name = "MinModelYearTextbox";
            this.MinModelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.MinModelYearTextbox.TabIndex = 1;
            this.MinModelYearTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnlyKeyHundle);
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
            // MinIdTextbox
            // 
            this.MinIdTextbox.Location = new System.Drawing.Point(10, 46);
            this.MinIdTextbox.Name = "MinIdTextbox";
            this.MinIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.MinIdTextbox.TabIndex = 1;
            this.MinIdTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnlyKeyHundle);
            // 
            // DeleteVehicleButton
            // 
            this.DeleteVehicleButton.Location = new System.Drawing.Point(533, 172);
            this.DeleteVehicleButton.Name = "DeleteVehicleButton";
            this.DeleteVehicleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteVehicleButton.Size = new System.Drawing.Size(130, 74);
            this.DeleteVehicleButton.TabIndex = 6;
            this.DeleteVehicleButton.Text = "車両情報削除";
            this.DeleteVehicleButton.UseVisualStyleBackColor = true;
            this.DeleteVehicleButton.Click += new System.EventHandler(this.DeleteVehicleButtonClick);
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
            this.IdGroupBox.Text = "車両ID";
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
            // ModelYearGroupBox
            // 
            this.ModelYearGroupBox.Controls.Add(this.ModelYearWaveLabel);
            this.ModelYearGroupBox.Controls.Add(this.MinModelYearTextbox);
            this.ModelYearGroupBox.Controls.Add(this.minModelYearLabel);
            this.ModelYearGroupBox.Controls.Add(this.MaxModelYearTextbox);
            this.ModelYearGroupBox.Controls.Add(this.maxModelYearLabel);
            this.ModelYearGroupBox.Location = new System.Drawing.Point(155, 92);
            this.ModelYearGroupBox.Name = "ModelYearGroupBox";
            this.ModelYearGroupBox.Size = new System.Drawing.Size(251, 74);
            this.ModelYearGroupBox.TabIndex = 3;
            this.ModelYearGroupBox.TabStop = false;
            this.ModelYearGroupBox.Text = "年式";
            // 
            // ModelYearWaveLabel
            // 
            this.ModelYearWaveLabel.AutoSize = true;
            this.ModelYearWaveLabel.Location = new System.Drawing.Point(116, 49);
            this.ModelYearWaveLabel.Name = "ModelYearWaveLabel";
            this.ModelYearWaveLabel.Size = new System.Drawing.Size(22, 15);
            this.ModelYearWaveLabel.TabIndex = 2;
            this.ModelYearWaveLabel.Text = "～";
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
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameLabel);
            this.NameGroupBox.Controls.Add(this.NameTextbox);
            this.NameGroupBox.Location = new System.Drawing.Point(412, 92);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(251, 74);
            this.NameGroupBox.TabIndex = 4;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "車両名";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(8, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "車両名";
            // 
            // ShowTopFormButton
            // 
            this.ShowTopFormButton.Location = new System.Drawing.Point(12, 12);
            this.ShowTopFormButton.Name = "ShowTopFormButton";
            this.ShowTopFormButton.Size = new System.Drawing.Size(130, 74);
            this.ShowTopFormButton.TabIndex = 0;
            this.ShowTopFormButton.Text = "トップ画面へ";
            this.ShowTopFormButton.UseVisualStyleBackColor = true;
            this.ShowTopFormButton.Click += new System.EventHandler(this.ShowTopFormButtonClick);
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(10, 46);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(234, 23);
            this.ManufacturerComboBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ManufacturerLabel);
            this.groupBox1.Controls.Add(this.ManufacturerComboBox);
            this.groupBox1.Location = new System.Drawing.Point(155, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "メーカー名";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(8, 28);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(67, 15);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "メーカー名";
            // 
            // DeleteVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(949, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShowTopFormButton);
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.DateTimeGroupBox);
            this.Controls.Add(this.ModelYearGroupBox);
            this.Controls.Add(this.IdGroupBox);
            this.Controls.Add(this.DeleteVehicleButton);
            this.Name = "DeleteVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "車両情報削除";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteVehicleFormClosing);
            this.IdGroupBox.ResumeLayout(false);
            this.IdGroupBox.PerformLayout();
            this.ModelYearGroupBox.ResumeLayout(false);
            this.ModelYearGroupBox.PerformLayout();
            this.DateTimeGroupBox.ResumeLayout(false);
            this.DateTimeGroupBox.PerformLayout();
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label MinIdLabel;
        private System.Windows.Forms.TextBox MaxIdTextbox;
        private System.Windows.Forms.Label maxModelYearLabel;
        private System.Windows.Forms.TextBox MaxModelYearTextbox;
        private System.Windows.Forms.Label minModelYearLabel;
        private System.Windows.Forms.TextBox MinModelYearTextbox;
        private System.Windows.Forms.Label MaxIdLabel;
        private System.Windows.Forms.TextBox MinIdTextbox;
        private System.Windows.Forms.Button DeleteVehicleButton;
        private System.Windows.Forms.Label MaxDateTimeLabel;
        private System.Windows.Forms.TextBox MaxDateTimeTextbox;
        private System.Windows.Forms.Label MinDateTimeLabel;
        private System.Windows.Forms.TextBox MinDateTimeTextbox;
        private System.Windows.Forms.GroupBox IdGroupBox;
        private System.Windows.Forms.GroupBox ModelYearGroupBox;
        private System.Windows.Forms.Label IdWaveLabel;
        private System.Windows.Forms.Label ModelYearWaveLabel;
        private System.Windows.Forms.GroupBox DateTimeGroupBox;
        private System.Windows.Forms.Label DateTimeWaveLabel;
        private System.Windows.Forms.GroupBox NameGroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ShowTopFormButton;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ManufacturerLabel;
    }
}