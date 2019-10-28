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
    public partial class Supplier : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Suppliers _suppliers = new Suppliers();

        public Supplier()
        {
            InitializeComponent();
            supplierGridView.DataSource = _supplierManager.show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _suppliers.Code = codeTextBox.Text;
            _suppliers.Name = nameTextBox.Text;
            _suppliers.Address = addressTextBox.Text;
            _suppliers.Email = emailTextBox.Text;
            _suppliers.Contact = contactTextBox.Text;
            _suppliers.ContactPerson = contactPersonTextBox.Text;


            if (string.IsNullOrEmpty(_suppliers.Code))
            {
                MessageBox.Show("Code Must not be empty");
                codeTextBox.Focus();
                return;
            }
            if (_suppliers.Code.Length != 4)
            {
                MessageBox.Show("Code Must be in 4 Digit");
                return;
            }
            if (string.IsNullOrEmpty(_suppliers.Name))
            {
                MessageBox.Show("Please provide Name");
                nameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_suppliers.Address))
            {
                MessageBox.Show("Please provide Address");
                addressTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_suppliers.Email))
            {
                MessageBox.Show("Please provide Email");
                emailTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_suppliers.Contact))
            {
                MessageBox.Show("Please provide Contact");
                contactTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_suppliers.ContactPerson))
            {
                MessageBox.Show("Please provide Contact Person");
                contactPersonTextBox.Focus();
                return;
            }

            if (_supplierManager.IsCodeexist(_suppliers))
            {
                MessageBox.Show("Code Already Exist");
                return;
            }
            if (_supplierManager.IsEmailexist(_suppliers))
            {
                MessageBox.Show("Email Already Exist");
                return;
            }
            if (_supplierManager.IsContactexist(_suppliers))
            {
                MessageBox.Show("Contact Already Exist");
                return;
            }

            if (saveButton.Text == @"Save")
            {
                try
                {

                    bool isAdded = _supplierManager.insertvalue(_suppliers);
                    if (isAdded)
                    {
                        MessageBox.Show("Successfully Saved");
                        supplierGridView.DataSource = _supplierManager.show();
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
                    if (_supplierManager.update(_suppliers))
                    {
                        supplierGridView.DataSource = _supplierManager.show();
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
            contactPersonTextBox.Clear();
        }

        private void supplierGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (supplierGridView.Columns[e.ColumnIndex].Name == "Edit")

                {
                    supplierGridView.CurrentRow.Selected = true;
                    _suppliers.Id = Convert.ToInt32(supplierGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());


                    codeTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
                    nameTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    addressTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    emailTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    contactTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                    contactPersonTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["ContactPerson"].FormattedValue.ToString();

                    saveButton.Text = "Update";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }
        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            bool isDelete = _supplierManager.delete(_suppliers);
            try
            {
                if (isDelete)
                {
                    MessageBox.Show("Deleted");
                    supplierGridView.DataSource = _supplierManager.show();
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

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(searchTextBox.Text))
                {
                    MessageBox.Show("Search input is required");
                    searchTextBox.Focus();
                    ClearText();
                    return;
                }

                if (_supplierManager.Search(searchTextBox.Text, searchTextBox.Text, searchTextBox.Text).Count > 0)
                {
                    MessageBox.Show("Search Found");
                    supplierGridView.DataSource = _supplierManager.Search(searchTextBox.Text, searchTextBox.Text, searchTextBox.Text);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Not found");
                    searchTextBox.Clear();
                    searchTextBox.Focus();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            ClearText();
        }

        private void showButton_Click_1(object sender, EventArgs e)
        {
            supplierGridView.DataSource = _supplierManager.show();
            ClearText();
            searchTextBox.Clear();
        }
    }
}
