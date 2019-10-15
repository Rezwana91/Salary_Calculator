using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        Salary salary = new Salary();

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            //validation check

            if (String.IsNullOrEmpty(employeeNameTextBox.Text))
            {
                MessageBox.Show("Employee Name cannnot be empty!");
                return;
            }

            if (String.IsNullOrEmpty(basicAmountTextBox.Text))
            {
                MessageBox.Show("Basic amount cannnot be empty!");
                return; 
            }

            if (String.IsNullOrEmpty(homeRentTextBox.Text))
            {
                MessageBox.Show("Home rent cannnot be empty!");
                return;
            }

            if (String.IsNullOrEmpty(medicalAllowanceTextBox.Text))
            {
                MessageBox.Show("Medical allowance cannnot be empty!");
                return;
            }

           double basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
           double houseRent = Convert.ToDouble(homeRentTextBox.Text);
           double medical = Convert.ToDouble(medicalAllowanceTextBox.Text);

            salary.employeeName = employeeNameTextBox.Text;
            MessageBox.Show(salary.Calculate(basicAmount, houseRent, medical));




        }
    }
}
