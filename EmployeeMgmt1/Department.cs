﻿using System;
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
            ShowDepartments();
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
        private void ShowDepartments()
        {
            String Query = "Select * from DepartmentTb1";
            DepList.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
        try
        {
            if(DepNameTb.text == "")
            {
                MessageBox.Show("missing data!!!");
            }
            else
            {
                string Dep = DepNameTb.Text;
                string Query = "insert into DepartmentTb1 values('{0}')";
                Query = string.Format(DepNameTb.Text);
                Con.SetData(Query);
                ShowDepartments();
                MessageBox.Show("Department Added!!!");
            }
        }
        catch (Exception Ex)
        {

            MessageBox.Show(Ex.Message);
        }
        }
    }
}
