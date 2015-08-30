using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        Excel.Application myExcelApp;
        Excel.Workbooks myExcelWorkbooks;
        Excel.Workbook myExcelWorkbook;
        Excel.Worksheet myExcelWorksheet;
        OleDbConnection conn;
        main parent;
        object misValue = System.Reflection.Missing.Value;
        double summary = 0;

        int pid = -1;

        public Form1(main p)
        {


            InitializeComponent();

            button4.Visible = false;
            button5.Visible = false;
            parent = p;
            var DBPath = Application.StartupPath + "\\Data\\Data.mdb";

            conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;"
                + "Data Source=" + DBPath);
            conn.Open();
           

           /* date.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            date.AutoCompleteSource = AutoCompleteSource.ListItems;
            month.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            month.AutoCompleteSource = AutoCompleteSource.ListItems;
            year.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            year.AutoCompleteSource = AutoCompleteSource.ListItems;
            KH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            KH.AutoCompetleSource = AutoCompleteSource.ListItems;*/

            for (int i = 1; i <= 31; i++)
            {
                date.Items.Add(i.ToString());
                hd_date.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                month.Items.Add(i.ToString());
                hd_month.Items.Add(i.ToString());

            }
            for (int i = 2014; i <= 2017; i++)
            {
                year.Items.Add(i.ToString());
                hd_year.Items.Add(i.ToString());

            }
            // dataGridView2.SelectionChanged += new EventHandler(DataGridView2_SelectionChanged);

        }

        private void OpenExcel()
        {
            myExcelApp = new Excel.Application();
            myExcelApp.Visible = false;
            myExcelWorkbooks = myExcelApp.Workbooks;
            String fileName = Application.StartupPath + "\\Data\\pttform.xls"; ;
            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;
            //HandleRef hwnd = new HandleRef(myExcelApp, (IntPtr)myExcelApp.Hwnd);
            //GetWindowThreadProcessId(hwnd, out pid);
        }
        private void CloseExcel()
        {
            try
            {
                myExcelWorkbook.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                myExcelWorkbooks.Close();
                myExcelApp.Quit();
                Marshal.ReleaseComObject(myExcelWorksheet);
                Marshal.ReleaseComObject(myExcelWorksheet);
                Marshal.ReleaseComObject(myExcelWorkbook);
                Marshal.ReleaseComObject(myExcelWorkbooks);
                Marshal.ReleaseComObject(myExcelApp);
                myExcelWorksheet = null;
                myExcelWorkbooks = null;
                myExcelWorkbook = null;
                myExcelApp = null;
                GC.GetTotalMemory(false);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.GetTotalMemory(true);  

            }
            catch (Exception)
            {
            }
        }
        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //public static extern int GetWindowThreadProcessId(HandleRef handle, out int processId);
        //private void KillProcess(int pid, string processName)
        //{
        //    // to kill current process of excel
        //    System.Diagnostics.Process[] AllProcesses = System.Diagnostics.Process.GetProcessesByName(processName);
        //    foreach (System.Diagnostics.Process process in AllProcesses)
        //    {
        //        if (process.Id == pid)
        //        {
        //            process.Kill();
        //        }
        //    }
        //    AllProcesses = null;
        //}
        public void after_load()
        {
            date.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          date.AutoCompleteSource = AutoCompleteSource.ListItems;
          month.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          month.AutoCompleteSource = AutoCompleteSource.ListItems;
          year.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          year.AutoCompleteSource = AutoCompleteSource.ListItems;
          KH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          KH.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            datagridview2_clearselect();
        }

        private void read_KH()
        {
            using (DataTable dt = new DataTable())
            {
                string sql = "SELECT name FROM KH";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
                foreach (DataRow row in dt.Rows)
                {
                    MessageBox.Show(row[0].ToString());
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_name_DoubleClick(object sender, EventArgs e)
        {
            tbx_name.SelectAll();
        }

        private void KH_DoubleClick(object sender, EventArgs e)
        {
            KH.SelectAll();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string str = tbx_name.Text;
            thucDonBindingSource.Filter = string.Format("name LIKE '%{0}%'", str);
            //lbl_tonghoadon.Text = "";


        }

        private void datagridview2_clearselect()
        {
            dg_data.ClearSelection();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean check = true;
            int row_index = e.RowIndex;
            if (row_index >= 0)
            {
                double invent;
                string inventory = dg_data.Rows[row_index].Cells[3].Value.ToString();
                if (inventory.Length == 0) invent = 0;
                else invent = Double.Parse(inventory);
                Double take = Double.Parse(soluong.Text);
                dg_data.Rows[row_index].Cells[3].Value = (invent - take);
                foreach (DataGridViewRow r in dg_list.Rows)
                {
                    if (r.Cells[0].Value == dg_data.Rows[row_index].Cells[0].Value)
                    {
                        r.Cells[2].Value = Double.Parse(soluong.Text) + Double.Parse(r.Cells[2].Value.ToString());
                        check = false;
                    }
                }
                if (check)
                {
                    DataGridViewRow row = (DataGridViewRow)dg_list.Rows[0].Clone();
                    row.Cells[0].Value = dg_data.Rows[row_index].Cells[0].Value;
                    row.Cells[1].Value = dg_data.Rows[row_index].Cells[2].Value;
                    row.Cells[3].Value = dg_data.Rows[row_index].Cells[1].Value;
                    row.Cells[2].Value = soluong.Text;
                    dg_list.Rows.Add(row);
                    update_price();
                    tbx_name.Text = "";
                }
                // dataGridView2.ClearSelection();
            }
        }

        private void update_price()
        {
            int row_count = dg_list.Rows.Count - 1;
            for (int i = 0; i < row_count; i++)
            {
                DataGridViewRow r = dg_list.Rows[i];
                if (r.Cells[0].Value != null)
                {
                    String name = dg_list.Rows[i].Cells[0].Value.ToString();
                    using (DataTable dt = new DataTable())
                    {
                        string sql = "SELECT * FROM ThucDon WHERE name LIKE '" + name + "'";
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                        {
                            adapter.Fill(dt);
                        }
                        dg_list.Rows[i].Cells[1].Value = dt.Rows[0]["price"];
                    }
                }
            }
            dg_list.RefreshEdit();
            cal();
        }
        private void thucDonDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Item(object sender, DataGridViewRowCancelEventArgs e)
        {
            int row_index = dg_list.CurrentCell.RowIndex;
            Double soluong = Double.Parse(dg_list.Rows[row_index].Cells[2].Value.ToString());
            foreach (DataGridViewRow r in dg_data.Rows)
            {
                if (r.Cells[0].Value == dg_list.Rows[row_index].Cells[0].Value)
                {
                    Double tonkho = Double.Parse(r.Cells[3].Value.ToString());
                    r.Cells[3].Value = tonkho + soluong;
                    break;
                }
            }

        }


        private void Update_Inventory(DataGridViewRow r)
        {
            String name = r.Cells[0].Value.ToString();
            double soluong_bandau;
            using (DataTable dt = new DataTable())
            {
                String sql_search = "SELECT inventor FROM ThucDon WHERE name='" + name + "'";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql_search, conn))
                {
                    adapter.Fill(dt);
                }
                soluong_bandau = Double.Parse(dt.Rows[0][0].ToString());
            }

            double soluong_dachon = Double.Parse(r.Cells[2].Value.ToString());
            foreach (DataGridViewRow r_data in dg_data.Rows)
            {
                if (r_data.Cells[0].Value == r.Cells[0].Value)
                {
                    r_data.Cells[3].Value = soluong_bandau - soluong_dachon;
                }
            }

        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.ThucDon' table. You can move, or remove it, as needed.
            this.thucDonTableAdapter.Fill(this.dataDataSet.ThucDon);
            // TODO: This line of code loads data into the 'dataDataSet.KH' table. You can move, or remove it, as needed.
            this.kHTableAdapter1.Fill(this.dataDataSet.KH);
            // TODO: This line of code loads data into the 'dataDataSet.ThucDon' table. You can move, or remove it, as needed.
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dg_list.Rows[e.RowIndex];
            if (r.Cells[0].Value != null) Update_Inventory(r);
            cal();
        }

        private void cal()
        {
            int count_row = dg_list.Rows.Count;
            summary = 0;
            for (int i = 0; i < count_row - 1; i++)
            {
                if (dg_list.Rows[i].Cells[0].Value != null) summary += Double.Parse(dg_list.Rows[i].Cells[1].Value.ToString()) * Double.Parse(dg_list.Rows[i].Cells[2].Value.ToString());

            }
            lb_sum.Text = summary.ToString("N");
            lbl_thanhtien.Text = (summary * 110 / 100).ToString("N");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.dg_list.Rows.Clear();
            refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count_row = dg_list.Rows.Count;
            Boolean check = check_tb();
            if (count_row > 1 && check)
            {
                String ID = date.Text + "-" + month.Text + "-" + year.Text + "-" + number.Text;
                Boolean check_exist = false;
                using (DataTable dt = new DataTable())
                {
                    String sql_search = "SELECT * FROM phieuthanhtoan WHERE ID='" + ID + "'";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql_search, conn))
                    {
                        adapter.Fill(dt);
                    }
                    if (dt.Rows.Count > 0) check_exist = true;
                }
                if (check_exist)
                {
                    DialogResult dialogResult = MessageBox.Show("Ghi đè?", "Trùng phiếu", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Save(ID, count_row);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    Save(ID, count_row);
                }


            }
        }

        private void Save(String ID, int count_row)
        {
           
            int count = 0;
            double sum = 0;
            loading.Visible = true;
            done.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            CloseExcel();
            OpenExcel();

            try
            {
                Excel.Range Line = (Excel.Range)myExcelWorksheet.Rows[10];

                myExcelWorksheet.get_Range("G6", misValue).Formula = number.Text;
                myExcelWorksheet.get_Range("C5", misValue).Formula = hd_num.Text;
                myExcelWorksheet.get_Range("C6", misValue).Formula = date.Text + "/" + month.Text + "/" + year.Text;
                myExcelWorksheet.get_Range("G5", misValue).Formula = hd_date.Text + "/" + hd_month.Text + "/" + hd_year.Text;
                myExcelWorksheet.get_Range("C7", misValue).Formula = KH.Text;
                DataGridViewRow row;

                for (int i = 0; i < count_row - 1; i++)
                {
                    row = dg_list.Rows[i];
                    if (row.Cells[0].Value != null)
                    {
                        count++;
                        if (count < count_row - 2)
                        {

                            Line.Insert();
                        }
                        String row_num = (8 + count).ToString();
                        double price = Double.Parse(row.Cells[1].Value.ToString()) * Double.Parse(row.Cells[2].Value.ToString());
                        sum += price;
                        myExcelWorksheet.get_Range("A" + row_num, misValue).Formula = count;
                        myExcelWorksheet.get_Range("B" + row_num, misValue).Formula = row.Cells[0].Value.ToString();
                        myExcelWorksheet.get_Range("D" + row_num, misValue).Formula = row.Cells[3].Value.ToString();
                        myExcelWorksheet.get_Range("E" + row_num, misValue).Formula = row.Cells[2].Value.ToString();
                        myExcelWorksheet.get_Range("F" + row_num, misValue).Formula = row.Cells[1].Value.ToString();
                        myExcelWorksheet.get_Range("G" + row_num, misValue).Formula = price;
                    }
                }
                String num;
                double gtgt = sum / 10;
                // count = count + 4;
                num = (9 + count).ToString();
                myExcelWorksheet.get_Range("G" + num, misValue).Formula = sum;
                count = count + 2;
                num = (9 + count).ToString();
                myExcelWorksheet.get_Range("G" + num, misValue).Formula = gtgt;
                count = count + 1;
                num = (9 + count).ToString();
                myExcelWorksheet.get_Range("G" + num, misValue).Formula = sum + gtgt;

                string path = Application.StartupPath + "\\ThongKe\\" + year.Text + "\\Thang" + month.Text; // your code goes here

                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                myExcelWorkbook.SaveAs(path + "\\PTT-" + date.Text + "-" + month.Text + "-" + year.Text + "-" + number.Text + ".xls");
               // myExcelWorkbook.Close();


                String sql_delete = "DELETE FROM phieuthanhtoan WHERE ID='" + ID + "'";
                using (OleDbCommand cmd = new OleDbCommand(sql_delete, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                count = 0;
                for (int i = 0; i < count_row - 1; i++)
                {
                    row = dg_list.Rows[i];
                    if (row.Cells[0].Value != null)
                    {

                        String sql = "INSERT INTO phieuthanhtoan VALUES ('" + ID + "','" + year.Text + "','" + month.Text
                            + "', '" + date.Text + "', '" + row.Cells[0].Value.ToString() + "', '" + row.Cells[2].Value.ToString()
                            + "', '" + hd_date.Text + "', '" + hd_month.Text + "', '" + hd_year.Text + "', '" + hd_num.Text + "')";
                        using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    count++;
                }
                foreach (DataGridViewRow r in dg_data.Rows)
                {
                    thucDonTableAdapter.UpdateInventory(Double.Parse(r.Cells[3].Value.ToString()), r.Cells[0].Value.ToString());
                }
                dataDataSet.AcceptChanges();
                if (checkBox1.Checked)
                {
                    try
                    {
                        myExcelWorksheet.PrintOut(1, 1, 1, false);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi khi in");
                    }
                }
                loading.Visible = false;
                done.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void KH_SelectedIndexChanged(object sender, EventArgs e)
        {
            KH.SelectAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Form_update f;
        private void btn_update_Click(object sender, EventArgs e)
        {
            f = new Form_update(this);
            f.Show();
        }
        public void refresh()
        {
            this.thucDonTableAdapter.Fill(this.dataDataSet.ThucDon);
            dg_data.Refresh();

            update_price();
            cal();
            dg_list.Refresh();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void thucDonBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private Boolean check_tb()
        {
            if (date.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập Ngày");
                return false;
            }
            else
                if (year.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập Năm");
                    return false;
                }
                else
                    if (month.Text.Length == 0)
                    {
                        MessageBox.Show("Chưa nhập Tháng");
                        return false;
                    }
                    else
                        if (number.Text.Length == 0)
                        {
                            MessageBox.Show("Chưa nhập Số phiếu");
                            return false;
                        }
            return true;
        }
        Form_edit form_edit;
        private void button1_Click(object sender, EventArgs e)
        {
            form_edit = new Form_edit(this);
            form_edit.Show();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (myExcelWorkbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(myExcelWorkbook);
            myExcelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(myExcelApp);

            parent.enable_btn1();
        }

        private void soluong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myExcelApp.Visible = true;

            try
            {
              //  myExcelWorksheet.PrintPreview();
     
            myExcelApp.Dialogs[Excel.XlBuiltInDialog.xlDialogPrintPreview].Show(
        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            myExcelApp.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Không xem được");

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                myExcelWorksheet.PrintOut(1, 1, 1, false);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi in");
            }
        }

 
    }

}
