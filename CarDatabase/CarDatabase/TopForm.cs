using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarDatabase
{
    public partial class TopForm : Form
    {
        // 表示されていない時はtrueになる
        private bool closing = false;

        /// <summary>
        /// 最初に実行される処理
        /// </summary>
        public TopForm()
        {
            // フォーム表示処理
            InitializeComponent();
        }

        // 車両情報テーブルの存在をチェック
        private bool CheckVehicleTableExist()
        {
            // database.dbを使用
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    // コマンド定義
                    SQLiteCommand cmd = con.CreateCommand();

                    // コマンド文を設定
                    cmd.CommandText = "SELECT * FROM m_vehicle";

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
                        MessageBox.Show("メーカー情報テーブルが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // falseを返す
                        return false;
                    }

                    // trueを返す
                    return true;
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        // メーカー情報テーブルの存在をチェック
        private bool CheckManufacturerTableExist()
        {
            // database.dbを使用
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    // コマンド定義
                    SQLiteCommand cmd = con.CreateCommand();

                    // コマンド文を設定
                    cmd.CommandText = "SELECT * FROM m_manufacturer";

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
                        MessageBox.Show("メーカー情報テーブルが存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // falseを返す
                        return false;
                    }

                    // trueを返す
                    return true;
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        /// <summary>
        /// 車両情報テーブル管理画面を表示する
        /// </summary>
        private void ShowVehicleTableFormButtonClick(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // 車両情報テーブル管理画面を表示
            VehicleTableManagement form = new VehicleTableManagement();
            form.Show();
        }

        /// <summary>
        /// 車両情報検索画面を表示する
        /// </summary>
        private void ShowSearchVehicleFormButtonClick(object sender, EventArgs e)
        {
            // 車両情報テーブルの存在をチェック
            if (!CheckVehicleTableExist())
            {
                return;
            }

            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // 車両情報登録画面を表示
            SearchVehicle form = new SearchVehicle();
            form.Show();
        }


        /// <summary>
        /// 車両情報登録画面を表示する
        /// </summary>
        private void ShowRegisterVehicleFormButtonClick(object sender, EventArgs e)
        {
            // 車両情報テーブルの存在をチェック
            if (!CheckVehicleTableExist())
            {
                return;
            }

            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // 車両情報登録画面を表示
            RegisterVehicle form = new RegisterVehicle();
            form.Show();
        }

        /// <summary>
        /// 車両情報削除画面を表示する
        /// </summary>
        private void ShowDeleteVehicleFormButtonClick(object sender, EventArgs e)
        {
            // 車両情報テーブルの存在をチェック
            if (!CheckVehicleTableExist())
            {
                return;
            }

            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // 車両情報削除画面を表示
            DeleteVehicle form = new DeleteVehicle();
            form.Show();
        }


        /// <summary>
        /// メーカー情報テーブル管理画面を表示する
        /// </summary>
        private void ShowManufacturerTableFormButtonClick(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // メーカー情報テーブル管理画面を表示
            ManufacturerTableManagement form = new ManufacturerTableManagement();
            form.Show();
        }

        /// <summary>
        /// メーカー情報検索画面を表示する
        /// </summary>
        private void ShowSearchManufacturerFormButton_Click(object sender, EventArgs e)
        {
            // メーカー情報テーブルの存在をチェック
            if (!CheckManufacturerTableExist())
            {
                return;
            }

            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // メーカー情報検索画面を表示
            SearchManufacturer form = new SearchManufacturer();
            form.Show();
        }

        /// <summary>
        /// メーカー情報登録画面を表示する
        /// </summary>
        private void ShowRegisterManufacturerFormButtonClick(object sender, EventArgs e)
        {
            // メーカー情報テーブルの存在をチェック
            if (!CheckManufacturerTableExist())
            {
                return;
            }

            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // メーカー情報登録画面を表示
            RegisterManufacturer form = new RegisterManufacturer();
            form.Show();
        }

        /// <summary>
        /// メーカー情報削除画面を表示する
        /// </summary>
        private void ShowDeleteManufacturerFormButtonClick(object sender, EventArgs e)
        {
            // メーカー情報テーブルの存在をチェック
            if (!CheckManufacturerTableExist())
            {
                return;
            }

            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // メーカー情報削除画面を表示
            DeleteManufacturer form = new DeleteManufacturer();
            form.Show();
        }

        /// <summary>
        /// ✕ボタンが押されたとき
        /// </summary>
        private void TopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // すでに非表示なら何もしない
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
