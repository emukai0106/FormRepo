
namespace CarDatabase
{
    partial class NoResultPopUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索条件に該当するデータがありません";
            // 
            // ContinueButton
            // 
            this.ContinueButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ContinueButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ContinueButton.Location = new System.Drawing.Point(12, 71);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(236, 38);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "続行";
            this.ContinueButton.UseVisualStyleBackColor = true;
            // 
            // NoResultPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(463, 247);
            this.ControlBox = false;
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.label1);
            this.Name = "NoResultPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "検索結果なし";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContinueButton;
    }
}