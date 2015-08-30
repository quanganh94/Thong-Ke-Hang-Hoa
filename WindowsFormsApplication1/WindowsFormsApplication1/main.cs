using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        private BackgroundWorker myWorker = new BackgroundWorker();

        public main()
        {
            InitializeComponent();
            myWorker.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            myWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            myWorker.ProgressChanged += new ProgressChangedEventHandler(myWorker_ProgressChanged);
            myWorker.WorkerReportsProgress = true;
            myWorker.WorkerSupportsCancellation = true;

        }
        private Form1 f;
        private thongke fk;
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            fk = new thongke(this);
            fk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!myWorker.IsBusy)//Check if the worker is already in progress
            {
                button1.Enabled = false;//Disable the Start button
                loading.Visible = true;
                myWorker.RunWorkerAsync();//Call the background worker
            }
        }
        protected void myWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            f = new Form1(this);
            f.Size = new Size(950, 700);

        }
        protected void myWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            f.after_load();

            f.Show();
            loading.Visible = false;
        }
        protected void myWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        public void enable_btn1(){
            button1.Enabled =true;
        }

        public void enable_btn2(){
            button2.Enabled =true;
        }
        private void main_Load(object sender, EventArgs e)
        {

        }



    }
}
