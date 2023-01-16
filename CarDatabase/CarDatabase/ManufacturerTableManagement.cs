using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarDatabase
{
    public partial class ManufacturerTableManagement : Form
    {
        // 表示されていない時はtrueになる
        private bool closing = false;

        /// <summary>
        /// 最初に実行される処理
        /// </summary>
        public ManufacturerTableManagement()
        {
            // フォーム表示処理
            InitializeComponent();
        }

        /// <summary>
        /// トップ画面を表示する
        /// </summary>
        private void ShowTopFormButtonClick(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            Visible = false;

            // トップ画面を表示
            TopForm form = new TopForm();
            form.Show();
        }

        /// <summary>
        /// テーブル削除ボタンがクリックされたときの動作
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
                    DialogResult dialogResult = MessageBox.Show("メーカーテーブルを削除します。\n本当に削除しますか？", "テーブル削除",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    // いいえが押された場合何もしない
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

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

        /// <summary>
        /// ✕ボタンが押されたとき
        /// </summary>
        private void ManufacturerTableManagementFormClosing(object sender, FormClosingEventArgs e)
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
