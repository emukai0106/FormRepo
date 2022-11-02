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

        private void createTableButton_Click(object sender, EventArgs e)
        {
            // SQLiteConnectionの引数はstring型
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=database.db"))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    //テーブルm_vehicleを作成
                    command.CommandText = ("CREATE TABLE m_vehicle(ID INTEGER AUTOINCREMENT, name TEXT, manufacturer_id INTEGER, model_year INTEGER)");
                    command.ExecuteNonQuery();

                    //テーブルm_manufacturerを作成
                    //command.CommandText = ("CREATE TABLE m_manufacturer(ID INTEGER AUTOINCREMENT, name TEXT, country TEXT)");
                    //command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
