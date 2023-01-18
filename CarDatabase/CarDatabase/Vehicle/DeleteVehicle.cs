using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarDatabase
{
    public partial class DeleteVehicle : Form
    {
        // 表示されていない時はtrueになる
        private bool closing = false;

        // 車両情報テーブルSELECT文用コマンド
        private string selectComandText = "SELECT * FROM m_vehicle";

        // 件数取得用コマンド
        private string countComandText = "SELECT COUNT (*) FROM m_vehicle";

        // 車両情報テーブルDELETE文用コマンド
        private string deleteComandText = "DELETE FROM m_vehicle";

        // 下限値文字列
        string min = "";

        // 上限値文字列
        string max = "";

        // 名前検索文字列
        string nameString = "";

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
        public DeleteVehicle()
        {
            // フォーム表示処理
            InitializeComponent();

            // コンボボックスの中身を設定
            SetManufacturerComboBox();
        }

        /// <summary>
        /// メーカー名を抽出し、コンボボックスに表示する
        /// </summary>
        private void SetManufacturerComboBox()
        {
            // database.dbを使用
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // データテーブル生成
                DataTable dataTable = new DataTable();
                try
                {
                    // m_manufacturerからメーカー名を取得しdataTableに格納
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT name FROM m_manufacturer", con);
                    adapter.Fill(dataTable);

                    // コンボボックスのインデックスと表示名を指定
                    ManufacturerComboBox.ValueMember = "id";
                    ManufacturerComboBox.DisplayMember = "name";

                    // コンボボックスのDataSourceを指定
                    ManufacturerComboBox.DataSource = dataTable;

                    // 何も選択されていない状態にする
                    ManufacturerComboBox.SelectedIndex = -1;
                }

                // メーカー名を取得できなかった場合
                catch (SQLiteException)
                {
                    // 何も選択されていない状態にする
                    ManufacturerComboBox.SelectedIndex = -1;

                    // メッセージを表示
                    MessageBox.Show("メーカー名の読み込みに失敗しました。\nメーカー情報テーブルが存在しない可能性があります。", "読み込み失敗", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// 車両情報削除ボタンが押されたときの動作
        /// </summary>
        private void DeleteVehicleButtonClick(object sender, EventArgs e)
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

                    // コマンド文字列初期化
                    string commandText = " WHERE ";

                    #region 車両ID検索

                    // 上限・下限取得
                    min = ConvertString(MinIdTextbox.Text);
                    max = ConvertString(MaxIdTextbox.Text);

                    // 上限・下限どちらか片方でも入力されている場合
                    if (min != null || max != null)
                    {
                        // 上限が未入力の場合
                        if (max == null)
                        {
                            // 車両IDが下限以上のものを指定
                            commandText += "id >= @MinId AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinId", DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(min);
                        }
                        // 下限が未入力の場合
                        else if (min == null)
                        {
                            // 車両IDが上限以下ものを指定
                            commandText += "id <= @MaxId AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MaxId", DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MaxId"].Value = int.Parse(max);
                        }

                        // 上限・下限ともに入力されている場合
                        else
                        {
                            // 車両IDが下限から上限までのものを指定
                            commandText += "id BETWEEN @MinId AND @MaxId AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinId", DbType.Int64);
                            cmd.Parameters.Add("MaxId", DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(min);
                            cmd.Parameters["MaxId"].Value = int.Parse(max);
                        }
                    }
                    #endregion

                    #region 年式検索

                    // 上限・下限取得
                    min = ConvertString(MinModelYearTextbox.Text);
                    max = ConvertString(MaxModelYearTextbox.Text);

                    // 上限・下限どちらか片方でも入力されている場合
                    if (min != null || max != null)
                    {
                        // 上限が未入力の場合
                        if (max == null)
                        {
                            // 年式が下限以上のものを指定
                            commandText += "model_year >= @MinModelYear AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinModelYear", DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinModelYear"].Value = int.Parse(min);
                        }

                        // 下限が未入力の場合
                        else if (min == null)
                        {
                            // 年式が上限以下のものを指定
                            commandText += "model_year <= @MaxModelYear AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MaxModelYear", DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MaxModelYear"].Value = int.Parse(max);
                        }

                        // 上限、下限ともに入力されている場合
                        else
                        {
                            // 年式が下限から上限までのものを指定
                            commandText += "model_year BETWEEN @MinModelYear AND @MaxModelYear AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinModelYear", DbType.Int64);
                            cmd.Parameters.Add("MaxModelYear", DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinModelYear"].Value = int.Parse(min);
                            cmd.Parameters["MaxModelYear"].Value = int.Parse(max);
                        }
                    }
                    #endregion

                    #region 名前検索

                    // 車両名を取得
                    nameString = ConvertString(NameTextbox.Text);

                    // 車両名が入力されている場合
                    if (nameString != null)
                    {
                        // 車両名が一致するものを指定
                        commandText += "name LIKE '%' || @Name || '%' AND ";

                        // パラメータ追加
                        cmd.Parameters.Add("Name", DbType.String);


                        // パラメータを設定
                        cmd.Parameters["Name"].Value = nameString;
                    }
                    #endregion

                    #region メーカー名検索

                    // メーカー名を取得
                    nameString = ConvertString(ManufacturerComboBox.Text);

                    // メーカー名が入力されている場合
                    if (nameString != null)
                    {
                        // メーカー名が一致するデータのメーカーIDをm_manufacturerから取得して指定
                        commandText += "manufacturer_id IN (SELECT id FROM m_manufacturer WHERE name LIKE '%' || @ManufacturerName || '%')";

                        // パラメータ追加
                        cmd.Parameters.Add("ManufacturerName", DbType.String);

                        // パラメータを設定
                        cmd.Parameters["ManufacturerName"].Value = nameString;
                    }
                    #endregion

                    #region 更新日時検索

                    // 上限・下限取得
                    min = ConvertString(MinDateTimeTextbox.Text);
                    max = ConvertString(MaxDateTimeTextbox.Text);

                    // 上限・下限のDateTime型を定義
                    DateTime maxDateTime;
                    DateTime minDateTime;

                    // 上限・下限どちらか片方でも入力されている場合
                    if (min != null || max != null)
                    {
                        // 下限のみ入力されている場合
                        if (max == null)
                        {
                            // 下限をDataTimeに変換できた場合
                            if (System.DateTime.TryParse(min, out minDateTime))
                            {
                                // 文字列を日付型に変換(Parse)→文字列型に再変換(ToString)
                                min = minDateTime.ToString("yyyy/MM/dd HH:mm:ss");

                                // 更新日時が下限以上のものを指定
                                commandText += "date_time >= @MinDateTime AND ";

                                // パラメータ追加
                                cmd.Parameters.Add("MinDateTime", DbType.String);

                                // パラメータを設定
                                cmd.Parameters["MinDateTime"].Value = min;
                            }
                            // minをDataTimeに変換できなかった場合
                            else
                            {
                                // コネクションを閉じる
                                con.Close();

                                // エラー通知ダイアログ表示
                                MessageBox.Show("日付の入力形式が間違っています。\n入力例:2022/01/01", "入力形式エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;
                            }
                        }
                        // 上限のみ入力されている場合
                        else if (min == null)
                        {
                            // 上限をDataTimeに変換できた場合
                            if (System.DateTime.TryParse(max, out maxDateTime))
                            {
                                // 文字列を日付型に変換(Parse)→文字列型に再変換(ToString)
                                max = maxDateTime.ToString("yyyy/MM/dd HH:mm:ss");

                                // 更新日時が上限以下のものを指定
                                commandText += "date_time <= @MaxDateTime AND ";

                                // パラメータ追加
                                cmd.Parameters.Add("MaxDateTime", DbType.String);

                                // パラメータを設定
                                cmd.Parameters["MaxDateTime"].Value = max;
                            }
                            // maxをDataTimeに変換できなかった場合
                            else
                            {
                                // コネクションを閉じる
                                con.Close();

                                // エラー通知ダイアログ表示
                                MessageBox.Show("日付の入力形式が間違っています。\n入力例:2022/01/01", "入力形式エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;
                            }
                        }
                        // 上限、下限ともに入力されている場合
                        else
                        {
                            // 文字列を日付型に変換(Parse)→文字列型に再変換(ToString)
                            min = System.DateTime.Parse(min).ToString("yyyy/MM/dd HH:mm:ss");
                            max = System.DateTime.Parse(max).ToString("yyyy/MM/dd HH:mm:ss");

                            // IDがMinIdからMaxIdまでを削除
                            commandText += "date_time BETWEEN @MinDateTime AND @MaxDateTime AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinDateTime", DbType.String);
                            cmd.Parameters.Add("MaxDateTime", DbType.String);

                            // パラメータを設定
                            cmd.Parameters["MinDateTime"].Value = min;
                            cmd.Parameters["MaxDateTime"].Value = max;
                        }
                        // MaxDateTime、MinDateTimeはstring型で読み込まれるが、SQL内では日付として処理される
                    }
                    #endregion

                    // コマンドから削除する文字数
                    int removeChars;

                    // コマンドがANDで終わっていれば末尾を削除
                    if (commandText.EndsWith(" AND "))
                    {
                        //文字数を5に設定
                        removeChars = 5;

                        // commandTextの末尾を削除
                        commandText = commandText.Remove(commandText.Length - removeChars);
                    }
                    // コマンドがWHEREで終わっていれば末尾を削除
                    if (commandText.EndsWith(" WHERE "))
                    {
                        //文字数を5に設定
                        removeChars = 7;

                        // commandTextの末尾を削除
                        commandText = commandText.Remove(commandText.Length - removeChars);
                    }

                    // ポップアップの入力結果を格納する
                    DialogResult popUpResult;

                    // 件数取得用コマンド文字列を結合
                    cmd.CommandText = countComandText + commandText;

                    // 検索結果の件数(int64型のためlong)が0の場合
                    if (cmd.ExecuteScalar() != null && (long)cmd.ExecuteScalar() == 0)
                    {
                        // コネクションを閉じる
                        con.Close();

                        // メッセージを表示
                        MessageBox.Show("検索条件に該当するデータがありません。", "該当なし", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 以降の処理は行わない
                        return;
                    }

                    // データテーブル生成
                    DataTable dataTable = new DataTable();

                    // 検索用コマンド文字列を結合
                    cmd.CommandText = selectComandText + commandText;

                    // 削除確認ポップアップ用アダプターを作成
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    // 削除確認ポップアップを表示
                    DeletePopUp deletePopUp = new DeletePopUp();

                    // ポップアップのDataSourceを指定
                    deletePopUp.PopUpSql(dataTable);

                    // ポップアップを表示し、DialogResultを設定
                    popUpResult = deletePopUp.ShowDialog();

                    // キャンセルが押された場合は何もせずreturn
                    if (popUpResult == DialogResult.Cancel)
                    {
                        // コネクションを閉じる
                        con.Close();

                        return;
                    }

                    // 削除用コマンド文字列を結合
                    cmd.CommandText = deleteComandText + commandText;

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
                        MessageBox.Show("車両情報の削除に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();

                // エラーメッセージを表示
                MessageBox.Show("車両情報の削除に成功しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void DeleteVehicleFormClosing(object sender, FormClosingEventArgs e)
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
