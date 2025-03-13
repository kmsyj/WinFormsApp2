using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider9.Clear();

            bool hasError = false;

            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                errorProvider1.SetError(txtname, "Name is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtage.Text) || !Regex.IsMatch(txtage.Text, @"^\d+$"))
            {
                errorProvider2.SetError(txtage, "Age must be a number.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtaddress.Text))
            {
                errorProvider3.SetError(txtaddress, "Address is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtcn.Text) || !Regex.IsMatch(txtcn.Text, @"^\d+$"))
            {
                errorProvider4.SetError(txtcn, "Contact number must be a number.");
                hasError = true;
            }
            if (cmbcourse.SelectedIndex == -1)
            {
                errorProvider5.SetError(cmbcourse, "Course is required.");
                hasError = true;
            }
            if (cmbyear.SelectedIndex == -1)
            {
                errorProvider8.SetError(cmbyear, "Year is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                errorProvider6.SetError(txtemail, "Email is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtnameofparent.Text))
            {
                errorProvider7.SetError(txtnameofparent, "Guardian name is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtparentcn.Text) || !Regex.IsMatch(txtparentcn.Text, @"^\d+$"))
            {
                errorProvider9.SetError(txtparentcn, "Guardian contact must be a number.");
                hasError = true;
            }

            // If no errors, save profile
            if (!hasError)
            {
                MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
        }

        private void cmbyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbcourse.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });
            cmbyear.Items.AddRange(new string[] { "First", "Second", "Third", "Fourth" });
        }
    }
}
