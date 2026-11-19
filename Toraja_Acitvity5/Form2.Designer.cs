namespace Toraja_FinalLab
{
    partial class SummaryForm
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
            this.lblDanielle = new System.Windows.Forms.Label();
            this.lblEdward = new System.Windows.Forms.Label();
            this.lblFatima = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDanielle
            // 
            this.lblDanielle.AccessibleName = "";
            this.lblDanielle.AutoSize = true;
            this.lblDanielle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanielle.Location = new System.Drawing.Point(149, 82);
            this.lblDanielle.Name = "lblDanielle";
            this.lblDanielle.Size = new System.Drawing.Size(86, 31);
            this.lblDanielle.TabIndex = 0;
            this.lblDanielle.Text = "label1";
            // 
            // lblEdward
            // 
            this.lblEdward.AccessibleName = "";
            this.lblEdward.AutoSize = true;
            this.lblEdward.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdward.Location = new System.Drawing.Point(149, 118);
            this.lblEdward.Name = "lblEdward";
            this.lblEdward.Size = new System.Drawing.Size(86, 31);
            this.lblEdward.TabIndex = 1;
            this.lblEdward.Text = "label2";
            // 
            // lblFatima
            // 
            this.lblFatima.AccessibleName = "";
            this.lblFatima.AutoSize = true;
            this.lblFatima.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatima.Location = new System.Drawing.Point(149, 155);
            this.lblFatima.Name = "lblFatima";
            this.lblFatima.Size = new System.Drawing.Size(86, 31);
            this.lblFatima.TabIndex = 2;
            this.lblFatima.Text = "label3";
            this.lblFatima.Click += new System.EventHandler(this.lblFatima_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AccessibleName = "";
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(149, 248);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 31);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label4";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "SALES SUMMARY REPORT";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFatima);
            this.Controls.Add(this.lblEdward);
            this.Controls.Add(this.lblDanielle);
            this.Name = "SummaryForm";
            this.Text = "Home Sales Summary Report";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanielle;
        private System.Windows.Forms.Label lblEdward;
        private System.Windows.Forms.Label lblFatima;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}