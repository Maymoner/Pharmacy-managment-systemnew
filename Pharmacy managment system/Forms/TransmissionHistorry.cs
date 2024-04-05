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
    public partial class TransmissionHistorry : Form
    {
        TransmissionClass transmissionClass = new TransmissionClass();
        public TransmissionHistorry()
        {
            InitializeComponent();

            transmissionClass.DataShowHistory(dataGridView1, dateTimePicker1.Value);
        }

        private void refund_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[0];
                transmissionClass.Refund(row);
                transmissionClass.delete(dataGridView1);
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            transmissionClass.DataShowHistory(dataGridView1,dateTimePicker1.Value);
        }
    }
}
