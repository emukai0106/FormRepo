
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
            this.createTableButton = new System.Windows.Forms.Button();
            this.registerVehicleButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.registerVehicleNameTextbox = new System.Windows.Forms.TextBox();
            this.registerVehicleManufactureIdTextbox = new System.Windows.Forms.TextBox();
            this.registerVehicleModelYearTextbox = new System.Windows.Forms.TextBox();
            this.registerVehicleNameLabel = new System.Windows.Forms.Label();
            this.registerVehicleManufactureIdLabel = new System.Windows.Forms.Label();
            this.registerVehicleModelYearLabel = new System.Windows.Forms.Label();
            this.viewVehicleButton = new System.Windows.Forms.Button();
            this.deleteVehicleButton = new System.Windows.Forms.Button();
            this.updateVehicleButton = new System.Windows.Forms.Button();
            this.deleteTableButton = new System.Windows.Forms.Button();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.updateSearchVehicleIdTextbox = new System.Windows.Forms.TextBox();
            this.updateVehicleNameTextbox = new System.Windows.Forms.TextBox();
            this.updateSearchVehicleIdLabel = new System.Windows.Forms.Label();
            this.updateVehicleNameLabel = new System.Windows.Forms.Label();
            this.updateVehicleManufactureIdTextbox = new System.Windows.Forms.TextBox();
            this.updateVehicleManufactureIdLabel = new System.Windows.Forms.Label();
            this.updateVehicleModelYearTextbox = new System.Windows.Forms.TextBox();
            this.updateVehicleModelYearLabel = new System.Windows.Forms.Label();
            this.deleteSearchVehicleMinIdTextbox = new System.Windows.Forms.TextBox();
            this.deleteSearchVehicleIdLabel = new System.Windows.Forms.Label();
            this.deleteSearchVehicleMinModelYearTextbox = new System.Windows.Forms.TextBox();
            this.deleteSearchVehicleMinModelYearLabel = new System.Windows.Forms.Label();
            this.deleteSearchVehicleMaxModelYearTextbox = new System.Windows.Forms.TextBox();
            this.deleteSearchVehicleMaxModelYearLabel = new System.Windows.Forms.Label();
            this.deleteSearchVehicleIdCheckBox = new System.Windows.Forms.CheckBox();
            this.showForm1Button = new System.Windows.Forms.Button();
            this.deleteSearchVehicleModelYearCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteSearchVehicleMaxIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(12, 12);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(130, 93);
            this.createTableButton.TabIndex = 0;
            this.createTableButton.Text = "テーブル作成";
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // registerVehicleButton
            // 
            this.registerVehicleButton.Location = new System.Drawing.Point(148, 12);
            this.registerVehicleButton.Name = "registerVehicleButton";
            this.registerVehicleButton.Size = new System.Drawing.Size(130, 93);
            this.registerVehicleButton.TabIndex = 1;
            this.registerVehicleButton.Text = "車両情報登録";
            this.registerVehicleButton.UseVisualStyleBackColor = true;
            this.registerVehicleButton.Click += new System.EventHandler(this.registerVehicleButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // registerVehicleNameTextbox
            // 
            this.registerVehicleNameTextbox.Location = new System.Drawing.Point(284, 83);
            this.registerVehicleNameTextbox.Name = "registerVehicleNameTextbox";
            this.registerVehicleNameTextbox.Size = new System.Drawing.Size(100, 22);
            this.registerVehicleNameTextbox.TabIndex = 3;
            // 
            // registerVehicleManufactureIdTextbox
            // 
            this.registerVehicleManufactureIdTextbox.Location = new System.Drawing.Point(390, 83);
            this.registerVehicleManufactureIdTextbox.Name = "registerVehicleManufactureIdTextbox";
            this.registerVehicleManufactureIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.registerVehicleManufactureIdTextbox.TabIndex = 4;
            // 
            // registerVehicleModelYearTextbox
            // 
            this.registerVehicleModelYearTextbox.Location = new System.Drawing.Point(496, 83);
            this.registerVehicleModelYearTextbox.Name = "registerVehicleModelYearTextbox";
            this.registerVehicleModelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.registerVehicleModelYearTextbox.TabIndex = 5;
            // 
            // registerVehicleNameLabel
            // 
            this.registerVehicleNameLabel.AutoSize = true;
            this.registerVehicleNameLabel.Location = new System.Drawing.Point(281, 65);
            this.registerVehicleNameLabel.Name = "registerVehicleNameLabel";
            this.registerVehicleNameLabel.Size = new System.Drawing.Size(37, 15);
            this.registerVehicleNameLabel.TabIndex = 6;
            this.registerVehicleNameLabel.Text = "車名";
            // 
            // registerVehicleManufactureIdLabel
            // 
            this.registerVehicleManufactureIdLabel.AutoSize = true;
            this.registerVehicleManufactureIdLabel.Location = new System.Drawing.Point(387, 65);
            this.registerVehicleManufactureIdLabel.Name = "registerVehicleManufactureIdLabel";
            this.registerVehicleManufactureIdLabel.Size = new System.Drawing.Size(66, 15);
            this.registerVehicleManufactureIdLabel.TabIndex = 7;
            this.registerVehicleManufactureIdLabel.Text = "メーカーID";
            // 
            // registerVehicleModelYearLabel
            // 
            this.registerVehicleModelYearLabel.AutoSize = true;
            this.registerVehicleModelYearLabel.Location = new System.Drawing.Point(493, 65);
            this.registerVehicleModelYearLabel.Name = "registerVehicleModelYearLabel";
            this.registerVehicleModelYearLabel.Size = new System.Drawing.Size(37, 15);
            this.registerVehicleModelYearLabel.TabIndex = 8;
            this.registerVehicleModelYearLabel.Text = "年式";
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
            // deleteVehicleButton
            // 
            this.deleteVehicleButton.Location = new System.Drawing.Point(148, 210);
            this.deleteVehicleButton.Name = "deleteVehicleButton";
            this.deleteVehicleButton.Size = new System.Drawing.Size(130, 93);
            this.deleteVehicleButton.TabIndex = 10;
            this.deleteVehicleButton.Text = "車両情報削除";
            this.deleteVehicleButton.UseVisualStyleBackColor = true;
            this.deleteVehicleButton.Click += new System.EventHandler(this.deleteVehicleButton_Click);
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
            // deleteTableButton
            // 
            this.deleteTableButton.Location = new System.Drawing.Point(12, 111);
            this.deleteTableButton.Name = "deleteTableButton";
            this.deleteTableButton.Size = new System.Drawing.Size(130, 93);
            this.deleteTableButton.TabIndex = 12;
            this.deleteTableButton.Text = "テーブル削除";
            this.deleteTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // vehicleDataGridView
            // 
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
            this.updateVehicleNameLabel.Size = new System.Drawing.Size(37, 15);
            this.updateVehicleNameLabel.TabIndex = 17;
            this.updateVehicleNameLabel.Text = "車名";
            // 
            // updateVehicleManufactureIdTextbox
            // 
            this.updateVehicleManufactureIdTextbox.Location = new System.Drawing.Point(390, 182);
            this.updateVehicleManufactureIdTextbox.Name = "updateVehicleManufactureIdTextbox";
            this.updateVehicleManufactureIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.updateVehicleManufactureIdTextbox.TabIndex = 18;
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
            // deleteSearchVehicleMinIdTextbox
            // 
            this.deleteSearchVehicleMinIdTextbox.Location = new System.Drawing.Point(284, 238);
            this.deleteSearchVehicleMinIdTextbox.Name = "deleteSearchVehicleMinIdTextbox";
            this.deleteSearchVehicleMinIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.deleteSearchVehicleMinIdTextbox.TabIndex = 22;
            // 
            // deleteSearchVehicleIdLabel
            // 
            this.deleteSearchVehicleIdLabel.AutoSize = true;
            this.deleteSearchVehicleIdLabel.Location = new System.Drawing.Point(281, 220);
            this.deleteSearchVehicleIdLabel.Name = "deleteSearchVehicleIdLabel";
            this.deleteSearchVehicleIdLabel.Size = new System.Drawing.Size(91, 15);
            this.deleteSearchVehicleIdLabel.TabIndex = 23;
            this.deleteSearchVehicleIdLabel.Text = "車両ID(下限)";
            // 
            // deleteSearchVehicleMinModelYearTextbox
            // 
            this.deleteSearchVehicleMinModelYearTextbox.Location = new System.Drawing.Point(284, 281);
            this.deleteSearchVehicleMinModelYearTextbox.Name = "deleteSearchVehicleMinModelYearTextbox";
            this.deleteSearchVehicleMinModelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.deleteSearchVehicleMinModelYearTextbox.TabIndex = 24;
            // 
            // deleteSearchVehicleMinModelYearLabel
            // 
            this.deleteSearchVehicleMinModelYearLabel.AutoSize = true;
            this.deleteSearchVehicleMinModelYearLabel.Location = new System.Drawing.Point(284, 263);
            this.deleteSearchVehicleMinModelYearLabel.Name = "deleteSearchVehicleMinModelYearLabel";
            this.deleteSearchVehicleMinModelYearLabel.Size = new System.Drawing.Size(77, 15);
            this.deleteSearchVehicleMinModelYearLabel.TabIndex = 25;
            this.deleteSearchVehicleMinModelYearLabel.Text = "年式(下限)";
            // 
            // deleteSearchVehicleMaxModelYearTextbox
            // 
            this.deleteSearchVehicleMaxModelYearTextbox.Location = new System.Drawing.Point(390, 281);
            this.deleteSearchVehicleMaxModelYearTextbox.Name = "deleteSearchVehicleMaxModelYearTextbox";
            this.deleteSearchVehicleMaxModelYearTextbox.Size = new System.Drawing.Size(100, 22);
            this.deleteSearchVehicleMaxModelYearTextbox.TabIndex = 26;
            // 
            // deleteSearchVehicleMaxModelYearLabel
            // 
            this.deleteSearchVehicleMaxModelYearLabel.AutoSize = true;
            this.deleteSearchVehicleMaxModelYearLabel.Location = new System.Drawing.Point(387, 263);
            this.deleteSearchVehicleMaxModelYearLabel.Name = "deleteSearchVehicleMaxModelYearLabel";
            this.deleteSearchVehicleMaxModelYearLabel.Size = new System.Drawing.Size(77, 15);
            this.deleteSearchVehicleMaxModelYearLabel.TabIndex = 27;
            this.deleteSearchVehicleMaxModelYearLabel.Text = "年式(上限)";
            // 
            // deleteSearchVehicleIdCheckBox
            // 
            this.deleteSearchVehicleIdCheckBox.AutoSize = true;
            this.deleteSearchVehicleIdCheckBox.Location = new System.Drawing.Point(496, 220);
            this.deleteSearchVehicleIdCheckBox.Name = "deleteSearchVehicleIdCheckBox";
            this.deleteSearchVehicleIdCheckBox.Size = new System.Drawing.Size(139, 19);
            this.deleteSearchVehicleIdCheckBox.TabIndex = 29;
            this.deleteSearchVehicleIdCheckBox.Text = "車両IDで検索する";
            this.deleteSearchVehicleIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // showForm1Button
            // 
            this.showForm1Button.Location = new System.Drawing.Point(916, 582);
            this.showForm1Button.Name = "showForm1Button";
            this.showForm1Button.Size = new System.Drawing.Size(130, 93);
            this.showForm1Button.TabIndex = 30;
            this.showForm1Button.Text = "Form1";
            this.showForm1Button.UseVisualStyleBackColor = true;
            this.showForm1Button.Click += new System.EventHandler(this.showForm1Button_Click);
            // 
            // deleteSearchVehicleModelYearCheckBox
            // 
            this.deleteSearchVehicleModelYearCheckBox.AutoSize = true;
            this.deleteSearchVehicleModelYearCheckBox.Location = new System.Drawing.Point(496, 238);
            this.deleteSearchVehicleModelYearCheckBox.Name = "deleteSearchVehicleModelYearCheckBox";
            this.deleteSearchVehicleModelYearCheckBox.Size = new System.Drawing.Size(125, 19);
            this.deleteSearchVehicleModelYearCheckBox.TabIndex = 31;
            this.deleteSearchVehicleModelYearCheckBox.Text = "年式で検索する";
            this.deleteSearchVehicleModelYearCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteSearchVehicleMaxIdTextbox
            // 
            this.deleteSearchVehicleMaxIdTextbox.Location = new System.Drawing.Point(390, 238);
            this.deleteSearchVehicleMaxIdTextbox.Name = "deleteSearchVehicleMaxIdTextbox";
            this.deleteSearchVehicleMaxIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.deleteSearchVehicleMaxIdTextbox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "車両ID(上限)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteSearchVehicleMaxIdTextbox);
            this.Controls.Add(this.deleteSearchVehicleModelYearCheckBox);
            this.Controls.Add(this.showForm1Button);
            this.Controls.Add(this.deleteSearchVehicleIdCheckBox);
            this.Controls.Add(this.deleteSearchVehicleMaxModelYearLabel);
            this.Controls.Add(this.deleteSearchVehicleMaxModelYearTextbox);
            this.Controls.Add(this.deleteSearchVehicleMinModelYearLabel);
            this.Controls.Add(this.deleteSearchVehicleMinModelYearTextbox);
            this.Controls.Add(this.deleteSearchVehicleIdLabel);
            this.Controls.Add(this.deleteSearchVehicleMinIdTextbox);
            this.Controls.Add(this.updateVehicleModelYearLabel);
            this.Controls.Add(this.updateVehicleModelYearTextbox);
            this.Controls.Add(this.updateVehicleManufactureIdLabel);
            this.Controls.Add(this.updateVehicleManufactureIdTextbox);
            this.Controls.Add(this.updateVehicleNameLabel);
            this.Controls.Add(this.updateSearchVehicleIdLabel);
            this.Controls.Add(this.updateVehicleNameTextbox);
            this.Controls.Add(this.updateSearchVehicleIdTextbox);
            this.Controls.Add(this.vehicleDataGridView);
            this.Controls.Add(this.deleteTableButton);
            this.Controls.Add(this.updateVehicleButton);
            this.Controls.Add(this.deleteVehicleButton);
            this.Controls.Add(this.viewVehicleButton);
            this.Controls.Add(this.registerVehicleModelYearLabel);
            this.Controls.Add(this.registerVehicleManufactureIdLabel);
            this.Controls.Add(this.registerVehicleNameLabel);
            this.Controls.Add(this.registerVehicleModelYearTextbox);
            this.Controls.Add(this.registerVehicleManufactureIdTextbox);
            this.Controls.Add(this.registerVehicleNameTextbox);
            this.Controls.Add(this.registerVehicleButton);
            this.Controls.Add(this.createTableButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "車両データベース";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button registerVehicleButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox registerVehicleNameTextbox;
        private System.Windows.Forms.TextBox registerVehicleManufactureIdTextbox;
        private System.Windows.Forms.TextBox registerVehicleModelYearTextbox;
        private System.Windows.Forms.Label registerVehicleNameLabel;
        private System.Windows.Forms.Label registerVehicleManufactureIdLabel;
        private System.Windows.Forms.Label registerVehicleModelYearLabel;
        private System.Windows.Forms.Button viewVehicleButton;
        private System.Windows.Forms.Button deleteVehicleButton;
        private System.Windows.Forms.Button updateVehicleButton;
        private System.Windows.Forms.Button deleteTableButton;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.TextBox updateSearchVehicleIdTextbox;
        private System.Windows.Forms.TextBox updateVehicleNameTextbox;
        private System.Windows.Forms.Label updateSearchVehicleIdLabel;
        private System.Windows.Forms.Label updateVehicleNameLabel;
        private System.Windows.Forms.TextBox updateVehicleManufactureIdTextbox;
        private System.Windows.Forms.Label updateVehicleManufactureIdLabel;
        private System.Windows.Forms.TextBox updateVehicleModelYearTextbox;
        private System.Windows.Forms.Label updateVehicleModelYearLabel;
        private System.Windows.Forms.TextBox deleteSearchVehicleMinIdTextbox;
        private System.Windows.Forms.Label deleteSearchVehicleIdLabel;
        private System.Windows.Forms.TextBox deleteSearchVehicleMinModelYearTextbox;
        private System.Windows.Forms.Label deleteSearchVehicleMinModelYearLabel;
        private System.Windows.Forms.TextBox deleteSearchVehicleMaxModelYearTextbox;
        private System.Windows.Forms.Label deleteSearchVehicleMaxModelYearLabel;
        private System.Windows.Forms.CheckBox deleteSearchVehicleIdCheckBox;
        private System.Windows.Forms.Button showForm1Button;
        private System.Windows.Forms.CheckBox deleteSearchVehicleModelYearCheckBox;
        private System.Windows.Forms.TextBox deleteSearchVehicleMaxIdTextbox;
        private System.Windows.Forms.Label label1;
    }
}

