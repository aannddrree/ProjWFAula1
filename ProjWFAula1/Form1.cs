using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWFAula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //LoadGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var employee = getEmployee();
            if (Crud().Insert(employee))
            {
                MessageBox.Show("Inserido com sucesso!");
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            dGVDados.DataSource = Crud().GetAll();
        }

        private Employee getEmployee()
        {
            return new Employee
            {
                Name = txtNome.Text,
                Telephone = txtTelefone.Text
            };
        }

        private IEmployeeDB Crud()
        {
            return new EmployeeDB();
        }

    }
}
