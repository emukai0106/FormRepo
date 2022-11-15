
namespace CarDatabase
{
    partial class Form2
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
            this.showForm1Button = new System.Windows.Forms.Button();
            this.deleteManufacturerTableButton = new System.Windows.Forms.Button();
            this.createManufacturerTableButton = new System.Windows.Forms.Button();
            this.registerManufacturerCountryLabel = new System.Windows.Forms.Label();
            this.registerManufacturerNameLabel = new System.Windows.Forms.Label();
            this.registerManufacturerCountryTextbox = new System.Windows.Forms.TextBox();
            this.registerManufacturerNameTextbox = new System.Windows.Forms.TextBox();
            this.registerManufacturerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showForm1Button
            // 
            this.showForm1Button.Location = new System.Drawing.Point(658, 345);
            this.showForm1Button.Name = "showForm1Button";
            this.showForm1Button.Size = new System.Drawing.Size(130, 93);
            this.showForm1Button.TabIndex = 2;
            this.showForm1Button.Text = "Form1";
            this.showForm1Button.UseVisualStyleBackColor = true;
            this.showForm1Button.Click += new System.EventHandler(this.showForm1Button_Click);
            // 
            // deleteManufacturerTableButton
            // 
            this.deleteManufacturerTableButton.Location = new System.Drawing.Point(12, 111);
            this.deleteManufacturerTableButton.Name = "deleteManufacturerTableButton";
            this.deleteManufacturerTableButton.Size = new System.Drawing.Size(130, 93);
            this.deleteManufacturerTableButton.TabIndex = 14;
            this.deleteManufacturerTableButton.Text = "テーブル削除";
            this.deleteManufacturerTableButton.Click += new System.EventHandler(this.deleteManufacturerTableButton_Click);
            // 
            // createManufacturerTableButton
            // 
            this.createManufacturerTableButton.Location = new System.Drawing.Point(12, 12);
            this.createManufacturerTableButton.Name = "createManufacturerTableButton";
            this.createManufacturerTableButton.Size = new System.Drawing.Size(130, 93);
            this.createManufacturerTableButton.TabIndex = 13;
            this.createManufacturerTableButton.Text = "テーブル作成";
            this.createManufacturerTableButton.Click += new System.EventHandler(this.createManufacturerTableButton_Click);
            // 
            // registerManufacturerCountryLabel
            // 
            this.registerManufacturerCountryLabel.AutoSize = true;
            this.registerManufacturerCountryLabel.Location = new System.Drawing.Point(387, 65);
            this.registerManufacturerCountryLabel.Name = "registerManufacturerCountryLabel";
            this.registerManufacturerCountryLabel.Size = new System.Drawing.Size(22, 15);
            this.registerManufacturerCountryLabel.TabIndex = 20;
            this.registerManufacturerCountryLabel.Text = "国";
            // 
            // registerManufacturerNameLabel
            // 
            this.registerManufacturerNameLabel.AutoSize = true;
            this.registerManufacturerNameLabel.Location = new System.Drawing.Point(281, 65);
            this.registerManufacturerNameLabel.Name = "registerManufacturerNameLabel";
            this.registerManufacturerNameLabel.Size = new System.Drawing.Size(67, 15);
            this.registerManufacturerNameLabel.TabIndex = 19;
            this.registerManufacturerNameLabel.Text = "メーカー名";
            // 
            // registerManufacturerCountryTextbox
            // 
            this.registerManufacturerCountryTextbox.Location = new System.Drawing.Point(390, 83);
            this.registerManufacturerCountryTextbox.Name = "registerManufacturerCountryTextbox";
            this.registerManufacturerCountryTextbox.Size = new System.Drawing.Size(100, 22);
            this.registerManufacturerCountryTextbox.TabIndex = 17;
            // 
            // registerManufacturerNameTextbox
            // 
            this.registerManufacturerNameTextbox.Location = new System.Drawing.Point(284, 83);
            this.registerManufacturerNameTextbox.Name = "registerManufacturerNameTextbox";
            this.registerManufacturerNameTextbox.Size = new System.Drawing.Size(100, 22);
            this.registerManufacturerNameTextbox.TabIndex = 16;
            // 
            // registerManufacturerButton
            // 
            this.registerManufacturerButton.Location = new System.Drawing.Point(148, 12);
            this.registerManufacturerButton.Name = "registerManufacturerButton";
            this.registerManufacturerButton.Size = new System.Drawing.Size(130, 93);
            this.registerManufacturerButton.TabIndex = 15;
            this.registerManufacturerButton.Text = "メーカー情報登録";
            this.registerManufacturerButton.UseVisualStyleBackColor = true;
            this.registerManufacturerButton.Click += new System.EventHandler(this.registerManufacturerButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerManufacturerCountryLabel);
            this.Controls.Add(this.registerManufacturerNameLabel);
            this.Controls.Add(this.registerManufacturerCountryTextbox);
            this.Controls.Add(this.registerManufacturerNameTextbox);
            this.Controls.Add(this.registerManufacturerButton);
            this.Controls.Add(this.deleteManufacturerTableButton);
            this.Controls.Add(this.createManufacturerTableButton);
            this.Controls.Add(this.showForm1Button);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showForm1Button;
        private System.Windows.Forms.Button deleteManufacturerTableButton;
        private System.Windows.Forms.Button createManufacturerTableButton;
        private System.Windows.Forms.Label registerManufacturerCountryLabel;
        private System.Windows.Forms.Label registerManufacturerNameLabel;
        private System.Windows.Forms.TextBox registerManufacturerCountryTextbox;
        private System.Windows.Forms.TextBox registerManufacturerNameTextbox;
        private System.Windows.Forms.Button registerManufacturerButton;
    }
}