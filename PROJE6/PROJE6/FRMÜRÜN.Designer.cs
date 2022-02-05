
namespace PROJE6
{
    partial class FRMÜRÜN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.proje6DataSet1 = new PROJE6.proje6DataSet1();
            this.tBLÜRÜNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLÜRÜNLERTableAdapter = new PROJE6.proje6DataSet1TableAdapters.TBLÜRÜNLERTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLISFİYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATISFİYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLÜRÜNLERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(152)))));
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 445);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN LİSTELE";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sTOKDataGridViewTextBoxColumn,
            this.aLISFİYATDataGridViewTextBoxColumn,
            this.sATISFİYATDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tBLÜRÜNLERBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(793, 416);
            this.dataGridView2.TabIndex = 0;
            // 
            // proje6DataSet1
            // 
            this.proje6DataSet1.DataSetName = "proje6DataSet1";
            this.proje6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLÜRÜNLERBindingSource
            // 
            this.tBLÜRÜNLERBindingSource.DataMember = "TBLÜRÜNLER";
            this.tBLÜRÜNLERBindingSource.DataSource = this.proje6DataSet1;
            // 
            // tBLÜRÜNLERTableAdapter
            // 
            this.tBLÜRÜNLERTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sTOKDataGridViewTextBoxColumn
            // 
            this.sTOKDataGridViewTextBoxColumn.DataPropertyName = "STOK";
            this.sTOKDataGridViewTextBoxColumn.HeaderText = "STOK";
            this.sTOKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTOKDataGridViewTextBoxColumn.Name = "sTOKDataGridViewTextBoxColumn";
            // 
            // aLISFİYATDataGridViewTextBoxColumn
            // 
            this.aLISFİYATDataGridViewTextBoxColumn.DataPropertyName = "ALISFİYAT";
            this.aLISFİYATDataGridViewTextBoxColumn.HeaderText = "ALISFİYAT";
            this.aLISFİYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLISFİYATDataGridViewTextBoxColumn.Name = "aLISFİYATDataGridViewTextBoxColumn";
            // 
            // sATISFİYATDataGridViewTextBoxColumn
            // 
            this.sATISFİYATDataGridViewTextBoxColumn.DataPropertyName = "SATISFİYAT";
            this.sATISFİYATDataGridViewTextBoxColumn.HeaderText = "SATISFİYAT";
            this.sATISFİYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sATISFİYATDataGridViewTextBoxColumn.Name = "sATISFİYATDataGridViewTextBoxColumn";
            // 
            // FRMÜRÜN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMÜRÜN";
            this.Text = "FRMÜRÜN";
            this.Load += new System.EventHandler(this.FRMÜRÜN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLÜRÜNLERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private proje6DataSet1 proje6DataSet1;
        private System.Windows.Forms.BindingSource tBLÜRÜNLERBindingSource;
        private proje6DataSet1TableAdapters.TBLÜRÜNLERTableAdapter tBLÜRÜNLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLISFİYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATISFİYATDataGridViewTextBoxColumn;
    }
}