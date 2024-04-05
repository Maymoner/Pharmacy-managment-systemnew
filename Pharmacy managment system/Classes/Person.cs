using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
namespace Pharmacy_managment_system
{
    abstract class Person
    {
        protected int ID;
        protected string name ,contact,address,gender;
        protected DateTime dateOfBirth;
        public abstract void data_show(DataGridView grid);
        public abstract void insert(int id, string name, string dateOfBirth,string contactInfo, string address, string gender, DataGridView grid);
        public abstract void update(int idtxt, string nametxt,   string dateOfBirthtxt, string contactInfotxt, string addresstxt, string gendertxt, DataGridView grid);
        public abstract void delete(DataGridView gridView);
        public abstract void Search(string searchText, DataGridView grid);
        //remember the search function
    }
}
