namespace projectEDP
{
    partial class FormSign_Up
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
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.cmBoxGender = new System.Windows.Forms.ComboBox();
            this.txtBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.txtBoxUsername2 = new System.Windows.Forms.TextBox();
            this.txtBoxPassword2 = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.bttnRegister = new System.Windows.Forms.Button();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblUsername2 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(229, 285);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 39;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(236, 224);
            this.txtBoxPhone.Multiline = true;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(197, 25);
            this.txtBoxPhone.TabIndex = 38;
            // 
            // cmBoxGender
            // 
            this.cmBoxGender.FormattingEnabled = true;
            this.cmBoxGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmBoxGender.Location = new System.Drawing.Point(158, 332);
            this.cmBoxGender.Name = "cmBoxGender";
            this.cmBoxGender.Size = new System.Drawing.Size(121, 24);
            this.cmBoxGender.TabIndex = 37;
            // 
            // txtBoxConfirmPass
            // 
            this.txtBoxConfirmPass.Location = new System.Drawing.Point(292, 499);
            this.txtBoxConfirmPass.Multiline = true;
            this.txtBoxConfirmPass.Name = "txtBoxConfirmPass";
            this.txtBoxConfirmPass.PasswordChar = '*';
            this.txtBoxConfirmPass.Size = new System.Drawing.Size(197, 25);
            this.txtBoxConfirmPass.TabIndex = 36;
            // 
            // txtBoxUsername2
            // 
            this.txtBoxUsername2.Location = new System.Drawing.Point(191, 384);
            this.txtBoxUsername2.Multiline = true;
            this.txtBoxUsername2.Name = "txtBoxUsername2";
            this.txtBoxUsername2.Size = new System.Drawing.Size(197, 25);
            this.txtBoxUsername2.TabIndex = 35;
            // 
            // txtBoxPassword2
            // 
            this.txtBoxPassword2.Location = new System.Drawing.Point(197, 436);
            this.txtBoxPassword2.Multiline = true;
            this.txtBoxPassword2.Name = "txtBoxPassword2";
            this.txtBoxPassword2.Size = new System.Drawing.Size(197, 25);
            this.txtBoxPassword2.TabIndex = 34;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(137, 176);
            this.txtBoxEmail.Multiline = true;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(197, 25);
            this.txtBoxEmail.TabIndex = 33;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(137, 121);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(197, 25);
            this.txtBoxName.TabIndex = 32;
            // 
            // bttnRegister
            // 
            this.bttnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRegister.Location = new System.Drawing.Point(112, 577);
            this.bttnRegister.Name = "bttnRegister";
            this.bttnRegister.Size = new System.Drawing.Size(346, 37);
            this.bttnRegister.TabIndex = 31;
            this.bttnRegister.Text = "REGISTER";
            this.bttnRegister.UseVisualStyleBackColor = false;
            this.bttnRegister.Click += new System.EventHandler(this.bttnRegister_Click);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(48, 495);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(238, 25);
            this.lblConfirmPass.TabIndex = 30;
            this.lblConfirmPass.Text = "CONFIRM PASSWORD :";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.Location = new System.Drawing.Point(50, 436);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(141, 25);
            this.lblPassword2.TabIndex = 29;
            this.lblPassword2.Text = "PASSWORD :";
            // 
            // lblUsername2
            // 
            this.lblUsername2.AutoSize = true;
            this.lblUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername2.Location = new System.Drawing.Point(50, 384);
            this.lblUsername2.Name = "lblUsername2";
            this.lblUsername2.Size = new System.Drawing.Size(135, 25);
            this.lblUsername2.TabIndex = 28;
            this.lblUsername2.Text = "USERNAME :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(48, 332);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(105, 25);
            this.lblGender.TabIndex = 27;
            this.lblGender.Text = "GENDER :";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(50, 282);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(173, 25);
            this.lblDOB.TabIndex = 26;
            this.lblDOB.Text = "DATE OF BIRTH :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(48, 224);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(182, 25);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "PHONE NUMBER :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(48, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(83, 25);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "EMAIL :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(50, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 25);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "NAME :";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(119, 30);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(287, 29);
            this.lblRegister.TabIndex = 22;
            this.lblRegister.Text = "REGISTRATION FORM";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // FormSign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 678);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.cmBoxGender);
            this.Controls.Add(this.txtBoxConfirmPass);
            this.Controls.Add(this.txtBoxUsername2);
            this.Controls.Add(this.txtBoxPassword2);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.bttnRegister);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblUsername2);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegister);
            this.Name = "FormSign_Up";
            this.Text = "FormSign_Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.ComboBox cmBoxGender;
        private System.Windows.Forms.TextBox txtBoxConfirmPass;
        private System.Windows.Forms.TextBox txtBoxUsername2;
        private System.Windows.Forms.TextBox txtBoxPassword2;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button bttnRegister;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblUsername2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRegister;
    }
}