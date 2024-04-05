using NewSQLitetest;
using Pharmacy_managment_system.Classes;
using Pharmacy_managment_system.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_managment_system
{
    public partial class Inventory : Form
    {
        inventoryClass inventory = new inventoryClass();
        public Inventory()
        {
            InitializeComponent();
            inventory.data_show(dataGridView1);
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                inventory.insert(Convert.ToInt32(idtxt.Text), nametxt.Text,typetxt.Text, Convert.ToDouble(dosagetxt.Text.Split()[0]),measurementBox.Text, Convert.ToInt32(quantitytxt.Text), brandtxt.Text, Convert.ToInt32(pricetxt.Text), dateTimePicker1.Value, dataGridView1);
                idtxt.Clear();
                nametxt.Clear();
                typetxt.Items.Clear();
                dosagetxt.Clear();
                quantitytxt.Clear();
                brandtxt.Clear(); pricetxt.Clear();
            }
            catch (FormatException ex) { MessageBox.Show("one of the inputs are wrong","Miss type"); }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                inventory.delete(dataGridView1);
            }
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.update(Convert.ToInt32(idtxt.Text), nametxt.Text, typetxt.Text, Convert.ToDouble(dosagetxt.Text.Split()[0]), Convert.ToInt32(quantitytxt.Text), brandtxt.Text, Convert.ToInt32(pricetxt.Text), dateTimePicker1.Value, dataGridView1);
            }
            catch (FormatException ex) { MessageBox.Show("one of the inputs are wrong", "Miss type"); }
        }

        private void checkExpartionButton_Click(object sender, EventArgs e)
        {
            ExpirationList expirationList = new ExpirationList();
            expirationList.Show();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            inventory.Search(textBox6.Text,dataGridView1);
        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["name"].Value.ToString();
                string type = selectedRow.Cells["type"].Value.ToString();
                string dosage = selectedRow.Cells["dosage"].Value.ToString();
                string quantity= selectedRow.Cells["quantity"].Value.ToString();
                string brand = selectedRow.Cells["brand"].Value.ToString() ;
                string price = selectedRow.Cells["price"].Value.ToString();
                string expirationdate = selectedRow.Cells["expirationdate"].Value.ToString();

                idtxt.Text = id;
                nametxt.Text = name;
                typetxt.Text = type;
                dosagetxt.Text = dosage;
                quantitytxt.Text = quantity;
                brandtxt.Text = brand;
                pricetxt.Text = price;
                dateTimePicker1.Text = expirationdate;

            }
        }
    }
}
