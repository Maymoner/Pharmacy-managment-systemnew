using Pharmacy_managment_system.Classes;
using Pharmacy_managment_system.Forms;
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
    public partial class Mainform : Form
    {
        


        public Mainform()
        {
            InitializeComponent();
            openChildForm(new Dashboard());
            
        }
        private Form acctiveForm =null;
        private void openChildForm(Form childForm)
        {
            if(acctiveForm!=null)
            {
                acctiveForm.Close();
            }
            acctiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;  
            childForm.Dock=DockStyle.Fill;
            panelChaildForm.Controls.Add(childForm);
            panelChaildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventory());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Pharmacists());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Paitents());
        }

        

        private void TransmissionButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Transmission());
        }
    }   
}
