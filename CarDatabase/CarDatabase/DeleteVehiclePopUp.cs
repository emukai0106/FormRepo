using System.Data;
using System.Windows.Forms;

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
