using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRVC
{
    public partial class ShowCode : Form
    {
        private string _message;
        MySqlConnection conn = DBUtils.GetDBConnection();
        public ShowCode()
        {
            InitializeComponent();
           
        }
        //public ShowCode(string Message) : this()
        //{
        //    _message = Message;
        //    lblReceived.Text = _message;
        //}

        public void dataGridViewShowCode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Code code1 = new Code();
            

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewShowCode.Rows[e.RowIndex];
            code1.txtS_code.Text = Convert.ToString(row.Cells[1].Value);
            
            code1.txtF.Text = Convert.ToString(row.Cells[2].Value);
            code1.txtItemName.Text = Convert.ToString(row.Cells[3].Value);
            code1.txtAccountNo.Text = Convert.ToString(row.Cells[4].Value);
            code1.txtBank.Text = Convert.ToString(row.Cells[5].Value);
            code1.txtType.Text = Convert.ToString(row.Cells[6].Value);
           // code1.comboBoxGroupCode.Text = Convert.ToString(row.Cells[7].Value);
            code1.Show();
        }

        private void ShowCode_Load(object sender, EventArgs e)
        {
            conn.Open();
            string request = "SELECT * FROM trvc_data.code;";
            using (MySqlCommand cmd = new MySqlCommand(request, conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewShowCode.DataSource = dataTable;
                conn.Close();
            }
        }

        private void txtSeachCode_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string request = "SELECT * FROM trvc_data.code where S_code like '%" + txtSeachCode.Text.Trim() + "%' ";
             MySqlCommand cmd = new MySqlCommand(request, conn);
                
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
             DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewShowCode.DataSource = dataTable;
            conn.Close();
        }
    }
}
