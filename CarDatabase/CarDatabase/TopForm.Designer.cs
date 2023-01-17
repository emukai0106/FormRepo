
namespace CarDatabase
{
    partial class TopForm
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
            this.ShowRegisterVehicleFormButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowSearchVehicleFormButton = new System.Windows.Forms.Button();
            this.ShowVehicleTableFormButton = new System.Windows.Forms.Button();
            this.ShowDeleteVehicleFormButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowSearchManufacturerFormButton = new System.Windows.Forms.Button();
            this.ShowDeleteManufacturerFormButton = new System.Windows.Forms.Button();
            this.ShowManufacturerTableFormButton = new System.Windows.Forms.Button();
            this.ShowRegisterManufacturerFormButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowRegisterVehicleFormButton
            // 
            this.ShowRegisterVehicleFormButton.Location = new System.Drawing.Point(6, 219);
            this.ShowRegisterVehicleFormButton.Name = "ShowRegisterVehicleFormButton";
            this.ShowRegisterVehicleFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowRegisterVehicleFormButton.TabIndex = 2;
            this.ShowRegisterVehicleFormButton.Text = "車両情報\r\n登録画面へ";
            this.ShowRegisterVehicleFormButton.UseVisualStyleBackColor = true;
            this.ShowRegisterVehicleFormButton.Click += new System.EventHandler(this.ShowRegisterVehicleFormButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowSearchVehicleFormButton);
            this.groupBox1.Controls.Add(this.ShowVehicleTableFormButton);
            this.groupBox1.Controls.Add(this.ShowDeleteVehicleFormButton);
            this.groupBox1.Controls.Add(this.ShowRegisterVehicleFormButton);
            this.groupBox1.Location = new System.Drawing.Point(309, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "車両情報テーブル管理";
            // 
            // ShowSearchVehicleFormButton
            // 
            this.ShowSearchVehicleFormButton.Location = new System.Drawing.Point(6, 120);
            this.ShowSearchVehicleFormButton.Name = "ShowSearchVehicleFormButton";
            this.ShowSearchVehicleFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowSearchVehicleFormButton.TabIndex = 1;
            this.ShowSearchVehicleFormButton.Text = "車両情報\r\n検索画面へ";
            this.ShowSearchVehicleFormButton.UseVisualStyleBackColor = true;
            this.ShowSearchVehicleFormButton.Click += new System.EventHandler(this.ShowSearchVehicleFormButtonClick);
            // 
            // ShowVehicleTableFormButton
            // 
            this.ShowVehicleTableFormButton.Location = new System.Drawing.Point(6, 21);
            this.ShowVehicleTableFormButton.Name = "ShowVehicleTableFormButton";
            this.ShowVehicleTableFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowVehicleTableFormButton.TabIndex = 0;
            this.ShowVehicleTableFormButton.Text = "テーブル\r\n作成/削除画面へ";
            this.ShowVehicleTableFormButton.UseVisualStyleBackColor = true;
            this.ShowVehicleTableFormButton.Click += new System.EventHandler(this.ShowVehicleTableFormButtonClick);
            // 
            // ShowDeleteVehicleFormButton
            // 
            this.ShowDeleteVehicleFormButton.Location = new System.Drawing.Point(6, 318);
            this.ShowDeleteVehicleFormButton.Name = "ShowDeleteVehicleFormButton";
            this.ShowDeleteVehicleFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowDeleteVehicleFormButton.TabIndex = 3;
            this.ShowDeleteVehicleFormButton.Text = "車両情報\r\n削除画面へ";
            this.ShowDeleteVehicleFormButton.UseVisualStyleBackColor = true;
            this.ShowDeleteVehicleFormButton.Click += new System.EventHandler(this.ShowDeleteVehicleFormButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowSearchManufacturerFormButton);
            this.groupBox2.Controls.Add(this.ShowDeleteManufacturerFormButton);
            this.groupBox2.Controls.Add(this.ShowManufacturerTableFormButton);
            this.groupBox2.Controls.Add(this.ShowRegisterManufacturerFormButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 423);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "メーカー情報テーブル管理";
            // 
            // ShowSearchManufacturerFormButton
            // 
            this.ShowSearchManufacturerFormButton.Location = new System.Drawing.Point(13, 119);
            this.ShowSearchManufacturerFormButton.Name = "ShowSearchManufacturerFormButton";
            this.ShowSearchManufacturerFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowSearchManufacturerFormButton.TabIndex = 1;
            this.ShowSearchManufacturerFormButton.Text = "メーカー情報\r\n検索画面へ";
            this.ShowSearchManufacturerFormButton.UseVisualStyleBackColor = true;
            this.ShowSearchManufacturerFormButton.Click += new System.EventHandler(this.ShowSearchManufacturerFormButton_Click);
            // 
            // ShowDeleteManufacturerFormButton
            // 
            this.ShowDeleteManufacturerFormButton.Location = new System.Drawing.Point(13, 317);
            this.ShowDeleteManufacturerFormButton.Name = "ShowDeleteManufacturerFormButton";
            this.ShowDeleteManufacturerFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowDeleteManufacturerFormButton.TabIndex = 3;
            this.ShowDeleteManufacturerFormButton.Text = "メーカー情報\r\n削除画面へ";
            this.ShowDeleteManufacturerFormButton.UseVisualStyleBackColor = true;
            this.ShowDeleteManufacturerFormButton.Click += new System.EventHandler(this.ShowDeleteManufacturerFormButtonClick);
            // 
            // ShowManufacturerTableFormButton
            // 
            this.ShowManufacturerTableFormButton.Location = new System.Drawing.Point(13, 20);
            this.ShowManufacturerTableFormButton.Name = "ShowManufacturerTableFormButton";
            this.ShowManufacturerTableFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowManufacturerTableFormButton.TabIndex = 0;
            this.ShowManufacturerTableFormButton.Text = "テーブル\r\n作成/削除画面へ";
            this.ShowManufacturerTableFormButton.UseVisualStyleBackColor = true;
            this.ShowManufacturerTableFormButton.Click += new System.EventHandler(this.ShowManufacturerTableFormButtonClick);
            // 
            // ShowRegisterManufacturerFormButton
            // 
            this.ShowRegisterManufacturerFormButton.Location = new System.Drawing.Point(13, 218);
            this.ShowRegisterManufacturerFormButton.Name = "ShowRegisterManufacturerFormButton";
            this.ShowRegisterManufacturerFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowRegisterManufacturerFormButton.TabIndex = 2;
            this.ShowRegisterManufacturerFormButton.Text = "メーカー情報\r\n登録画面へ";
            this.ShowRegisterManufacturerFormButton.UseVisualStyleBackColor = true;
            this.ShowRegisterManufacturerFormButton.Click += new System.EventHandler(this.ShowRegisterManufacturerFormButtonClick);
            // 
            // TopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(720, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "トップ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowRegisterVehicleFormButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ShowManufacturerTableFormButton;
        private System.Windows.Forms.Button ShowDeleteVehicleFormButton;
        private System.Windows.Forms.Button ShowVehicleTableFormButton;
        private System.Windows.Forms.Button ShowSearchVehicleFormButton;
        private System.Windows.Forms.Button ShowSearchManufacturerFormButton;
        private System.Windows.Forms.Button ShowDeleteManufacturerFormButton;
        private System.Windows.Forms.Button ShowRegisterManufacturerFormButton;
    }
}