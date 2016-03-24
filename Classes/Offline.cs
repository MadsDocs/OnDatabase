using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;

using System.Windows.Forms;

namespace Attach_Detach_DB.Classes
{
    class Detach
    {
       
        public static string SettOffline(string user, string passwort, string database,string instance, string dns)
        {

            if (user == string.Empty && passwort == string.Empty && database == string.Empty && instance == string.Empty && dns == string.Empty)
            {
                return "Bitte Usernamen, Passwort und eine Datenbank angeben!";
            }
            else if (database == "master" || database == "msdb" || database == "tempdb" || database == "model")
            {
                return "System Datenbanken können nicht offline genommen werden!";
            }
            else
            {
                string fiiledconnectionstring = @"Server=" + dns + @"\" + instance + ",49193;Database=master;" + "User Id=" + user + ";" + "Password=" + passwort + ";";

                string query = @"ALTER DATABASE " + database + " SET OFFLINE WITH ROLLBACK IMMEDIATE;";

                SqlConnection con = new SqlConnection(fiiledconnectionstring);
                SqlCommand cmd = new SqlCommand(query, con);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Dispose();
                    con.Close();

                    return "Datenbank ist offline!";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show(ex.StackTrace);

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                        con.Close();
                    }


                    return "Datenbank konnte nicht auf Offline gestellt werden!";


                }
            }



            
        }
    }
}
