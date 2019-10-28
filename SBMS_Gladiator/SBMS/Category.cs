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
    public partial class Category : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        Categories categories = new Categories();
        public Category()
        {
            InitializeComponent();
            categoryGridView.DataSource = _categoryManager.show(categories);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            categories.Code = categoryCodeTextBox.Text;
            categories.Name = categoryNameTextBox.Text;

            
            if (string.IsNullOrEmpty(categoryCodeTextBox.Text))
            {
                MessageBox.Show("Code Must be required");
                categoryCodeTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(categoryNameTextBox.Text))
            {
                MessageBox.Show("Please fill the name");
                categoryNameTextBox.Focus();
                return;
            }

            if (categoryCodeTextBox.TextLength > 4 || categoryCodeTextBox.TextLength < 4)
            {
                MessageBox.Show("Code must be in 4 digit");
                return;
            }

            if (_categoryManager.IsNameexist(categories))

            {
                MessageBox.Show("Name Already Exist");
                return;
            }
            if (_categoryManager.IsCodeexist(categories))

            {
                MessageBox.Show("Code Already Exist");
                return;
            }
            
            if (saveButton.Text == "Save")
               {
               
                   bool isInsert = _categoryManager.insertvalue(categories);
                        if (isInsert)
                        {
                            MessageBox.Show("Successfully saved");
                        }
                        else
                        {
                            MessageBox.Show("Not saved");
                        }
                    }
            else
            {
                if (_categoryManager.update(categories))
                {
                   categoryGridView.DataSource = _categoryManager.show(categories);
                  
                    MessageBox.Show("Updated Successfully");
                    saveButton.Text = @"Save";
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Update failed");
                    return;
                }
            }

            categoryGridView.DataSource = _categoryManager.show(categories);

        }
        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                categoryGridView.CurrentRow.Selected = true;

                categories.Id = Convert.ToInt32(categoryGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                categoryCodeTextBox.Text = categoryGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
                categoryNameTextBox.Text = categoryGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                saveButton.Text = "Update";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            categoryGridView.DataSource = _categoryManager.show(categories);
            ClearText();
        }

        private void ClearText()
        {
            categoryCodeTextBox.Clear();
            categoryNameTextBox.Clear(); 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool isDelete = _categoryManager.delete(categories);
            try
            {
                if (isDelete)
                {
                    MessageBox.Show("Deleted");
                   categoryGridView.DataSource = _categoryManager.show(categories);
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
            saveButton.Text = @"Save";
            ClearText();
        }

        private void searchButton_Click(object sender, EventArgs e)
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

                if (_categoryManager.Search(searchTextBox.Text,searchTextBox.Text).Count > 0)
                {
                    MessageBox.Show("Search Found");
                    categoryGridView.DataSource = _categoryManager.Search(searchTextBox.Text, searchTextBox.Text);
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
    }

}

       
    
