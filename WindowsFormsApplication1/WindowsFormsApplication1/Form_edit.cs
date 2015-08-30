using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form_edit : Form
    {
        OleDbConnection conn;
        Form1 parent;
        public Form_edit(Form1 p)
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
            for (int i = 1; i <= 31; i++)
            {
                cb_date.Items.Add(i.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.ThucDon' table. You can move, or remove it, as needed.
            this.thucDonTableAdapter.Fill(this.dataDataSet.ThucDon);
            // TODO: This line of code loads data into the 'dataDataSet.phieuthanhtoan' table. You can move, or remove it, as needed.
            this.phieuthanhtoanTableAdapter.Fill(this.dataDataSet.phieuthanhtoan);

        }

        private void cb_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void cb_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_number.Items.Clear();
            if (cb_year.Text.Length > 0 && cb_month.Text.Length > 0)
            {
                phieuthanhtoanBindingSource.RemoveFilter();
                phieuthanhtoanBindingSource.Filter = string.Format("[year] = " + cb_year.Text);
                phieuthanhtoanBindingSource.Filter = string.Format("[month] = " + cb_month.Text);
                phieuthanhtoanBindingSource.Filter = string.Format("[date] = " + cb_date.Text);
                cb_number.Text = "";
                //phieuthanhtoanBindingSource.Filter = string.Format("[year] = "+cb_year.Text+" and [month] = "+ cb_month.Text  + "date
                foreach (DataGridViewRow r in dg_list.Rows)
                {
                    if (r.Cells[0].Value != null)
                    {
                        String id = r.Cells[0].Value.ToString();
                        int index = id.LastIndexOf("-") + 1;
                        id = id.Substring(index, id.Length - index);
                        if (!cb_number.Items.Contains(id)) cb_number.Items.Add(id);
                    }
                }
            }
        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            phieuthanhtoanBindingSource.RemoveFilter();
            phieuthanhtoanBindingSource.Filter = string.Format("[year] = " + cb_year.Text);
            cb_month.Text = "";
            cb_date.Text = "";
            cb_number.Text = "";
        }

        private void cb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            phieuthanhtoanBindingSource.RemoveFilter();
            phieuthanhtoanBindingSource.Filter = string.Format("[year] = " + cb_year.Text);
            phieuthanhtoanBindingSource.Filter = string.Format("[month] = " + cb_month.Text);
            cb_number.Text = "";
            cb_date.Text = "";
        }

        private void filter()
        {
            phieuthanhtoanBindingSource.RemoveFilter();
            String ID = cb_date.Text + "-" + cb_month.Text + "-" + cb_year.Text + "-" + cb_number.Text;
            phieuthanhtoanBindingSource.Filter = string.Format("ID like '%{0}%'", ID);

        }

        private void dg_list_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_list_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    double oldValue = Double.Parse(dg_list[e.ColumnIndex, e.RowIndex].Value.ToString());
                    double newValue = Double.Parse(e.FormattedValue.ToString());
                    if (oldValue != newValue)
                    {
                        Boolean check = true; ;
                        string name = dg_list.Rows[e.RowIndex].Cells[1].Value.ToString();

                        foreach (DataGridViewRow r in dg_edited.Rows)
                        {
                            if (r.Cells[0].Value != null)
                            {
                                string n = r.Cells[0].Value.ToString();
                                if (n == name)
                                {
                                    double tonkho = Double.Parse(r.Cells[3].Value.ToString());
                                    r.Cells[3].Value = tonkho + oldValue - newValue;
                                    check = false;
                                }
                                if (r.Cells[2].Value == r.Cells[3].Value)
                                {
                                    dg_edited.Rows.Remove(r);
                                }
                            }
                        }
                        if (check)
                            using (DataTable dt = new DataTable())
                            {
                                string sql = "SELECT name,price,inventor FROM ThucDon WHERE name ='" + name + "'";
                                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                                {
                                    adapter.Fill(dt);
                                }
                                DataGridViewRow r = (DataGridViewRow)dg_edited.Rows[0].Clone();
                                r.Cells[0].Value = dt.Rows[0]["name"].ToString();
                                r.Cells[1].Value = Int32.Parse(dt.Rows[0]["price"].ToString()).ToString("N");
                                double tonkho = Double.Parse(dt.Rows[0]["inventor"].ToString());
                                r.Cells[2].Value = tonkho;
                                r.Cells[3].Value = tonkho + oldValue - newValue;
                                dg_edited.Rows.Add(r);
                            }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra đầu vào");
                }
            }
        }


        private void dg_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dg_list.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string name = dg_list.Rows[e.RowIndex].Cells[1].Value.ToString();
                    using (DataTable dt = new DataTable())
                    {
                        string sql = "SELECT name,price,inventor FROM ThucDon WHERE name ='" + name + "'";
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                        {
                            adapter.Fill(dt);
                        }
                        mathang.Text = dt.Rows[0]["name"].ToString();
                        tonkho.Text = dt.Rows[0]["inventor"].ToString();
                        gia.Text = dt.Rows[0]["price"].ToString();
                    }
                }
            }
            catch (Exception) {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            done.Visible = false;
            phieuthanhtoanBindingSource.RemoveFilter();
            foreach (DataGridViewRow r in dg_list.Rows)
            {
                if (r.Cells[0].Value != null) {
                    String sql = "UPDATE phieuthanhtoan SET quantity =" + Double.Parse(r.Cells[2].Value.ToString()) + " WHERE ID='" + r.Cells[0].Value.ToString()+"' AND name ='"+r.Cells[1].Value.ToString()+"'";
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            foreach (DataGridViewRow r in dg_edited.Rows)
            {
                if (r.Cells[0].Value != null)
                    thucDonTableAdapter.UpdateInventory(Double.Parse(r.Cells[3].Value.ToString()), r.Cells[0].Value.ToString());
            }
            dataDataSet.AcceptChanges();
            loading.Visible = false;
            done.Visible = true;
            parent.refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phieuthanhtoanBindingSource.RemoveFilter();
            cb_number.Text = "";
            cb_date.Text = "";
            cb_month.Text = "";
            cb_year.Text = "";
        }
    }
}
