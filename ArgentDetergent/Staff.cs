using Laundry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgentDetergent
{
    public partial class frmStaff : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();

        public frmStaff()
        {
            InitializeComponent();
            this.cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.SelectedIndex = 0;
            this.g_proc.fncConnectToDatabase();
        }

        private void func_ClearInput()
        {
            txtboxFullName.Clear();
            txtboxAddress.Clear();
            txtboxPhone.Clear();
            txtboxEmail.Clear();
            cboGender.SelectedIndex = 0;
            txtboxUsername.Clear();
            txtboxPassword.Clear();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxFullName.Text) || string.IsNullOrWhiteSpace(txtboxAddress.Text) || string.IsNullOrWhiteSpace(txtboxEmail.Text) || string.IsNullOrWhiteSpace(txtboxPhone.Text))
            {
                MessageBox.Show("Please enter all fields!");
                return;
            }

            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procAddStaff";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlCommand.Parameters.AddWithValue("@p_fullname", txtboxFullName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", dateBirthdate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_gender", cboGender.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_address", txtboxAddress.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_contactno", txtboxPhone.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_emailadd", txtboxEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_username", txtboxUsername.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_password", txtboxPassword.Text);
                g_proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Recorded Successfully Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                func_ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex);
            }
        }
    }
}
