﻿namespace zirsakht_stock
{
    partial class frmkardex
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dahande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsadereh = new System.Windows.Forms.Label();
            this.lblmandeh = new System.Windows.Forms.Label();
            this.lblvaredeh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.cmbEquipments = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblsadereh);
            this.splitContainer1.Panel2.Controls.Add(this.lblmandeh);
            this.splitContainer1.Panel2.Controls.Add(this.lblvaredeh);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtDevice);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel2.Controls.Add(this.cmbTypes);
            this.splitContainer1.Panel2.Controls.Add(this.cmbEquipments);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 441);
            this.splitContainer1.SplitterDistance = 878;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PartNumber,
            this.date,
            this.Tedad,
            this.unit,
            this.dahande,
            this.receivedby,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(878, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // PartNumber
            // 
            this.PartNumber.DataPropertyName = "PartNumber";
            this.PartNumber.HeaderText = "part number";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.ReadOnly = true;
            this.PartNumber.Width = 180;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Tedad
            // 
            this.Tedad.DataPropertyName = "Tedad";
            this.Tedad.HeaderText = "تعداد";
            this.Tedad.Name = "Tedad";
            this.Tedad.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "واحد";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // dahande
            // 
            this.dahande.DataPropertyName = "dahande";
            this.dahande.HeaderText = "تحویل دهنده";
            this.dahande.Name = "dahande";
            this.dahande.ReadOnly = true;
            this.dahande.Width = 130;
            // 
            // receivedby
            // 
            this.receivedby.DataPropertyName = "receivedby";
            this.receivedby.HeaderText = "گیرنده";
            this.receivedby.Name = "receivedby";
            this.receivedby.ReadOnly = true;
            this.receivedby.Width = 220;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "وضعیت";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // lblsadereh
            // 
            this.lblsadereh.AutoSize = true;
            this.lblsadereh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsadereh.Location = new System.Drawing.Point(133, 230);
            this.lblsadereh.Name = "lblsadereh";
            this.lblsadereh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblsadereh.Size = new System.Drawing.Size(0, 18);
            this.lblsadereh.TabIndex = 1009;
            // 
            // lblmandeh
            // 
            this.lblmandeh.AutoSize = true;
            this.lblmandeh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblmandeh.Location = new System.Drawing.Point(133, 270);
            this.lblmandeh.Name = "lblmandeh";
            this.lblmandeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblmandeh.Size = new System.Drawing.Size(0, 18);
            this.lblmandeh.TabIndex = 1008;
            // 
            // lblvaredeh
            // 
            this.lblvaredeh.AutoSize = true;
            this.lblvaredeh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblvaredeh.Location = new System.Drawing.Point(133, 196);
            this.lblvaredeh.Name = "lblvaredeh";
            this.lblvaredeh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblvaredeh.Size = new System.Drawing.Size(0, 18);
            this.lblvaredeh.TabIndex = 1007;
            this.lblvaredeh.Click += new System.EventHandler(this.lblvaredeh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 229);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 1006;
            this.label3.Text = "مجموع صادره :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 269);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1005;
            this.label2.Text = "مانده :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 195);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1004;
            this.label1.Text = "مجموع وارده :";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(26, 97);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(161, 23);
            this.txtDevice.TabIndex = 1003;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(176, 385);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 28);
            this.btnPrint.TabIndex = 1002;
            this.btnPrint.Text = "گزارش";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(26, 22);
            this.cmbTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(161, 24);
            this.cmbTypes.TabIndex = 1;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // cmbEquipments
            // 
            this.cmbEquipments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipments.FormattingEnabled = true;
            this.cmbEquipments.Location = new System.Drawing.Point(26, 54);
            this.cmbEquipments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipments.Name = "cmbEquipments";
            this.cmbEquipments.Size = new System.Drawing.Size(161, 24);
            this.cmbEquipments.TabIndex = 2;
            this.cmbEquipments.SelectedIndexChanged += new System.EventHandler(this.cmbEquipments_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 143);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 1001;
            this.btnAdd.Text = "جستجو";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmkardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1187, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmkardex";
            this.Load += new System.EventHandler(this.frmkardex_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.ComboBox cmbEquipments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dahande;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Label lblsadereh;
        private System.Windows.Forms.Label lblmandeh;
        private System.Windows.Forms.Label lblvaredeh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
