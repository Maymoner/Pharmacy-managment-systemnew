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

namespace Pharmacy_managment_system.Forms
{
    public partial class Transmission : Form
    {
        public Transmission()
        {
            InitializeComponent();

            transmissionClass.data_show(dataGridView2);
        }
        TransmissionClass transmissionClass = new TransmissionClass();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            transmissionClass.Search(textBox1.Text, dataGridView2);
        }

        private void sellToAssign_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.Show();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                transmissionClass.Sell(selectedRow);
                dataGridView2.Rows.Clear();
                transmissionClass.data_show(dataGridView2);
            }
        }

        private void refund_Click(object sender, EventArgs e)
        {
            TransmissionHistorry transmissionHistorry = new TransmissionHistorry();
            transmissionHistorry.Show();
        }
    }
}
