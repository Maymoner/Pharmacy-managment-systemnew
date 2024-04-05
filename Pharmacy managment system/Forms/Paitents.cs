using Pharmacy_managment_system.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_managment_system
{
    public partial class Paitents : Form
    {
        PaitentsClass paitents = new PaitentsClass();
        public Paitents()
        {
            InitializeComponent();
            paitents.data_show(dataGridView1);
        }
        private void addButton_Click(object sender, EventArgs e)
        {

            paitents.insert(Convert.ToInt32(idtxt.Text), nametxt.Text, contactxt.Text, addresstxt.Text, gendertxt.Text, dateTimePicker1.Value, allergiestxt.Text, dataGridView1);
            idtxt.Clear();
            nametxt.Clear(); contactxt.Clear(); addresstxt.Clear();gendertxt.Text = string.Empty;allergiestxt.Text = string.Empty;
        }
      
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            paitents.Search(textBox6.Text, dataGridView1);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                paitents.delete(dataGridView1);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
