using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            DateTime dateTime = dateTimePickershowCashVND.Value;
            string request = "SELECT * FROM trvc_data.cashvnd where Month(DayCash) = '" + dateTime.Month + "';";
            //string request = "SELECT * FROM trvc_data.cashvnd;";
            using (MySqlCommand cmd = new MySqlCommand(request, conn))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewShowCashVND.DataSource = dataTable;
                
                conn.Close();
            }
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            //for (int i = 0; i < dataGridViewShowCashVND.Rows.Count; ++i)
            //{
            //    sum += Convert.ToInt32(dataGridViewShowCashVND.Rows[i].Cells[5].Value);
            //}
           // lbBalanceCashVND.Text = sum.ToString();
            for (int j = 0; j < dataGridViewShowCashVND.Rows.Count; ++j)
            {
                sum1 += Convert.ToInt32(dataGridViewShowCashVND.Rows[j].Cells[3].Value);
            }
            lbImcome.Text = sum1.ToString();
            for (int k = 0; k < dataGridViewShowCashVND.Rows.Count; ++k)
            {
                sum2 += Convert.ToInt32(dataGridViewShowCashVND.Rows[k].Cells[4].Value);
            }
            lbPayment.Text = sum2.ToString();
            // sum = Convert.ToInt32(dataGridViewShowCashVND.Rows[dataGridViewShowCashVND.Rows.Count - 1].Cells[5].Value);
            //lbBalanceCashVND.Text = sum.ToString();
            //  MessageBox.Show("" + dataGridViewShowCashVND.Rows.Count);
            sum = dataGridViewShowCashVND.Rows.Count -2;
            lbBalanceCashVND.Text = dataGridViewShowCashVND[5, sum].Value.ToString();
            //MessageBox.Show("" + sum);

        }

        private void dataGridViewShowCashVND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeachShowVND_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime dateTime = dateTimePickershowCashVND.Value;
            
            //string request = "SELECT * FROM trvc_data.code where S_code like '%" + txtSeachCode.Text.Trim() + "%' ";
            string request = "SELECT * FROM trvc_data.cashvnd where Month(DayCash) = '" + dateTime.Month+"';";

            MySqlCommand cmd = new MySqlCommand(request, conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewShowCashVND.DataSource = dataTable;
            conn.Close();
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            //for (int i = 0; i < dataGridViewShowCashVND.Rows.Count; ++i)
            //{
            //    sum += Convert.ToInt32(dataGridViewShowCashVND.Rows[i].Cells[5].Value);
            //}
            //lbBalanceCashVND.Text = sum.ToString();
            for (int j = 0; j < dataGridViewShowCashVND.Rows.Count; ++j)
            {
                sum1 += Convert.ToInt32(dataGridViewShowCashVND.Rows[j].Cells[3].Value);
            }
            lbImcome.Text = sum1.ToString();
            for (int k = 0; k < dataGridViewShowCashVND.Rows.Count; ++k)
            {
                sum2 += Convert.ToInt32(dataGridViewShowCashVND.Rows[k].Cells[4].Value);
            }
            lbPayment.Text = sum2.ToString();

            // sum =  Convert.ToInt32(dataGridViewShowCashVND.Rows[dataGridViewShowCashVND.Rows.Count-1].Cells[5].Value);
            // lbBalanceCashVND.Text = sum.ToString();
            //MessageBox.Show("" + sum);
            sum = dataGridViewShowCashVND.Rows.Count - 2;
            lbBalanceCashVND.Text = dataGridViewShowCashVND[5, sum].Value.ToString();
        }

        private void btn_Balane_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
