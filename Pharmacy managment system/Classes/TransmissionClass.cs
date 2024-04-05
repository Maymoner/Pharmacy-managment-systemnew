using Pharmacy_managment_system.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_managment_system.Classes
{
    internal class TransmissionClass
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db"; SQLiteDataReader dr;
        string cs2 = @"URI=file:" + Application.StartupPath + "\\history.db";
        private string name, brand, type;
        private int ID, quantity, price;
        DateTime expirationDate, currentDay = DateTime.Now;


        public void data_show(DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM inventory";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = dr.GetString(1);
                type = dr.IsDBNull(2) ? "" : dr.GetString(2);
                brand = dr.GetString(5);
                price = dr.GetInt32(6);
                quantity = dr.GetInt32(4);
                string expirationDate = dr.GetString(7);

                // Insert values into DataGridView
                grid.Rows.Insert(0,  name, type, brand, price, quantity, expirationDate);
            }

            con.Close();
        }

        public void Sell(DataGridViewRow selectedRow)
        {
            if (selectedRow == null) return;

            name = selectedRow.Cells["name"].Value?.ToString();
            type = selectedRow.Cells["type"].Value?.ToString();
            brand = selectedRow.Cells["brand"].Value?.ToString();
            var priceObj = selectedRow.Cells["price"].Value;
            var expirationDateObj = selectedRow.Cells["expirationDate"].Value;

            if (name == null || type == null || brand == null || priceObj == null || expirationDateObj == null) return;

             
            if (!int.TryParse(priceObj.ToString(), out price)) return;
            if (!int.TryParse(selectedRow.Cells["quantity"].Value?.ToString(), out quantity)) return;

            using (var con = new SQLiteConnection(cs))
            using (var cmd = new SQLiteCommand(con))
            {
                con.Open();

                cmd.CommandText = "UPDATE inventory SET quantity = quantity - 1 WHERE name = @name;";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT quantity FROM inventory WHERE name = @name;";
                quantity = Convert.ToInt32(cmd.ExecuteScalar());

                if (quantity == 0)
                {
                    MessageBox.Show($"The quantity of {name} has reached 0.");
                }
            }

            using (var con2 = new SQLiteConnection(cs2))
            using (var cmd2 = new SQLiteCommand(con2))
            {
                con2.Open();

                cmd2.CommandText = $"INSERT INTO transmissionsHistory_{currentDay:yyyyMMdd} (name, type, brand, price, expirationDate, transmissonDate) VALUES (@name, @type, @brand, @price, @expirationDate, @transmissonDate);";
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@type", type);
                cmd2.Parameters.AddWithValue("@brand", brand);
                cmd2.Parameters.AddWithValue("@price", price);
                cmd2.Parameters.AddWithValue("@expirationDate", expirationDateObj);
                cmd2.Parameters.AddWithValue("@transmissonDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd2.ExecuteNonQuery();
            }
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
                name = dr.GetString(1);
                type = dr.IsDBNull(2) ? "" : dr.GetString(2);

                brand = dr.GetString(5);
                price = dr.GetInt32(6);
                quantity = dr.GetInt32(4);
                string expirationDate = dr.GetString(7);

                // Insert values into DataGridView
                grid.Rows.Insert(0, name, type, brand, price, quantity, expirationDate);
            }

            con.Close();
        }
        public void DataShowHistory(DataGridView grid, DateTime dateTime)
        {
            currentDay = dateTime;
            using (var con = new SQLiteConnection(cs2))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name=@tableName;";
                    cmd.Parameters.AddWithValue("@tableName", "transmissionsHistory_"+currentDay.ToString("yyyyMMdd"));
                    int tableCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (tableCount != 0)
                    {
                        string stm = $"SELECT * FROM transmissionsHistory_{currentDay:yyyyMMdd}";
                        cmd.CommandText = stm;
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int ID = dr.GetInt32(0);
                                string name = dr.GetString(1);
                                string type = dr.IsDBNull(2) ? "" : dr.GetString(2);
                                string brand = dr.GetString(3);
                                int price = dr.GetInt32(4);
                                string expirationDate = dr.GetString(5);
                                string prescribingDate = dr.GetString(6);

                                // Insert values into DataGridView
                                grid.Rows.Insert(0, ID, name, type, brand, price, expirationDate.Split()[0], prescribingDate);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no data with the date (" + currentDay.ToString("yyyy-MM-dd") + ")", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                    string name = selectedRow.Cells["name"].Value.ToString();
                    cmd.CommandText = "UPDATE inventory SET quantity = quantity + 1 WHERE name = @name;";
                    cmd.Parameters.AddWithValue("@name", name);
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
                int idToDelete = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string name = selectedRow.Cells["name"].Value.ToString();
                using (var con = new SQLiteConnection(cs2))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand(con))
                    {
                        try
                        {
                            cmd.CommandText = $"DELETE FROM transmissionsHistory_{currentDay:yyyyMMdd} WHERE ID = @id AND  name=@name";

                            cmd.Parameters.AddWithValue("@id", idToDelete);
                            cmd.Parameters.AddWithValue("@name", name);
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
        public void CheckOrCreateTransmissionsHistoryTable(DateTime date)
        {
            var tableName = "transmissionsHistory_" + date.ToString("yyyyMMdd"); // Table name format: transmissionsHistory_yyyymmdd
            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS " + tableName + @" (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT NOT NULL,
            type TEXT NOT NULL,
            brand TEXT NOT NULL,
            price INTEGER NOT NULL,
            expirationDate TEXT NOT NULL,
            transmissonDate TEXT
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


    }
}
