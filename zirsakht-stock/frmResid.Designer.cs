namespace zirsakht_stock
{
    partial class frmResid
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.faEnd = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faStart = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgharar = new System.Windows.Forms.TextBox();
            this.cmbReturned = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtErsal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresidno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.residno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daryaft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ersal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anbar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // faEnd
            // 
            this.faEnd.Location = new System.Drawing.Point(166, 60);
            this.faEnd.Name = "faEnd";
            this.faEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faEnd.Size = new System.Drawing.Size(183, 20);
            this.faEnd.TabIndex = 36;
            // 
            // faStart
            // 
            this.faStart.Location = new System.Drawing.Point(166, 22);
            this.faStart.Name = "faStart";
            this.faStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faStart.Size = new System.Drawing.Size(183, 20);
            this.faStart.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 63);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "تا :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 19);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "از :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 19);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Partnumber :";
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(397, 16);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(100, 23);
            this.txtPart.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 64);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "شماره قرارداد :";
            // 
            // txtgharar
            // 
            this.txtgharar.Location = new System.Drawing.Point(397, 61);
            this.txtgharar.Name = "txtgharar";
            this.txtgharar.Size = new System.Drawing.Size(100, 23);
            this.txtgharar.TabIndex = 7;
            this.txtgharar.TextChanged += new System.EventHandler(this.txtgharar_TextChanged);
            // 
            // cmbReturned
            // 
            this.cmbReturned.AutoSize = true;
            this.cmbReturned.Location = new System.Drawing.Point(88, 59);
            this.cmbReturned.Name = "cmbReturned";
            this.cmbReturned.Size = new System.Drawing.Size(74, 20);
            this.cmbReturned.TabIndex = 6;
            this.cmbReturned.Text = "برگشتی";
            this.cmbReturned.UseVisualStyleBackColor = true;
            this.cmbReturned.CheckedChanged += new System.EventHandler(this.cmbReturned_CheckedChanged);
            this.cmbReturned.CheckStateChanged += new System.EventHandler(this.cmbReturned_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 60);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ارسال کننده :";
            // 
            // txtErsal
            // 
            this.txtErsal.Location = new System.Drawing.Point(593, 60);
            this.txtErsal.Name = "txtErsal";
            this.txtErsal.Size = new System.Drawing.Size(100, 23);
            this.txtErsal.TabIndex = 4;
            this.txtErsal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtErsal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "شماره رسید :";
            // 
            // txtresidno
            // 
            this.txtresidno.Location = new System.Drawing.Point(593, 19);
            this.txtresidno.Name = "txtresidno";
            this.txtresidno.Size = new System.Drawing.Size(100, 23);
            this.txtresidno.TabIndex = 2;
            this.txtresidno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresidno_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.residno,
            this.daryaft,
            this.ersal,
            this.date,
            this.anbar,
            this.contractno});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // residno
            // 
            this.residno.DataPropertyName = "residno";
            this.residno.HeaderText = "شماره رسید";
            this.residno.Name = "residno";
            this.residno.ReadOnly = true;
            this.residno.Width = 150;
            // 
            // daryaft
            // 
            this.daryaft.DataPropertyName = "receivedby";
            this.daryaft.HeaderText = "دریافت کننده";
            this.daryaft.Name = "daryaft";
            this.daryaft.ReadOnly = true;
            this.daryaft.Width = 150;
            // 
            // ersal
            // 
            this.ersal.DataPropertyName = "ersal";
            this.ersal.HeaderText = "تحویل دهنده";
            this.ersal.Name = "ersal";
            this.ersal.ReadOnly = true;
            this.ersal.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // anbar
            // 
            this.anbar.DataPropertyName = "anbar";
            this.anbar.HeaderText = "انبار";
            this.anbar.Name = "anbar";
            this.anbar.ReadOnly = true;
            // 
            // contractno
            // 
            this.contractno.DataPropertyName = "contractno";
            this.contractno.HeaderText = "شماره قرارداد";
            this.contractno.Name = "contractno";
            this.contractno.ReadOnly = true;
            // 
            // frmResid
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(798, 408);
            this.Controls.Add(this.faEnd);
            this.Controls.Add(this.faStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgharar);
            this.Controls.Add(this.cmbReturned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtErsal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresidno);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmResid";
            this.Text = "رسید";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResid_FormClosing);
            this.Load += new System.EventHandler(this.frmResid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtresidno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtErsal;
        private System.Windows.Forms.CheckBox cmbReturned;
        private System.Windows.Forms.TextBox txtgharar;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn residno;
        private System.Windows.Forms.DataGridViewTextBoxColumn daryaft;
        private System.Windows.Forms.DataGridViewTextBoxColumn ersal;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn anbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractno;
        private FarsiLibrary.Win.Controls.FADatePicker faEnd;
        private FarsiLibrary.Win.Controls.FADatePicker faStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
