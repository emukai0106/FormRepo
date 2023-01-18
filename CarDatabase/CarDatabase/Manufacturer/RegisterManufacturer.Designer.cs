
namespace CarDatabase
{
    partial class RegisterManufacturer
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
            this.RegisterManufacturerButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowTopFormButton
            // 
            this.ShowTopFormButton.Location = new System.Drawing.Point(12, 12);
            this.ShowTopFormButton.Name = "ShowTopFormButton";
            this.ShowTopFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowTopFormButton.TabIndex = 3;
            this.ShowTopFormButton.Text = "トップ画面へ";
            this.ShowTopFormButton.UseVisualStyleBackColor = true;
            this.ShowTopFormButton.Click += new System.EventHandler(this.ShowTopFormButtonClick);
            // 
            // RegisterManufacturerButton
            // 
            this.RegisterManufacturerButton.Location = new System.Drawing.Point(412, 12);
            this.RegisterManufacturerButton.Name = "RegisterManufacturerButton";
            this.RegisterManufacturerButton.Size = new System.Drawing.Size(130, 74);
            this.RegisterManufacturerButton.TabIndex = 5;
            this.RegisterManufacturerButton.Text = "メーカー情報登録";
            this.RegisterManufacturerButton.UseVisualStyleBackColor = true;
            this.RegisterManufacturerButton.Click += new System.EventHandler(this.RegisterManufacturerButtonClick);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.NameLabel);
            this.GroupBox.Controls.Add(this.NameTextbox);
            this.GroupBox.Location = new System.Drawing.Point(155, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(251, 74);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "メーカー情報";
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
            // RegisterManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.ShowTopFormButton);
            this.Controls.Add(this.RegisterManufacturerButton);
            this.Name = "RegisterManufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メーカー情報登録";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterManufacturerFormClosing);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowTopFormButton;
        private System.Windows.Forms.Button RegisterManufacturerButton;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
    }
}