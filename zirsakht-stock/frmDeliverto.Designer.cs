namespace zirsakht_stock
{
    partial class frmDeliverto
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResid = new System.Windows.Forms.TextBox();
            this.cmbTemp = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.txtTedad = new System.Windows.Forms.TextBox();
            this.cmbSites = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbEquipments = new System.Windows.Forms.ComboBox();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.txtPartNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmval = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblMojodi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnReport
            // 
            this.btnReport.Enabled = false;
            this.btnReport.Location = new System.Drawing.Point(24, 121);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(254, 23);
            this.btnReport.TabIndex = 1046;
            this.btnReport.Text = "چاپ";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1045;
            this.label1.Text = "شماره رسید :";
            // 
            // txtResid
            // 
            this.txtResid.Location = new System.Drawing.Point(632, 4);
            this.txtResid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtResid.Name = "txtResid";
            this.txtResid.Size = new System.Drawing.Size(161, 23);
            this.txtResid.TabIndex = 1044;
            this.txtResid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResid_KeyPress);
            // 
            // cmbTemp
            // 
            this.cmbTemp.AutoSize = true;
            this.cmbTemp.Location = new System.Drawing.Point(331, 143);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(57, 20);
            this.cmbTemp.TabIndex = 1031;
            this.cmbTemp.Text = "موقت";
            this.cmbTemp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 119);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 1043;
            this.label8.Text = "شماره معرفی نامه :";
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(331, 107);
            this.txtIdent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(161, 23);
            this.txtIdent.TabIndex = 1028;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 1039;
            this.label7.Text = "موجودی";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(191, 82);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 1034;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(632, 27);
            this.cmbTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(161, 24);
            this.cmbTypes.TabIndex = 1018;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // txtTedad
            // 
            this.txtTedad.Location = new System.Drawing.Point(331, 61);
            this.txtTedad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTedad.Name = "txtTedad";
            this.txtTedad.Size = new System.Drawing.Size(161, 23);
            this.txtTedad.TabIndex = 1026;
            this.txtTedad.Text = "0";
            this.txtTedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedad_KeyPress);
            this.txtTedad.Validating += new System.ComponentModel.CancelEventHandler(this.txtTedad_Validating);
            // 
            // cmbSites
            // 
            this.cmbSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSites.FormattingEnabled = true;
            this.cmbSites.Location = new System.Drawing.Point(632, 98);
            this.cmbSites.Name = "cmbSites";
            this.cmbSites.Size = new System.Drawing.Size(161, 24);
            this.cmbSites.TabIndex = 1021;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(24, 15);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(254, 60);
            this.txtDesc.TabIndex = 1033;
            // 
            // cmbEquipments
            // 
            this.cmbEquipments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipments.FormattingEnabled = true;
            this.cmbEquipments.Location = new System.Drawing.Point(632, 51);
            this.cmbEquipments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipments.Name = "cmbEquipments";
            this.cmbEquipments.Size = new System.Drawing.Size(161, 24);
            this.cmbEquipments.TabIndex = 1019;
            this.cmbEquipments.SelectedIndexChanged += new System.EventHandler(this.cmbEquipments_SelectedIndexChanged);
            // 
            // txtAgent
            // 
            this.txtAgent.Location = new System.Drawing.Point(331, 38);
            this.txtAgent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(161, 23);
            this.txtAgent.TabIndex = 1025;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(331, 15);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(161, 23);
            this.txtPerson.TabIndex = 1023;
            // 
            // txtPartNum
            // 
            this.txtPartNum.Enabled = false;
            this.txtPartNum.Location = new System.Drawing.Point(632, 75);
            this.txtPartNum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.Size = new System.Drawing.Size(161, 23);
            this.txtPartNum.TabIndex = 1020;
            this.txtPartNum.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(24, 84);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 1035;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNumber,
            this.Tedad,
            this.unit,
            this.name,
            this.Agent,
            this.ReceivedBy,
            this.date,
            this.description,
            this.ID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(899, 388);
            this.dataGridView1.TabIndex = 1017;
            // 
            // PartNumber
            // 
            this.PartNumber.DataPropertyName = "PartNumber";
            this.PartNumber.HeaderText = "part number";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.ReadOnly = true;
            this.PartNumber.Width = 120;
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
            this.unit.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "سایت";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Agent
            // 
            this.Agent.DataPropertyName = "agent";
            this.Agent.HeaderText = "تحویل دهنده";
            this.Agent.Name = "Agent";
            this.Agent.ReadOnly = true;
            this.Agent.Width = 130;
            // 
            // ReceivedBy
            // 
            this.ReceivedBy.DataPropertyName = "ReceivedBy";
            this.ReceivedBy.HeaderText = "تحویل گیرنده";
            this.ReceivedBy.Name = "ReceivedBy";
            this.ReceivedBy.ReadOnly = true;
            this.ReceivedBy.Width = 130;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "شرح";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 98);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 1042;
            this.label9.Text = "شماره اموال :";
            // 
            // txtAmval
            // 
            this.txtAmval.Location = new System.Drawing.Point(331, 84);
            this.txtAmval.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAmval.Name = "txtAmval";
            this.txtAmval.Size = new System.Drawing.Size(161, 23);
            this.txtAmval.TabIndex = 1027;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(-224, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 1040;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 1038;
            this.label11.Text = "موجودی";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(812, 55);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 1037;
            this.label12.Text = "نام : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(812, 30);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 1036;
            this.label13.Text = "نوع : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 68);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 1032;
            this.label14.Text = "تعداد :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(808, 106);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(79, 16);
            this.label15.TabIndex = 1029;
            this.label15.Text = "محل مصرف :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(498, 18);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(90, 16);
            this.label16.TabIndex = 1024;
            this.label16.Text = "تحویل گیرنده : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(498, 45);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(90, 16);
            this.label17.TabIndex = 1022;
            this.label17.Text = "تحویل دهتده : ";
            // 
            // lblMojodi
            // 
            this.lblMojodi.AutoSize = true;
            this.lblMojodi.Location = new System.Drawing.Point(70, 147);
            this.lblMojodi.Name = "lblMojodi";
            this.lblMojodi.Size = new System.Drawing.Size(12, 16);
            this.lblMojodi.TabIndex = 1047;
            this.lblMojodi.Text = " ";
            // 
            // frmDeliverto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 555);
            this.Controls.Add(this.lblMojodi);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResid);
            this.Controls.Add(this.cmbTemp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.txtTedad);
            this.Controls.Add(this.cmbSites);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cmbEquipments);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.txtPartNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAmval);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDeliverto";
            this.Text = "تحویل کالا";
            this.Load += new System.EventHandler(this.frmDeliverto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResid;
        private System.Windows.Forms.CheckBox cmbTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdent;
        
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.TextBox txtTedad;
        private System.Windows.Forms.ComboBox cmbSites;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cmbEquipments;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMojodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}