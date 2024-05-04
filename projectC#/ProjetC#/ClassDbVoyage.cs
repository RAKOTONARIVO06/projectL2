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
    class ClassDbVoyage
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

        public static void AddNewTravel(ClassTravel trav)
        {
            string sql = "INSERT INTO travel VALUES(@codev,@datev,@code,@source,@dest,@travelCoast)";
            MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@codev", MySqlDbType.VarChar).Value = trav.codeV;
                cmd.Parameters.Add("@datev", MySqlDbType.Date).Value = trav.dateV;
                cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = trav.codeTrain;
                cmd.Parameters.Add("@source", MySqlDbType.VarChar).Value = trav.sourceV;
                cmd.Parameters.Add("@dest", MySqlDbType.VarChar).Value = trav.destinationV;
                cmd.Parameters.Add("@travelCoast", MySqlDbType.Int32).Value = trav.coastV;
            try
        {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            catch (MySqlException ex)
        {
            MessageBox.Show("Error!" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        con.Close();
        }

        public static void updateTravel(ClassTravel trav)
        {
            string sql = "UPDATE travel set dateV=@datev, codeTrain=@code, sourceV=@source, destinationV=@dest, coastV=@travelCoast WHERE codeV=@codeV";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@codev", MySqlDbType.VarChar).Value = trav.codeV;
            cmd.Parameters.Add("@datev", MySqlDbType.Date).Value = trav.dateV;
            cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = trav.codeTrain;
            cmd.Parameters.Add("@source", MySqlDbType.VarChar).Value = trav.sourceV;
            cmd.Parameters.Add("@dest", MySqlDbType.VarChar).Value = trav.destinationV;
            cmd.Parameters.Add("@travelCoast", MySqlDbType.Int32).Value = trav.coastV;

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

        public static void deleteTravel(string id)
        {
            string sql = "DELETE FROM travel WHERE codeV=@codev";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@codev", MySqlDbType.VarChar).Value = id;
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
