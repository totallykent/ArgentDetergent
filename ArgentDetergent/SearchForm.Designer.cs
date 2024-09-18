namespace ArgentDetergent
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagridSearch = new System.Windows.Forms.DataGridView();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridSearch
            // 
            this.datagridSearch.AllowUserToAddRows = false;
            this.datagridSearch.AllowUserToOrderColumns = true;
            this.datagridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFullName,
            this.colGender,
            this.colAddress,
            this.colContactNo,
            this.colEmail});
            this.datagridSearch.Location = new System.Drawing.Point(12, 184);
            this.datagridSearch.Name = "datagridSearch";
            this.datagridSearch.ReadOnly = true;
            this.datagridSearch.Size = new System.Drawing.Size(1008, 407);
            this.datagridSearch.TabIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colContactNo
            // 
            this.colContactNo.HeaderText = "Contact No.";
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblSearch.Location = new System.Drawing.Point(13, 57);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(128, 33);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(147, 57);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(354, 31);
            this.txtboxSearch.TabIndex = 32;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.ControlBox = false;
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.datagridSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.datagridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
    }
}