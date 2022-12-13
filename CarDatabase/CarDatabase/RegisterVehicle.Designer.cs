
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
            this.manufacturerIdTextbox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.registerVehicleButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelYearTextbox = new System.Windows.Forms.TextBox();
            this.modelYearLabel = new System.Windows.Forms.Label();
            this.showRegisterForm = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // manufacturerIdTextbox
            // 
            this.manufacturerIdTextbox.Location = new System.Drawing.Point(250, 46);
            this.manufacturerIdTextbox.Name = "manufacturerIdTextbox";
            this.manufacturerIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.manufacturerIdTextbox.TabIndex = 40;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.modelYearLabel);
            this.groupBox.Controls.Add(this.modelYearTextbox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.manufacturerIdTextbox);
            this.groupBox.Controls.Add(this.id);
            this.groupBox.Controls.Add(this.nameTextbox);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Location = new System.Drawing.Point(155, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(633, 74);
            this.groupBox.TabIndex = 65;
            this.groupBox.TabStop = false;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(-3, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(51, 15);
            this.id.TabIndex = 66;
            this.id.Text = "車両ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 15);
            this.nameLabel.TabIndex = 39;
            this.nameLabel.Text = "車両ID";
            // 
            // registerVehicleButton
            // 
            this.registerVehicleButton.Location = new System.Drawing.Point(12, 12);
            this.registerVehicleButton.Name = "registerVehicleButton";
            this.registerVehicleButton.Size = new System.Drawing.Size(130, 93);
            this.registerVehicleButton.TabIndex = 63;
            this.registerVehicleButton.Text = "車両情報登録";
            this.registerVehicleButton.UseVisualStyleBackColor = true;
            this.registerVehicleButton.Click += new System.EventHandler(this.registerVehicleButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(10, 46);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(234, 22);
            this.nameTextbox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "メーカーID";
            // 
            // modelYearTextbox
            // 
            this.modelYearTextbox.Location = new System.Drawing.Point(356, 46);
            this.modelYearTextbox.Name = "modelYearTextbox";
            this.modelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.modelYearTextbox.TabIndex = 69;
            // 
            // modelYearLabel
            // 
            this.modelYearLabel.AutoSize = true;
            this.modelYearLabel.Location = new System.Drawing.Point(353, 28);
            this.modelYearLabel.Name = "modelYearLabel";
            this.modelYearLabel.Size = new System.Drawing.Size(37, 15);
            this.modelYearLabel.TabIndex = 70;
            this.modelYearLabel.Text = "年式";
            // 
            // showRegisterForm
            // 
            this.showRegisterForm.Location = new System.Drawing.Point(658, 345);
            this.showRegisterForm.Name = "showRegisterForm";
            this.showRegisterForm.Size = new System.Drawing.Size(130, 93);
            this.showRegisterForm.TabIndex = 66;
            this.showRegisterForm.Text = "削除画面へ";
            this.showRegisterForm.UseVisualStyleBackColor = true;
            this.showRegisterForm.Click += new System.EventHandler(this.showRegisterForm_Click);
            // 
            // RegisterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showRegisterForm);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.registerVehicleButton);
            this.Name = "RegisterVehicle";
            this.Text = "RegisterVehicle";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox manufacturerIdTextbox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button registerVehicleButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modelYearLabel;
        private System.Windows.Forms.TextBox modelYearTextbox;
        private System.Windows.Forms.Button showRegisterForm;
    }
}