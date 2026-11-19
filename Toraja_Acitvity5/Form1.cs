using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toraja_FinalLab
{
    public partial class Form1 : Form
    {

        private double DanielleSales = 0;
        private double EdwardSales = 0;
        private double FatimaSales = 0;

        public Form1()
        {
            InitializeComponent();
            lblDisplay.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void getSalesPerson_Amount(
           string salesInitial, double salesAmount)
        {
            string salespersonName = "";

            salesInitial = salesInitial.Trim().ToUpper();

            switch (salesInitial)
            {
                case "D":
                    DanielleSales += salesAmount;
                    salespersonName = "Danielle";
                    break;

                case "E":
                    EdwardSales += salesAmount;
                    salespersonName = "Edward";
                    break;

                case "F":
                    FatimaSales += salesAmount;
                    salespersonName = "Fatima";
                    break;

                default:
                    MessageBox.Show(
                        "Invalid initial! Please enter D, E, or F.",
                        "Invalid Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }


            lblDisplay.Text =
                "Salesperson: " + salespersonName + "\n" +
                "Amount of Sale: " +
                salesAmount.ToString("₱#,##0.00") + "\n" +
                "Transaction Successful!\n\n" +
                "CURRENT SALES TOTALS:\n" +
                "Danielle: " + DanielleSales.ToString("₱#,##0.00") + "\n" +
                "Edward: " + EdwardSales.ToString("₱#,##0.00") + "\n" +
                "Fatima: " + FatimaSales.ToString("₱#,##0.00") + "\n";
        }

        private void clearEntry()
        {
            txtBoxInitial.Clear();
            txtBoxAmount.Clear();
            lblDisplay.Text = "";

            txtBoxInitial.Focus();
        }

        private void txtBoxInitial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string salesInitial = txtBoxInitial.Text.Trim();

            double salesAmount;


            if (string.IsNullOrWhiteSpace(salesInitial))
            {
                MessageBox.Show(
                    "Please enter the salesperson initial.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxInitial.Focus();
                return;
            }


            if (!double.TryParse(
                txtBoxAmount.Text,
                NumberStyles.Currency,
                CultureInfo.CurrentCulture,
                out salesAmount))
            {
                MessageBox.Show(
                    "Please enter a valid sale amount.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxAmount.Focus();
                return;
            }


            if (salesAmount <= 0)
            {
                MessageBox.Show(
                    "Sale amount must be greater than zero.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxAmount.Focus();
                return;
            }


            string initial = salesInitial.ToUpper();

            if (initial != "D" &&
                initial != "E" &&
                initial != "F")
            {
                MessageBox.Show(
                    "Invalid salesperson initial!\n" +
                    "Please enter D, E, or F.",
                    "Invalid Initial",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBoxInitial.Focus();
                return;
            }


            getSalesPerson_Amount(salesInitial, salesAmount);


            txtBoxInitial.Clear();
            txtBoxAmount.Clear();

            txtBoxInitial.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SummaryForm report = new SummaryForm(
                DanielleSales,
                EdwardSales,
                FatimaSales
            );

            report.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
