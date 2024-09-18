namespace ArgentDetergent
{
    partial class frmCustomer
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
            this.dateBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxFullName = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.picboxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthdate.Location = new System.Drawing.Point(416, 174);
            this.dateBirthdate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dateBirthdate.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(209, 32);
            this.dateBirthdate.TabIndex = 33;
            // 
            // cboGender
            // 
            this.cboGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cboGender.Location = new System.Drawing.Point(416, 84);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(209, 33);
            this.cboGender.TabIndex = 32;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.Location = new System.Drawing.Point(33, 368);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(592, 31);
            this.txtboxEmail.TabIndex = 28;
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPhone.Location = new System.Drawing.Point(33, 174);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(304, 31);
            this.txtboxPhone.TabIndex = 29;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAddress.Location = new System.Drawing.Point(33, 278);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(592, 31);
            this.txtboxAddress.TabIndex = 30;
            // 
            // txtboxFullName
            // 
            this.txtboxFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFullName.Location = new System.Drawing.Point(33, 84);
            this.txtboxFullName.Name = "txtboxFullName";
            this.txtboxFullName.Size = new System.Drawing.Size(354, 31);
            this.txtboxFullName.TabIndex = 31;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblBirthdate.Location = new System.Drawing.Point(410, 138);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(172, 33);
            this.lblBirthdate.TabIndex = 22;
            this.lblBirthdate.Text = "Birthdate:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblEmail.Location = new System.Drawing.Point(27, 332);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(241, 33);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblPhone.Location = new System.Drawing.Point(27, 138);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(246, 33);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblGender.Location = new System.Drawing.Point(410, 48);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(134, 33);
            this.lblGender.TabIndex = 25;
            this.lblGender.Text = "Gender:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblAddress.Location = new System.Drawing.Point(27, 242);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 33);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address:";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblFullName.Location = new System.Drawing.Point(27, 48);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(173, 33);
            this.lblFullName.TabIndex = 27;
            this.lblFullName.Text = "Full Name:";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F);
            this.btnCreate.Location = new System.Drawing.Point(702, 449);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(300, 78);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // picboxProfile
            // 
            this.picboxProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxProfile.Image = global::ArgentDetergent.Properties.Resources.profilePicture;
            this.picboxProfile.Location = new System.Drawing.Point(702, 48);
            this.picboxProfile.Name = "picboxProfile";
            this.picboxProfile.Size = new System.Drawing.Size(300, 300);
            this.picboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxProfile.TabIndex = 20;
            this.picboxProfile.TabStop = false;
            this.picboxProfile.Click += new System.EventHandler(this.picboxProfile_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 642);
            this.ControlBox = false;
            this.Controls.Add(this.dateBirthdate);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxFullName);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.picboxProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateBirthdate;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.TextBox txtboxFullName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox picboxProfile;
    }
}