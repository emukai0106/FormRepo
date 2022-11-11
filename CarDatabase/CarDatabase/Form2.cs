using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void showForm1Button_Click(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            this.Visible = false;

            // Form1を表示
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
