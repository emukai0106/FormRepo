using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarDatabase
{
    public partial class VehicleTableManagement : Form
    {
        // 表示されていない時はtrueになる
        private bool closing = false;

        /// <summary>
        /// 最初に実行される処理
        /// </summary>
        public VehicleTableManagement()
        {
            // フォーム表示処理
            InitializeComponent();
        }

        /// <summary>
        /// テーブル作成ボタンがクリックされたとき
        /// </summary>
        private void CreateVehicleTableButtonClick(object sender, EventArgs e)
        {
            // database.dbを使用
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();

                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    // テーブルm_vehicleを作成する
                    cmd.CommandText = ("CREATE TABLE m_vehicle(id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL, " +
                        "manufacturer_id INTEGER, model_year INTEGER, date_time TEXT NOT NULL)");

                    try
                    {
                        // SQL実行
                        cmd.ExecuteNonQuery();
                    }

                    // SQLの実行に失敗した場合
                    catch (SQLiteException)
                    {
                        // コネクションを閉じる
                        con.Close();

                        // エラーメッセージを表示
                        MessageBox.Show("テーブルの作成に失敗しました。\nテーブルがすでに存在しています。", "テーブル作成エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    // メッセージを表示
                    MessageBox.Show("テーブルの作成に成功しました。", "テーブル作成", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                // コネクションを閉じる
                con.Close();
            }
        }

        /// <summary>
        /// テーブル削除ボタンがクリックされたとき
        /// </summary>
        private void DeleteVehicleTableButtonClick(object sender, EventArgs e)
        {
            // database.dbを使用
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // 削除確認ダイアログ表示
                    DialogResult dialogResult = MessageBox.Show("車両情報テーブルを削除します。\n本当に削除しますか？", "テーブル削除",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    // いいえが押された場合何もしない
                    if (dialogResult == DialogResult.No)
                    {
                        // コネクションを閉じる
                        con.Close();

                        return;
                    }

                    // テーブルm_vehicleが存在すれば削除
                    cmd.CommandText = "DROP TABLE IF EXISTS m_vehicle";

                    try
                    {
                        // SQL実行
                        cmd.ExecuteNonQuery();
                    }

                    // SQLの実行に失敗した場合
                    catch (SQLiteException)
                    {
                        // コネクションを閉じる
                        con.Close();

                        // メッセージを表示
                        MessageBox.Show("テーブルの削除に失敗しました。", "テーブル削除エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();

                // メッセージを表示
                MessageBox.Show("テーブルの削除に成功しました。", "テーブル削除", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// トップ画面を表示する
        /// </summary>
        private void ShowTopFormButtonClick(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // トップ画面を表示
            TopForm form = new TopForm();
            form.Show();
        }

        /// <summary>
        /// ✕ボタンが押されたとき
        /// </summary>
        private void VehicleTableManagementFormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing)
            {
                return;
            }

            // 終了確認ダイアログ表示
            DialogResult dialogResult = MessageBox.Show("アプリケーションを終了します。\nよろしいですか？", "終了",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // はいが押された場合は終了
            if (dialogResult == DialogResult.Yes)
            {
                closing = true;
                Application.Exit();
            }

            //いいえが押された場合は終了しない
            else
            {
                e.Cancel = true;
            }
        }
    }
}
