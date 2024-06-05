
namespace CURDform
{
    partial class Result
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furqanTestDBDataSet = new CURDform.FurqanTestDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentTableAdapter = new CURDform.FurqanTestDBDataSetTableAdapters.StudentTableAdapter();
            this.furqanTestDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furqanTestDBDataSet1 = new CURDform.FurqanTestDBDataSet1();
            this.furqanTestDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownHeight = 111;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(225, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(389, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.furqanTestDBDataSet;
            // 
            // furqanTestDBDataSet
            // 
            this.furqanTestDBDataSet.DataSetName = "FurqanTestDBDataSet";
            this.furqanTestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(749, 310);
            this.dataGridView2.TabIndex = 3;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // furqanTestDBDataSetBindingSource
            // 
            this.furqanTestDBDataSetBindingSource.DataSource = this.furqanTestDBDataSet;
            this.furqanTestDBDataSetBindingSource.Position = 0;
            // 
            // furqanTestDBDataSet1
            // 
            this.furqanTestDBDataSet1.DataSetName = "FurqanTestDBDataSet1";
            this.furqanTestDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furqanTestDBDataSet1BindingSource
            // 
            this.furqanTestDBDataSet1BindingSource.DataSource = this.furqanTestDBDataSet1;
            this.furqanTestDBDataSet1BindingSource.Position = 0;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furqanTestDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FurqanTestDBDataSet furqanTestDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private FurqanTestDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource furqanTestDBDataSet1BindingSource;
        private FurqanTestDBDataSet1 furqanTestDBDataSet1;
        private System.Windows.Forms.BindingSource furqanTestDBDataSetBindingSource;
    }
}