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
    class UpdateRes
    {
        public static void update(ClassUpdate res)
        {
            string sql = "server=localhost; port=3306; username=root; password=narivo2777; database=railway";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
                string sql1 = "UPDATE reservation set idClient=@idclient, codeVoyage=@codevoyage, typeOfpaid=@typeofpaid, reste=@reste WHERE idReservation=@idreservation";
               
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@idclient", MySqlDbType.VarChar).Value = res.idcli;
                cmd.Parameters.Add("@codevoyage", MySqlDbType.Date).Value = res.codev;
                cmd.Parameters.Add("@typeofpaid", MySqlDbType.VarChar).Value = res.typeofpaid;
                cmd.Parameters.Add("@reste", MySqlDbType.VarChar).Value = res.prix;
                cmd.Parameters.Add("@idreservation", MySqlDbType.VarChar).Value = res.idRes;

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
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection \n" + ex.Message);
            }
            
        }

    }
}
