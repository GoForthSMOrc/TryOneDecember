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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
            getInfo(listView1);
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }
        
        void getInfo(ListView list)
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
    }
}
