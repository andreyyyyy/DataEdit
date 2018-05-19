namespace DataEdit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myDataDataSet = new DataEdit.myDataDataSet();
            this.testTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTblTableAdapter = new DataEdit.myDataDataSetTableAdapters.TestTblTableAdapter();
            this.tableAdapterManager = new DataEdit.myDataDataSetTableAdapters.TableAdapterManager();
            this.testTblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTblDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataDataSet
            // 
            this.myDataDataSet.DataSetName = "myDataDataSet";
            this.myDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testTblBindingSource
            // 
            this.testTblBindingSource.DataMember = "TestTbl";
            this.testTblBindingSource.DataSource = this.myDataDataSet;
            // 
            // testTblTableAdapter
            // 
            this.testTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestTblTableAdapter = this.testTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataEdit.myDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testTblDataGridView
            // 
            this.testTblDataGridView.AllowUserToAddRows = false;
            this.testTblDataGridView.AllowUserToDeleteRows = false;
            this.testTblDataGridView.AutoGenerateColumns = false;
            this.testTblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testTblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.testTblDataGridView.DataSource = this.testTblBindingSource;
            this.testTblDataGridView.Location = new System.Drawing.Point(33, 45);
            this.testTblDataGridView.MultiSelect = false;
            this.testTblDataGridView.Name = "testTblDataGridView";
            this.testTblDataGridView.ReadOnly = true;
            this.testTblDataGridView.RowHeadersVisible = false;
            this.testTblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testTblDataGridView.Size = new System.Drawing.Size(205, 220);
            this.testTblDataGridView.TabIndex = 1;
            this.testTblDataGridView.DoubleClick += new System.EventHandler(this.testTblDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(33, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 368);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.testTblDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTblDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myDataDataSet myDataDataSet;
        private System.Windows.Forms.BindingSource testTblBindingSource;
        private myDataDataSetTableAdapters.TestTblTableAdapter testTblTableAdapter;
        private myDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView testTblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnEdit;
    }
}

