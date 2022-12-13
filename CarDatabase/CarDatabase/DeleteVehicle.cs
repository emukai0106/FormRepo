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
    public partial class DeleteVehicle : Form
    {
        // SELECT文用コマンド
        private string selectComandText = "SELECT * FROM m_vehicle";

        // 件数取得用コマンド
        private string countComandText = "SELECT COUNT (*) FROM m_vehicle";

        //DELETE文用コマンド
        private string deleteComandText = "DELETE FROM m_vehicle";

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
            // 文字列が入力されていた場合
            else
            {
                // dataをそのまま返す
                return String.Format("{0}", data);
            }
        }

        public DeleteVehicle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 車両情報削除ボタンが押されたときの動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteVehicleButton_Click(object sender, EventArgs e)
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

                    // 下限値文字列初期化
                    string min = "";

                    // 上限値文字列初期化
                    string max = "";

                    // 名前検索文字列初期化
                    string name = "";

                    #region 車両ID検索

                    // 上限・下限取得
                    min = ConvertString(minIdTextbox.Text);
                    max = ConvertString(maxIdTextbox.Text);

                    // 上限・下限どちらか片方でも入力されている場合
                    if (min != null || max != null)
                    {
                        // 上限が未入力の場合
                        if (ConvertString(maxIdTextbox.Text) == null)
                        {
                            // 車両IDが下限以上のものを指定
                            commandText = commandText + "id >= @MinId AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinId", System.Data.DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(min);
                        }
                        // 下限が未入力の場合
                        else if (min == null)
                        {
                            // 車両IDが上限以下ものを指定
                            commandText = commandText + "id <= @MaxId AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MaxId", System.Data.DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MaxId"].Value = int.Parse(max);
                        }

                        // 上限・下限ともに入力されている場合
                        else
                        {
                            // 車両IDが下限から上限までのものを指定
                            commandText = commandText + "id BETWEEN @MinId AND @MaxId AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinId", System.Data.DbType.Int64);
                            cmd.Parameters.Add("MaxId", System.Data.DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(min);
                            cmd.Parameters["MaxId"].Value = int.Parse(max);
                        }
                    }
                    #endregion

                    #region 年式検索

                    // 上限・下限取得
                    min = ConvertString(minModelYearTextbox.Text);
                    max = ConvertString(maxModelYearTextbox.Text);

                    // 上限・下限どちらか片方でも入力されている場合
                    if (min != null || max != null)
                    {
                        // 上限が未入力の場合
                        if (max == null)
                        {
                            // 年式が下限以上のものを指定
                            commandText = commandText + "model_year >= @MinModelYear AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinModelYear", System.Data.DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinModelYear"].Value = int.Parse(min);
                        }

                        // 下限が未入力の場合
                        else if (min == null)
                        {
                            // 年式が上限以下のものを指定
                            commandText = commandText + "model_year <= @MaxModelYear AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MaxModelYear", System.Data.DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MaxModelYear"].Value = int.Parse(max);
                        }

                        // 上限、下限ともに入力されている場合
                        else
                        {
                            // 年式が下限から上限までのものを指定
                            commandText = commandText + "model_year BETWEEN @MinModelYear AND @MaxModelYear AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinModelYear", System.Data.DbType.Int64);
                            cmd.Parameters.Add("MaxModelYear", System.Data.DbType.Int64);

                            // パラメータを設定
                            cmd.Parameters["MinModelYear"].Value = int.Parse(min);
                            cmd.Parameters["MaxModelYear"].Value = int.Parse(max);
                        }
                    }
                    #endregion

                    #region 名前検索

                    // 車両名を取得
                    name = ConvertString(nameTextbox.Text);

                    // 車両名が入力されている場合
                    if (name != null)
                    {
                        // 車両名が一致するものを指定
                        commandText = commandText + "name LIKE '%' || @Name || '%' AND ";

                        // パラメータ追加
                        cmd.Parameters.Add("Name", System.Data.DbType.String);


                        // パラメータを設定
                        cmd.Parameters["Name"].Value = name;
                    }
                    #endregion

                    #region メーカーID検索

                    // メーカーIDにチェックされていた時
                    if (manufacturerIdRadioButton.Checked)
                    {
                        // 上限・下限取得
                        min = ConvertString(minManufacturerIdTextBox.Text);
                        max = ConvertString(maxManufacturerIdTextBox.Text);

                        // 上限・下限どちらか片方でも入力されている場合
                        if (min != null || max != null)
                        {
                            // 上限が未入力の場合
                            if (max == null)
                            {
                                // メーカーIDが下限以上のものを指定
                                commandText = commandText + "manufacturer_id >= @MinManufacturerId AND ";

                                // パラメータ追加
                                cmd.Parameters.Add("MinManufacturerId", System.Data.DbType.Int64);

                                // パラメータを設定
                                cmd.Parameters["MinManufacturerId"].Value = int.Parse(min);
                            }

                            // 下限が未入力の場合
                            else if (min == null)
                            {
                                // メーカーIDが上限以下のものを指定
                                commandText = commandText + "manufacturer_id <= @MaxModelYear AND ";

                                // パラメータ追加
                                cmd.Parameters.Add("MaxManufacturerId", System.Data.DbType.Int64);

                                // パラメータを設定
                                cmd.Parameters["MaxManufacturerId"].Value = int.Parse(max);
                            }

                            // 上限・下限ともに入力されている場合
                            else
                            {
                                // メーカーIDがmin以上max以下のものを指定
                                commandText = commandText + "manufacturer_id BETWEEN @MinManufacturerId AND @MaxManufacturerId AND ";

                                // パラメータ追加
                                cmd.Parameters.Add("MinManufacturerId", System.Data.DbType.Int64);
                                cmd.Parameters.Add("MaxManufacturerId", System.Data.DbType.Int64);

                                // パラメータを設定
                                cmd.Parameters["MinManufacturerId"].Value = int.Parse(min);
                                cmd.Parameters["MaxManufacturerId"].Value = int.Parse(max);
                            }
                        }
                    }
                    #endregion

                    #region メーカー名検索

                    //メーカー名にチェックされていた時
                    else
                    {
                        // メーカー名を取得
                        name = ConvertString(manufacturerNameTextbox.Text);

                        // メーカー名が入力されている場合
                        if (name != null)
                        {
                            // メーカー名が一致するデータのメーカーIDをm_manufacturerから取得して指定
                            commandText = commandText + "manufacturer_id IN (SELECT id FROM m_manufacturer WHERE name LIKE '%' || @ManufacturerName || '%')";

                            // パラメータ追加
                            cmd.Parameters.Add("ManufacturerName", System.Data.DbType.String);

                            // パラメータを設定
                            cmd.Parameters["ManufacturerName"].Value = name;
                        }
                    }

                    #endregion

                    #region 更新日時検索

                    // 上限・下限取得
                    min = ConvertString(minDateTimeTextbox.Text);
                    max = ConvertString(maxDateTimeTextbox.Text);

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
                            if (DateTime.TryParse(min, out minDateTime))
                            {
                                // 文字列を日付型に変換(Parse)→文字列型に再変換(ToString)
                                min = minDateTime.ToString("yyyy/MM/dd HH:mm:ss");

                                // 更新日時が下限以上のものを指定
                                commandText = commandText + "date_time >= @MinDateTime AND ";

                                // パラメータ追加
                                cmd.Parameters.Add("MinDateTime", System.Data.DbType.String);

                                // パラメータを設定
                                cmd.Parameters["MinDateTime"].Value = min;
                            }
                            // minをDataTimeに変換できなかった場合
                            else
                            {
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
                            if (DateTime.TryParse(max, out maxDateTime))
                            {
                                // 文字列を日付型に変換(Parse)→文字列型に再変換(ToString)
                                max = maxDateTime.ToString("yyyy/MM/dd HH:mm:ss");

                                // 更新日時が上限以下のものを指定
                                commandText = commandText + "date_time <= @MaxDateTime AND ";

                                // パラメータ追加
                                cmd.Parameters.Add("MaxDateTime", System.Data.DbType.String);

                                // パラメータを設定
                                cmd.Parameters["MaxDateTime"].Value = max;
                            }
                            // maxをDataTimeに変換できなかった場合
                            else
                            {
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
                            min = DateTime.Parse(min).ToString("yyyy/MM/dd HH:mm:ss");
                            max = DateTime.Parse(max).ToString("yyyy/MM/dd HH:mm:ss");

                            // IDがMinIdからMaxIdまでを削除
                            commandText = commandText + "date_time BETWEEN @MinDateTime AND @MaxDateTime AND ";

                            // パラメータ追加
                            cmd.Parameters.Add("MinDateTime", System.Data.DbType.String);
                            cmd.Parameters.Add("MaxDateTime", System.Data.DbType.String);

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
                    // DialogResult
                    DialogResult dialogResult;

                    // 件数取得用コマンド文字列を結合
                    cmd.CommandText = countComandText + commandText;

                    MessageBox.Show(cmd.CommandText);

                    // 検索結果の件数(int64型のためlong)が0の場合
                    if ((long)cmd.ExecuteScalar() == 0)
                    {
                        // NoResultPopUpを表示し、入力結果をdialogResultに格納
                        NoResultPopUp noResultPopUp = new NoResultPopUp();
                        dialogResult = noResultPopUp.ShowDialog();

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
                    PopUp1 popUp1 = new PopUp1();

                    // ポップアップのDataSourceを指定
                    popUp1.PopUpSql(dataTable);

                    // ポップアップを表示し、DialogResultを設定
                    dialogResult = popUp1.ShowDialog();

                    // キャンセルが押された場合は何もせずreturn
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }

                    // 削除用コマンド文字列を結合
                    cmd.CommandText = deleteComandText + commandText;

                    // SQL実行
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }

        /// <summary>
        /// 車両登録画面を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showRegisterForm_Click(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            this.Visible = false;

            // 登録画面を表示
            RegisterVehicle form = new RegisterVehicle();
            form.Show();
        }
    }
}
