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
    public partial class AddNewLumber : Form
    {
        public AddNewLumber()
        {
            InitializeComponent();
        }

        private void AddNewLumberButton_Click(object sender, EventArgs e)
        {
            if (newsizeBox.SelectedIndex == 0)
            {
                string YEP = "1";
                String query = "Insert into Lumbers(NameLumbers,id_Size) values ('" + newlumberBox.Text + "','" + YEP + "')";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    MessageBox.Show("Новый пиломатериал успешно добавлен!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления пиломатериала");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if(newsizeBox.SelectedIndex == 1)
                {
                    string YEP = "2";
                    String query = "Insert into Lumbers(NameLumbers,id_Size) values ('" + newlumberBox.Text + "','" + YEP + "')";
                    MySqlConnection conn = DBUtils.GetDBConnection();
                    MySqlCommand cmDB = new MySqlCommand(query, conn);
                    MySqlDataReader rd;
                    try
                    {
                        conn.Open();
                        rd = cmDB.ExecuteReader();
                        MessageBox.Show("Новый пиломатериал успешно добавлен!");
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления пиломатериала");
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (newsizeBox.SelectedIndex == 2)
                    {
                        string YEP = "3";
                        String query = "Insert into Lumbers(NameLumbers,id_Size) values ('" + newlumberBox.Text + "','" + YEP + "')";
                        MySqlConnection conn = DBUtils.GetDBConnection();
                        MySqlCommand cmDB = new MySqlCommand(query, conn);
                        MySqlDataReader rd;
                        try
                        {
                            conn.Open();
                            rd = cmDB.ExecuteReader();
                            MessageBox.Show("Новый пиломатериал успешно добавлен!");
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка добавления пиломатериала");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

     
    }
    
}
