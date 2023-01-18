using System;
using System.Windows.Forms;

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

        /// <summary>
        /// 車両テーブル管理画面を表示する
        /// </summary>
        private void ShowVehicleTableFormButtonClick(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // 車両テーブル管理画面を表示
            VehicleTableManagement form = new VehicleTableManagement();
            form.Show();
        }

        /// <summary>
        /// 車両情報検索画面を表示する
        /// </summary>
        private void ShowSearchVehicleFormButtonClick(object sender, EventArgs e)
        {
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
            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // 車両情報削除画面を表示
            DeleteVehicle form = new DeleteVehicle();
            form.Show();
        }
        

        /// <summary>
        /// メーカーテーブル管理画面を表示する
        /// </summary>
        private void ShowManufacturerTableFormButtonClick(object sender, EventArgs e)
        {
            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // メーカーテーブル管理画面を表示
            ManufacturerTableManagement form = new ManufacturerTableManagement();
            form.Show();
        }

        /// <summary>
        /// メーカー情報検索画面を表示する
        /// </summary>
        private void ShowSearchManufacturerFormButton_Click(object sender, EventArgs e)
        {
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
            // 現在の画面を非表示にする
            Visible = false;
            closing = true;

            // メーカー情報登録画面を表示
            SearchManufacturer form = new SearchManufacturer();
            form.Show();
        }

        /// <summary>
        /// メーカー情報削除画面を表示する
        /// </summary>
        private void ShowDeleteManufacturerFormButtonClick(object sender, EventArgs e)
        {
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
