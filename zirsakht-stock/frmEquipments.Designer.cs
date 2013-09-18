namespace zirsakht_stock
{
    partial class frmEquipments
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbUints = new System.Windows.Forms.ComboBox();
            this.txtPartNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 54);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 1002;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbUints
            // 
            this.cmbUints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUints.FormattingEnabled = true;
            this.cmbUints.Location = new System.Drawing.Point(227, 16);
            this.cmbUints.Name = "cmbUints";
            this.cmbUints.Size = new System.Drawing.Size(161, 24);
            this.cmbUints.TabIndex = 1005;
            // 
            // txtPartNum
            // 
            this.txtPartNum.Location = new System.Drawing.Point(466, 54);
            this.txtPartNum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.Size = new System.Drawing.Size(161, 23);
            this.txtPartNum.TabIndex = 1004;
            this.txtPartNum.TextChanged += new System.EventHandler(this.txtPartNum_TextChanged);
            this.txtPartNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 54);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 1008;
            this.label5.Text = "نام : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 22);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 1007;
            this.label3.Text = "نوع : ";
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(466, 19);
            this.cmbTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(161, 24);
            this.cmbTypes.TabIndex = 1006;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1009;
            this.label1.Text = "واحد :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.type,
            this.unit});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 194);
            this.dataGridView1.TabIndex = 1013;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 170;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "نوع";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 250;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "واحد";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // frmEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(693, 333);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.cmbUints);
            this.Controls.Add(this.txtPartNum);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmEquipments";
            this.Load += new System.EventHandler(this.frmEquipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbUints;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
    }
}
