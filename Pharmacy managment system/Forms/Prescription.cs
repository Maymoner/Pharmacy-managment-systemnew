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
using System.Xml.Linq;

namespace Pharmacy_managment_system.Forms
{
    public partial class Prescription : Form
    {
        prescriptionClass prescription = new prescriptionClass();
        
        public Prescription()
        {
            
            InitializeComponent();
            dataGridViewPat.SelectionChanged += dataGridViewPat_SelectionChanged;
           

        }
        private void Prescription_Load(object sender, EventArgs e)
        {
            
            prescription.data_show(dataGridViewMed);
            prescription.data_showP(dataGridViewPat);
            
        }

        private void searchPatient_TextChanged(object sender, EventArgs e)
        {
            prescription.SearchP(searchPatient.Text, dataGridViewPat);
        }

        private void searchMedication_TextChanged(object sender, EventArgs e)
        {
           
            prescription.Search(searchMedication.Text, dataGridViewMed);
        }

       

        private void dataGridViewPat_SelectionChanged(object sender, EventArgs e)
        {

            
            if (dataGridViewPat.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewPat.SelectedRows[0];


                string id = selectedRow.Cells["patid"].Value.ToString();
               


                patientIdBox.Text = id;
               
            }
        }

        

        private void dataGridViewMed_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMed.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridViewMed.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();
                string price = selectedRow.Cells["price"].Value.ToString();
                string quantity = selectedRow.Cells["quantity"].Value.ToString();
                medicationIdBox.Text = id;
                pricelable.Text = "$"+price;
                quantitylable.Text = quantity;
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            PrescriptionsHistory prescriptionHistoryForm = new PrescriptionsHistory();
            prescriptionHistoryForm.Show();
        }

        private void SELL_Click(object sender, EventArgs e)
        {
            try
            {
            prescription.insert(Convert.ToInt32(patientIdBox.Text), Convert.ToInt32(medicationIdBox.Text), Convert.ToDouble(dosageBox.Text), frequencyBox.Text, Convert.ToInt32(durationBox.Text),Convert.ToInt32( pricelable.Text),noteBox.Text);
            dataGridViewMed.Rows.Clear();
            prescription.data_show(dataGridViewMed);
            }
            catch (FormatException) { MessageBox.Show("all the boxes need to be filled"); }
            patientIdBox.Clear();
            medicationIdBox.Clear();
            dosageBox.Clear();
            durationBox.Clear();
            frequencyBox.Clear();
            pricelable.Text = "$0";
            noteBox.Clear();
            quantitylable.Text = "0";
        }
    }
}
