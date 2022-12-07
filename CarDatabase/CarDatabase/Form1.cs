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

        //private string selectComandText = "SELECT * FROM m_vehicle WHERE ";

        //private string countComandText = "SELECT COUNT (*) FROM m_vehicle WHERE ";

        //private string deleteComandText = "DELETE FROM m_vehicle WHERE ";
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
        /// createVehicleTableButtonがクリックされたとき
        /// テーブルを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTableButton_Click(object sender, EventArgs e)
        {
            // SQLiteConnectionの引数はstring型でコマンドを格納
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    // テーブルm_vehicleが存在しなければ作成する(CREATE TABLE IF NOT EXISTS)
                    cmd.CommandText = ("CREATE TABLE IF NOT EXISTS m_vehicle(id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL, " +
                        "manufacturer_id INTEGER, model_year INTEGER, date_time TEXT NOT NULL)");
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
                    cmd.CommandText = "INSERT INTO m_vehicle (name, manufacturer_id, model_year, date_time) VALUES (@Name, @ManufacturerId, @ModelYear, " +
                        "@DateTime)";

                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("ManufacturerId", System.Data.DbType.Int64);
                    cmd.Parameters.Add("ModelYear", System.Data.DbType.Int64);


                    // 現状nullを処理できないため対処が必要

                    // データ追加
                    cmd.Parameters["Name"].Value = GetDbString(registerVehicleNameTextbox.Text);
                    cmd.Parameters["ManufacturerId"].Value = int.Parse(GetDbString(registerVehicleManufacturerIdTextbox.Text));
                    cmd.Parameters["ModelYear"].Value = int.Parse(GetDbString(registerVehicleModelYearTextbox.Text));
                    cmd.Parameters["DateTime"].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        /// <summary>
        /// deleteVehicleTableButtonがクリックされたとき
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
                    cmd.CommandText = "UPDATE m_vehicle SET name = @Name, manufacturer_id = @ManufacturerId, model_year = @ModelYear, " +
                        "date_time = CURRENT_TIMESTAMP WHERE id = @Id";

                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("ManufacturerId", System.Data.DbType.Int64);
                    cmd.Parameters.Add("ModelYear", System.Data.DbType.Int64);
                    cmd.Parameters.Add("Id", System.Data.DbType.Int64);

                    // データ追加
                    cmd.Parameters["Name"].Value = GetDbString(updateVehicleNameTextbox.Text);
                    cmd.Parameters["ManufacturerId"].Value = int.Parse(GetDbString(updateVehicleManufacturerIdTextbox.Text));
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
                // メーカーIDが入力されていればm_manufacturerを参照して結合(V = m_vehicle, M = m_manufacturer)
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT V.ID AS '車両ID', V.name AS '車両名', M.name AS 'メーカー名', " +
                    "V.model_year AS '年式' ,V.date_time AS '更新日時' FROM m_vehicle AS V LEFT OUTER JOIN m_manufacturer AS M ON V.manufacturer_id = M.ID", con);
                adapter.Fill(dataTable);
                vehicleDataGridView.DataSource = dataTable;
            }
        }

        private void ShowDeleteFormButton_Click(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            this.Visible = false;

            // Form2を表示
            Form3 f2 = new Form3();
            f2.Show();
        }
    }
}
