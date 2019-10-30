using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashboardUI.Validators;
using ModelLibrary;
using FluentValidation.Results;

namespace DashboardUI
{
    public partial class DashBoard : Form
    {
        BindingList<string> errors = new BindingList<string>();

        public DashBoard()
        {
            InitializeComponent();

            listBox_ErrorList.DataSource = errors;
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            errors.Clear();

            if (!decimal.TryParse(text_AccountBalance.Text, out decimal accountBalance))
            {
                errors.Add("Account Balance: Invalid Amount");
                return;
            }

            PersonModel person = new PersonModel();
            person.FirstName = text_FirstName.Text;
            person.LastName = text_LastName.Text;
            person.AccountBalance = accountBalance;
            person.DateOfBirth = picker_DateOfBirth.Value;

            // Validate my data
            PersonValidator validator = new PersonValidator();

            ValidationResult results = validator.Validate(person);

            if (!results.IsValid)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    errors.Add($"{ failure.PropertyName }: { failure.ErrorMessage }");
                }
            }

            // Insert into database

            MessageBox.Show("Operation complete");
        }
    }
}
