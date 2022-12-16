
namespace CarDatabase
{
    partial class DeleteVehiclePopUp
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.deleteVehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deleteVehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(81, 243);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 38);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // continueButton
            // 
            this.continueButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.continueButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.continueButton.Location = new System.Drawing.Point(201, 243);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(114, 38);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "続行";
            this.continueButton.UseVisualStyleBackColor = true;
            // 
            // deleteVehicleDataGridView
            // 
            this.deleteVehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteVehicleDataGridView.Location = new System.Drawing.Point(81, 101);
            this.deleteVehicleDataGridView.Name = "deleteVehicleDataGridView";
            this.deleteVehicleDataGridView.RowHeadersWidth = 51;
            this.deleteVehicleDataGridView.RowTemplate.Height = 24;
            this.deleteVehicleDataGridView.Size = new System.Drawing.Size(237, 136);
            this.deleteVehicleDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "以下のデータを削除します";
            // 
            // PopUp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteVehicleDataGridView);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "PopUp1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.deleteVehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.DataGridView deleteVehicleDataGridView;
        private System.Windows.Forms.Label label1;
    }
}