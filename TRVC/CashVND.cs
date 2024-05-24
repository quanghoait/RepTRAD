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
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRVC
{
    public partial class CashVND : Form
    {
        // private string _message;
        MySqlConnection conn = DBUtils.GetDBConnection();
        public CashVND()
        {
            InitializeComponent();
        }

   

        private void CashVND_Load(object sender, EventArgs e)
        {
            conn.Open();

            string request = "SELECT * FROM trvc_data.code";

            //using( MySqlCommand cmd = new MySqlCommand()
            //{

            //    reader = cmd.ExecuteReader();
            // while (reader.Read())
            // {
            // txtS_code.Text = reader["S"].ToString();
            //MessageBox.Show("" + reader["CodeGroupName"].ToString());

            //string s = reader["S_code"].ToString();
            //comboBoxGroupCode.Items.Add(reader["CodeGroupName"].ToString());
            // comboBoxCode.Items.Add(s);


            //   }
            //  }
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(request, conn);
            

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string s = reader["S_code"].ToString();
                    //comboBoxCode.Items.Add(reader["S_code"].ToString());
                    comboBoxCode.Items.Add(s);
                }
                //comboBoxCode.Items.Add(reader["S_code"].ToString());


                
            
            conn.Close();
        }
        private void comboBoxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();

            string request = "SELECT F FROM trvc_data.code where S_code= '" + comboBoxCode.Text + "' ";
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(request, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // txtS_code.Text = reader["S"].ToString();
                //MessageBox.Show("" + reader["CodeGroupName"].ToString());

                string s = reader["F"].ToString();
                //comboBoxGroupCode.Items.Add(reader["CodeGroupName"].ToString());
                //comboBoxCode.Items.Add(s);
                //txtFcode.Text = s;
                MessageBox.Show("" + s);


            }


            conn.Close();
        }
        private void textincomecashVND_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value1 = decimal.Parse(textincomecashVND.Text, System.Globalization.NumberStyles.AllowThousands);
            textincomecashVND.Text = String.Format(culture, "{0:N0}", value1);
            textincomecashVND.Select(textincomecashVND.Text.Length, 0);
        }

        private void txtPaymentCashVND_TextChanged(object sender, EventArgs e)
        {
            

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value2 = decimal.Parse(txtPaymentCashVND.Text, System.Globalization.NumberStyles.AllowThousands);
            txtPaymentCashVND.Text = String.Format(culture, "{0:N0}", value2);
            txtPaymentCashVND.Select(txtPaymentCashVND.Text.Length, 0);
            decimal SumB = decimal.Parse(txtPaymentCashVND.Text) + decimal.Parse(textincomecashVND.Text);

            txtBalance.Text = SumB.ToString();







        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value3 = decimal.Parse(txtBalance.Text, System.Globalization.NumberStyles.AllowThousands);
            txtBalance.Text = String.Format(culture, "{0:N0}", value3);
            txtBalance.Select(txtBalance.Text.Length, 0);
        }


    }
}
   


