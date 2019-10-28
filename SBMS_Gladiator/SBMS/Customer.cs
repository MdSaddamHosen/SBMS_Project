using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.BLL;
using SBMS.Model;

namespace SBMS
{
    public partial class Customer : Form
    {

        CustomerManager _customerManager = new CustomerManager();
        Customers _customers = new Customers();
        public Customer()
        {
            InitializeComponent();
            customerDataGridView.DataSource = _customerManager.show();
        }

        private void saveButton_Click(object sender, EventArgs e)

        {

            _customers.Code = codeTextBox.Text;
            _customers.Name = nameTextBox.Text;
            _customers.Address = addressTextBox.Text;
            _customers.Email = emailTextBox.Text;
            _customers.Contact = contactTextBox.Text;
            _customers.LoyltyPoint = Convert.ToDouble( loyltyPointTextBox.Text);


            if (string.IsNullOrEmpty(_customers.Code))
            {
                MessageBox.Show("Code Must not be empty");
                codeTextBox.Focus();
                return;
            }
            if (_customers.Code.Length != 4)
            {
                MessageBox.Show("Code Must be in 4 Digit");
                return;
            }
            if (string.IsNullOrEmpty(_customers.Name))
            {
                MessageBox.Show("Please provide Name");
                nameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_customers.Address))
            {
                MessageBox.Show("Please provide Address");
                addressTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_customers.Email))
            {
                MessageBox.Show("Please provide Email");
                emailTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_customers.Contact))
            {
                MessageBox.Show("Please provide Contact");
                contactTextBox.Focus();
                return;
            }
            if  (_customers.LoyltyPoint==0)
            {
                MessageBox.Show("Please provide Contact Person");
                loyltyPointTextBox.Focus();
                return;
            }

            if (_customerManager.IsCodeexist(_customers))
            {
                MessageBox.Show("Code Already Exist");
                return;
            }
            if (_customerManager.IsEmailexist(_customers))
            {
                MessageBox.Show("Email Already Exist");
                return;
            }
            if (_customerManager.IsContactexist(_customers))
            {
                MessageBox.Show("Contact Already Exist");
                return;
            }

            if (saveButton.Text == @"Save")
            {
                try
                {

                    bool isAdded = _customerManager.insertvalue(_customers);
                    if (isAdded)
                    {
                        MessageBox.Show("Successfully Saved");
                        customerDataGridView.DataSource = _customerManager.show();
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            else
            {
                try
                {
                    if (_customerManager.update(_customers))
                    {
                        customerDataGridView.DataSource = _customerManager.show();
                        saveButton.Text = @"Save";
                        MessageBox.Show("Updated Successfully");
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                        return;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }


        }
        private void ClearText()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            loyltyPointTextBox.Clear();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            customerDataGridView.DataSource = _customerManager.show();
            ClearText();
            searchTextBox.Clear();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool isDelete = _customerManager.delete(_customers);
            try
            {
                if (isDelete)
                {
                    MessageBox.Show("Deleted");
                    customerDataGridView.DataSource = _customerManager.show();
                }
                else
                {
                    MessageBox.Show("Not deleted");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            ClearText();
            saveButton.Text = @"Save";


        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (customerDataGridView.Columns[e.ColumnIndex].Name == "Edit")

                {
                    customerDataGridView.CurrentRow.Selected = true;
                    //_customers.Id = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());

                    _customers.Id = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                    codeTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
                    nameTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    addressTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    emailTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    contactTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                    loyltyPointTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells["LoyltyPoint"].FormattedValue.ToString();

                    saveButton.Text = "Update";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(searchButton.Text))
                {
                    MessageBox.Show("Search input is required");
                    searchButton.Focus();
                    return;
                }

                if (_customerManager.Search(searchTextBox.Text, searchTextBox.Text, searchTextBox.Text).Count > 0)
                {
                    MessageBox.Show("Search Found");
                    customerDataGridView.DataSource = _customerManager.Search(searchTextBox.Text,searchTextBox.Text,searchTextBox.Text);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Not found");
                    searchTextBox.Clear();
                    searchTextBox.Focus();
                }
            
            


        }
    }
}
