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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUButton_Click(object sender, EventArgs e)
        {
            String query = "update UsersDB set LoginU = '" + logUBox.Text + "', PasswordU = '" + passUBox.Text + "' where Id_UsersDB = '" + numberUBox.Text + "' ;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Попробуйте еще раз");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
