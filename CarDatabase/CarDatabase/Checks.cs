using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDatabase
{
    public partial class Checks
    {
        /// <summary>
        /// 削除時検索用フラグ
        /// </summary>
        public class DeleteChecks
        {
            public bool manufactureIdRadioCheck = false;// メーカーID検索
        }
        public DeleteChecks deleteChecks = new DeleteChecks();

        /// <summary>
        /// 一覧時検索用フラグ
        /// </summary>
        public class ViewChecks
        {
            public bool id = false;// ID検索
            public bool name = false;// 車両名検索
            public bool manufacture = true;// メーカー検索
            public bool manufactureIdRadioCheck = false;// メーカーID検索
            public bool manufactureName = false;// メーカー名検索
            public bool modelYear = false;// 年式検索
            public bool horsePower = false;// 馬力検索
            public bool length = false;// 全長検索
            public bool width = false;// 全幅検索
            public bool dateTime = false;// 更新日時検索
        }
        public ViewChecks viewChecks = new ViewChecks();
    }
}
