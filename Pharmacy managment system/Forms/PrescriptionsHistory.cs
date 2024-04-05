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
    public partial class PrescriptionsHistory : Form
    {

        prescriptionClass prescriptionClass = new prescriptionClass();
        public PrescriptionsHistory()
        {
            InitializeComponent();
            
            prescriptionClass.data_showHistory(PrescriptionHistoryDataView,dateTimePicker1.Value);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                PrescriptionHistoryDataView.Rows.Clear();
                prescriptionClass.data_showHistory(PrescriptionHistoryDataView, dateTimePicker1.Value);
            }
            else
            {
                prescriptionClass.SearchHistory(textBox1.Text, PrescriptionHistoryDataView, patientIDCheck.Checked, medicationIdCheck.Checked);
            }

        }

        private void refund_Click(object sender, EventArgs e)
        {
            if (PrescriptionHistoryDataView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = PrescriptionHistoryDataView.Rows[0];
                prescriptionClass.Refund(row);
                prescriptionClass.delete(PrescriptionHistoryDataView);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PrescriptionHistoryDataView.Rows.Clear();
            prescriptionClass.data_showHistory(PrescriptionHistoryDataView,dateTimePicker1.Value);
        }
    }
}
