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

    public partial class Form_update : Form
    {
        Form1 parent = null;
        public Form_update (Form1 p)
        {
            InitializeComponent();
            parent = p;
        }

        private void Form_update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.ThucDon' table. You can move, or remove it, as needed.
            this.thucDonTableAdapter.Fill(this.dataDataSet.ThucDon);
            // TODO: This line of code loads data into the 'dataDataSet.ThucDon' table. You can move, or remove it, as needed.
            this.thucDonTableAdapter.Fill(this.dataDataSet.ThucDon);
            // TODO: This line of code loads data into the 'dataDataSet.ThucDon' table. You can move, or remove it, as needed.
            this.thucDonTableAdapter.Fill(this.dataDataSet.ThucDon);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            thucDonBindingSource.Filter = string.Format("name LIKE '%{0}%'", str);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /* int index = e.RowIndex;
             String name = dataGridView1.Rows[index].Cells[0].Value.ToString();
             String unit = dataGridView1.Rows[index].Cells[1].Value.ToString();
             String price = dataGridView1.Rows[index].Cells[2].Value.ToString();

             string sql = "UPDATE ThucDon SET price=" + price + ",unit='" + unit + "',name='" + name + "' WHERE name='" + name + "'";
             using (OleDbCommand cmd = new OleDbCommand(sql, conn))
             {
                 cmd.ExecuteNonQuery();
             }*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.thucDonBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDataSet);
                dataGridView1.Refresh();
                dataDataSet.AcceptChanges();
                parent.refresh();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }

            /*this.Validate();
            this.thucDonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.thucDonDataSet);*/
        }

        private void thucDonBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
