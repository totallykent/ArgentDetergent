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
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.Xml.Linq;

namespace ArgentDetergent
{
    public partial class frmCustomer : Form
    {
        OpenFileDialog filedialogueProfilePic = new OpenFileDialog();
        string imgProfile;
        GlobalProcedure g_proc = new GlobalProcedure();

        public frmCustomer()
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
            picboxProfile.Load("../../src/profilePicture.png");
        }

        private void picboxProfile_Click(object sender, EventArgs e)
        {
            filedialogueProfilePic.InitialDirectory = "c:\\";
            filedialogueProfilePic.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            filedialogueProfilePic.FilterIndex = 2;
            filedialogueProfilePic.RestoreDirectory = true;

            if (filedialogueProfilePic.ShowDialog() == DialogResult.OK)
            {
                picboxProfile.Image = new Bitmap(filedialogueProfilePic.FileName);
                picboxProfile.Image = new Bitmap(filedialogueProfilePic.FileName);
                imgProfile = filedialogueProfilePic.FileName;
            }
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
                g_proc.sqlCommand.CommandText = "procAddCustomer";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlCommand.Parameters.AddWithValue("@p_fullname", txtboxFullName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", dateBirthdate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_gender", cboGender.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_address", txtboxAddress.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_contactno", txtboxPhone.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_emailadd", txtboxEmail.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_cust_photo", picboxProfile);
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
