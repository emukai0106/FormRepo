
namespace CarDatabase
{
    partial class ManufacturerTableManagement
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
            this.DeleteVehicleTableButton = new System.Windows.Forms.Button();
            this.CreateVehicleTableButton = new System.Windows.Forms.Button();
            this.ShowTopFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteVehicleTableButton
            // 
            this.DeleteVehicleTableButton.Location = new System.Drawing.Point(12, 111);
            this.DeleteVehicleTableButton.Name = "DeleteVehicleTableButton";
            this.DeleteVehicleTableButton.Size = new System.Drawing.Size(266, 93);
            this.DeleteVehicleTableButton.TabIndex = 1;
            this.DeleteVehicleTableButton.Text = "テーブル削除";
            this.DeleteVehicleTableButton.Click += new System.EventHandler(this.DeleteVehicleTableButtonClick);
            // 
            // CreateVehicleTableButton
            // 
            this.CreateVehicleTableButton.Location = new System.Drawing.Point(12, 12);
            this.CreateVehicleTableButton.Name = "CreateVehicleTableButton";
            this.CreateVehicleTableButton.Size = new System.Drawing.Size(266, 93);
            this.CreateVehicleTableButton.TabIndex = 0;
            this.CreateVehicleTableButton.Text = "テーブル作成";
            this.CreateVehicleTableButton.Click += new System.EventHandler(this.CreateVehicleTableButtonClick);
            // 
            // ShowTopFormButton
            // 
            this.ShowTopFormButton.Location = new System.Drawing.Point(284, 130);
            this.ShowTopFormButton.Name = "ShowTopFormButton";
            this.ShowTopFormButton.Size = new System.Drawing.Size(130, 74);
            this.ShowTopFormButton.TabIndex = 2;
            this.ShowTopFormButton.Text = "トップ画面へ";
            this.ShowTopFormButton.UseVisualStyleBackColor = true;
            this.ShowTopFormButton.Click += new System.EventHandler(this.ShowTopFormButtonClick);
            // 
            // ManufacturerTableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.ShowTopFormButton);
            this.Controls.Add(this.DeleteVehicleTableButton);
            this.Controls.Add(this.CreateVehicleTableButton);
            this.Name = "ManufacturerTableManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "メーカーテーブル作成/削除";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManufacturerTableManagementFormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteVehicleTableButton;
        private System.Windows.Forms.Button CreateVehicleTableButton;
        private System.Windows.Forms.Button ShowTopFormButton;
    }
}