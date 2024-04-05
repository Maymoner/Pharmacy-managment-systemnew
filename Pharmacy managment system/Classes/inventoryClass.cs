using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_managment_system.Classes
{
    internal class inventoryClass
    {

        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";

        SQLiteDataReader dr;
        private string name, brand,type, measurement;
        private int ID, quantity,price;
        private double dosage;
        private DateTime expirationDate;
        public void insert(int idtxt, string nametxt, string typetxt, double dosagetxt, string measurementUnit, int quantitytxt, string brandtxt, int pricetxt, DateTime expirationDatetxt, DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO inventory(id, name, type, dosage, quantity, brand, price, expirationDate) VALUES(@id, @name, @type, @dosage, @quantity, @brand, @price, @expirationDate)";
                ID = idtxt;
                name = nametxt;
                type = typetxt;
                dosage = dosagetxt;
                quantity = quantitytxt;
                brand = brandtxt;
                price = pricetxt;
                expirationDate = expirationDatetxt;

                // Concatenate dosage with measurement unit
                string dosageWithUnit = dosagetxt.ToString() + " " + measurementUnit;

                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@dosage", dosageWithUnit);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate.ToString("yyyy-MM-dd"));

                // Update DataGridView columns and add new row
                grid.ColumnCount = 8;
                grid.Columns[0].Name = "id";
                grid.Columns[1].Name = "name";
                grid.Columns[2].Name = "type";
                grid.Columns[3].Name = "dosage";
                grid.Columns[4].Name = "quantity";
                grid.Columns[5].Name = "brand";
                grid.Columns[6].Name = "price";
                grid.Columns[7].Name = "expirationDate";

                string[] row = new string[] { ID.ToString(), name, type, dosageWithUnit, quantity.ToString(), brand, price.ToString(), expirationDate.ToString("yyyy-MM-dd") };
                grid.Rows.Add(row);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }





        public void update(int idtxt, string nametxt, string typetxt, double dosagetxt, int quantitytxt, string brandtxt, int pricetxt, DateTime expirationDatetxt, DataGridView grid)
        {
            if (grid.SelectedRows.Count > 0)
            {
                var selectedRow = grid.SelectedRows[0];
                int idToUpdate = Convert.ToInt32(selectedRow.Cells["id"].Value); // Get the ID of the selected row

                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand(con))
                    {
                        try
                        {
                            cmd.CommandText = "UPDATE inventory SET name = @name, type = @type, dosage = @dosage, quantity = @quantity, brand = @brand, price = @price, expirationDate = @expirationDate WHERE id = @id";

                     

                            // Set parameters for the update query
                            cmd.Parameters.AddWithValue("@id", idToUpdate);
                            cmd.Parameters.AddWithValue("@name", nametxt);
                            cmd.Parameters.AddWithValue("@type", typetxt);
                            cmd.Parameters.AddWithValue("@dosage", dosagetxt);
                            cmd.Parameters.AddWithValue("@quantity", quantitytxt);
                            cmd.Parameters.AddWithValue("@brand", brandtxt);
                            cmd.Parameters.AddWithValue("@price", pricetxt);
                            cmd.Parameters.AddWithValue("@expirationDate", expirationDatetxt);
                            cmd.ExecuteNonQuery();

                            // Update the DataGridView with the new values
                            selectedRow.Cells["name"].Value = nametxt;
                            selectedRow.Cells["type"].Value = typetxt;
                            selectedRow.Cells["dosage"].Value = dosagetxt;
                            selectedRow.Cells["quantity"].Value = quantitytxt;
                            selectedRow.Cells["brand"].Value = brandtxt;
                            selectedRow.Cells["price"].Value = pricetxt;
                            selectedRow.Cells["expirationDate"].Value = expirationDatetxt;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error updating row: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }


        public void delete(DataGridView gridView)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                var selectedRow = gridView.SelectedRows[0];
                string nameToDelete = selectedRow.Cells["name"].Value.ToString();

                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand(con))
                    {
                        try
                        {
                            cmd.CommandText = "DELETE FROM inventory WHERE name = @name";

                            cmd.Parameters.AddWithValue("@name", nameToDelete);
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
        public  void data_show(DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM inventory";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               ID = dr.GetInt32(0);
               name = dr.GetString(1);
               type = dr.IsDBNull(2)?"":dr.GetString(2);
               dosage = dr.GetDouble(3);
               quantity= dr.GetInt32(4);
               brand = dr.GetString(5);
               price = dr.GetInt32(6);
               string expirationDate = dr.GetString(7) ; 
     
                // Insert values into DataGridView
                grid.Rows.Insert(0, ID, name,type, dosage, quantity, brand, price, expirationDate.Split()[0]);
            }

            con.Close();
        }

        public void data_showExpDate(DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            // Retrieve medications with expiration dates near today's date
            string stm = "SELECT * FROM inventory WHERE expirationDate BETWEEN date('now') AND date('now', '+7 days')";

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ID = dr.GetInt32(0);
                name = dr.GetString(1);
                type = dr.IsDBNull(2) ? "" : dr.GetString(2);
                dosage = dr.GetDouble(3);
                quantity = dr.GetInt32(4);
                brand = dr.GetString(5);
                price = dr.GetInt32(6);
                string expirationDate = dr.GetString(7);

                // Insert values into DataGridView
                grid.Rows.Insert(0, ID, name, type, dosage, quantity, brand, price, expirationDate);
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
                ID = dr.GetInt32(0);
                name = dr.GetString(1);
                type = dr.IsDBNull(2) ? "" : dr.GetString(2);
                dosage = dr.GetDouble(3);
                quantity = dr.GetInt32(4);
                brand = dr.GetString(5);
                price = dr.GetInt32(6);
                expirationDate = dr.GetDateTime(7);

                grid.Rows.Add(ID, name, type, dosage, quantity, brand, price, expirationDate);
            }

            con.Close();
        }

    }
}
