using Laundry;
using MySql.Data.MySqlClient;
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
    public partial class frmEdit : Form
    {
        GlobalProcedure g_proc = new GlobalProcedure();
        int v_index = 0;

        public frmEdit(int v_indexID)
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            g_proc.fncConnectToDatabase();
            this.cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            v_index = v_indexID;
            func_LoadCustomerData();
        }

        private void func_LoadCustomerData()
        {
            try
            {
                g_proc.sqlLaundryAdapter = new MySqlDataAdapter();
                g_proc.datLaundry = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procShowEditCustomer";
                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", v_index);
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlLaundryAdapter.SelectCommand = g_proc.sqlCommand;

                g_proc.datLaundry.Clear();
                g_proc.sqlLaundryAdapter.Fill(g_proc.datLaundry);

                if (g_proc.datLaundry.Rows.Count > 0)
                {
                    DataRow row = g_proc.datLaundry.Rows[0];
                    txtboxFullName.Text = row["fullname"].ToString();
                    dateBirthdate.Value = Convert.ToDateTime(row["birthdate"]);
                    cboGender.SelectedItem = row["gender"].ToString();
                    txtboxAddress.Text = row["address"].ToString();
                    txtboxPhone.Text = row["contactno"].ToString();
                    txtboxEmail.Text = row["emailadd"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            g_proc.sqlLaundryAdapter.Dispose();
            g_proc.datLaundry.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procSaveEditCustomer";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;

                g_proc.sqlCommand.Parameters.AddWithValue("@p_id", v_index);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_fullname", txtboxFullName.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", dateBirthdate.Value);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_gender", cboGender.SelectedItem.ToString());
                g_proc.sqlCommand.Parameters.AddWithValue("@p_address", txtboxAddress.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_contactno", txtboxPhone.Text);
                g_proc.sqlCommand.Parameters.AddWithValue("@p_emailadd", txtboxEmail.Text);

                int rowsAffected = g_proc.sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record updated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
