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
    public partial class frmSearch : Form
    {
        frmCustomer cust = new frmCustomer();
        GlobalProcedure g_proc = new GlobalProcedure();
        int row;

        public frmSearch()
        {
            InitializeComponent();
            g_proc.fncConnectToDatabase();
            DisplayAllCustomer();
        }

        public void DisplayAllCustomer()
        {
            try
            {
                g_proc.sqlLaundryAdapter = new MySqlDataAdapter();
                g_proc.datLaundry = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procDisplayAllcustomer";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlLaundryAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datLaundry.Clear();
                g_proc.sqlLaundryAdapter.Fill(g_proc.datLaundry);
                if (g_proc.datLaundry.Rows.Count > 0)
                {
                    row = 0;
                    lblTotal.Text = "Total: " + (Convert.ToString(g_proc.datLaundry.Rows.Count));
                    grdSearch.RowCount = g_proc.datLaundry.Rows.Count;
                    while (!(g_proc.datLaundry.Rows.Count - 1 < row))
                    {
                        grdSearch.Rows[row].Cells[0].Value = g_proc.datLaundry.Rows[row]["id"].ToString();
                        grdSearch.Rows[row].Cells[1].Value = g_proc.datLaundry.Rows[row]["fullname"].ToString();
                        grdSearch.Rows[row].Cells[2].Value = g_proc.datLaundry.Rows[row]["birthdate"].ToString();
                        grdSearch.Rows[row].Cells[3].Value = g_proc.datLaundry.Rows[row]["gender"].ToString();
                        grdSearch.Rows[row].Cells[4].Value = g_proc.datLaundry.Rows[row]["address"].ToString();
                        grdSearch.Rows[row].Cells[5].Value = g_proc.datLaundry.Rows[row]["contactno"].ToString();
                        grdSearch.Rows[row].Cells[6].Value = g_proc.datLaundry.Rows[row]["emailadd"].ToString();
                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("Record not Found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                g_proc.sqlLaundryAdapter.Dispose();
                g_proc.datLaundry.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void checkboxAutoComplete_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
