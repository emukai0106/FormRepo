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
            public bool id = false;
            public bool name = false;
            public bool manufactureId = false;
            public bool manufactureName = false;
            public bool modelYear = false;
            public bool horsePower = false;
            public bool torque = false;
            public bool length = false;
            public bool width = false;
        }
        public DeleteChecks deleteChecks = new DeleteChecks();

        /// <summary>
        /// 一覧時検索用フラグ
        /// </summary>
        public class ViewChecks
        {
            public bool id = false;
            public bool name = false;
            public bool manufactureId = false;
            public bool manufactureName = false;
            public bool modelYear = false;
            public bool horsePower = false;
            public bool torque = false;
            public bool length = false;
            public bool width = false;
        }
        public ViewChecks viewChecks = new ViewChecks();
    }
}
