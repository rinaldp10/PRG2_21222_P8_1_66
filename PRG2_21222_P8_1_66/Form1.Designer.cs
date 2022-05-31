namespace PRG2_21222_P8_1_66
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.msmhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMahasiswa_0320210066 = new PRG2_21222_P8_1_66.dsMahasiswa_0320210066();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.msprodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMahasiswa_03202100661 = new PRG2_21222_P8_1_66.dsMahasiswa_0320210066();
            this.msprodiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p5_66DataSet = new PRG2_21222_P8_1_66.P5_66DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.msmhsTableAdapter1 = new PRG2_21222_P8_1_66.dsMahasiswa_0320210066TableAdapters.msmhsTableAdapter();
            this.msprodiTableAdapter1 = new PRG2_21222_P8_1_66.dsMahasiswa_0320210066TableAdapters.msprodiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMahasiswa_0320210066)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msprodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMahasiswa_03202100661)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msprodiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_66DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // msmhsBindingSource
            // 
            this.msmhsBindingSource.DataMember = "msmhs";
            this.msmhsBindingSource.DataSource = this.dsMahasiswa_0320210066;
            // 
            // dsMahasiswa_0320210066
            // 
            this.dsMahasiswa_0320210066.DataSetName = "dsMahasiswa_0320210066";
            this.dsMahasiswa_0320210066.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbProdi
            // 
            this.cmbProdi.DataSource = this.msprodiBindingSource;
            this.cmbProdi.DisplayMember = "singkatan";
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Location = new System.Drawing.Point(335, 182);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(219, 24);
            this.cmbProdi.TabIndex = 8;
            this.cmbProdi.ValueMember = "id_prodi";
            // 
            // msprodiBindingSource
            // 
            this.msprodiBindingSource.DataMember = "msprodi";
            this.msprodiBindingSource.DataSource = this.dsMahasiswa_03202100661;
            // 
            // dsMahasiswa_03202100661
            // 
            this.dsMahasiswa_03202100661.DataSetName = "dsMahasiswa_0320210066";
            this.dsMahasiswa_03202100661.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // msprodiiBindingSource
            // 
            this.msprodiiBindingSource.DataMember = "msprodii";
            this.msprodiiBindingSource.DataSource = this.p5_66DataSet;
            // 
            // p5_66DataSet
            // 
            this.p5_66DataSet.DataSetName = "P5_66DataSet";
            this.p5_66DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Program Studi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "DATA MAHASISWA";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.msmhsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PRG2_21222_P8_1_66.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(65, 237);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(806, 344);
            this.reportViewer1.TabIndex = 10;
            // 
            // msmhsTableAdapter1
            // 
            this.msmhsTableAdapter1.ClearBeforeFill = true;
            // 
            // msprodiTableAdapter1
            // 
            this.msprodiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 688);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laporan Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMahasiswa_0320210066)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msprodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMahasiswa_03202100661)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msprodiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_66DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private P5_66DataSet p5_66DataSet;
        private System.Windows.Forms.BindingSource msprodiiBindingSource;
        private dsMahasiswa_0320210066TableAdapters.msmhsTableAdapter msmhsTableAdapter1;
        private dsMahasiswa_0320210066 dsMahasiswa_03202100661;
        private dsMahasiswa_0320210066TableAdapters.msprodiTableAdapter msprodiTableAdapter1;
        private System.Windows.Forms.BindingSource msmhsBindingSource;
        private dsMahasiswa_0320210066 dsMahasiswa_0320210066;
        private System.Windows.Forms.BindingSource msprodiBindingSource;
    }
}

