using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // コネクション開く→テーブル作成→コネクション閉じる
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                // con開く
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "create table t_product(CD INTEGER PRIMARY KEY AUTOINCREMENT, productname TEXT, price INTEGER)";
                    command.ExecuteNonQuery();
                }
                // con閉じる
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();// con開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "INSERT INTO t_product (productname, price) VALUES (@Product, @Price)";
                    // パラメータセット
                    cmd.Parameters.Add("Product", System.Data.DbType.String);
                    cmd.Parameters.Add("Price", System.Data.DbType.Int64);
                    // データ追加
                    cmd.Parameters["Product"].Value = textBox1.Text;
                    cmd.Parameters["Price"].Value = int.Parse(textBox2.Text);
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
                // con閉じる
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                //DataTable生成
                DataTable dataTable = new DataTable();
                //SQL実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();// con開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // アップデート
                    cmd.CommandText = "UPDATE t_product SET productname = @Product, price = @Price WHERE CD = @Cd";
                    // パラメータセット
                    cmd.Parameters.Add("Product", System.Data.DbType.String);
                    cmd.Parameters.Add("Price", System.Data.DbType.Int64);
                    cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                    // データ追加
                    cmd.Parameters["Product"].Value = textBox3.Text;
                    cmd.Parameters["Price"].Value = int.Parse(textBox4.Text);
                    cmd.Parameters["Cd"].Value = int.Parse(textBox5.Text);
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
                // con閉じる
                con.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();// con開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // デリート
                    cmd.CommandText = "DELETE FROM t_product WHERE CD = @Cd";
                    // パラメータセット
                    cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                    // データ追加
                    cmd.Parameters["Cd"].Value = int.Parse(textBox6.Text);
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
                // con閉じる
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=test.db"))
            {
                con.Open();// con開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // テーブル削除
                    cmd.CommandText = "DROP TABLE t_product";
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
                // con閉じる
                con.Close();
            }
        }
    }
}
