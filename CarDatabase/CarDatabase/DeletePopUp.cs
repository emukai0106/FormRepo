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
            deleteVehicleDataGridView.DataSource = dataTable;
        }
    }
}
