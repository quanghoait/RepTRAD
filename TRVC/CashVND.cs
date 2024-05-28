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
using Mysqlx.Crud;
using System.Reflection.Emit;

namespace TRVC
{
    public partial class CashVND : Form
    {
        // private string _message;
        MySqlConnection conn = DBUtils.GetDBConnection();
        public CashVND()
        {
            InitializeComponent();
            conn.Open();

            string request = "SELECT Balance FROM trvc_data.cashvnd where IDCash = (SELECT max(IDCash)  FROM trvc_data.cashvnd);";
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(request, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string s = reader["Balance"].ToString();
                txtBalaceRe.Text = s;
            }
            conn.Close();
        }


        private void CashVND_Load(object sender, EventArgs e)
        {
            conn.Open();
            string request = "SELECT * FROM trvc_data.code";
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(request, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string s = reader["S_code"].ToString();
                comboBoxCode.Items.Add(s);
            }
            conn.Close();
        }

        private void textincomecashVND_TextChanged(object sender, EventArgs e)
        {
            
            if (textincomecashVND.Text == "" ||  txtBalaceRe.Text == "")
            {
                textincomecashVND.Text = "0";
            }
            else
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value1 = decimal.Parse(textincomecashVND.Text, System.Globalization.NumberStyles.AllowThousands);
                textincomecashVND.Text = String.Format(culture, "{0:N0}", value1);
                textincomecashVND.Select(textincomecashVND.Text.Length, 0);

                decimal SumB = decimal.Parse(txtBalaceRe.Text) + decimal.Parse(textincomecashVND.Text) - decimal.Parse(txtPaymentCashVND.Text);
                txtBalance.Text = SumB.ToString();
            }


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
                string s = reader["F"].ToString();
                txtFcode.Text = s;
            }
            conn.Close();
        }

        private void txtBalaceRe_TextChanged(object sender, EventArgs e)
        {
            if(txtBalaceRe.Text == "")
            {
                txtBalaceRe.Text = "0";
            }
            else
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value4 = decimal.Parse(txtBalaceRe.Text, System.Globalization.NumberStyles.AllowThousands);
                txtBalaceRe.Text = String.Format(culture, "{0:N0}", value4);
                txtBalaceRe.Select(txtBalaceRe.Text.Length, 0);
            }
           
        }

        private void txtPaymentCashVND_TextChanged(object sender, EventArgs e)
        {
            

            if(txtPaymentCashVND.Text == "")
            {
                txtPaymentCashVND.Text = "0";
            }
            else
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value2 = decimal.Parse(txtPaymentCashVND.Text, System.Globalization.NumberStyles.AllowThousands);
                txtPaymentCashVND.Text = String.Format(culture, "{0:N0}", value2);
                txtPaymentCashVND.Select(txtPaymentCashVND.Text.Length, 0);
                decimal SumB = decimal.Parse(txtBalaceRe.Text) + decimal.Parse(textincomecashVND.Text) - decimal.Parse(txtPaymentCashVND.Text);
                txtBalance.Text = SumB.ToString();
            }
            
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            if(txtBalance.Text == "")
            {
                txtBalance.Text = "0";
               }
            else
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value3 = decimal.Parse(txtBalance.Text, System.Globalization.NumberStyles.AllowThousands);
                txtBalance.Text = String.Format(culture, "{0:N0}", value3);
                txtBalance.Select(txtBalance.Text.Length, 0);
                
            }
            
        }

        private void btnInsertCashVND_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerCash.Value;
            conn.Open();
            string request = "INSERT INTO `trvc_data`.`cashvnd` (`DayCash`, `Decscription`, `Income`, `Payment`, `Balance`, `S_code`) VALUES('" + dateTime.ToShortDateString() + "', '" + txtDecsriptionCashVND.Text + "', '" + decimal.Parse(textincomecashVND.Text) + "', '" + decimal.Parse(txtPaymentCashVND.Text) + "', '"  +decimal.Parse(txtBalance.Text)+ "', '" + comboBoxCode.Text + "');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("AddedCash");
                txtBalaceRe.Text = txtBalance.Text;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                
            }
            conn.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
           ShowCashVND  cashVND = new ShowCashVND();
            cashVND.Show();
        }
    }

}


