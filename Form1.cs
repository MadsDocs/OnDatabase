using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;

using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;

using System.Reflection;
using System.Configuration;



namespace Attach_Detach_DB
{
    
    public partial class frm_Main : Form
    {
        private static string connectionstring = @"Server=192.168.1.184\SQLEXPRESS,49193;Database=master;User Id=dispatcher;Password=Animated-gamers;";
        private static string query = @"SELECT name, database_id, state, user_access  FROM sys.databases;";

        private static string username;
        private static string passwort;
        private static string database;
        private static string instance;
        private static string dns;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_kappen_Click(object sender, EventArgs e)
        {
            username = txtbx_username.Text;
            passwort = txtbx_passwort.Text;
            database = txtbx_db.Text;
            instance = txtbx_instance.Text;
            dns = txtbx_dns.Text;

           string success = Classes.Detach.SettOffline(username,passwort,database,instance,dns);
            txtbx_status.Text = success;
            lstbx_Status.Items.Clear();
            update(lstbx_Status);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username = txtbx_username.Text;
            passwort = txtbx_passwort.Text;
            database = txtbx_db.Text;
            instance = txtbx_instance.Text;
            dns = txtbx_dns.Text;

            string sucess =  Classes.Attach.SetOnline(username, passwort, database, instance, dns);
            txtbx_status.Text = sucess;
            lstbx_Status.Items.Clear();
            update(lstbx_Status);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                this.Text = "OnDatabase Version: " + version;

                bool status = Classes.Einstellungenspeichern.GetStatusAppSetting("sucess");

                if (status)
                {
                    btn_speichern.Enabled = false;
                }
                else
                {
                    btn_speichern.Enabled = true;
                }


                update(lstbx_Status);
            }
            catch (Exception ex)
            {
                txtbx_status.Text = "Config Datei wurde nicht gefunden!";
                btn_laden.Enabled = false;

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
          
        }

        public static void update(ListBox lst)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            using (IDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lst.Items.Add("Datenbank: " + dr[0].ToString());
                    string state = dr[2].ToString();
                    string user_access = dr[3].ToString();

                    switch (state)
                    {
                        case "0":
                            lst.Items.Add("Status: Online");
                            break;
                        case "1":
                            lst.Items.Add("Status: Wiederhergestellt");
                            break;
                        case "2":
                            lst.Items.Add("Status: Wird Wiederhergestellt");
                            break;
                        case "3":
                            lst.Items.Add("Status: Auf Wiederherstellung wird gewartet");
                            break;
                        case "4":
                        case "5":
                            lst.Items.Add("Status: Datenbankfehler");
                            break;
                        case "6":
                            lst.Items.Add("Status: Datenbank ist offline");
                            break;
                        default:
                            break;
                    }

                    switch (user_access)
                    {
                        case "0":
                            lst.Items.Add("User Zugriff: MULTI_USER");
                            break;
                        case "1":
                            lst.Items.Add("User Zugriff: SINGLE_USER");
                            break;
                        case "2":
                            lst.Items.Add("User Zugriff: RESTRICTED_USER");
                            break;
                        default:
                            break;
                    }
                }
            }
            
           con.Dispose();
           con.Close();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            try
            {
                username = txtbx_username.Text;
                passwort = txtbx_passwort.Text;
                database = txtbx_db.Text;
                instance = txtbx_instance.Text;
                dns = txtbx_dns.Text;
                string sucess = Classes.Einstellungenspeichern.Speichern(username, passwort, database, dns, instance);
                txtbx_status.Text = sucess;
                btn_laden.Enabled = true;
            }
            catch (Exception ex)
            {
                txtbx_status.Text = "Einstellungen wurden nicht gespeichert!";
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btn_laden_Click(object sender, EventArgs e)
        {
            try
            {
                txtbx_username.Text = Classes.Einstellungenspeichern.GetAppSettings("Username");
                txtbx_passwort.Text = Classes.Einstellungenspeichern.GetAppSettings("Passwort");
                txtbx_db.Text = Classes.Einstellungenspeichern.GetAppSettings("Datenbank");
                txtbx_dns.Text = Classes.Einstellungenspeichern.GetAppSettings("DNS");
                txtbx_instance.Text = Classes.Einstellungenspeichern.GetAppSettings("Instanz");
            }
            catch (Exception ex)
            {
                txtbx_status.Text = "Konnte Einstellungen nicht laden!";
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbx_username.Clear();
            txtbx_passwort.Clear();
            txtbx_db.Clear();
            txtbx_dns.Clear();
            txtbx_instance.Clear();
        }

        private void btn_propClear_Click(object sender, EventArgs e)
        {
            Classes.Einstellungenspeichern.ResetAppSettings();
        }
    }
}
