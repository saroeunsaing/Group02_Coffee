using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Coffee_Managment_System
{
    public partial class Form_TestingDB : Form
    {
        public Form_TestingDB()
        {
            InitializeComponent();
        }
        private string server = "localhost";
        private string user = "root";
        private string pwd = "";
        private string db = "coffee";
        private string cs;
        public MySqlConnection cn;
        private void btShow_Click(object sender, EventArgs e)
        {
            cs = @"server=" + server + ";user id=" + user + ";persistsecurityinfo=true;database=" + db + ";password=" + pwd + "";
            cn = new MySqlConnection(cs);

            try
            {
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    tbResult.Text = "Connected";
                    tbResult.ForeColor = Color.Blue;
                }
                else
                {
                    tbResult.Text = "Not Connected";
                    tbResult.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }
    }
}
