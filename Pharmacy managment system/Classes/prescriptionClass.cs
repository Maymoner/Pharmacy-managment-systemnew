using Pharmacy_managment_system.Forms;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_managment_system.Classes
{
    internal class prescriptionClass
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";
        string cs2 = @"URI=file:" + Application.StartupPath + "\\history.db";
        SQLiteDataReader dr;
        private string name , frequency, notes;
        private int patID, medID, duration , quantity,price,prescriptionID;
        private DateTime prescribingDate,currentDay=DateTime.Now;
        private double dosage;
        
        public void data_show(DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM inventory";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                medID = dr.GetInt32(0);
                name = dr.GetString(1);
                quantity = dr.GetInt32(4);
                price = dr.GetInt32(6);
             
                grid.Rows.Insert(0, medID, name,price,quantity);

               
            }

            con.Close();
        }
        public  void data_showP(DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM paitents";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                patID = dr.GetInt32(0);
                name = dr.GetString(1);
               
                
                grid.Rows.Insert(0, patID, name);
            }

            con.Close();
        }
        public void Search(string searchText, DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            // Construct the SQL query with a WHERE clause to filter based on the search text
            string stm = "SELECT * FROM inventory WHERE name LIKE @searchText OR type LIKE @searchText OR brand LIKE @searchText";
            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // Use wildcard '%' to match any substring

            // Execute the SQL query
            dr = cmd.ExecuteReader();

            // Clear existing rows in the DataGridView
            grid.Rows.Clear();

            // Populate the DataGridView with the search results
            while (dr.Read())
            {
                medID = dr.GetInt32(0);
                name = dr.GetString(1);
                grid.Rows.Add(medID, name);
            }

            con.Close();
        }
        public  void SearchP(string searchText, DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            // Construct the SQL query with a WHERE clause to filter based on the search text
            string stm = "SELECT * FROM paitents WHERE name LIKE @searchText ";
            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // Use wildcard '%' to match any substring

            // Execute the SQL query
            dr = cmd.ExecuteReader();

            // Clear existing rows in the DataGridView
            grid.Rows.Clear();

            // Populate the DataGridView with the search results
            while (dr.Read())
            {
                patID = dr.GetInt32(0);
                name = dr.GetString(1);
                // Insert values into DataGridView
                grid.Rows.Insert(0, patID, name);
            }

            con.Close();
        }

        public void CheckOrCreatePrescriptionTable(DateTime date)
        {
            var tableName = "prescription_" + date.ToString("yyyyMMdd"); // Table name format: prescription_yyyymmdd
            string createTableQuery = @"
        CREATE TABLE IF NOT EXISTS " + tableName + @" (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            patientId INTEGER NOT NULL,
            medicationId INTEGER NOT NULL,
            prescriptionDate TEXT,
            dosage INTEGER,
            frequency TEXT,
            duration INTEGER,
            price INTEGER,
            notes TEXT
        );";

            var con = new SQLiteConnection(cs2);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                // Check if the table exists
                cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name=@tableName;";
                cmd.Parameters.AddWithValue("@tableName", tableName);
                int tableCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (tableCount == 0)
                {
                    // Table does not exist, create a new one
                    cmd.CommandText = createTableQuery;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table created: " + tableName);
                }
                else
                {
                    Console.WriteLine("Table already exists: " + tableName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking/creating table: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void insert(int pattxt, int medtxt, double dosagetxt, string frequencytxt, int duratuintxt,int pricetxt, string notestxt)
        {
            var con = new SQLiteConnection(cs);
            var con2 = new SQLiteConnection(cs2);
            con.Open();
            con2.Open();
            var cmd = new SQLiteCommand(con);
            var cmd2 = new SQLiteCommand(con2);
            try
            {


                
                cmd2.CommandText = $"INSERT INTO prescription_{currentDay.ToString("yyyyMMdd")}(patientId, medicationId, prescriptionDate, dosage, frequency, duration, price, notes) VALUES(@patientId, @medicationId, @prescriptionDate, @dosage, @frequency, @duration, @price, @notes)";
                
                patID = pattxt;
                medID = medtxt;
                frequency = frequencytxt;
                dosage = dosagetxt;
                duration = duratuintxt;
                notes = notestxt;
                price = pricetxt;
                prescribingDate= DateTime.Now;
               
                cmd2.Parameters.AddWithValue("@patientId", patID);
                cmd2.Parameters.AddWithValue("@medicationId", medID);
                cmd2.Parameters.AddWithValue("@prescriptionDate", prescribingDate.ToString("yyyy-MM-dd HH-mm-ss"));
                cmd2.Parameters.AddWithValue("@dosage", dosage);
                cmd2.Parameters.AddWithValue("@frequency", frequency);
                cmd2.Parameters.AddWithValue("@duration", duration);
                cmd2.Parameters.AddWithValue("@price", price);
                cmd2.Parameters.AddWithValue("@notes", notes);
                cmd2.ExecuteNonQuery();

                cmd.CommandText = "SELECT COUNT(*) FROM inventory WHERE id = @id;";
                cmd.Parameters.AddWithValue("@id", medID); // Assuming medID holds the ID of the medication
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Decrease the quantity of the medication with the matching ID
                    cmd.CommandText = "UPDATE inventory SET quantity = quantity - 1 WHERE id = @id;";
                    cmd.ExecuteNonQuery();

                    // Check if the quantity has reached 0
                    cmd.CommandText = "SELECT quantity FROM inventory WHERE id = @id;";
                    int quantity = Convert.ToInt32(cmd.ExecuteScalar());

                    if (quantity == 0)
                    {
                        MessageBox.Show("The quantity of " + name + " has reached 0.");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting data: " + ex.Message);
            }
            finally
            {
                con.Close();
                con2.Close();
            }
        }
        public void data_showHistory(DataGridView grid,DateTime dateTime)
        {

            currentDay = dateTime;

            var con = new SQLiteConnection(cs2);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name=@tableName;";

            cmd.Parameters.AddWithValue("@tableName", "prescription_"+ currentDay.ToString("yyyyMMdd"));
            int tableCount = Convert.ToInt32(cmd.ExecuteScalar());

            
            
            if (tableCount != 0)
            {
                string stm = "SELECT * FROM prescription_" + currentDay.ToString("yyyyMMdd");
                cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prescriptionID = dr.GetInt32(0);
                    patID = dr.GetInt32(1);
                    medID = dr.GetInt32(2);
                    string prescribingDate = dr.GetString(3);
                    dosage = dr.GetDouble(4);
                    frequency = dr.GetString(5);
                    duration = dr.GetInt32(6);
                    price = dr.GetInt32(7);
                    notes = dr.GetString(8);
                    grid.Rows.Insert(0, prescriptionID, patID, medID, prescribingDate, dosage, frequency, duration, price, notes);
                }

            }
            else
            {
                MessageBox.Show("There are no data with the date ("+currentDay.ToString("yyyy-MM-dd")+")","Missing Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            con.Close();
        }
        public void SearchHistory(string searchText, DataGridView grid, bool patientCheck, bool medicationCheck)
        {
            var con = new SQLiteConnection(cs2);
            con.Open();
            string stm;
          
            if (patientCheck == true)
            {

                stm = $"SELECT * FROM prescription_{currentDay.ToString("yyyyMMdd")} WHERE patientId LIKE @searchText";
            }
            else if (medicationCheck == true)
            {
                stm = $"SELECT * FROM prescription_{currentDay.ToString("yyyyMMdd")} WHERE medicationId LIKE @searchText";
            }
            else
            {
                stm = $"SELECT * FROM prescription_{currentDay.ToString("yyyyMMdd")} WHERE ID LIKE @searchText";
            }
            // Construct the SQL query with a WHERE clause to filter based on the search text
            

            var cmd = new SQLiteCommand(stm, con);

            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // Use wildcard '%' to match any substring

            // Execute the SQL query

            
            dr = cmd.ExecuteReader();
            // Clear existing rows in the DataGridView
            grid.Rows.Clear();

            // Populate the DataGridView with the search results
            while (dr.Read())
            {
                prescriptionID = dr.GetInt32(0);
                patID = dr.GetInt32(1);
                medID = dr.GetInt32(2);
                string prescribingDate = dr.GetString(3);
                dosage = dr.GetDouble(4);
                frequency = dr.GetString(5);
                duration = dr.GetInt32(6);
                price = dr.GetInt32(7);
                notes = dr.GetString(8);
                grid.Rows.Insert(0, prescriptionID, patID, medID, prescribingDate, dosage, frequency, duration, price, notes);
            }

            con.Close();
        }

        public void Refund(DataGridViewRow selectedRow)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                if (selectedRow != null)
                {
                    int id = Convert.ToInt32(selectedRow.Cells["medication_id"].Value);
                    cmd.CommandText = "UPDATE inventory SET quantity = quantity + 1 WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }
        public void delete(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                var selectedRow = gridView.SelectedRows[0];
                int idToDelete = Convert.ToInt32(selectedRow.Cells["medication_id"].Value);
                int idPatientToDelete = Convert.ToInt32(selectedRow.Cells["patient_id"].Value);
                using (var con = new SQLiteConnection(cs2))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand(con))
                    {
                        try
                        {
                            cmd.CommandText = $"DELETE FROM prescription_{currentDay.ToString("yyyyMMdd")} WHERE medicationId = @medId AND  patientId=@patID";

                            cmd.Parameters.AddWithValue("@medId", idToDelete);
                            cmd.Parameters.AddWithValue("@patID",idPatientToDelete); 
                            cmd.ExecuteNonQuery();
                            gridView.Rows.Remove(selectedRow);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error deleting row: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


    }
}
