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
    public partial class RegisterVehicle : Form
    {
        public RegisterVehicle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 文字列がnullか空白ならnullを返す
        /// </summary>
        /// <param name="data">対象となる文字列</param>
        /// <returns></returns>
        private string ConvertString(String data)
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
                    // コマンド定義
                    SQLiteCommand cmd = con.CreateCommand();

                    // 名前入力文字列初期化
                    string name = "";

                    name = ConvertString(nameTextbox.Text);
                    if (name == null)
                    {
                        // エラー通知ダイアログ表示
                        MessageBox.Show("車両名が入力されていません。", "未入力エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // インサート
                    cmd.CommandText = "INSERT INTO m_vehicle (name, manufacturer_id, model_year, date_time) VALUES (@Name, @ManufacturerId, @ModelYear, " +
                        "@DateTime)";

                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);
                    cmd.Parameters.Add("ManufacturerId", System.Data.DbType.Int64);
                    cmd.Parameters.Add("ModelYear", System.Data.DbType.Int64);
                    cmd.Parameters.Add("DateTime", System.Data.DbType.String);

                    // データ追加
                    cmd.Parameters["Name"].Value = name;
                    cmd.Parameters["ManufacturerId"].Value = int.Parse(ConvertString(manufacturerIdTextbox.Text));
                    cmd.Parameters["ModelYear"].Value = int.Parse(ConvertString(modelYearTextbox.Text));
                    cmd.Parameters["DateTime"].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                    MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        private void showRegisterForm_Click(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            this.Visible = false;

            // 登録画面を表示
            DeleteVehicle form = new DeleteVehicle();
            form.Show();
        }
    }
}
