﻿namespace ArgentDetergent
{
    partial class frmEdit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picboxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthdate.Location = new System.Drawing.Point(419, 226);
            this.dateBirthdate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dateBirthdate.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(209, 32);
            this.dateBirthdate.TabIndex = 48;
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
            this.cboGender.Location = new System.Drawing.Point(419, 136);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(209, 33);
            this.cboGender.TabIndex = 47;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.Location = new System.Drawing.Point(36, 420);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(592, 31);
            this.txtboxEmail.TabIndex = 43;
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPhone.Location = new System.Drawing.Point(36, 226);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(304, 31);
            this.txtboxPhone.TabIndex = 44;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAddress.Location = new System.Drawing.Point(36, 330);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(592, 31);
            this.txtboxAddress.TabIndex = 45;
            // 
            // txtboxFullName
            // 
            this.txtboxFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFullName.Location = new System.Drawing.Point(36, 136);
            this.txtboxFullName.Name = "txtboxFullName";
            this.txtboxFullName.Size = new System.Drawing.Size(354, 31);
            this.txtboxFullName.TabIndex = 46;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblBirthdate.Location = new System.Drawing.Point(413, 190);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(172, 33);
            this.lblBirthdate.TabIndex = 36;
            this.lblBirthdate.Text = "Birthdate:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblEmail.Location = new System.Drawing.Point(30, 384);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(241, 33);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblPhone.Location = new System.Drawing.Point(30, 190);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(246, 33);
            this.lblPhone.TabIndex = 38;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblGender.Location = new System.Drawing.Point(413, 100);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(134, 33);
            this.lblGender.TabIndex = 39;
            this.lblGender.Text = "Gender:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblAddress.Location = new System.Drawing.Point(30, 294);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 33);
            this.lblAddress.TabIndex = 40;
            this.lblAddress.Text = "Address:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 39);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "CUSTOMER EDIT";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(209)))));
            this.lblFullName.Location = new System.Drawing.Point(30, 100);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(173, 33);
            this.lblFullName.TabIndex = 42;
            this.lblFullName.Text = "Full Name:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F);
            this.btnSave.Location = new System.Drawing.Point(705, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 78);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save Edit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picboxProfile
            // 
            this.picboxProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxProfile.Image = global::ArgentDetergent.Properties.Resources.profilePicture;
            this.picboxProfile.Location = new System.Drawing.Point(705, 100);
            this.picboxProfile.Name = "picboxProfile";
            this.picboxProfile.Size = new System.Drawing.Size(300, 300);
            this.picboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxProfile.TabIndex = 34;
            this.picboxProfile.TabStop = false;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 642);
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
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picboxProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picboxProfile;
    }
}