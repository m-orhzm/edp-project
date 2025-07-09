namespace projectEDP
{
    partial class DiscountForm
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
            this.components = new System.ComponentModel.Container();
            this.eDP_DatabaseDataSet = new projectEDP.EDP_DatabaseDataSet();
            this.discountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountTableAdapter = new projectEDP.EDP_DatabaseDataSetTableAdapters.DiscountTableAdapter();
            this.lblDisName = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bttnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eDP_DatabaseDataSet1
            // 
            this.eDP_DatabaseDataSet.DataSetName = "EDP_DatabaseDataSet1";
            this.eDP_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discountBindingSource
            // 
            this.discountBindingSource.DataMember = "Discount";
            this.discountBindingSource.DataSource = this.eDP_DatabaseDataSet;
            // 
            // discountTableAdapter
            // 
            this.discountTableAdapter.ClearBeforeFill = true;
            // 
            // lblDisName
            // 
            this.lblDisName.AutoSize = true;
            this.lblDisName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisName.Location = new System.Drawing.Point(31, 38);
            this.lblDisName.Name = "lblDisName";
            this.lblDisName.Size = new System.Drawing.Size(93, 32);
            this.lblDisName.TabIndex = 0;
            this.lblDisName.Text = "Name";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.Location = new System.Drawing.Point(31, 376);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(190, 32);
            this.lblExp.TabIndex = 1;
            this.lblExp.Text = "Expired Date";
            this.lblExp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(31, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(168, 32);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(31, 469);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(86, 32);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 236);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 386);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 41);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(299, 460);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 41);
            this.textBox3.TabIndex = 7;
            // 
            // bttnBack
            // 
            this.bttnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBack.Location = new System.Drawing.Point(320, 555);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(246, 46);
            this.bttnBack.TabIndex = 8;
            this.bttnBack.Text = "BACK";
            this.bttnBack.UseVisualStyleBackColor = false;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblDisName);
            this.Name = "DiscountForm";
            this.Text = "DiscountForm";
            this.Load += new System.EventHandler(this.DiscountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EDP_DatabaseDataSet eDP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource discountBindingSource;
        private EDP_DatabaseDataSetTableAdapters.DiscountTableAdapter discountTableAdapter;

        private System.Windows.Forms.Label lblDisName;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bttnBack;

    }
}