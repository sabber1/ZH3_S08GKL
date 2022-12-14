namespace ZH3_forms
{
    partial class ReceptekUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hozzavaloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.receptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.névDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiség4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegiEgysegsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysÁrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 364);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIdDataGridViewTextBoxColumn,
            this.fogasIdDataGridViewTextBoxColumn,
            this.névDataGridViewTextBoxColumn,
            this.mennyiség4DataGridViewTextBoxColumn,
            this.mennyisegiEgysegsDataGridViewTextBoxColumn,
            this.egysÁrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzavaloBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(126, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(510, 365);
            this.dataGridView1.TabIndex = 2;
            // 
            // hozzavaloBindingSource1
            // 
            this.hozzavaloBindingSource1.DataSource = typeof(ZH3_forms.Hozzavalo);
            // 
            // hozzavaloBindingSource
            // 
            this.hozzavaloBindingSource.DataSource = typeof(ZH3_forms.Hozzavalo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bevásárló lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // receptIdDataGridViewTextBoxColumn
            // 
            this.receptIdDataGridViewTextBoxColumn.DataPropertyName = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.HeaderText = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.Name = "receptIdDataGridViewTextBoxColumn";
            this.receptIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            this.fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            this.fogasIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // névDataGridViewTextBoxColumn
            // 
            this.névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            this.névDataGridViewTextBoxColumn.HeaderText = "Név";
            this.névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            // 
            // mennyiség4DataGridViewTextBoxColumn
            // 
            this.mennyiség4DataGridViewTextBoxColumn.DataPropertyName = "Mennyiség4";
            this.mennyiség4DataGridViewTextBoxColumn.HeaderText = "Mennyiség4";
            this.mennyiség4DataGridViewTextBoxColumn.Name = "mennyiség4DataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegsDataGridViewTextBoxColumn
            // 
            this.mennyisegiEgysegsDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgysegs";
            this.mennyisegiEgysegsDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgysegs";
            this.mennyisegiEgysegsDataGridViewTextBoxColumn.Name = "mennyisegiEgysegsDataGridViewTextBoxColumn";
            // 
            // egysÁrDataGridViewTextBoxColumn
            // 
            this.egysÁrDataGridViewTextBoxColumn.DataPropertyName = "EgysÁr";
            this.egysÁrDataGridViewTextBoxColumn.HeaderText = "EgysÁr";
            this.egysÁrDataGridViewTextBoxColumn.Name = "egysÁrDataGridViewTextBoxColumn";
            // 
            // ReceptekUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReceptekUC";
            this.Size = new System.Drawing.Size(636, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private BindingSource hozzavaloBindingSource;
        private BindingSource hozzavaloBindingSource1;
        private DataGridViewTextBoxColumn receptIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiség4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysÁrDataGridViewTextBoxColumn;
    }
}
