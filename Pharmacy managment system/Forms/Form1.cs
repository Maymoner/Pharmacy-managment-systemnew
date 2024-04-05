using NewSQLitetest;
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
    public partial class Form1 : Form
    {
        SQLconnection sql = new SQLconnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sql.InfoCheck(userText.Text, passwordText.Text))
            {
                Form1 form1 = new Form1();
                form1.Hide();
                Mainform mainform = new Mainform();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("w", "w", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
        }
    }
}
