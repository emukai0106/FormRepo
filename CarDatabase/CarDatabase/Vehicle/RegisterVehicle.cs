using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CarDatabase
{
    public partial class RegisterVehicle : Form
    {
        // 表示されていない時はtrueになる
        private bool closing = false;

        /// <summary>
        /// 最初に実行される処理
        /// </summary>
        public RegisterVehicle()
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
                }

                // エラーが発生した場合は何もしない
                catch (SQLiteException) { }


                // 何も選択されていない状態にする
                ManufacturerComboBox.SelectedIndex = -1;
            }
        }

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
        /// 車両情報登録ボタンが押されたときの動作
        /// </summary>
        private void RegisterVehicleButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=database.db"))
            {
                // コネクションを開く
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    // コマンド定義
                    SQLiteCommand cmd = con.CreateCommand();

                    // 車両名を取得
                    string nameString = ConvertString(nameTextbox.Text);

                    //メーカー名を取得
                    string manufacturer = ConvertString(ManufacturerComboBox.Text);

                    //年式を取得
                    string modelYear = ConvertString(ModelYearTextbox.Text);

                    // 車両名が未入力だった場合
                    if (nameString == null)
                    {
                        // エラー通知ダイアログ表示
                        MessageBox.Show("車両名が入力されていません。", "未入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // パラメータ追加
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("ManufacturerName", DbType.String);
                    cmd.Parameters.Add("ModelYear", DbType.Int64);
                    cmd.Parameters.Add("DateTime", DbType.String);

                    // パラメータを設定
                    cmd.Parameters["Name"].Value = nameString;
                    cmd.Parameters["ManufacturerName"].Value = manufacturer;
                    cmd.Parameters["ModelYear"].Value = modelYear;
                    cmd.Parameters["DateTime"].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                    // 既存データ検索コマンド文を設定
                    cmd.CommandText = "SELECT * FROM m_vehicle WHERE name LIKE '%' || @Name || '%'";

                    // メーカー名が入力されていた場合
                    if (manufacturer != null)
                    {
                        // 検索用コマンドにメーカーIDを追加
                        cmd.CommandText += " AND manufacturer_id IN (SELECT id FROM m_manufacturer WHERE name LIKE '%' || @ManufacturerName || '%')";
                    }

                    // 年式が入力されていた場合
                    if (modelYear != null)
                    {
                        // 検索用コマンドに年式を追加
                        cmd.CommandText += " AND model_year = @ModelYear";
                    }

                    // 検索結果の件数(int64型のためlong)が1以上の場合
                    if ((long)cmd.ExecuteScalar() >= 1)
                    {
                        // エラーメッセージを表示
                        MessageBox.Show("その車両はすでに登録されています。\n車両名、メーカー、年式のいずれかを変更してください。", "データ重複",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // 以降の処理は行わない
                        return;
                    }

                    // データ追加コマンド文を設定
                    cmd.CommandText = "INSERT INTO m_vehicle (name, manufacturer_id, model_year, date_time) VALUES " +
                        "(@Name, (SELECT id FROM m_manufacturer WHERE name LIKE '%' || @ManufacturerName || '%'), @ModelYear, @DateTime)";

                    try
                    {
                        // SQL実行
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException)
                    {

                    }

                    

                    // コミット
                    trans.Commit();
                }
                // コネクションを閉じる
                con.Close();
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
        private void RegisterVehicle_FormClosing(object sender, FormClosingEventArgs e)
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
