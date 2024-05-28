using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRVC
{
    public partial class ShowCashVND : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public ShowCashVND()
        {
            InitializeComponent();
        }

        private void ShowCashVND_Load(object sender, EventArgs e)
        {
            conn.Open();
            string request = "SELECT * FROM trvc_data.cashvnd;";
            using (MySqlCommand cmd = new MySqlCommand(request, conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewShowCashVND.DataSource = dataTable;
                conn.Close();
            }
        }

        private void dataGridViewShowCashVND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeachShowVND_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime dateTime = dateTimePickershowCashVND.Value;
            
            //string request = "SELECT * FROM trvc_data.code where S_code like '%" + txtSeachCode.Text.Trim() + "%' ";
            string request = "SELECT * FROM trvc_data.cashvnd where Month(DayCash) = '"+dateTime.Month+"';";

            MySqlCommand cmd = new MySqlCommand(request, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewShowCashVND.DataSource = dataTable;
            conn.Close();
            DataGridViewColumn column = new DataGridViewColumn();
            //column.

        }
    }
}
