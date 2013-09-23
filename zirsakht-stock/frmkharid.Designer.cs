namespace zirsakht_stock
{
    partial class frmkharid
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.btnResid = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGharardad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKharidType = new System.Windows.Forms.ComboBox();
            this.txtPartNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEquipments = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUints = new System.Windows.Forms.ComboBox();
            this.txtTedad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgirandeh = new System.Windows.Forms.TextBox();
            this.txtdahandeh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateadded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ersal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kharidtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 13);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 1035;
            this.label6.Text = "شرح :";
            // 
            // cmbTypes
            // 
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(709, 10);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(161, 24);
            this.cmbTypes.TabIndex = 1017;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // btnResid
            // 
            this.btnResid.Location = new System.Drawing.Point(61, 124);
            this.btnResid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResid.Name = "btnResid";
            this.btnResid.Size = new System.Drawing.Size(289, 28);
            this.btnResid.TabIndex = 1032;
            this.btnResid.Text = "ثبت رسید";
            this.btnResid.UseVisualStyleBackColor = true;
            this.btnResid.Click += new System.EventHandler(this.btnResid_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 107);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 1034;
            this.label5.Text = "شماره قرارداد :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 88);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 28);
            this.btnDelete.TabIndex = 1031;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(876, 65);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 1038;
            this.label9.Text = "نام : ";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(41, 10);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(320, 71);
            this.txtDesc.TabIndex = 1028;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 28);
            this.btnAdd.TabIndex = 1030;
            this.btnAdd.Text = "ثبت کالا";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1033;
            this.label3.Text = "نوع خرید :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNumber,
            this.dateadded,
            this.pid,
            this.contractno,
            this.Tedad,
            this.unit,
            this.ersal,
            this.date,
            this.kharidtype,
            this.description,
            this.ID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(921, 438);
            this.dataGridView1.TabIndex = 1016;
            // 
            // txtGharardad
            // 
            this.txtGharardad.Location = new System.Drawing.Point(427, 104);
            this.txtGharardad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGharardad.Name = "txtGharardad";
            this.txtGharardad.Size = new System.Drawing.Size(161, 23);
            this.txtGharardad.TabIndex = 1027;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(876, 42);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 1037;
            this.label7.Text = "نام : ";
            // 
            // cmbKharidType
            // 
            this.cmbKharidType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKharidType.FormattingEnabled = true;
            this.cmbKharidType.Location = new System.Drawing.Point(427, 80);
            this.cmbKharidType.Name = "cmbKharidType";
            this.cmbKharidType.Size = new System.Drawing.Size(161, 24);
            this.cmbKharidType.TabIndex = 1026;
            // 
            // txtPartNum
            // 
            this.txtPartNum.Location = new System.Drawing.Point(709, 58);
            this.txtPartNum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.Size = new System.Drawing.Size(161, 23);
            this.txtPartNum.TabIndex = 1019;
            this.txtPartNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartNum_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(876, 10);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 1036;
            this.label8.Text = "نوع : ";
            // 
            // cmbEquipments
            // 
            this.cmbEquipments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipments.FormattingEnabled = true;
            this.cmbEquipments.Location = new System.Drawing.Point(709, 34);
            this.cmbEquipments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipments.Name = "cmbEquipments";
            this.cmbEquipments.Size = new System.Drawing.Size(161, 24);
            this.cmbEquipments.TabIndex = 1018;
            this.cmbEquipments.SelectedIndexChanged += new System.EventHandler(this.cmbEquipments_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 61);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1029;
            this.label4.Text = "تعداد :";
            // 
            // cmbUints
            // 
            this.cmbUints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUints.FormattingEnabled = true;
            this.cmbUints.Location = new System.Drawing.Point(709, 81);
            this.cmbUints.Name = "cmbUints";
            this.cmbUints.Size = new System.Drawing.Size(161, 24);
            this.cmbUints.TabIndex = 1020;
            this.cmbUints.Visible = false;
            // 
            // txtTedad
            // 
            this.txtTedad.Location = new System.Drawing.Point(427, 57);
            this.txtTedad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTedad.Name = "txtTedad";
            this.txtTedad.Size = new System.Drawing.Size(161, 23);
            this.txtTedad.TabIndex = 1025;
            this.txtTedad.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 13);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1024;
            this.label2.Text = "دریافت کننده: ";
            // 
            // txtgirandeh
            // 
            this.txtgirandeh.Location = new System.Drawing.Point(427, 11);
            this.txtgirandeh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtgirandeh.Name = "txtgirandeh";
            this.txtgirandeh.Size = new System.Drawing.Size(161, 23);
            this.txtgirandeh.TabIndex = 1022;
            this.txtgirandeh.Text = "ارواحی";
            // 
            // txtdahandeh
            // 
            this.txtdahandeh.Location = new System.Drawing.Point(427, 34);
            this.txtdahandeh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtdahandeh.Name = "txtdahandeh";
            this.txtdahandeh.Size = new System.Drawing.Size(161, 23);
            this.txtdahandeh.TabIndex = 1023;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1021;
            this.label1.Text = "تحویل دهتده : ";
            // 
            // PartNumber
            // 
            this.PartNumber.DataPropertyName = "PartNumber";
            this.PartNumber.HeaderText = "part number";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.ReadOnly = true;
            this.PartNumber.Width = 180;
            // 
            // dateadded
            // 
            this.dateadded.DataPropertyName = "dateadded";
            this.dateadded.HeaderText = "Column1";
            this.dateadded.Name = "dateadded";
            this.dateadded.ReadOnly = true;
            this.dateadded.Visible = false;
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "pid";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Visible = false;
            // 
            // contractno
            // 
            this.contractno.DataPropertyName = "contractno";
            this.contractno.HeaderText = "شماره قرارداد";
            this.contractno.Name = "contractno";
            this.contractno.ReadOnly = true;
            // 
            // Tedad
            // 
            this.Tedad.DataPropertyName = "Tedad";
            this.Tedad.HeaderText = "تعداد";
            this.Tedad.Name = "Tedad";
            this.Tedad.ReadOnly = true;
            this.Tedad.Width = 50;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "واحد";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // ersal
            // 
            this.ersal.DataPropertyName = "ersal";
            this.ersal.HeaderText = "فرستنده";
            this.ersal.Name = "ersal";
            this.ersal.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // kharidtype
            // 
            this.kharidtype.DataPropertyName = "kharidtype";
            this.kharidtype.HeaderText = "خرید";
            this.kharidtype.Name = "kharidtype";
            this.kharidtype.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "شرح";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 220;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // frmkharid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(921, 618);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.btnResid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGharardad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKharidType);
            this.Controls.Add(this.txtPartNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEquipments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUints);
            this.Controls.Add(this.txtTedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgirandeh);
            this.Controls.Add(this.txtdahandeh);
            this.Controls.Add(this.label1);
            this.Name = "frmkharid";
            this.Text = "ثبت کالای خریداری شده";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmkharid_FormClosing);
            this.Load += new System.EventHandler(this.frmkharid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Button btnResid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGharardad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKharidType;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEquipments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUints;
        private System.Windows.Forms.TextBox txtTedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgirandeh;
        private System.Windows.Forms.TextBox txtdahandeh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateadded;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ersal;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn kharidtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;

    }
}
