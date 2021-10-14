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
    public partial class UpdateWorker : Form
    {
        public UpdateWorker()
        {
            InitializeComponent();
        }

        private void UpdateWButton_Click(object sender, EventArgs e)
        {
            String query = "update WorkersDB set LoginW = '" + logWBox.Text + "', PasswordW = '" + passWBox.Text + "' where Id_WorkersDB = '" + numberWBox.Text + "' ;";
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
