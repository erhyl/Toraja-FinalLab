using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toraja_FinalLab
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        public SummaryForm(double danielle, double edward, double fatima)
        {
            InitializeComponent();

            double totalSales = danielle + edward + fatima;

            this.Text = "Home Sales Summary Report";

            lblDanielle.Text = "Danielle:  " + danielle.ToString("₱#,##0.00");
            lblEdward.Text = "Edward:  " + edward.ToString("₱#,##0.00");
            lblFatima.Text = "Fatima:  " + fatima.ToString("₱#,##0.00");

            lblTotal.Text = "Total Sales:  " + totalSales.ToString("₱#,##0.00");
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
        }

        private void lblFatima_Click(object sender, EventArgs e)
        {
        }
    }
}

