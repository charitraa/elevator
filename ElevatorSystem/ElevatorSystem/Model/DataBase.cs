// Import required namespaces for MySQL database operations, data management, and Windows Forms
using MySql.Data.MySqlClient; // Provides methods for connecting to and interacting with a MySQL database
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data; // Enables data access, including DataSet and DataRow
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Provides classes for creating Windows Forms applications

namespace ElevatorSystem
{
    // Class to handle database operations for the elevator system
    public class DataBase
    {
        // Connection string to connect to the MySQL database, with necessary credentials
        private readonly string dbConnection = "Server=localhost;Database=elevator;Uid=root;Pwd=;";

        // Method to display logs from the database in a ListBox
        public void DisplayLog(ListBox logListBox, DataSet ds)
        {
            try
            {
                // SQL command to retrieve all records from the 'logs' table
                const string dbCommand = "SELECT * FROM logs;";

                // Establish connection and command for executing the SQL query
                using (MySqlConnection conn = new MySqlConnection(dbConnection))
                using (MySqlCommand comm = new MySqlCommand(dbCommand, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comm))
                {
                    // Open the database connection
                    conn.Open();

                    // Fill the DataSet with data from the database
                    adapter.Fill(ds);
                }

                // Clear the ListBox before displaying logs to avoid duplicates
                logListBox.Items.Clear();

                // Iterate through each row in the DataSet and display log entries in ListBox
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    logListBox.Items.Add($"{Convert.ToDateTime(row["Date"]):yyyy-MM-dd}\t\t{row["Time"]}\t\t{row["Actions"]}");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if the connection to the database fails
                MessageBox.Show("Cannot open connection! " + ex.Message);
            }
        }

        // Method to insert a new log entry into the database and display it in the ListBox
        internal void InsertData(ListBox logListBox, Log log)
        {
            // SQL command for inserting a new log entry
            const string dbCommand = "INSERT INTO logs (actions, date, time) VALUES (@actions, @date, @timestamp)";

            // Get the current date and time for the log entry
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string timestamp = DateTime.Now.ToString("HH:mm:ss");

            // Add log entry to the ListBox before inserting into the database
            logListBox.Items.Add($"{date}\t\t{timestamp}\t\t{log.Action}");

            try
            {
                // Establish connection and command to insert the log entry
                using (MySqlConnection connDb = new MySqlConnection(dbConnection))
                using (MySqlCommand commInsert = new MySqlCommand(dbCommand, connDb))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(commInsert))
                {
                    // Define parameters for the SQL command
                    commInsert.Parameters.AddWithValue("@actions", log.Action);
                    commInsert.Parameters.AddWithValue("@date", date);
                    commInsert.Parameters.AddWithValue("@timestamp", timestamp);

                    // Open the database connection and execute the insert command
                    connDb.Open();

                }
            }
            catch (Exception ex)
            {
                // Display an error message if the insertion fails
                MessageBox.Show("Failed to insert log! " + ex.Message);
            }
        }

        // Method to delete all logs from the 'logs' table and clear them from the ListBox
        public void DeleteLogs(ListBox logListBox)
        {
            try
            {
                // SQL command to clear all records from the 'logs' table
                const string dbCommand = "TRUNCATE TABLE logs;";

                // Establish connection and command to execute the truncate operation
                using (MySqlConnection conn = new MySqlConnection(dbConnection))
                using (MySqlCommand comm = new MySqlCommand(dbCommand, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(comm))
                {
                    // Open the database connection and execute the command
                    conn.Open();

                }

                // Inform the user that logs have been cleared successfully
                MessageBox.Show("Logs cleared successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the ListBox to reflect the deletion
                logListBox.Items.Clear();
            }
            catch (Exception ex)
            {
                // Display an error message if log deletion fails
                MessageBox.Show("Failed to clear logs! " + ex.Message);
            }
        }
    }
}
