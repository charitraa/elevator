using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public class DataBase
    {  
        
        private readonly string dbConnection = "Server=localhost;Database=elevator;Uid=root;Pwd=root;";

        public void DisplayLog(ListBox logListBox, DataSet ds)
        {
            try
            {
                const string dbCommand = "SELECT * FROM logs;";
                using (MySqlConnection conn = new MySqlConnection(dbConnection))
                using (MySqlCommand comm = new MySqlCommand(dbCommand, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comm))
                {
                    conn.Open();
                    adapter.Fill(ds);
                }

                logListBox.Items.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    logListBox.Items.Add($"{Convert.ToDateTime(row["Date"]):yyyy-MM-dd}\t\t{row["Time"]}\t\t{row["Actions"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

        internal void InsertData(ListBox logListBox, Log log)
        {
            const string dbCommand = "INSERT INTO logs (actions, date, time) VALUES (@actions, @date, @timestamp)";
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            logListBox.Items.Add($"{date}\t\t{timestamp}\t\t{log.Action}");

            try
            {
                using (MySqlConnection connDb = new MySqlConnection(dbConnection))
                using (MySqlCommand commInsert = new MySqlCommand(dbCommand, connDb))
                {
                    commInsert.Parameters.AddWithValue("@actions", log.Action);
                    commInsert.Parameters.AddWithValue("@date", date);
                    commInsert.Parameters.AddWithValue("@timestamp", timestamp);

                    connDb.Open();
                    commInsert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert log! " + ex.Message);
            }
        }

        public void DeleteLogs(ListBox logListBox)
        {
            try
            {
                const string dbCommand = "TRUNCATE TABLE logs;";
                using (MySqlConnection conn = new MySqlConnection(dbConnection))
                using (MySqlCommand comm = new MySqlCommand(dbCommand, conn))
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }

                MessageBox.Show("Logs cleared successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                logListBox.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to clear logs! " + ex.Message);
            }
        }
    }
}
