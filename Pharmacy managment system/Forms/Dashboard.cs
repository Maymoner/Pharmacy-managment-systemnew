using Pharmacy_managment_system.Classes;
using Pharmacy_managment_system.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_managment_system
{
    public partial class Dashboard : Form
    {
        prescriptionClass prescription = new prescriptionClass();
        TransmissionClass transmission = new TransmissionClass();
        DashboardClass dashboardClass= new DashboardClass();
        public Dashboard()
        {
            InitializeComponent();
            DateTime currentTime = DateTime.Today;
            prescription.CheckOrCreatePrescriptionTable(currentTime);
            transmission.CheckOrCreateTransmissionsHistoryTable(currentTime);
            dashboardClass.totalRevenue(moneylab,dateTimePicker1.Value);
            dashboardClass.totalPatients(patientsLab,dateTimePicker1.Value);
            dashboardClass.data_showQuantity(dataGridView1);
            dashboardClass.data_showExpDate(dataGridView2);
        }

    }
}
