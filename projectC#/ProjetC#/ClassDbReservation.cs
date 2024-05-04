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
    class ClassDbReservation
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
        public static void addNewReservation(ClassReservation res)
        {
            string sql = "INSERT INTO reservation VALUES(NULL,@id,@code,@type,@price)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = res.idcli;
            cmd.Parameters.Add("@code", MySqlDbType.VarChar).Value = res.codev;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = res.typeofpaid;
            cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = res.prix;
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

        public static void updateReservation(ClassReservation res)
        {
            string sql = "UPDATE reservation set idClient=@idclient, codeVoyage=@codevoyage, typeOfpaid=@typeofpaid, reste=@reste WHERE idReservation=@idreservation";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@idclient", MySqlDbType.VarChar).Value = res.idcli;
            cmd.Parameters.Add("@codevoyage", MySqlDbType.Date).Value = res.codev;
            cmd.Parameters.Add("@typeofpaid", MySqlDbType.VarChar).Value = res.typeofpaid;
            cmd.Parameters.Add("@reste", MySqlDbType.VarChar).Value = res.prix;
           // cmd.Parameters.Add("@idreservation", MySqlDbType.VarChar).Value = res.idres;
           
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

        public static void deleteReservation(string id)
        {
            string sql = "DELETE FROM reservation WHERE idReservation=@reserv";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@reserv", MySqlDbType.VarChar).Value = id;
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


        public static void searchAndDisplay(string query, DataGridView dgv)
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
