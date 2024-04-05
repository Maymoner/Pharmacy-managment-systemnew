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
    public partial class Pharmacists : Form
    {

        Pharmacist pharmacist = new Pharmacist();
        public Pharmacists()
        {
            
            InitializeComponent();
           
            
            pharmacist.data_show(dataGridView1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            pharmacist.insert(Convert.ToInt32(idtxt.Text), nametxt.Text, contactInfotxt.Text, addresstxt.Text, gendertxt.Text, dateTimePicker1.Value, specaiallzationtxt.Text,licensetxt.Text,  dataGridView1);
            idtxt.Clear();
            nametxt.Clear();
            contactInfotxt.Clear();
            addresstxt.Clear();
            gendertxt.Text = string.Empty;
            specaiallzationtxt.Text = string.Empty;
            licensetxt.Clear();
            
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            pharmacist.update(Convert.ToInt32(idtxt.Text), nametxt.Text, contactInfotxt.Text, addresstxt.Text, gendertxt.Text, dateTimePicker1.Value, specaiallzationtxt.Text, licensetxt.Text, dataGridView1);
           
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pharmacist.delete(dataGridView1);
            }
        }




        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            pharmacist.Search(textBox6.Text,dataGridView1);
        }
    }
}
