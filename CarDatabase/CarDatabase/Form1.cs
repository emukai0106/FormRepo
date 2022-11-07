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
        /// createTableButtonがクリックされたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTableButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("database.db"))
            {

            }

            // SQLiteConnectionの引数はstring型でコマンドを格納
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    // テーブルm_vehicleが存在しなければ作成する(CREATE TABLE IF NOT EXISTS)
                    command.CommandText = ("CREATE TABLE IF NOT EXISTS m_vehicle(ID INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, manufacturer_id INTEGER, model_year INTEGER)");
                    command.ExecuteNonQuery();

                    // テーブルm_manufacturerが存在しなければ作成する(CREATE TABLE IF NOT EXISTS)
                    command.CommandText = ("CREATE TABLE IF NOT EXISTS m_manufacturer(ID INTEGER PRIMARY KEY  AUTOINCREMENT, name TEXT, country TEXT)");
                    command.ExecuteNonQuery();
                }
                // コネクションを閉じる
                connection.Close();
            }
        }
    }
}
