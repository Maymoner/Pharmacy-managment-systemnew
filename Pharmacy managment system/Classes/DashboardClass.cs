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
    internal class DashboardClass
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";
        string cs2 = @"URI=file:" + Application.StartupPath + "\\history.db";
        SQLiteDataReader dr; private string name, brand, type;
        private int ID, quantity, price;
        private double dosage;
        private string expirationDate;
        private DateTime currentDay = DateTime.Now;

        public void totalRevenue(Label label,DateTime date)
        {
            currentDay = date;
            using (var con = new SQLiteConnection(cs2))
            {
                con.Open();
                using (var cmd = new SQLiteCommand($"SELECT (SELECT SUM(price) FROM prescription_{currentDay:yyyyMMdd}) + (SELECT SUM(price) FROM transmissionsHistory_{currentDay:yyyyMMdd})", con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        label.Text = "$" + result.ToString();
                    }
                }
            }
        }
        public void totalPatients(Label label,DateTime date)
        {
            currentDay = date;
            using (var con = new SQLiteConnection(cs2))
            {
                con.Open();
                using (var cmdPrescription = new SQLiteCommand($"SELECT COUNT(*) FROM prescription_{currentDay:yyyyMMdd}", con))
                using (var cmdTransmissionHistory = new SQLiteCommand($"SELECT COUNT(*) FROM transmissionsHistory_{currentDay:yyyyMMdd}", con))
                {
                    int totalpatients = Convert.ToInt32(cmdPrescription.ExecuteScalar()) + Convert.ToInt32(cmdTransmissionHistory.ExecuteScalar());
                    label.Text = totalpatients.ToString();


                }


            }
        }
        public void data_showQuantity(DataGridView grid)
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
                dosage = dr.GetDouble(3);
                quantity = dr.GetInt32(4);
                brand = dr.GetString(5);


                // Insert values into DataGridView
                grid.Rows.Insert(0, quantity, name, type, dosage, brand);
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
               
                name = dr.GetString(1);
                type = dr.IsDBNull(2) ? "" : dr.GetString(2);
                dosage = dr.GetDouble(3);
               
                brand = dr.GetString(5);
               
                expirationDate = dr.GetString(7);

                // Insert values into DataGridView
                grid.Rows.Insert(0, expirationDate,  name, type, dosage,brand);
            }

            con.Close();
        }
    }
}
