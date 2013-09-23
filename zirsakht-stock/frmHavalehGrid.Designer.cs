namespace zirsakht_stock
{
    partial class frmHavalehGrid
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
            this.btnReport = new System.Windows.Forms.Button();
            this.faEnd = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faStart = new FarsiLibrary.Win.Controls.FADatePicker();
            this.cmbSites = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbReturned = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtErsal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresidno = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.havalehno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amvalno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Location = new System.Drawing.Point(31, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 33;
            this.btnReport.Text = "چاپ";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // faEnd
            // 
            this.faEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faEnd.Location = new System.Drawing.Point(222, 56);
            this.faEnd.Name = "faEnd";
            this.faEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faEnd.Size = new System.Drawing.Size(183, 20);
            this.faEnd.TabIndex = 32;
            // 
            // faStart
            // 
            this.faStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faStart.Location = new System.Drawing.Point(222, 18);
            this.faStart.Name = "faStart";
            this.faStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faStart.Size = new System.Drawing.Size(183, 20);
            this.faStart.TabIndex = 31;
            this.faStart.SelectedDateTimeChanging += new FarsiLibrary.Win.Events.SelectedDateTimeChangingEventHandler(this.faStart_SelectedDateTimeChanging);
            // 
            // cmbSites
            // 
            this.cmbSites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSites.FormattingEnabled = true;
            this.cmbSites.Location = new System.Drawing.Point(467, 9);
            this.cmbSites.Name = "cmbSites";
            this.cmbSites.Size = new System.Drawing.Size(161, 24);
            this.cmbSites.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(634, 15);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(79, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "محل مصرف :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 60);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Partnumber :";
            // 
            // txtPart
            // 
            this.txtPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPart.Location = new System.Drawing.Point(467, 57);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(161, 23);
            this.txtPart.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 59);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "تا :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 15);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "از :";
            // 
            // cmbReturned
            // 
            this.cmbReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReturned.AutoSize = true;
            this.cmbReturned.Location = new System.Drawing.Point(130, 58);
            this.cmbReturned.Name = "cmbReturned";
            this.cmbReturned.Size = new System.Drawing.Size(63, 20);
            this.cmbReturned.TabIndex = 18;
            this.cmbReturned.Text = "موقتی";
            this.cmbReturned.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "دریافت کننده :";
            // 
            // txtErsal
            // 
            this.txtErsal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErsal.Location = new System.Drawing.Point(719, 53);
            this.txtErsal.Name = "txtErsal";
            this.txtErsal.Size = new System.Drawing.Size(100, 23);
            this.txtErsal.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "شماره حواله :";
            // 
            // txtresidno
            // 
            this.txtresidno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtresidno.Location = new System.Drawing.Point(719, 12);
            this.txtresidno.Name = "txtresidno";
            this.txtresidno.Size = new System.Drawing.Size(100, 23);
            this.txtresidno.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(31, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnumber,
            this.agent,
            this.site,
            this.tedad,
            this.date,
            this.havalehno,
            this.residno,
            this.description,
            this.temp,
            this.amvalno});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // partnumber
            // 
            this.partnumber.DataPropertyName = "partnumber";
            this.partnumber.HeaderText = "partnumber";
            this.partnumber.Name = "partnumber";
            this.partnumber.ReadOnly = true;
            this.partnumber.Width = 180;
            // 
            // agent
            // 
            this.agent.DataPropertyName = "agent";
            this.agent.HeaderText = "تحویل دهنده";
            this.agent.Name = "agent";
            this.agent.ReadOnly = true;
            // 
            // site
            // 
            this.site.DataPropertyName = "site";
            this.site.HeaderText = "محل مصرف";
            this.site.Name = "site";
            this.site.ReadOnly = true;
            // 
            // tedad
            // 
            this.tedad.DataPropertyName = "tedad";
            this.tedad.HeaderText = "تعداد";
            this.tedad.Name = "tedad";
            this.tedad.ReadOnly = true;
            this.tedad.Width = 50;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // havalehno
            // 
            this.havalehno.DataPropertyName = "havalehno";
            this.havalehno.HeaderText = "حواله";
            this.havalehno.Name = "havalehno";
            this.havalehno.ReadOnly = true;
            // 
            // residno
            // 
            this.residno.DataPropertyName = "residno";
            this.residno.HeaderText = "شماره رسید";
            this.residno.Name = "residno";
            this.residno.ReadOnly = true;
            this.residno.Width = 130;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "شرح";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // temp
            // 
            this.temp.DataPropertyName = "temp";
            this.temp.HeaderText = "موقتی";
            this.temp.Name = "temp";
            this.temp.ReadOnly = true;
            this.temp.Width = 45;
            // 
            // amvalno
            // 
            this.amvalno.DataPropertyName = "amvalno";
            this.amvalno.HeaderText = "شماره اموال";
            this.amvalno.Name = "amvalno";
            this.amvalno.ReadOnly = true;
            // 
            // frmHavalehGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1057, 389);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.faEnd);
            this.Controls.Add(this.faStart);
            this.Controls.Add(this.cmbSites);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbReturned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtErsal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresidno);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHavalehGrid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHavalehGrid_FormClosing);
            this.Load += new System.EventHandler(this.frmHavalehGrid_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cmbReturned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtErsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresidno;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.ComboBox cmbSites;
        private System.Windows.Forms.Label label15;
        private FarsiLibrary.Win.Controls.FADatePicker faStart;
        private FarsiLibrary.Win.Controls.FADatePicker faEnd;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn havalehno;
        private System.Windows.Forms.DataGridViewTextBoxColumn residno;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn amvalno;
       

    }
}
