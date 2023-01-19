using System.Data;
using System.Windows.Forms;

namespace CarDatabase
{
    public partial class DeletePopUp : Form
    {
        public DeletePopUp()
        {
            InitializeComponent();
        }

        public void PopUpSql(DataTable dataTable)
        {
            // グリッドビューにデータを表示
            deleteVehicleDataGridView.DataSource = dataTable;
        }
    }
}
