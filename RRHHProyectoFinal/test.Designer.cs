namespace RRHHProyectoFinal
{
    partial class test
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.reporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.ReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RRHHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RRHHProyectoFinal.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(223, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // RRHHDataSet
            // 
            this.RRHHDataSet.DataSetName = "RRHHDataSet";
            this.RRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteBindingSource
            // 
            this.reporteBindingSource.DataMember = "Reporte";
            this.reporteBindingSource.DataSource = this.RRHHDataSet;
            // 
            // reporteTableAdapter
            // 
            this.reporteTableAdapter.ClearBeforeFill = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RRHHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RRHHDataSet RRHHDataSet;
        private System.Windows.Forms.BindingSource reporteBindingSource;
        private RRHHDataSetTableAdapters.ReporteTableAdapter reporteTableAdapter;
    }
}