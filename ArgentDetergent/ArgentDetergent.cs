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
    public partial class ArgentDetergent : Form
    {
        public ArgentDetergent()
        {
            InitializeComponent();
        }

        public void func_loadform(object Form)
        { 
            if (this.panelMain.Controls.Count > 0)
            this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            func_loadform(new frmCustomer());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            func_loadform(new frmSearch());
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            func_loadform(new frmStaff());
        }
    }
}
