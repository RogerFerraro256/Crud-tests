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

namespace WindowsFormsApp1
{
    public partial class editSoldier : Form
    {
        public editSoldier()
        {
            InitializeComponent();
        }

        private void editSoldier_Load(object sender, EventArgs e)
        {
            allSoldiers();
        }

        private void allSoldiers()
        {
            string server = "localhost";
            string database = "Motherbase";
            string username = "root";
            string password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);

            string query = "SELECT idSoldier FROM soldier";

            

            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader r = null;
            con.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                listBox1.Items.Add(r["idSoldier"]);
            }
            con.Close();
        }


        DataBase db = new DataBase();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(listBox1.GetItemText(listBox1.SelectedItem));

            string server = "localhost";
            string database = "Motherbase";
            string username = "root";
            string password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);

            string query = "SELECT * FROM soldier where idSoldier="+id;

            MySqlCommand cmd = new MySqlCommand(query, conn);

            conn.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            DataTable ft = new System.Data.DataTable();
            

            while (r.Read())
            {
                try
                {
                    txtName.Text = r["SoldierName"].ToString();
                    txtCountry.Text = r["SoldierCountry"].ToString();
                    txtAlliance.Text = r["SoldierAlliance"].ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listBox1.GetItemText(listBox1.SelectedItem));
            db.Update(txtName.Text, txtCountry.Text, txtAlliance.Text,id);
            
            
        }
    }
}
