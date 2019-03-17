using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    
    class DataBase
    {



        private MySqlConnection conn;
        private string server;
        private string database;
        private string username;
        private string password;

        public DataBase()
        {
            
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "Motherbase";
            username = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }catch(MySqlException)
            {
               
            }


            return false;
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException)
            {
                
                return false;
            }
        }

        //Insert statement
        public void Insert(string SoldierName,string SoldierCountry,string SoldierAlliance)
        {
            string query = "INSERT INTO soldier(SoldierName,SoldierCountry,SoldierAlliance) VALUES('" + SoldierName + "','" + SoldierCountry + "','" + SoldierAlliance + "');";
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                   
                }
            }catch(Exception)
            {
                
            }
            
        }

        //Update statement
        public void Update(string SoldierName, string SoldierCountry, string SoldierAlliance,int idSoldier)
        {
            string query = "UPDATE soldier SET SoldierName = '" + SoldierName+"', SoldierCountry = '"+SoldierCountry+"',SoldierAlliance = '"+SoldierAlliance+"' WHERE idSoldier = "+idSoldier+";";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query,conn);
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = conn;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        //this will delete from the
        public void Delete(string idSoldier)
        {
            string query = "DELETE FROM soldier WHERE idSoldier=" + idSoldier+";";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        //will select the items from the DB but didn't worked
        public List<string>[] Select()
        {
            string query = "SELECT * FROM soldier";

            //Create a list to store the result
            List<string>[] list = new List<string>[Count()];
                        
            for(int i = 0; i < Count(); i++)
            {
                list[i] = new List<string>();
            }

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["SoldierName"] + "");
                    list[1].Add(dataReader["SoldierCountry"] + "");
                    list[2].Add(dataReader["SoldierAlliance"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }


            
        }

        //Count statement
        //Conta quantas entradas tem
        public int Count()
        {
            string query = "SELECT Count(*) FROM soldier";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }


    }
}
