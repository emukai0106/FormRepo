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
    public partial class Form1 : Form
    {
        public Form1()
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

        /// <summary>
        /// createTableButtonがクリックされたとき
        /// テーブルを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTableButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("database.db"))
            {

            }

            // SQLiteConnectionの引数はstring型でコマンドを格納
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    // テーブルm_vehicleが存在しなければ作成する(CREATE TABLE IF NOT EXISTS)
                    cmd.CommandText = ("CREATE TABLE IF NOT EXISTS m_vehicle(id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL, manufacturer_id INTEGER, model_year INTEGER)");
                    cmd.ExecuteNonQuery();

                    // テーブルm_manufacturerが存在しなければ作成する(CREATE TABLE IF NOT EXISTS)
                    cmd.CommandText = ("CREATE TABLE IF NOT EXISTS m_manufacturer(id INTEGER PRIMARY KEY  AUTOINCREMENT, name TEXT NOT NULL, country TEXT)");
                    cmd.ExecuteNonQuery();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        /// <summary>
        /// registerVehicleButtonがクリックされたとき
        /// 車両情報を登録する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerVehicleButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // インサート
                    cmd.CommandText = "INSERT INTO m_vehicle (name, manufacturer_id, model_year) VALUES (@Name, @ManufactureId, @ModelYear)";

                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("ManufactureId", System.Data.DbType.Int64);
                    cmd.Parameters.Add("ModelYear", System.Data.DbType.Int64);


                    // 現状nullを処理できないため対処が必要

                    // データ追加
                    cmd.Parameters["Name"].Value = GetDbString(registerVehicleNameTextbox.Text);
                    cmd.Parameters["ManufactureId"].Value = int.Parse(GetDbString(registerVehicleManufactureIdTextbox.Text));
                    cmd.Parameters["ModelYear"].Value = int.Parse(GetDbString(registerVehicleModelYearTextbox.Text));
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        /// <summary>
        /// deleteTableButtonがクリックされたとき
        /// テーブルを削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // テーブルm_vehicleが存在すれば削除
                    cmd.CommandText = "DROP TABLE IF EXISTS m_vehicle";
                    cmd.ExecuteNonQuery();

                    // テーブルm_vehicleが存在すれば削除
                    cmd.CommandText = "DROP TABLE IF EXISTS m_manufacture";
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        private void updateVehicleButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート
                    cmd.CommandText = "UPDATE m_vehicle SET name = @Name, manufacturer_id = @ManufactureId, model_year = @ModelYear WHERE id = @Id";

                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("ManufactureId", System.Data.DbType.Int64);
                    cmd.Parameters.Add("ModelYear", System.Data.DbType.Int64);
                    cmd.Parameters.Add("Id", System.Data.DbType.Int64);

                    // データ追加
                    cmd.Parameters["Name"].Value = GetDbString(updateVehicleNameTextbox.Text);
                    cmd.Parameters["ManufactureId"].Value = int.Parse(GetDbString(updateVehicleManufactureIdTextbox.Text));
                    cmd.Parameters["ModelYear"].Value = int.Parse(GetDbString(updateVehicleModelYearTextbox.Text));
                    cmd.Parameters["Id"].Value = int.Parse(GetDbString(updateSearchVehicleIdTextbox.Text));
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        private void viewVehicleButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // データテーブル生成
                DataTable dataTable = new DataTable();

                // 表示
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM m_vehicle", con);
                adapter.Fill(dataTable);
                vehicleDataGridView.DataSource = dataTable;
            }
        }

        private void deleteVehicleButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // ID入力欄が空白だった場合
                    if (GetDbString(deleteSearchVehicleIdTextbox.Text) == null)
                    {
                        // コマンド文字列指定
                        // 年式がMinModelYearからMaxModelYearまでを削除
                        cmd.CommandText = "DELETE FROM m_vehicle WHERE model_year BETWEEN @MinModelYear AND @MaxModelYear";

                        // パラメータ追加
                        cmd.Parameters.Add("MinModelYear", System.Data.DbType.Int64);
                        cmd.Parameters.Add("MaxModelYear", System.Data.DbType.Int64);

                        // パラメータを設定し実行
                        cmd.Parameters["MinModelYear"].Value = int.Parse(GetDbString(deleteSearchVehicleMinModelYearTextbox.Text));
                        cmd.Parameters["MaxModelYear"].Value = int.Parse(GetDbString(deleteSearchVehicleMaxModelYearTextbox.Text));
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // コマンド文字列指定
                        cmd.CommandText = "DELETE FROM m_vehicle WHERE id = @Id";

                        // パラメータ追加
                        cmd.Parameters.Add("Id", System.Data.DbType.Int64);

                        // パラメータを設定し実行
                        cmd.Parameters["Id"].Value = int.Parse(GetDbString(deleteSearchVehicleIdTextbox.Text));
                        cmd.ExecuteNonQuery();
                    }

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }
        private void GetDeleteCheckBoxChecked()
        {
            //削除用検索のチェックボックスを全項目チェックする
        }

        private void showForm1Button_Click(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            this.Visible = false;

            // Form2を表示
            Form2 f2 = new Form2();
            f2.Show();
        }
    }    
}
