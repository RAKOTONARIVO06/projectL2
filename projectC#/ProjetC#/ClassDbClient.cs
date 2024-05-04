using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION
{
    class ClassDbClient
    {
       

        public static MySqlConnection GetConnection()
        {
            string sql = "server=localhost; port=3306; username=root; password=narivo2777; database=railway";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection \n" + ex.Message);
            }
            return con;
        }

        public static void AddClient(ClassClient clt)
        {
            string sql = "INSERT INTO CLIENT VALUES(@idCli,@nameCli,@contactCli)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@idCli", MySqlDbType.VarChar).Value = clt.idCli;
            cmd.Parameters.Add("@nameCli", MySqlDbType.VarChar).Value = clt.nameCli;
            cmd.Parameters.Add("@contactCli", MySqlDbType.VarChar).Value = clt.contactCli;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successifuly","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not insert! " + ex.Message, "Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            con.Close();
        }

        public static void updateClient(ClassClient clt, string id)
        {
            string sql = "UPDATE CLIENT set nameCli=@nameCli, contactCli=@contactCli WHERE idCli=@idCli";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@nameCli", MySqlDbType.VarChar).Value = clt.nameCli;
            cmd.Parameters.Add("@contactCli", MySqlDbType.VarChar).Value = clt.contactCli;
            cmd.Parameters.Add("@idCli", MySqlDbType.VarChar).Value = clt.idCli;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("update Successifuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("update not work! " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void deleteClient(string id)
        {
            string sql = "DELETE FROM CLIENT WHERE idCli=@idCli";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idCli", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successifuly","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Delete not work! " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            dgv.DataSource = tbl;
            adp.Fill(tbl);
            con.Close();
        }
    }
}
