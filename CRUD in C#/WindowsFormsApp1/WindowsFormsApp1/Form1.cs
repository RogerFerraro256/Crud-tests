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
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();
        public Form1()
        {
            //TODO finish the way to update the item

            InitializeComponent();

            allSoldiers.GridLines = true;
            allSoldiers.View = View.Details;

            //Add Column Header

            allSoldiers.Columns.Add("id Soldier", 100);
            allSoldiers.Columns.Add("Soldier name", 100);
            allSoldiers.Columns.Add("Soldier Country", 100);
            allSoldiers.Columns.Add("Souldier Alliance", 100);


        }

        private MySqlConnection conn;
        private string server;
        private string database;
        private string username;
        private string password;

        private void populateSoldiers()
        {
            //this is the select that will work in this exemple
            allSoldiers.GridLines = true;
            allSoldiers.View = View.Details;

            //Add Column Header

            allSoldiers.Columns.Add("id Soldier", 100);
            allSoldiers.Columns.Add("Soldier name", 100);
            allSoldiers.Columns.Add("Soldier Country", 100);
            allSoldiers.Columns.Add("Souldier Alliance", 100);

            allSoldiers.BeginUpdate();
            server = "localhost";
            database = "Motherbase";
            username = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connectionString);

            string query = "SELECT * FROM soldier";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable("myTable");
            da.Fill(table);
            allSoldiers.View = View.Details;
            ListViewItem iItem;
            foreach (DataRow row in table.Rows)
            {
                iItem = new ListViewItem();
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    if (i == 0)
                        iItem.Text = row.ItemArray[i].ToString();
                    else
                        iItem.SubItems.Add(row.ItemArray[i].ToString());
                }
                allSoldiers.Items.Add(iItem);
                allSoldiers.EndUpdate();
                allSoldiers.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateSoldiers();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            allSoldiers.Clear();
            db.Insert(SoldierName.Text, SoldierCountry.Text, SoldierAlliance.Text);
            populateSoldiers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selected in allSoldiers.SelectedItems)
            {
                String text = allSoldiers.SelectedItems[0].Text;
                label1.Text = text;
                db.Delete(text);
                allSoldiers.Items.Remove(selected);
            }
        }

        private void editSoldier_Click(object sender, EventArgs e)
        {
            new editSoldier().Show();
        }
    }
}
