using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NewSQLitetest
{
    public class SQLconnection
    {
        string path = "database.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";
        
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public void data_show(DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr.GetString(0);
                string id = dr.GetString(1);
                bool yes = false;
                if (!dr.IsDBNull(2))
                {
                    int intValue = dr.GetInt32(2);
                    if (intValue == 1)
                        yes = true;
                }
                grid.Rows.Insert(0, name, id, yes);
            }
            con.Close();
        }
        public void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20),id varchar (12))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else { Console.WriteLine("Database coannot create"); return; }
        }

        public void insert(TextBox nametext, TextBox idtext, CheckBox checkBoxtext, DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO test(name, id, Yes) VALUES(@name, @id, @Yes)";
                string NAME = nametext.Text;
                string ID = idtext.Text;
                bool Yes = checkBoxtext.Checked;
                int yescheck = Yes ? 1 : 0; // Convert boolean to integer

                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@Yes", yescheck); // Add boolean parameter

                grid.ColumnCount = 3;
                grid.Columns[0].Name = "Name";
                grid.Columns[1].Name = "ID";
                grid.Columns[2].Name = "Yes"; // Add column for boolean value

                string[] row = new string[] { NAME, ID, Yes.ToString() }; // Add boolean value to the row
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
        public void insert(TextBox nametext, TextBox idtext)
        {
            
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO accounts(email, password) VALUES(@email, @password)";
                string NAME = nametext.Text;
                string ID = idtext.Text;


                cmd.Parameters.AddWithValue("@email", NAME);
                cmd.Parameters.AddWithValue("@password", ID);
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
        public void insert(TextBox idText, TextBox nameText, TextBox dosageText,TextBox brandText,TextBox priceText,TextBox expirationDate, DataGridView grid)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO inventory(id, name, dosage,brand,price,expirationDate) VALUES(@id, @name, @dosage,@brand,@price,@expirationDate)";
                int ID = Convert.ToInt32(idText.Text);
                string name = nameText.Text;
                int dosage = Convert.ToInt32(dosageText.Text);
                string brand = brandText.Text;
                int price = Convert.ToInt32(priceText.Text); // Convert boolean to integer
                string expiration = expirationDate.Text;
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dosage", dosage);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@expirationDate", expiration); // Add boolean parameter

                grid.ColumnCount = 4;
                grid.Columns[0].Name = "id";
                grid.Columns[1].Name = "name";
                grid.Columns[2].Name = "dosage";
                grid.Columns[3].Name = "brand";
                grid.Columns[4].Name = "price";
                grid.Columns[5].Name = "expirationDate";
                // Add column for boolean value

                string[] row = new string[] { ID.ToString(), name, dosage.ToString(),brand,price.ToString(),expiration }; // Add boolean value to the row
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
        public bool InfoCheck(string UserName, string password)
        {
            using (var con = new SQLiteConnection(cs))
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "SELECT COUNT(*) FROM accounts WHERE UserName = @UserName AND Password = @Password";
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        public void update(TextBox nametext, TextBox idtext, CheckBox checkBoxtext, DataGridView grid)
        {
            if (grid.SelectedRows.Count > 0)
            {
                var selectedRow = grid.SelectedRows[0];
                string nameToUpdate = selectedRow.Cells["Name"].Value.ToString();

                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand(con))
                    {
                        try
                        {
                            cmd.CommandText = "UPDATE test SET id = @Id, Yes = @Yes WHERE name = @Name";
                            cmd.Parameters.AddWithValue("@Id", idtext.Text);
                            cmd.Parameters.AddWithValue("@Name", nameToUpdate);
                            cmd.Parameters.AddWithValue("@Yes", checkBoxtext.Checked ? 1 : 0);
                            cmd.ExecuteNonQuery();

                            // Update the DataGridView with the new value
                            selectedRow.Cells["ID"].Value = idtext.Text;
                            selectedRow.Cells["Yes"].Value = checkBoxtext.Checked; // Update the boolean value in the DataGridView
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
                string nameToDelete = selectedRow.Cells["Name"].Value.ToString();

                using (var con = new SQLiteConnection(cs))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand(con))
                    {
                        try
                        {
                            cmd.CommandText = "DELETE FROM test WHERE name = @Name";
                            cmd.Parameters.AddWithValue("@Name", nameToDelete);
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
        public void AddSpecializationAndLicense(string specialization, string license)
        {
            string cs = @"URI=file:" + Application.StartupPath + "\\database.db";

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(con))
                {
                    try
                    {
                        cmd.CommandText = "UPDATE pharmacists SET specialization = @specialization, license = @license WHERE specialization = @specialization";
                        cmd.Parameters.AddWithValue("@specialization", specialization);
                        cmd.Parameters.AddWithValue("@license", license);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error updating specialization and license: " + ex.Message);
                    }
                }
            }
        }
    }
}
