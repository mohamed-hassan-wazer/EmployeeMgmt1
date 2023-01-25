using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Department : Form
    
        Functions Con;
        public Department()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void ListerDepartments()
        {
            String Query = "Select * from DepartmentTb1";
            DepList.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
