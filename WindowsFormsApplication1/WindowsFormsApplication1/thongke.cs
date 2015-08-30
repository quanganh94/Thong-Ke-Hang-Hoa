using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Reflection;
using System.Data.SqlClient;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApplication1
{
    public partial class thongke : Form
    {
        OleDbConnection conn;
        main parent;
        class e_cell
        {
            int id;
            string c;
            public e_cell(int index, String CELL)
            {
                id = index;
                c = CELL;
            }
            public string get_cell(){
                return c;
            }
        }
        List<e_cell> cells = new List<e_cell>();
        public thongke(main p)
        {
            InitializeComponent();
            parent = p;
            var DBPath = Application.StartupPath + "\\Data\\Data.mdb";

            conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;"
                + "Data Source=" + DBPath);
            conn.Open();

            cb_month.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_month.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_year.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_year.AutoCompleteSource = AutoCompleteSource.ListItems;

            for (int i = 1; i <= 12; i++)
            {
                cb_month.Items.Add(i.ToString());
            }
            for (int i = 2014; i <= 2017; i++)
            {
                cb_year.Items.Add(i.ToString());
            }
            cells.Add(new e_cell(1, "B"));
            cells.Add(new e_cell(2, "C"));
            cells.Add(new e_cell(3, "D"));
            cells.Add(new e_cell(4, "E"));
            cells.Add(new e_cell(5, "F"));
            cells.Add(new e_cell(6, "G"));
            cells.Add(new e_cell(7, "H"));
            cells.Add(new e_cell(8, "I"));
            cells.Add(new e_cell(9, "J"));
            cells.Add(new e_cell(10, "K"));
            cells.Add(new e_cell(11, "L"));
            cells.Add(new e_cell(12, "M"));
            cells.Add(new e_cell(13, "N"));
            cells.Add(new e_cell(14, "O"));
            cells.Add(new e_cell(15, "P"));
            cells.Add(new e_cell(16, "Q"));
            cells.Add(new e_cell(17, "R"));
            cells.Add(new e_cell(18, "S"));
            cells.Add(new e_cell(19, "T"));
            cells.Add(new e_cell(20, "U"));
            cells.Add(new e_cell(21, "V"));
            cells.Add(new e_cell(22, "W"));
            cells.Add(new e_cell(23, "X"));
            cells.Add(new e_cell(24, "Y"));
            cells.Add(new e_cell(25, "Z"));
            cells.Add(new e_cell(26, "AA"));
            cells.Add(new e_cell(27, "AB"));
            cells.Add(new e_cell(28, "AC"));
            cells.Add(new e_cell(29, "AD"));
            cells.Add(new e_cell(30, "AE"));
            cells.Add(new e_cell(31, "AF"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Date

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Export
            object misValue = System.Reflection.Missing.Value;
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;
            Excel.Worksheet myExcelWorksheet; myExcelApp = new Excel.Application();
            myExcelApp.Visible = false;
            myExcelWorkbooks = myExcelApp.Workbooks;
            String fileName = Application.StartupPath + "\\Data\\tkform.xls"; ;
            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);

            myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;
            Excel.Range Line = (Excel.Range)myExcelWorksheet.Rows[10];
            myExcelWorksheet.get_Range("N5", misValue).Formula = cb_month.Text;
            myExcelWorksheet.get_Range("N6", misValue).Formula = cb_year.Text;

            int count_row = dataGridView1.Rows.Count;
            int count_col = dataGridView1.Columns.Count;
            int count = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                Double sum = 0;
                String row_num = (9 + count).ToString();
                myExcelWorksheet.get_Range("A" + row_num, misValue).Formula = r.Cells[0].Value.ToString();
                for (int i = 1; i < count_col; i++)
                {
                    int col_date = Int32.Parse(date[i - 1]);
                    e_cell ec = cells[col_date-1];
                    string val = r.Cells[i].Value.ToString();
                    if(val.Length>0)  sum += Double.Parse(val);
                  
                    myExcelWorksheet.get_Range(ec.get_cell() + row_num, misValue).Formula = val;
                }
                myExcelWorksheet.get_Range("AG"+ row_num, misValue).Formula = sum;
                count++;
                Line.Insert();

            }

            string path = Application.StartupPath + "\\ThongKe"; // your code goes here

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            myExcelWorkbook.SaveAs(path + "\\ThongKe-" + cb_year.Text + "-" + cb_month.Text + ".xls");
            myExcelWorkbook.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        List<string> date = new List<string>();
        private void thongke_dulieu()
        {
            //Month
            Boolean check = check_year() && check_month();
            if (check)
            {
                DataTable result = new DataTable();
                using (DataTable dt = new DataTable())
                {
                    String sql_search = "SELECT date FROM phieuthanhtoan where month='" + cb_month.Text + "' AND  year='" + cb_year.Text + "'group by date";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql_search, conn))
                    {
                        adapter.Fill(dt);
                    }
                    foreach (DataRow r in dt.Rows)
                    {
                        date.Add(r[0].ToString());
                    }
                }

                foreach (string d in date)
                    using (DataTable dt = new DataTable())
                    {
                        String sql_search = "SELECT name,SUM(quantity) as " + d + " FROM phieuthanhtoan WHERE year = '" + cb_year.Text + "' AND month='" + cb_month.Text + "' AND date='" + d + "' GROUP BY name";
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql_search, conn))
                        {
                            adapter.Fill(dt);
                        }
                        if (dt.Rows.Count > 0) result.Merge(dt, false);
                    }

                int count = result.Columns.Count;

                string column = "";
                for (int i = 1; i < count; i++)
                {
                    column += ",t" + i + " double";
                }
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand("DROP TABLE test", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                };
                using (OleDbCommand cmd = new OleDbCommand("create table test(ten char(40)" + column + ")", conn))
                {
                    cmd.ExecuteNonQuery();
                }


                foreach (DataRow r in result.Rows)
                {
                    string row = "";
                    for (int i = 1; i < count; i++)
                    {
                        row += ",?";
                    }
                    string sql = "INSERT INTO test VALUES (?" + row + ")";

                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("?", r[0].ToString());
                        for (int i = 1; i < count; i++)
                        {
                            cmd.Parameters.AddWithValue("?", r[i]);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }

                string select = "";
                for (int i = 1; i < count; i++)
                {
                    select += ",sum(t" + i.ToString() + ") as " + date[i - 1];
                }
                using (DataTable dt = new DataTable())
                {
                    String sql_search = "SELECT ten" + select + " FROM test group by ten";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql_search, conn))
                    {
                        adapter.Fill(dt);
                    }
                    dataGridView1.DataSource = dt;
                }
                export.Enabled = true;
            }
        }
        private Boolean check_year()
        {
            if (cb_year.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập năm");
                return false;
            }
            return true;
        }
        private Boolean check_month()
        {
            if (cb_month.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tháng");
                return false;
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Year
            check_year();
        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongke_dulieu();
        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            parent.enable_btn2();
        }
    }
}