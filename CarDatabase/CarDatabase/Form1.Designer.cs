
namespace CarDatabase
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createVehicleTableButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewVehicleButton = new System.Windows.Forms.Button();
            this.updateVehicleButton = new System.Windows.Forms.Button();
            this.deleteVehicleTableButton = new System.Windows.Forms.Button();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.updateSearchVehicleIdTextbox = new System.Windows.Forms.TextBox();
            this.updateVehicleNameTextbox = new System.Windows.Forms.TextBox();
            this.updateSearchVehicleIdLabel = new System.Windows.Forms.Label();
            this.updateVehicleNameLabel = new System.Windows.Forms.Label();
            this.updateVehicleManufacturerIdTextbox = new System.Windows.Forms.TextBox();
            this.updateVehicleManufactureIdLabel = new System.Windows.Forms.Label();
            this.updateVehicleModelYearTextbox = new System.Windows.Forms.TextBox();
            this.updateVehicleModelYearLabel = new System.Windows.Forms.Label();
            this.ShowDeleteFormButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createVehicleTableButton
            // 
            this.createVehicleTableButton.Location = new System.Drawing.Point(12, 12);
            this.createVehicleTableButton.Name = "createVehicleTableButton";
            this.createVehicleTableButton.Size = new System.Drawing.Size(130, 93);
            this.createVehicleTableButton.TabIndex = 0;
            this.createVehicleTableButton.Text = "テーブル作成";
            this.createVehicleTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // viewVehicleButton
            // 
            this.viewVehicleButton.Location = new System.Drawing.Point(148, 309);
            this.viewVehicleButton.Name = "viewVehicleButton";
            this.viewVehicleButton.Size = new System.Drawing.Size(130, 93);
            this.viewVehicleButton.TabIndex = 9;
            this.viewVehicleButton.Text = "車両情報表示";
            this.viewVehicleButton.UseVisualStyleBackColor = true;
            this.viewVehicleButton.Click += new System.EventHandler(this.viewVehicleButton_Click);
            // 
            // updateVehicleButton
            // 
            this.updateVehicleButton.Location = new System.Drawing.Point(148, 111);
            this.updateVehicleButton.Name = "updateVehicleButton";
            this.updateVehicleButton.Size = new System.Drawing.Size(130, 93);
            this.updateVehicleButton.TabIndex = 11;
            this.updateVehicleButton.Text = "車両情報変更";
            this.updateVehicleButton.UseVisualStyleBackColor = true;
            this.updateVehicleButton.Click += new System.EventHandler(this.updateVehicleButton_Click);
            // 
            // deleteVehicleTableButton
            // 
            this.deleteVehicleTableButton.Location = new System.Drawing.Point(12, 111);
            this.deleteVehicleTableButton.Name = "deleteVehicleTableButton";
            this.deleteVehicleTableButton.Size = new System.Drawing.Size(130, 93);
            this.deleteVehicleTableButton.TabIndex = 12;
            this.deleteVehicleTableButton.Text = "テーブル削除";
            this.deleteVehicleTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Location = new System.Drawing.Point(284, 309);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.RowHeadersWidth = 51;
            this.vehicleDataGridView.RowTemplate.Height = 24;
            this.vehicleDataGridView.Size = new System.Drawing.Size(312, 192);
            this.vehicleDataGridView.TabIndex = 13;
            // 
            // updateSearchVehicleIdTextbox
            // 
            this.updateSearchVehicleIdTextbox.Location = new System.Drawing.Point(284, 139);
            this.updateSearchVehicleIdTextbox.Name = "updateSearchVehicleIdTextbox";
            this.updateSearchVehicleIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.updateSearchVehicleIdTextbox.TabIndex = 14;
            // 
            // updateVehicleNameTextbox
            // 
            this.updateVehicleNameTextbox.Location = new System.Drawing.Point(284, 182);
            this.updateVehicleNameTextbox.Name = "updateVehicleNameTextbox";
            this.updateVehicleNameTextbox.Size = new System.Drawing.Size(100, 22);
            this.updateVehicleNameTextbox.TabIndex = 15;
            // 
            // updateSearchVehicleIdLabel
            // 
            this.updateSearchVehicleIdLabel.AutoSize = true;
            this.updateSearchVehicleIdLabel.Location = new System.Drawing.Point(281, 121);
            this.updateSearchVehicleIdLabel.Name = "updateSearchVehicleIdLabel";
            this.updateSearchVehicleIdLabel.Size = new System.Drawing.Size(51, 15);
            this.updateSearchVehicleIdLabel.TabIndex = 16;
            this.updateSearchVehicleIdLabel.Text = "検索ID";
            // 
            // updateVehicleNameLabel
            // 
            this.updateVehicleNameLabel.AutoSize = true;
            this.updateVehicleNameLabel.Location = new System.Drawing.Point(281, 164);
            this.updateVehicleNameLabel.Name = "updateVehicleNameLabel";
            this.updateVehicleNameLabel.Size = new System.Drawing.Size(52, 15);
            this.updateVehicleNameLabel.TabIndex = 17;
            this.updateVehicleNameLabel.Text = "車両名";
            // 
            // updateVehicleManufacturerIdTextbox
            // 
            this.updateVehicleManufacturerIdTextbox.Location = new System.Drawing.Point(390, 182);
            this.updateVehicleManufacturerIdTextbox.Name = "updateVehicleManufacturerIdTextbox";
            this.updateVehicleManufacturerIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.updateVehicleManufacturerIdTextbox.TabIndex = 18;
            // 
            // updateVehicleManufactureIdLabel
            // 
            this.updateVehicleManufactureIdLabel.AutoSize = true;
            this.updateVehicleManufactureIdLabel.Location = new System.Drawing.Point(387, 164);
            this.updateVehicleManufactureIdLabel.Name = "updateVehicleManufactureIdLabel";
            this.updateVehicleManufactureIdLabel.Size = new System.Drawing.Size(66, 15);
            this.updateVehicleManufactureIdLabel.TabIndex = 19;
            this.updateVehicleManufactureIdLabel.Text = "メーカーID";
            // 
            // updateVehicleModelYearTextbox
            // 
            this.updateVehicleModelYearTextbox.Location = new System.Drawing.Point(496, 182);
            this.updateVehicleModelYearTextbox.Name = "updateVehicleModelYearTextbox";
            this.updateVehicleModelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.updateVehicleModelYearTextbox.TabIndex = 20;
            // 
            // updateVehicleModelYearLabel
            // 
            this.updateVehicleModelYearLabel.AutoSize = true;
            this.updateVehicleModelYearLabel.Location = new System.Drawing.Point(493, 164);
            this.updateVehicleModelYearLabel.Name = "updateVehicleModelYearLabel";
            this.updateVehicleModelYearLabel.Size = new System.Drawing.Size(37, 15);
            this.updateVehicleModelYearLabel.TabIndex = 21;
            this.updateVehicleModelYearLabel.Text = "年式";
            // 
            // ShowDeleteFormButton
            // 
            this.ShowDeleteFormButton.Location = new System.Drawing.Point(916, 408);
            this.ShowDeleteFormButton.Name = "ShowDeleteFormButton";
            this.ShowDeleteFormButton.Size = new System.Drawing.Size(130, 93);
            this.ShowDeleteFormButton.TabIndex = 30;
            this.ShowDeleteFormButton.Text = "削除画面へ";
            this.ShowDeleteFormButton.UseVisualStyleBackColor = true;
            this.ShowDeleteFormButton.Click += new System.EventHandler(this.ShowDeleteFormButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 93);
            this.button1.TabIndex = 31;
            this.button1.Text = "メーカー画面へ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(780, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 93);
            this.button2.TabIndex = 32;
            this.button2.Text = "登録画面へ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 687);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowDeleteFormButton);
            this.Controls.Add(this.updateVehicleModelYearLabel);
            this.Controls.Add(this.updateVehicleModelYearTextbox);
            this.Controls.Add(this.updateVehicleManufactureIdLabel);
            this.Controls.Add(this.updateVehicleManufacturerIdTextbox);
            this.Controls.Add(this.updateVehicleNameLabel);
            this.Controls.Add(this.updateSearchVehicleIdLabel);
            this.Controls.Add(this.updateVehicleNameTextbox);
            this.Controls.Add(this.updateSearchVehicleIdTextbox);
            this.Controls.Add(this.vehicleDataGridView);
            this.Controls.Add(this.deleteVehicleTableButton);
            this.Controls.Add(this.updateVehicleButton);
            this.Controls.Add(this.viewVehicleButton);
            this.Controls.Add(this.createVehicleTableButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "車両データベース";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createVehicleTableButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button viewVehicleButton;
        private System.Windows.Forms.Button updateVehicleButton;
        private System.Windows.Forms.Button deleteVehicleTableButton;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.TextBox updateSearchVehicleIdTextbox;
        private System.Windows.Forms.TextBox updateVehicleNameTextbox;
        private System.Windows.Forms.Label updateSearchVehicleIdLabel;
        private System.Windows.Forms.Label updateVehicleNameLabel;
        private System.Windows.Forms.TextBox updateVehicleManufacturerIdTextbox;
        private System.Windows.Forms.Label updateVehicleManufactureIdLabel;
        private System.Windows.Forms.TextBox updateVehicleModelYearTextbox;
        private System.Windows.Forms.Label updateVehicleModelYearLabel;
        private System.Windows.Forms.Button ShowDeleteFormButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

