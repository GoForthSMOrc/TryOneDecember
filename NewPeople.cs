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
    public partial class NewPeople : Form
    {
        public NewPeople()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            String query = "Insert into UsersDB(LoginU,PasswordU) values ('"+ newlogUBox.Text + "','" + newpassUBox.Text + "')";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                MessageBox.Show("Новый пользователь успешно добавлен!");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка регистрации пользователя");
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewWorkerButton_Click(object sender, EventArgs e)
        {
            String query = "Insert into WorkersDB(LoginW,PasswordW) values ('" + newlogWBox.Text + "','" + newpassWBox.Text + "')";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                MessageBox.Show("Новый работник успешно добавлен!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка регистрации работника");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
