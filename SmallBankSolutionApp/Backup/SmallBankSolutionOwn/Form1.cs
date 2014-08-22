using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmallBankSolutionOwn
{
    public partial class Form1 : Form
    {
        private Customer aCustomer=null;
        double amount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aCustomer = new Customer();
            Account anAccount = new Account(accountNumberTextBoxEntry.Text ,openingDateTextBoxEntry.Text);

            aCustomer.CustomerName = customerNameTextBoxEntry.Text;
            aCustomer.CustomerEmail = emailTextBoxEntry.Text;
            aCustomer.CustomerAccount = anAccount;

            MessageBox.Show(aCustomer.CustomerName+ "has opened an account with " + "an account number " +aCustomer.CustomerAccount.AccountNumber);
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            customerNameTextBoxEntry.Clear();
            emailTextBoxEntry.Clear();
            accountNumberTextBoxEntry.Clear();
            openingDateTextBoxEntry.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            customerNameTextBoxDisplay.Text = aCustomer.CustomerName;
            emailTextBoxDisplay.Text = aCustomer.CustomerEmail;
            accountNumberTextBoxDisplay.Text = aCustomer.CustomerAccount.AccountNumber;
            openingDateTextBoxDisplay.Text = aCustomer.CustomerAccount.OpeningDate;
            balanceTextBoxDisplay.Text = aCustomer.CustomerAccount.Balance.ToString();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            if (aCustomer.CustomerAccount.Deposit(amount))
            {
                MessageBox.Show(amount + " Tk. has been added to the balance");
            }

            else
            {
                MessageBox.Show("Operation failed");
            }
           
            balanceTextBoxDisplay.Text = aCustomer.CustomerAccount.Balance.ToString();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);

            if (aCustomer.CustomerAccount.Withdraw(amount))
            {
                MessageBox.Show(amount +"Tk. withdrawn");
            }

            else
            {
                MessageBox.Show("Sorry! insufficient balance");
 
            }
          
            balanceTextBoxDisplay.Text = aCustomer.CustomerAccount.Balance.ToString();
        }
    }
}
