using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarDatabase
{
    public partial class RegisterManufacturer : Form
    {
        // 表示されていない時はtrueになる
        private bool closing = false;

        /// <summary>
        /// 文字列がnullか空白ならnullを返す
        /// </summary>
        /// <param name="data">文字列</param>
        /// <returns>空白チェックを行った文字列</returns>
        private string ConvertString(String data)
        {
            // 文字列が空白かnullならnullを返す
            if (String.IsNullOrEmpty(data))
            {
                return null;
            }
            // 文字列が入力されていた場合
            else
            {
                // dataをそのまま返す
                return String.Format("{0}", data);
            }
        }

        /// <summary>
        /// 最初に実行される処理
        /// </summary>
        public RegisterManufacturer()
        {
            // フォーム表示処理
            InitializeComponent();
        }

        /// <summary>
        /// メーカー情報登録ボタンが押されたときの動作
        /// </summary>
        private void RegisterManufacturerButtonClick(object sender, EventArgs e)
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

                    // メーカー名を取得
                    string nameString = ConvertString(NameTextbox.Text);


                    // メーカー名が未入力だった場合
                    if (nameString == null)
                    {
                        // エラー通知ダイアログ表示
                        MessageBox.Show("メーカー名が入力されていません。", "未入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // パラメータ追加
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("DateTime", DbType.String);

                    // パラメータを設定
                    cmd.Parameters["Name"].Value = nameString;
                    cmd.Parameters["DateTime"].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                    // 既存データ検索コマンド文を設定
                    cmd.CommandText = "SELECT * FROM m_manufacturer WHERE name LIKE '%' || @Name || '%'";

                    // 検索結果の件数(int64型のためlong)が1以上の場合
                    if (cmd.ExecuteScalar() != null && (long)cmd.ExecuteScalar() >= 1)
                    {
                        // ロールバック
                        trans.Rollback();

                        // コネクションを閉じる
                        con.Close();

                        // エラーメッセージを表示
                        MessageBox.Show("そのメーカーはすでに登録されています。\nメーカー名を変更してください。", "データ重複",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // 以降の処理は行わない
                        return;
                    }

                    // データ追加コマンド文を設定
                    cmd.CommandText = "INSERT INTO m_manufacturer (name, date_time) VALUES (@Name, @DateTime)";

                    try
                    {
                        // SQL実行
                        cmd.ExecuteNonQuery();

                        // コミット
                        trans.Commit();

                        // コネクションを閉じる
                        con.Close();

                        // メッセージを表示
                        MessageBox.Show("メーカー情報の登録に成功しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // SQLの実行に失敗した場合
                    catch (SQLiteException)
                    {
                        // ロールバック
                        trans.Rollback();

                        // コネクションを閉じる
                        con.Close();

                        // エラーメッセージを表示
                        MessageBox.Show("メーカー情報の登録に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                }
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
        private void RegisterManufacturerFormClosing(object sender, FormClosingEventArgs e)
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
