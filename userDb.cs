using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAuth
{
    internal class userDb
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "host=localhost;port=4200;username=root;password=;database=user_auth";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }catch (MySqlException ex)
            {
                MessageBox.Show("Failled to Connect to DB" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void addUser(users usr)
        {
           
            string sql = "INSERT INTO users VALUES(NULL,@uname,@password)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("uname", MySqlDbType.VarChar).Value = usr.username;
            cmd.Parameters.Add("password", MySqlDbType.VarChar).Value = usr.password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully","information",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }catch(MySqlException ex)
            {
                MessageBox.Show("Failled to query DB" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();   
        }
        public static void Select(string query)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string sql = query;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = new System.Data.CommandType();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Success" + sql, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
               
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Failled to query DB" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             conn.Close();
        }
    }
}
