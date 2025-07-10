namespace projectEDP
{
    partial class AdminHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHistory));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.discountName = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pkgName = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.eDP_DatabaseDataSet = new projectEDP.EDP_DatabaseDataSet();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new projectEDP.EDP_DatabaseDataSetTableAdapters.HistoryTableAdapter();
            this.historyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDP_DatabaseDataSet1 = new projectEDP.EDP_DatabaseDataSet1();
            this.discountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountTableAdapter = new projectEDP.EDP_DatabaseDataSet1TableAdapters.DiscountTableAdapter();
            this.eDP_DatabaseDataSet2 = new projectEDP.EDP_DatabaseDataSet2();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageTableAdapter = new projectEDP.EDP_DatabaseDataSet2TableAdapters.PackageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(210, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 57);
            this.button2.TabIndex = 56;
            this.button2.Text = "Clear Filters";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 57);
            this.button1.TabIndex = 55;
            this.button1.Text = "Apply Filters";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-32, 394);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Control;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(18, 272);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 23);
            this.label27.TabIndex = 54;
            this.label27.Text = "Username";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 56);
            this.label1.TabIndex = 45;
            this.label1.Text = "Aurora Travel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 40);
            this.label2.TabIndex = 46;
            this.label2.Text = "~ History";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(22, 299);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(364, 22);
            this.userName.TabIndex = 53;
            // 
            // dateFilter
            // 
            this.dateFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter.Location = new System.Drawing.Point(22, 129);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(364, 34);
            this.dateFilter.TabIndex = 47;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(18, 220);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 23);
            this.label24.TabIndex = 52;
            this.label24.Text = "Package Name";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(18, 167);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 23);
            this.label23.TabIndex = 50;
            this.label23.Text = "Discount Name";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // discountName
            // 
            this.discountName.DataSource = this.discountBindingSource;
            this.discountName.FormattingEnabled = true;
            this.discountName.Location = new System.Drawing.Point(22, 191);
            this.discountName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discountName.Name = "discountName";
            this.discountName.Size = new System.Drawing.Size(364, 24);
            this.discountName.TabIndex = 49;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(18, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 23);
            this.label22.TabIndex = 48;
            this.label22.Text = "Booking Date";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // pkgName
            // 
            this.pkgName.DataSource = this.packageBindingSource;
            this.pkgName.FormattingEnabled = true;
            this.pkgName.Location = new System.Drawing.Point(22, 246);
            this.pkgName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pkgName.Name = "pkgName";
            this.pkgName.Size = new System.Drawing.Size(364, 24);
            this.pkgName.TabIndex = 51;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(854, 49);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 39);
            this.button7.TabIndex = 63;
            this.button7.Text = "HISTORY";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(641, 49);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 39);
            this.button6.TabIndex = 62;
            this.button6.Text = "ADMIN PANEL";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.pkgidDataGridViewTextBoxColumn,
            this.discountidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.discountNameDataGridViewTextBoxColumn,
            this.pkgnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(395, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 444);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(499, 49);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 39);
            this.button8.TabIndex = 65;
            this.button8.Text = "DISCOUNT";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // eDP_DatabaseDataSet
            // 
            this.eDP_DatabaseDataSet.DataSetName = "EDP_DatabaseDataSet";
            this.eDP_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.eDP_DatabaseDataSet;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // historyidDataGridViewTextBoxColumn
            // 
            this.historyidDataGridViewTextBoxColumn.DataPropertyName = "history_id";
            this.historyidDataGridViewTextBoxColumn.HeaderText = "history_id";
            this.historyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.historyidDataGridViewTextBoxColumn.Name = "historyidDataGridViewTextBoxColumn";
            this.historyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgidDataGridViewTextBoxColumn
            // 
            this.pkgidDataGridViewTextBoxColumn.DataPropertyName = "pkg_id";
            this.pkgidDataGridViewTextBoxColumn.HeaderText = "pkg_id";
            this.pkgidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgidDataGridViewTextBoxColumn.Name = "pkgidDataGridViewTextBoxColumn";
            this.pkgidDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountidDataGridViewTextBoxColumn
            // 
            this.discountidDataGridViewTextBoxColumn.DataPropertyName = "Discount_id";
            this.discountidDataGridViewTextBoxColumn.HeaderText = "Discount_id";
            this.discountidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountidDataGridViewTextBoxColumn.Name = "discountidDataGridViewTextBoxColumn";
            this.discountidDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountNameDataGridViewTextBoxColumn
            // 
            this.discountNameDataGridViewTextBoxColumn.DataPropertyName = "Discount_Name";
            this.discountNameDataGridViewTextBoxColumn.HeaderText = "Discount_Name";
            this.discountNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountNameDataGridViewTextBoxColumn.Name = "discountNameDataGridViewTextBoxColumn";
            this.discountNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgnameDataGridViewTextBoxColumn
            // 
            this.pkgnameDataGridViewTextBoxColumn.DataPropertyName = "pkg_name";
            this.pkgnameDataGridViewTextBoxColumn.HeaderText = "pkg_name";
            this.pkgnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkgnameDataGridViewTextBoxColumn.Name = "pkgnameDataGridViewTextBoxColumn";
            this.pkgnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // eDP_DatabaseDataSet1
            // 
            this.eDP_DatabaseDataSet1.DataSetName = "EDP_DatabaseDataSet1";
            this.eDP_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discountBindingSource
            // 
            this.discountBindingSource.DataMember = "Discount";
            this.discountBindingSource.DataSource = this.eDP_DatabaseDataSet1;
            // 
            // discountTableAdapter
            // 
            this.discountTableAdapter.ClearBeforeFill = true;
            // 
            // eDP_DatabaseDataSet2
            // 
            this.eDP_DatabaseDataSet2.DataSetName = "EDP_DatabaseDataSet2";
            this.eDP_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataMember = "Package";
            this.packageBindingSource.DataSource = this.eDP_DatabaseDataSet2;
            // 
            // packageTableAdapter
            // 
            this.packageTableAdapter.ClearBeforeFill = true;
            // 
            // AdminHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 553);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.discountName);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pkgName);
            this.Name = "AdminHistory";
            this.Text = "AdminHistory";
            this.Load += new System.EventHandler(this.AdminHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDP_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox discountName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox pkgName;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private EDP_DatabaseDataSet eDP_DatabaseDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private EDP_DatabaseDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private EDP_DatabaseDataSet1 eDP_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource discountBindingSource;
        private EDP_DatabaseDataSet1TableAdapters.DiscountTableAdapter discountTableAdapter;
        private EDP_DatabaseDataSet2 eDP_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private EDP_DatabaseDataSet2TableAdapters.PackageTableAdapter packageTableAdapter;
        private System.Windows.Forms.TextBox userName;
    }
}