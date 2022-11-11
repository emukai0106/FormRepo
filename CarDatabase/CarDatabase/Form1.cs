﻿using System;
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
        private Checks checks = new Checks();

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
            // 削除用チェックボックスの状態を取得
            GetDeleteCheckBoxChecked();

            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    string commandText = "DELETE FROM m_vehicle WHERE ";

                    if (checks.deleteChecks.id)
                    {
                        // パラメータ追加
                        cmd.Parameters.Add("MinId", System.Data.DbType.Int64);
                        cmd.Parameters.Add("MaxId", System.Data.DbType.Int64);

                        // 上限、下限ともに未入力の場合
                        if (GetDbString(deleteSearchVehicleMinIdTextbox.Text) == null
                            & GetDbString(deleteSearchVehicleMaxIdTextbox.Text) == null)
                        {
                            // 何もしない
                            return;
                            // 本来はポップアップを表示する
                        }

                        // 下限が未入力の場合
                        else if (GetDbString(deleteSearchVehicleMinIdTextbox.Text) == null)
                        {
                            // IDがMaxId以下を削除
                            commandText = commandText + "id <= @MaxId AND ";

                            // パラメータを設定
                            cmd.Parameters["MaxId"].Value = int.Parse(GetDbString(deleteSearchVehicleMaxIdTextbox.Text));
                        }

                        // 上限が未入力の場合
                        else if (GetDbString(deleteSearchVehicleMaxIdTextbox.Text) == null)
                        {
                            // IDがMinId以上を削除
                            commandText = commandText + "id >= @MinId AND ";

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(GetDbString(deleteSearchVehicleMinIdTextbox.Text));
                        }
                        // 上限、下限ともに入力されている場合
                        else
                        {
                            // IDがMinIdからMaxIdまでを削除
                            commandText = commandText + "id BETWEEN @MinId AND @MaxId AND ";

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(GetDbString(deleteSearchVehicleMinIdTextbox.Text));
                            cmd.Parameters["MaxId"].Value = int.Parse(GetDbString(deleteSearchVehicleMaxIdTextbox.Text));
                        }
                    }

                    // 年式で検索する場合
                    if (checks.deleteChecks.modelYear)
                    {
                        // コマンド文字列指定
                        // 年式がMinModelYearからMaxModelYearまでを削除
                        commandText = commandText + "model_year BETWEEN @MinModelYear AND @MaxModelYear AND ";

                        // パラメータ追加
                        cmd.Parameters.Add("MinModelYear", System.Data.DbType.Int64);
                        cmd.Parameters.Add("MaxModelYear", System.Data.DbType.Int64);

                        // パラメータを設定
                        cmd.Parameters["MinModelYear"].Value = int.Parse(GetDbString(deleteSearchVehicleMinModelYearTextbox.Text));
                        cmd.Parameters["MaxModelYear"].Value = int.Parse(GetDbString(deleteSearchVehicleMaxModelYearTextbox.Text));
                    }

                    // コマンドがANDで終わっていれば末尾を削除
                    if (commandText.EndsWith("AND "))
                    {
                        const int REMOVE_CHARS = 4;

                        commandText = commandText.Remove(commandText.Length - REMOVE_CHARS);
                    }
                    cmd.CommandText = commandText;
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }
        /// <summary>
        /// 削除用絞り込みチェックボックスの状態確認
        /// </summary>
        private void GetDeleteCheckBoxChecked()
        {
            //削除用絞り込みチェックボックスを全項目確認する
            checks.deleteChecks.id = deleteSearchVehicleIdCheckBox.Checked;
            checks.deleteChecks.modelYear = deleteSearchVehicleModelYearCheckBox.Checked;
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
