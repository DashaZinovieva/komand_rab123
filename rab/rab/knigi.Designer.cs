namespace rab
{
    partial class knigi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.user59_dbDataSet = new rab.user59_dbDataSet();
            this.mDK0701KnigiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDK0701_KnigiTableAdapter = new rab.user59_dbDataSetTableAdapters.MDK0701_KnigiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idknigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godizdaniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvonaskladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDK0701KnigiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.user59_dbDataSet5 = new rab.user59_dbDataSet5();
            this.mDK0701_KnigiTableAdapter1 = new rab.user59_dbDataSet5TableAdapters.MDK0701_KnigiTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701KnigiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701KnigiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.книгиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(61, 24);
            this.toolStripMenuItem4.Text = "Склад";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 24);
            this.toolStripMenuItem2.Text = "|";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem3.Text = "Выдача";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавление";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // user59_dbDataSet
            // 
            this.user59_dbDataSet.DataSetName = "user59_dbDataSet";
            this.user59_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDK0701KnigiBindingSource
            // 
            this.mDK0701KnigiBindingSource.DataMember = "MDK0701_Knigi";
            this.mDK0701KnigiBindingSource.DataSource = this.user59_dbDataSet;
            // 
            // mDK0701_KnigiTableAdapter
            // 
            this.mDK0701_KnigiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idknigiDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.avtorDataGridViewTextBoxColumn,
            this.godizdaniyaDataGridViewTextBoxColumn,
            this.kolichestvonaskladeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mDK0701KnigiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(77, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 224);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idknigiDataGridViewTextBoxColumn
            // 
            this.idknigiDataGridViewTextBoxColumn.DataPropertyName = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.HeaderText = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.Name = "idknigiDataGridViewTextBoxColumn";
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // avtorDataGridViewTextBoxColumn
            // 
            this.avtorDataGridViewTextBoxColumn.DataPropertyName = "Avtor";
            this.avtorDataGridViewTextBoxColumn.HeaderText = "Avtor";
            this.avtorDataGridViewTextBoxColumn.Name = "avtorDataGridViewTextBoxColumn";
            // 
            // godizdaniyaDataGridViewTextBoxColumn
            // 
            this.godizdaniyaDataGridViewTextBoxColumn.DataPropertyName = "God_izdaniya";
            this.godizdaniyaDataGridViewTextBoxColumn.HeaderText = "God_izdaniya";
            this.godizdaniyaDataGridViewTextBoxColumn.Name = "godizdaniyaDataGridViewTextBoxColumn";
            // 
            // kolichestvonaskladeDataGridViewTextBoxColumn
            // 
            this.kolichestvonaskladeDataGridViewTextBoxColumn.DataPropertyName = "Kolichestvo_na_sklade";
            this.kolichestvonaskladeDataGridViewTextBoxColumn.HeaderText = "Kolichestvo_na_sklade";
            this.kolichestvonaskladeDataGridViewTextBoxColumn.Name = "kolichestvonaskladeDataGridViewTextBoxColumn";
            // 
            // mDK0701KnigiBindingSource1
            // 
            this.mDK0701KnigiBindingSource1.DataMember = "MDK0701_Knigi";
            this.mDK0701KnigiBindingSource1.DataSource = this.user59_dbDataSet5;
            // 
            // user59_dbDataSet5
            // 
            this.user59_dbDataSet5.DataSetName = "user59_dbDataSet5";
            this.user59_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDK0701_KnigiTableAdapter1
            // 
            this.mDK0701_KnigiTableAdapter1.ClearBeforeFill = true;
            // 
            // knigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "knigi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "knigi";
            this.Load += new System.EventHandler(this.knigi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701KnigiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701KnigiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private user59_dbDataSet user59_dbDataSet;
        private System.Windows.Forms.BindingSource mDK0701KnigiBindingSource;
        private user59_dbDataSetTableAdapters.MDK0701_KnigiTableAdapter mDK0701_KnigiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private user59_dbDataSet5 user59_dbDataSet5;
        private System.Windows.Forms.BindingSource mDK0701KnigiBindingSource1;
        private user59_dbDataSet5TableAdapters.MDK0701_KnigiTableAdapter mDK0701_KnigiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idknigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godizdaniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvonaskladeDataGridViewTextBoxColumn;
    }
}