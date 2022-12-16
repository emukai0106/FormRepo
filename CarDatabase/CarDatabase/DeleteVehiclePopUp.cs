using System;
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
    public partial class DeleteVehiclePopUp : Form
    {
        public DeleteVehiclePopUp()
        {
            InitializeComponent();
        }

        public void PopUpSql(DataTable dataTable)
        {
            deleteVehicleDataGridView.DataSource = dataTable;
        }
    }
}
