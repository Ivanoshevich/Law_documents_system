
namespace Планировщик_рабочего_времени
{
    partial class Pdf_viewer
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cTP_main_dt = new Планировщик_рабочего_времени.CTP_main_dt();
            this.cTP_mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTP_mainTableAdapter = new Планировщик_рабочего_времени.CTP_main_dtTableAdapters.CTP_mainTableAdapter();
            this.tableAdapterManager = new Планировщик_рабочего_времени.CTP_main_dtTableAdapters.TableAdapterManager();
            this.idCTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docfileDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.namenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationdocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateaffirmationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datereviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTP_main_dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTP_mainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(542, 86);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(642, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(61, 86);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(458, 22);
            this.txtFilePath.TabIndex = 2;
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AutoGenerateColumns = false;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCTPDataGridViewTextBoxColumn,
            this.docfileDataGridViewImageColumn,
            this.namenumberDataGridViewTextBoxColumn,
            this.designationdocDataGridViewTextBoxColumn,
            this.dateaffirmationDataGridViewTextBoxColumn,
            this.reviewDataGridViewTextBoxColumn,
            this.datereviewDataGridViewTextBoxColumn});
            this.dgvDocuments.DataSource = this.cTP_mainBindingSource;
            this.dgvDocuments.Location = new System.Drawing.Point(61, 154);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.RowTemplate.Height = 24;
            this.dgvDocuments.Size = new System.Drawing.Size(656, 216);
            this.dgvDocuments.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(61, 114);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // cTP_main_dt
            // 
            this.cTP_main_dt.DataSetName = "CTP_main_dt";
            this.cTP_main_dt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTP_mainBindingSource
            // 
            this.cTP_mainBindingSource.DataMember = "CTP_main";
            this.cTP_mainBindingSource.DataSource = this.cTP_main_dt;
            // 
            // cTP_mainTableAdapter
            // 
            this.cTP_mainTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTP_mainTableAdapter = this.cTP_mainTableAdapter;
            this.tableAdapterManager.UpdateOrder = Планировщик_рабочего_времени.CTP_main_dtTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idCTPDataGridViewTextBoxColumn
            // 
            this.idCTPDataGridViewTextBoxColumn.DataPropertyName = "id_CTP";
            this.idCTPDataGridViewTextBoxColumn.HeaderText = "id_CTP";
            this.idCTPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCTPDataGridViewTextBoxColumn.Name = "idCTPDataGridViewTextBoxColumn";
            this.idCTPDataGridViewTextBoxColumn.Width = 125;
            // 
            // docfileDataGridViewImageColumn
            // 
            this.docfileDataGridViewImageColumn.DataPropertyName = "doc_file";
            this.docfileDataGridViewImageColumn.HeaderText = "doc_file";
            this.docfileDataGridViewImageColumn.MinimumWidth = 6;
            this.docfileDataGridViewImageColumn.Name = "docfileDataGridViewImageColumn";
            this.docfileDataGridViewImageColumn.Width = 125;
            // 
            // namenumberDataGridViewTextBoxColumn
            // 
            this.namenumberDataGridViewTextBoxColumn.DataPropertyName = "Name_number";
            this.namenumberDataGridViewTextBoxColumn.HeaderText = "Name_number";
            this.namenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namenumberDataGridViewTextBoxColumn.Name = "namenumberDataGridViewTextBoxColumn";
            this.namenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationdocDataGridViewTextBoxColumn
            // 
            this.designationdocDataGridViewTextBoxColumn.DataPropertyName = "Designation_doc";
            this.designationdocDataGridViewTextBoxColumn.HeaderText = "Designation_doc";
            this.designationdocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationdocDataGridViewTextBoxColumn.Name = "designationdocDataGridViewTextBoxColumn";
            this.designationdocDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateaffirmationDataGridViewTextBoxColumn
            // 
            this.dateaffirmationDataGridViewTextBoxColumn.DataPropertyName = "date_affirmation";
            this.dateaffirmationDataGridViewTextBoxColumn.HeaderText = "date_affirmation";
            this.dateaffirmationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateaffirmationDataGridViewTextBoxColumn.Name = "dateaffirmationDataGridViewTextBoxColumn";
            this.dateaffirmationDataGridViewTextBoxColumn.Width = 125;
            // 
            // reviewDataGridViewTextBoxColumn
            // 
            this.reviewDataGridViewTextBoxColumn.DataPropertyName = "review";
            this.reviewDataGridViewTextBoxColumn.HeaderText = "review";
            this.reviewDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewDataGridViewTextBoxColumn.Name = "reviewDataGridViewTextBoxColumn";
            this.reviewDataGridViewTextBoxColumn.Width = 125;
            // 
            // datereviewDataGridViewTextBoxColumn
            // 
            this.datereviewDataGridViewTextBoxColumn.DataPropertyName = "date_review";
            this.datereviewDataGridViewTextBoxColumn.HeaderText = "date_review";
            this.datereviewDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datereviewDataGridViewTextBoxColumn.Name = "datereviewDataGridViewTextBoxColumn";
            this.datereviewDataGridViewTextBoxColumn.Width = 125;
            // 
            // Pdf_viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dgvDocuments);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Pdf_viewer";
            this.Text = "Pdf_viewer";
            this.Load += new System.EventHandler(this.Pdf_viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTP_main_dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTP_mainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnOpen;
        private CTP_main_dt cTP_main_dt;
        private System.Windows.Forms.BindingSource cTP_mainBindingSource;
        private CTP_main_dtTableAdapters.CTP_mainTableAdapter cTP_mainTableAdapter;
        private CTP_main_dtTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn docfileDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationdocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateaffirmationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereviewDataGridViewTextBoxColumn;
    }
}