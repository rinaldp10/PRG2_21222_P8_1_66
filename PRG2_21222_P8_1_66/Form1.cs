using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRG2_21222_P8_1_66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.msprodiTableAdapter1.Fill(this.dsMahasiswa_03202100661.msprodi);
            cmbProdi.Text = "-- Pilih Program Studi --";
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.msmhsTableAdapter1.Fill(this.dsMahasiswa_0320210066.msmhs, (string)
               cmbProdi.SelectedValue);
            this.reportViewer1.RefreshReport();
        }
    }
}
