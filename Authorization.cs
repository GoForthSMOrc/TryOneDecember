using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrainExam1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int CountU = 0;
            int CountW = 0;
            String queryW = "select count(*) from WorkersDB where LoginW = '" + logBox.Text + "' and PasswordW = '" + passBox.Text + "';";
            String queryU = "select count(*) from UsersDB where LoginU = '" + logBox.Text + "' and PasswordU = '" + passBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDBW = new MySqlCommand(queryW, conn);
            MySqlCommand cmDBU = new MySqlCommand(queryU, conn);
            try
            {
                conn.Open();
                CountW = Convert.ToInt32(cmDBW.ExecuteScalar());
                CountU = Convert.ToInt32(cmDBU.ExecuteScalar());
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка авторизации. Попробуйте еще раз");
                MessageBox.Show(ex.Message);
            }
            if(CountW > 0)
            {
                AdminMenu win = new AdminMenu();
                win.Show();
                this.Hide();
            }
            if (CountU > 0)
            {
                UserMenu win = new UserMenu();
                win.Show();
                this.Hide();
            }
            if (CountU == 0 && CountW == 0)
            {
                MessageBox.Show("Ошибка авторизации.");
            }

        }
    }
}
