namespace DataEdit
{
    partial class my_edit
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label countLabel;
            this.myDataDataSet = new DataEdit.myDataDataSet();
            this.testTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTblTableAdapter = new DataEdit.myDataDataSetTableAdapters.TestTblTableAdapter();
            this.tableAdapterManager = new DataEdit.myDataDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CanselBtn = new System.Windows.Forms.Button();
            this.countSpnr = new System.Windows.Forms.NumericUpDown();
            nameLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countSpnr)).BeginInit();
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
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(15, 30);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testTblBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(58, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(15, 56);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(37, 13);
            countLabel.TabIndex = 5;
            countLabel.Text = "count:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(16, 90);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CanselBtn
            // 
            this.CanselBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CanselBtn.Location = new System.Drawing.Point(107, 91);
            this.CanselBtn.Name = "CanselBtn";
            this.CanselBtn.Size = new System.Drawing.Size(75, 23);
            this.CanselBtn.TabIndex = 8;
            this.CanselBtn.Text = "Отмена";
            this.CanselBtn.UseVisualStyleBackColor = true;
            this.CanselBtn.Click += new System.EventHandler(this.CanselBtn_Click);
            // 
            // countSpnr
            // 
            this.countSpnr.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.testTblBindingSource, "count", true));
            this.countSpnr.Location = new System.Drawing.Point(58, 54);
            this.countSpnr.Name = "countSpnr";
            this.countSpnr.Size = new System.Drawing.Size(99, 20);
            this.countSpnr.TabIndex = 9;
            // 
            // my_edit
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CanselBtn;
            this.ClientSize = new System.Drawing.Size(199, 130);
            this.ControlBox = false;
            this.Controls.Add(this.countSpnr);
            this.Controls.Add(this.CanselBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(countLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "my_edit";
            this.Text = "my_edit";
            this.Load += new System.EventHandler(this.my_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countSpnr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myDataDataSet myDataDataSet;
        private System.Windows.Forms.BindingSource testTblBindingSource;
        private myDataDataSetTableAdapters.TestTblTableAdapter testTblTableAdapter;
        private myDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CanselBtn;
        private System.Windows.Forms.NumericUpDown countSpnr;
    }
}