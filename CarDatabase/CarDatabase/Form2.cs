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

namespace CarDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 文字列がnullか空白ならnullを返す
        /// </summary>
        /// <param name="data">対象となる文字列</param>
        /// <returns></returns>
        private string GetDbString(String data)
        {
            // 文字列が空白かnullならnullを返す
            if (String.IsNullOrEmpty(data))
            {
                return null;
            }
            else
            {
                // {0}にdataを代入して返す
                return String.Format("{0}", data);
            }

        }

        private void showForm1Button_Click(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            this.Visible = false;

            // Form1を表示
            Form1 f1 = new Form1();
            f1.Show();
        }
        /// <summary>
        /// createManufactureTableButtonがクリックされたとき
        /// テーブルを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createManufacturerTableButton_Click(object sender, EventArgs e)
        {
            // SQLiteConnectionの引数はstring型でコマンドを格納
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    // テーブルm_manufacturerが存在しなければ作成する(CREATE TABLE IF NOT EXISTS)
                    cmd.CommandText = ("CREATE TABLE IF NOT EXISTS m_manufacturer(id INTEGER PRIMARY KEY  AUTOINCREMENT, name TEXT NOT NULL, country TEXT)");
                    cmd.ExecuteNonQuery();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        /// <summary>
        /// deleteManufacturerTableButtonがクリックされたとき
        /// テーブルを削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteManufacturerTableButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // テーブルm_vehicleが存在すれば削除
                    cmd.CommandText = "DROP TABLE IF EXISTS m_manufacturer";
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        private void registerManufacturerButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // インサート
                    cmd.CommandText = "INSERT INTO m_manufacturer (name, country) VALUES (@Name, @Country)";

                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("Country", System.Data.DbType.String);


                    // 現状nullを処理できないため対処が必要

                    // データ追加
                    cmd.Parameters["Name"].Value = GetDbString(registerManufacturerNameTextbox.Text);
                    cmd.Parameters["Country"].Value = GetDbString(registerManufacturerCountryTextbox.Text);
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }
    }
}
