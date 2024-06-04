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
    public partial class Code : Form
    {
       // private string _message;
        MySqlConnection conn = DBUtils.GetDBConnection();
        public Code()
        {
            InitializeComponent();
        }
        

        private void comboBoxGroupCode_SelectedIndexChanged(object sender, EventArgs e)

        {
            conn.Open();
            if (comboBoxGroupCode.Text== "Goverment office" || comboBoxGroupCode.Text == "TRVC")
            {
                
                string request = "SELECT * FROM trvc_data.code where CodeGroup= '"+comboBoxGroupCode.Text+"' ORDER BY S_code  DESC LIMIT 1;";
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(request, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtS_code.Text = reader["S_code"].ToString();
                    

               }


            }
            conn.Close();   
        }

        private void btnInsetCode_Click(object sender, EventArgs e)
        {
            conn.Open();
            string request = "INSERT INTO `trvc_data`.`code` (`S_code`, `F`, `ITEM_NAME`, `Account_No`, `Bank`, `Type`, `CodeGroup`) VALUES ('" + txtS_code.Text + "', '" + txtF.Text + "', '" + txtItemName.Text + "', '" + txtAccountNo.Text + "', '" + txtBank.Text + "', '" + txtType.Text + "', '" +comboBoxGroupCode.Text + "');";
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
            conn.Close();
            
        }

        private void btnShowCode_Click(object sender, EventArgs e)
        {
            ShowCode showCode = new ShowCode();
            showCode.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtS_code.Text =string.Empty;
            txtF.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtAccountNo.Text = string.Empty;
            txtBank.Text = string.Empty;
            txtType.Text = string.Empty;
            comboBoxGroupCode.Text = string.Empty;

        }

        private void btnUpdateCode_Click(object sender, EventArgs e)
        {
            conn.Open();
            //  string request = "INSERT INTO `trvc_data`.`code` (`S_code`, `F`, `ITEM_NAME`, `Account_No`, `Bank`, `Type`, `CodeGroup`) VALUES ('" + txtS_code.Text + "', '" + txtF.Text + "', '" + txtItemName.Text + "', '" + txtAccountNo.Text + "', '" + txtBank.Text + "', '" + txtType.Text + "', '" + comboBoxGroupCode.Text + "');";
            string request = "UPDATE trvc_data.code SET S_code = '" + txtS_code.Text + "',F = '" + txtF.Text + "',ITEM_NAME = '" + txtItemName.Text + "',Account_No = '" + txtAccountNo.Text + "',Bank = '" + txtBank.Text + "',Bank = '" + txtBank.Text + "',Type = '" + txtType.Text + "',CodeGroup = '" + comboBoxGroupCode.Text + "' WHERE S_code = '" + txtS_code.Text + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Done");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            conn.Close();
        }

        private void btnDeleteCode_Click(object sender, EventArgs e)
        {
            conn.Open();
            //  string request = "INSERT INTO `trvc_data`.`code` (`S_code`, `F`, `ITEM_NAME`, `Account_No`, `Bank`, `Type`, `CodeGroup`) VALUES ('" + txtS_code.Text + "', '" + txtF.Text + "', '" + txtItemName.Text + "', '" + txtAccountNo.Text + "', '" + txtBank.Text + "', '" + txtType.Text + "', '" + comboBoxGroupCode.Text + "');";
            //string request = "UPDATE trvc_data.code SET S_code = '" + txtS_code.Text + "',F = '" + txtF.Text + "',ITEM_NAME = '" + txtItemName.Text + "',Account_No = '" + txtAccountNo.Text + "',Bank = '" + txtBank.Text + "',Bank = '" + txtBank.Text + "',Type = '" + txtType.Text + "',CodeGroup = '" + comboBoxGroupCode.Text + "' WHERE S_code = '" + txtS_code.Text + "';";
            string request = "DELETE FROM trvc_data.code WHERE S_code = '" + txtS_code.Text + "' ;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Deleted!!!");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            conn.Close();
        }

        private void Code_Load(object sender, EventArgs e)
        {
            conn.Open();

            string request = "SELECT CodeGroupName FROM trvc_data.codegroup";
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(request, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 // txtS_code.Text = reader["S"].ToString();
                //MessageBox.Show("" + reader["CodeGroupName"].ToString());
                string s = "" + reader["CodeGroupName"].ToString();
                //comboBoxGroupCode.Items.Add(reader["CodeGroupName"].ToString());
                comboBoxGroupCode.Items.Add(s);

            }
            conn.Close();

        }
    }
    }

