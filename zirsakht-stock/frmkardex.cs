using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;


using System.Reflection;

namespace zirsakht_stock
{
    public partial class frmkardex : zirsakht_stock.template
    {
        lqStockDataContext lq = new lqStockDataContext();
        object sql;
        public frmkardex()
        {
            InitializeComponent();
            var q = (from s in lq.vwKardes 
                     orderby s.date
                     orderby s.dateadded
                             select s).ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = q;


            var typequery = (from s in lq.tblTypes
                             select s).ToList();
            cmbTypes.DisplayMember = "TypeDesc";
            cmbTypes.ValueMember = "ID";
            cmbTypes.DataSource = typequery.ToArray();

            tblType a = new tblType();
            a.TypeDesc = "سایر";
            a.ID = -1;
            typequery.Add(a);
            cmbTypes.DisplayMember = "TypeDesc";
            cmbTypes.ValueMember = "ID";
            cmbTypes.DataSource = typequery.ToArray();

        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cmbequipments();

        }

        private void _cmbequipments()
        {
            if (Convert.ToInt32(cmbTypes.SelectedValue) == -1)
            {
                sql = (from s in lq.vwKardes
                          orderby s.id
                             select s);

                dataGridView1.DataSource = sql;
                cmbEquipments.Enabled = false;
            
            }
            else
            {
                cmbEquipments.Enabled = true;
                var query = (from s in lq.tblEquipments
                             where s.tblType.ID == Convert.ToInt32(cmbTypes.SelectedValue)
                             select s).ToList();

                tblEquipment a = new tblEquipment();
                a.Partnumber = "سایر";
                a.ID = -1;
                query.Add(a);
                cmbEquipments.DisplayMember = "Partnumber";
                cmbEquipments.ValueMember = "ID";
                cmbEquipments.DataSource = query.ToArray();
            }

        }

        private void cmbEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = (from s in lq.vwKardes
                   join t in lq.tblEquipments on s.equipid equals t.ID
                   join u in lq.tblUnits on t.UnitID equals u.ID
                   where s.equipid == Convert.ToInt32(cmbEquipments.SelectedValue)
                   orderby s.mj descending
                   select new {status=-s.status, partnumber = s.partnumber, tedad = s.tedad, receivedby = s.receivedby, dahande = s.dahande, vdate=s.vdate,sdate=s.sdate,date = s.date, mj = s.mj, sadereh = s.sadereh, varedeh=s.varedeh, unit = u.Unit });

            dataGridView1.DataSource = sql;
            mojoudi(Convert.ToInt32(cmbEquipments.SelectedValue));

           

        }
        private void mojoudi(int equipid)
        {
            var varedeh = lq.fnCalculatevaredeh(equipid);
            var sadereh = lq.fnCalculatesadereh(equipid);

            lblmandeh.Text = Convert.ToString(varedeh - sadereh);
            lblsadereh.Text = Convert.ToString(sadereh);
            lblvaredeh.Text = Convert.ToString(varedeh);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           frmKardexviewer m = new frmKardexviewer(sql);
            m.ShowDialog();
                
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((e.RowIndex) < (this.dataGridView1.Rows.Count ))
            {

                DataGridViewRow gvr = this.dataGridView1.Rows[e.RowIndex];

                if (Convert.ToInt32(gvr.Cells["status"].Value.ToString()) == 1)
                {

                    gvr.DefaultCellStyle.BackColor = Color.Green;

                }

                else if (Convert.ToInt32(gvr.Cells["status"].Value.ToString()) ==-1)
                {

                    gvr.DefaultCellStyle.BackColor = Color.Red;

                }

            }
        }

        private void frmkardex_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = (from s in lq.vwKardes
                   where s.partnumber.Contains(txtDevice.Text)
                   select s);
            dataGridView1.DataSource = sql;
        }

        private void lblvaredeh_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
           ExportToExcel(dataGridView1);
        }

        //public static void excel()
        //{
        //     int cols;
        //    //open file 
        //    StreamWriter wr = new StreamWriter("GB STOCK.csv");

        //    //determine the number of columns and write columns to file 
        //    cols = dataGridView1.Columns.Count;
        //    for (int i = 0; i < cols - 1; i++)
        //    {
        //        wr.Write(dataGridView1.Columns[i].Name.ToString().ToUpper() + ",");
        //    }
        //    wr.WriteLine();

        //    //write rows to excel file
        //    for (int i = 0; i < (dataGridView1.Rows.Count - 1); i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            if (dataGridView1.Rows[i].Cells[j].Value != null)
        //            {
        //                wr.Write(dataGridView1.Rows[i].Cells[j].Value + ",");
        //            }
        //            else
        //            {
        //                wr.Write(",");
        //            }
        //        }

        //        wr.WriteLine();
        //    }

        //    //close file
        //    wr.Close();
        //}

        public static void ExportToExcel(DataGridView dgView)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            try
            {
                // instantiating the excel application class
                object misValue = System.Reflection.Missing.Value;
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook currentWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet currentWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)currentWorkbook.ActiveSheet;
                currentWorksheet.Columns.ColumnWidth = 18;
                if (dgView.Rows.Count > 0)
                {
                    currentWorksheet.Cells[1, 1] = DateTime.Now.ToString("s");
                    int i = 1;
                    foreach (DataGridViewColumn dgviewColumn in dgView.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[2, i] = dgviewColumn.Name;
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A2", "G2");
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
                    //headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dgView.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dgView.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dgRow.Cells.Count; cellIndex++)
                        {
                            currentWorksheet.Cells[rowIndex + 3, cellIndex + 1] = dgRow.Cells[cellIndex].Value;
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = currentWorksheet.get_Range("A1", "G" + (rowIndex + 1).ToString());
                    fullTextRange.WrapText = true;
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                }
                else
                {
                    string timeStamp = DateTime.Now.ToString("s");
                    timeStamp = timeStamp.Replace(':', '-');
                    timeStamp = timeStamp.Replace("T", "__");
                    currentWorksheet.Cells[1, 1] = timeStamp;
                    currentWorksheet.Cells[1, 2] = "No error occured";
                }
                using (SaveFileDialog exportSaveFileDialog = new SaveFileDialog())
                {
                    exportSaveFileDialog.Title = "Select Excel File";
                    exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx";

                    if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                    {
                        string fullFileName = exportSaveFileDialog.FileName;
                        // currentWorkbook.SaveCopyAs(fullFileName);
                        // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                        // the save file dialogue box

                        currentWorkbook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, System.Reflection.Missing.Value, misValue, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
                        currentWorkbook.Saved = true;
                        MessageBox.Show("Exported successfully", "Exported to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (excelApp != null)
                {
                    excelApp.Quit();
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["equipid"].Value != null)
            {
                int _row = Convert.ToInt32(dataGridView1.CurrentRow.Cells["equipid"].Value.ToString());
                mojoudi(_row);
            }

        }

       
    }
}
