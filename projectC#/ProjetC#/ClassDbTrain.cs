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
    class ClassDbTrain
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
        public  static void AddNewTrain(ClassTrain tr)
        {
            string sql = "INSERT INTO train VALUES(@idTrain,@capacity,@status)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@idTrain", MySqlDbType.VarChar).Value = tr.numTrain;
            cmd.Parameters.Add("@capacity", MySqlDbType.VarChar).Value = tr.capacityTrain;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = tr.statusTrain;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error!"+ ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }

        public static void updateTrain(ClassTrain tr)
        {
            string sql = "UPDATE train set capacityTrain=@capacity, statusTrain=@status WHERE numTrain=@idTrain";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@idTrain", MySqlDbType.VarChar).Value = tr.numTrain;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = tr.statusTrain;
            cmd.Parameters.Add("@capacity", MySqlDbType.VarChar).Value = tr.capacityTrain;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("update Successifuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("update not work! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void deleteTrain(string id)
        {
            string sql = "DELETE FROM train WHERE numTrain=@idTrain";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idTrain", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successifuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Delete not work! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
