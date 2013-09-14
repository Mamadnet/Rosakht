namespace zirsakht_stock
{
    partial class frmResidItems
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endofgarranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnumber,
            this.tedad,
            this.residno,
            this.endofgarranty});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 373);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // partnumber
            // 
            this.partnumber.DataPropertyName = "partnumber";
            this.partnumber.HeaderText = "partnumber";
            this.partnumber.Name = "partnumber";
            this.partnumber.ReadOnly = true;
            // 
            // tedad
            // 
            this.tedad.DataPropertyName = "tedad";
            this.tedad.HeaderText = "تعداد";
            this.tedad.Name = "tedad";
            this.tedad.ReadOnly = true;
            // 
            // residno
            // 
            this.residno.DataPropertyName = "residno";
            this.residno.HeaderText = "شماره رسید";
            this.residno.Name = "residno";
            this.residno.ReadOnly = true;
            // 
            // endofgarranty
            // 
            this.endofgarranty.DataPropertyName = "endofgarranty";
            this.endofgarranty.HeaderText = "اتمام گارانتی";
            this.endofgarranty.Name = "endofgarranty";
            this.endofgarranty.ReadOnly = true;
            // 
            // frmResidItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(552, 373);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmResidItems";
            this.Load += new System.EventHandler(this.frmResidItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn residno;
        private System.Windows.Forms.DataGridViewTextBoxColumn endofgarranty;
    }
}
