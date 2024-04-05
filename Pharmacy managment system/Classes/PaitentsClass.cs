using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_managment_system.Classes
{
    internal class PaitentsClass:Person
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";

        SQLiteDataReader dr;
        public override void insert(int idtxt, string nametxt, string dateOfBirthtxt, string contactInfotxt, string addresstxt, string gendertxt, DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {

                cmd.CommandText = "INSERT INTO pharmacists(id, name,dateOfBirth, contactInfo,address,gender) VALUES(@id, @name,@dateOfBirth, @contactInfo,@address,@gender)";
                int ID = idtxt;
                string name = nametxt;
                string contact = contactInfotxt;
                string address = addresstxt;
                string gender = gendertxt;
                string dateOfBirth = dateOfBirthtxt;

                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contactInfo", contact);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

                grid.ColumnCount = 6;
                grid.Columns[0].Name = "id";
                grid.Columns[1].Name = "name";
                grid.Columns[2].Name = "contactInfo";
                grid.Columns[3].Name = "address";
                grid.Columns[4].Name = "gender";
                grid.Columns[5].Name = "dateOfBirth";


                string[] row = new string[] { ID.ToString(), name, contact, address, gender, dateOfBirth };
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
        public void insert(int idtxt, string nametxt, string contactInfotxt, string addresstxt, string gendertxt, DateTime dateOfBirthtxt,string allergiestxt , DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO paitents(id, name, dateOfBirth, contactInfo, address, gender, allergies) VALUES(@id, @name, @dateOfBirth, @contactInfo, @address, @gender, @allergies)";
                ID = idtxt;
                name = nametxt;
                contact = contactInfotxt;
                address = addresstxt;
                gender = gendertxt;
                dateOfBirth = dateOfBirthtxt;



                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contactInfo", contact);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth.ToString("yyy-MM-dd"));
                cmd.Parameters.AddWithValue("@allergies", allergiestxt);
                

                // Update DataGridView columns and add new row
                grid.ColumnCount = 7; 
                grid.Columns[0].Name = "id";
                grid.Columns[1].Name = "name";
                grid.Columns[2].Name = "contactInfo";
                grid.Columns[3].Name = "address";
                grid.Columns[4].Name = "gender";
                grid.Columns[5].Name = "dateOfBirth";
                grid.Columns[6].Name = "allergies";
               
                string[] row = new string[] { ID.ToString(), name, contact, address, gender, dateOfBirth.ToString("yyy-MM-dd"), allergiestxt };
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


        public override void update(int idtxt, string nametxt, string contactInfotxt, string addresstxt, string gendertxt, string dateOfBirthtxt, DataGridView grid)//make it work with the abstract
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
                            cmd.CommandText = "UPDATE pharmacists SET id = @id, name = @name, contact = @contactInfo, dateOfBirth = @dateOfBirth, address = @address, gender = @gender,specialization=@specialization ,license=@license WHERE id = @id";


                            // Use the ID of the selected row in the WHERE clause
                            cmd.Parameters.AddWithValue("@id", idToUpdate);
                            cmd.Parameters.AddWithValue("@name", nametxt);
                            cmd.Parameters.AddWithValue("@contactInfo", contactInfotxt);
                            cmd.Parameters.AddWithValue("@address", addresstxt);
                            cmd.Parameters.AddWithValue("@gender", gendertxt);
                            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirthtxt);

                            cmd.ExecuteNonQuery();

                            // Update the DataGridView with the new values
                            selectedRow.Cells["name"].Value = nametxt;
                            selectedRow.Cells["contact"].Value = contactInfotxt;
                            selectedRow.Cells["address"].Value = addresstxt;
                            selectedRow.Cells["gender"].Value = gendertxt;
                            selectedRow.Cells["dateOfBirth"].Value = dateOfBirthtxt;
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
        public void update(int idtxt, string nametxt, string contactInfotxt, string addresstxt, string gendertxt, string dateOfBirthtxt, string specializationtxt, string licensetxt, DataGridView grid)
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
                            cmd.CommandText = "UPDATE pharmacists SET  name = @name, contact = @contactInfo, address = @address, gender = @gender, dateOfBirth = @dateOfBirth,specialization=@specialization ,license=@license WHERE id = @id";


                            // Use the ID of the selected row in the WHERE clause
                            cmd.Parameters.AddWithValue("@id", idToUpdate);
                            cmd.Parameters.AddWithValue("@name", nametxt);
                            cmd.Parameters.AddWithValue("@contactInfo", contactInfotxt);
                            cmd.Parameters.AddWithValue("@address", addresstxt);
                            cmd.Parameters.AddWithValue("@gender", gendertxt);
                            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirthtxt);
                            cmd.Parameters.AddWithValue("@specialization", specializationtxt);
                            cmd.Parameters.AddWithValue("@license", licensetxt);
                            cmd.ExecuteNonQuery();

                            // Update the DataGridView with the new values
                            selectedRow.Cells["name"].Value = nametxt;
                            selectedRow.Cells["contact"].Value = contactInfotxt;
                            selectedRow.Cells["address"].Value = addresstxt;
                            selectedRow.Cells["gender"].Value = gendertxt;
                            selectedRow.Cells["dateOfBirth"].Value = dateOfBirthtxt;
                            selectedRow.Cells["specialization"].Value = specializationtxt;
                            selectedRow.Cells["license"].Value = licensetxt;
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
        public override void delete(DataGridView gridView)
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
                            cmd.CommandText = "DELETE FROM paitents WHERE name = @name";

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
        public override void data_show(DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM paitents";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                string contactInfo = dr.GetString(2);
                string address = dr.GetString(3);
                string gender = dr.GetString(4);
                string dateOfBirth = dr.GetString(5);
                string allergies =  dr.GetString(6); 
               

                // Insert values into DataGridView
                grid.Rows.Insert(0, id, name, dateOfBirth, contactInfo, address, gender, allergies);
            }

            con.Close();
        }
        public override void  Search(string searchText, DataGridView grid)
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
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                string contactInfo = dr.GetString(2);
                string address = dr.GetString(3);
                string gender = dr.GetString(4);
                string dateOfBirth = dr.GetString(5);
                string allergies = dr.GetString(6);


                // Insert values into DataGridView
                grid.Rows.Insert(0, id, name, dateOfBirth, contactInfo, address, gender, allergies);
            }

            con.Close();
        }


    }
}
