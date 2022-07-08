namespace WindowsFormsApplication8
{
    partial class Form8
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
            this.elektronikDataSet = new WindowsFormsApplication8.elektronikDataSet();
            this.alimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alimTableAdapter = new WindowsFormsApplication8.elektronikDataSetTableAdapters.alimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.elektronikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alimBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication8.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(557, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // elektronikDataSet
            // 
            this.elektronikDataSet.DataSetName = "elektronikDataSet";
            this.elektronikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alimBindingSource
            // 
            this.alimBindingSource.DataMember = "alim";
            this.alimBindingSource.DataSource = this.elektronikDataSet;
            // 
            // alimTableAdapter
            // 
            this.alimTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 393);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elektronikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource alimBindingSource;
        private elektronikDataSet elektronikDataSet;
        private elektronikDataSetTableAdapters.alimTableAdapter alimTableAdapter;
    }
}