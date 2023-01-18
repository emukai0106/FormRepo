
namespace CarDatabase
{
    partial class RegisterVehicle
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.modelYearLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelYearTextbox = new System.Windows.Forms.TextBox();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.RegisterVehicleButton = new System.Windows.Forms.Button();
            this.ShowTopFormButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.modelYearLabel);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.ModelYearTextbox);
            this.groupBox.Controls.Add(this.ManufacturerComboBox);
            this.groupBox.Controls.Add(this.NameTextbox);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Location = new System.Drawing.Point(155, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(571, 74);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "車両情報";
            // 
            // modelYearLabel
            // 
            this.modelYearLabel.AutoSize = true;
            this.modelYearLabel.Location = new System.Drawing.Point(459, 28);
            this.modelYearLabel.Name = "modelYearLabel";
            this.modelYearLabel.Size = new System.Drawing.Size(37, 15);
            this.modelYearLabel.TabIndex = 4;
            this.modelYearLabel.Text = "年式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "メーカー名";
            // 
            // ModelYearTextbox
            // 
            this.ModelYearTextbox.Location = new System.Drawing.Point(462, 45);
            this.ModelYearTextbox.Name = "ModelYearTextbox";
            this.ModelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.ModelYearTextbox.TabIndex = 5;
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Location = new System.Drawing.Point(250, 45);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(206, 23);
            this.ManufacturerComboBox.TabIndex = 3;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(10, 46);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(234, 22);
            this.NameTextbox.TabIndex = 1;
            this.NameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "車両名";
            // 
            // RegisterVehicleButton
            // 
            this.RegisterVehicleButton.Location = new System.Drawing.Point(596, 92);
            this.RegisterVehicleButton.Name = "RegisterVehicleButton";
            this.RegisterVehicleButton.Size = new System.Drawing.Size(130, 74);
            this.RegisterVehicleButton.TabIndex = 2;
            this.RegisterVehicleButton.Text = "車両情報登録";
            this.RegisterVehicleButton.UseVisualStyleBackColor = true;
            this.RegisterVehicleButton.Click += new System.EventHandler(this.RegisterVehicleButtonClick);
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
            // RegisterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowTopFormButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.RegisterVehicleButton);
            this.Name = "RegisterVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "車両情報登録";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterVehicle_FormClosing);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button RegisterVehicleButton;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modelYearLabel;
        private System.Windows.Forms.TextBox ModelYearTextbox;
        private System.Windows.Forms.Button ShowTopFormButton;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
    }
}