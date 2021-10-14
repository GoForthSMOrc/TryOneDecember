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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            getInfo1(listView1);
            getInfo2(listView2);
            getInfo3(listView3);
        }

        void getInfo1(ListView list)
        {
            String query = "select Lumbers.Id_Lumbers, Lumbers.NameLumbers, Size.NameSize from Lumbers join Size on Lumbers.id_Size = Size.Id_Size;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода информации списка пиломматериалов!");
                MessageBox.Show(ex.Message);
            }

        }
        void getInfo2(ListView list)
        {
            String query = "select UsersDB.Id_UsersDB, UsersDB.LoginU, UsersDB.PasswordU from UsersDB;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView2.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода информации списка пользователей!");
                MessageBox.Show(ex.Message);
            }
        }
        void getInfo3(ListView list)
        {
            String query = "select * from WorkersDB;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView3.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода информации списка работников!");
                MessageBox.Show(ex.Message);
            }
        }


        private void RefreshLumbersButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            getInfo1(listView1);
        }

        private void RefreshUsersDBButton_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            getInfo2(listView2);
        }

        private void RefreshWorkersDBButton_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            getInfo3(listView3);
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            NewPeople win = new NewPeople();
            win.Show();
        }

        private void NewLumberButton_Click(object sender, EventArgs e)
        {
            AddNewLumber win = new AddNewLumber();
            win.Show();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            String query = "Delete from Lumbers where Id_Lumbers = '" + deleteBox.Text + "';";
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
                MessageBox.Show("Ошибка удаления");
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String query = "select Lumbers.Id_Lumbers, Lumbers.NameLumbers, Size.NameSize from Lumbers join Size on Lumbers.id_Size = Size.Id_Size where Id_Lumbers = '" + searchBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска информации в списке пиломатериалов!");
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateRecord win = new UpdateRecord();
            win.Show();
        }

        private void deleteUButton_Click(object sender, EventArgs e)
        {
            String query = "Delete from UsersDB where Id_UsersDB = '" + deleteUBox.Text + "';";
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
                MessageBox.Show("Ошибка удаления");
                MessageBox.Show(ex.Message);
            }
        }

        private void searchUButton_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            String query = "select * from UsersDB where Id_UsersDB = '" + searchUBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView2.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска информации в списке пользователей!");
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUButton_Click(object sender, EventArgs e)
        {
            UpdateUser win = new UpdateUser();
            win.Show();
        }

        private void deleteWButton_Click(object sender, EventArgs e)
        {
            String query = "Delete from WorkersDB where Id_WorkersDB = '" + deleteWBox.Text + "';";
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
                MessageBox.Show("Ошибка удаления");
                MessageBox.Show(ex.Message);
            }
        }

        private void searchWButton_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            String query = "select * from WorkersDB where Id_WorkersDB = '" + searchWBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView3.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска информации в списке работников!");
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateWButton_Click(object sender, EventArgs e)
        {
            UpdateWorker win = new UpdateWorker();
            win.Show();
        }
    }
}
