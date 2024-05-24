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
    public partial class Code_Group : Form
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        
        
        public Code_Group()
        {
            InitializeComponent();

        }

        private void Code_Group_Load(object sender, EventArgs e)
        {
            conn.Open();
            string request = "SELECT * FROM trvc_data.codegroup;";
            using (MySqlCommand cmd = new MySqlCommand(request, conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewGroupCode.DataSource = dataTable;
            }
        }

        private void btn_code_group_Click(object sender, EventArgs e)
        {
            conn.Open();

            string request = "INSERT INTO `trvc_data`.`codegroup`(CodeGroupName) VALUES ('"+txtCode_Group.Text+"')";
            try
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery();
                
                conn.Close();
                MessageBox.Show("Added");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
