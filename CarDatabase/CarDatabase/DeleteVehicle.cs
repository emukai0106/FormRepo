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
        private Checks checks = new Checks();

        private string selectComandText = "SELECT * FROM m_vehicle WHERE ";

        private string countComandText = "SELECT COUNT (*) FROM m_vehicle WHERE ";

        private string deleteComandText = "DELETE FROM m_vehicle WHERE ";

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

        public DeleteVehicle()
        {
            InitializeComponent();
        }

        private void deleteVehicleButton_Click(object sender, EventArgs e)
        {
            // 削除用チェックボックスの状態を取得
            GetDeleteCheckBoxChecked();

            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                con.Open();// コネクションを開く
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    string commandText = "";

                    // IDで検索する場合
                    if (checks.deleteChecks.id)
                    {
                        string min = GetDbString(deleteSearchVehicleMinIdTextbox.Text);
                        string max = GetDbString(deleteSearchVehicleMaxIdTextbox.Text);

                        // パラメータ追加
                        cmd.Parameters.Add("MinId", System.Data.DbType.Int64);
                        cmd.Parameters.Add("MaxId", System.Data.DbType.Int64);

                        // 上限、下限ともに未入力の場合
                        if (min == null & max == null)
                        {
                            // 何もしない
                            return;
                            // 本来はポップアップを表示する
                        }

                        // 下限が未入力の場合
                        else if (min == null)
                        {
                            // IDがMaxId以下を削除
                            commandText = commandText + "id <= @MaxId AND ";

                            // パラメータを設定
                            cmd.Parameters["MaxId"].Value = int.Parse(max);
                        }

                        // 上限が未入力の場合
                        else if (GetDbString(deleteSearchVehicleMaxIdTextbox.Text) == null)
                        {
                            // IDがMinId以上を削除
                            commandText = commandText + "id >= @MinId AND ";

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(min);
                        }
                        // 上限、下限ともに入力されている場合
                        else
                        {
                            // IDがMinIdからMaxIdまでを削除
                            commandText = commandText + "id BETWEEN @MinId AND @MaxId AND ";

                            // パラメータを設定
                            cmd.Parameters["MinId"].Value = int.Parse(min);
                            cmd.Parameters["MaxId"].Value = int.Parse(max);
                        }
                    }

                    // 年式で検索する場合
                    if (checks.deleteChecks.modelYear)
                    {
                        string min = GetDbString(deleteSearchVehicleMinModelYearTextbox.Text);
                        string max = GetDbString(deleteSearchVehicleMaxModelYearTextbox.Text);

                        // パラメータ追加
                        cmd.Parameters.Add("MinModelYear", System.Data.DbType.Int64);
                        cmd.Parameters.Add("MaxModelYear", System.Data.DbType.Int64);

                        // 上限、下限ともに未入力の場合
                        if (min == null & max == null)
                        {
                            // 何もしない
                            return;
                            // 本来はポップアップを表示する
                        }

                        // 下限が未入力の場合
                        else if (min == null)
                        {
                            // IDがMaxId以下を削除
                            commandText = commandText + "model_year <= @MaxModelYear AND ";

                            // パラメータを設定
                            cmd.Parameters["MaxModelYear"].Value = int.Parse(max);
                        }

                        // 上限が未入力の場合
                        else if (max == null)
                        {
                            // IDがMinId以上を削除
                            commandText = commandText + "model_year >= @MinModelYear AND ";

                            // パラメータを設定
                            cmd.Parameters["MinModelYear"].Value = int.Parse(min);
                        }
                        // 上限、下限ともに入力されている場合
                        else
                        {
                            // IDがMinIdからMaxIdまでを削除
                            commandText = commandText + "model_year BETWEEN @MinModelYear AND @MaxModelYear AND ";

                            // パラメータを設定
                            cmd.Parameters["MinModelYear"].Value = int.Parse(min);
                            cmd.Parameters["MaxModelYear"].Value = int.Parse(max);
                        }
                    }

                    // 名前で検索する場合
                    if (checks.deleteChecks.name)
                    {
                        string name = GetDbString(deleteSearchVehicleNameTextbox.Text);

                        // パラメータ追加
                        cmd.Parameters.Add("Name", System.Data.DbType.String);

                        // 車両名が未入力の場合
                        if (name == null)
                        {
                            // 何もしない
                            return;
                            // 本来はポップアップを表示する
                        }
                        // 上限、下限ともに入力されている場合
                        else
                        {
                            // 車両名がNameに一致するものを削除
                            commandText = commandText + "name LIKE '%' || @Name || '%' AND ";

                            // パラメータを設定
                            cmd.Parameters["Name"].Value = name;
                        }
                    }
                    // コマンドがANDで終わっていれば末尾を削除
                    if (commandText.EndsWith(" AND "))
                    {
                        const int REMOVE_CHARS = 5;

                        commandText = commandText.Remove(commandText.Length - REMOVE_CHARS);
                    }
                    DialogResult dialogResult;

                    cmd.CommandText = countComandText + commandText;

                    MessageBox.Show(cmd.ExecuteScalar().GetType().ToString());

                    //検索結果の件数(int64型のためlong)が0の場合
                    if ((long)cmd.ExecuteScalar() == 0)
                    {
                        NoResultPopUp noResultPopUp = new NoResultPopUp();
                        dialogResult = noResultPopUp.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            return;
                        }
                    }


                    // データテーブル生成
                    DataTable dataTable = new DataTable();

                    // 表示
                    cmd.CommandText = selectComandText + commandText;
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    //削除確認ポップアップを表示
                    PopUp1 popUp1 = new PopUp1();

                    //ポップアップのDataSourceを指定
                    popUp1.PopUpSql(dataTable);

                    //ポップアップを表示し、DialogResultを設定
                    dialogResult = popUp1.ShowDialog();

                    //キャンセルが押された場合は何もせずreturn
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }

                    cmd.CommandText = deleteComandText + commandText;
                    cmd.ExecuteNonQuery();

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
            }
        }
        private void GetDeleteCheckBoxChecked()
        {
            //削除用絞り込みチェックボックスを全項目確認する
            checks.deleteChecks.id = deleteSearchVehicleIdCheckBox.Checked;
            checks.deleteChecks.name = deleteSearchVehicleNameCheckBox.Checked;
            checks.deleteChecks.modelYear = deleteSearchVehicleModelYearCheckBox.Checked;
        }
    }
}
