namespace rab
{
    partial class vыdacha
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvidachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idknigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpolzovyatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavidachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasdachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDK0701VidachaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user59_dbDataSet2 = new rab.user59_dbDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.mDK0701_VidachaTableAdapter = new rab.user59_dbDataSet2TableAdapters.MDK0701_VidachaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701VidachaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(45, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Сортировка по дате";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvidachiDataGridViewTextBoxColumn,
            this.idknigiDataGridViewTextBoxColumn,
            this.idpolzovyatelyaDataGridViewTextBoxColumn,
            this.datavidachiDataGridViewTextBoxColumn,
            this.datasdachiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mDK0701VidachaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 259);
            this.dataGridView1.TabIndex = 16;
            // 
            // idvidachiDataGridViewTextBoxColumn
            // 
            this.idvidachiDataGridViewTextBoxColumn.DataPropertyName = "id_vidachi";
            this.idvidachiDataGridViewTextBoxColumn.HeaderText = "id_vidachi";
            this.idvidachiDataGridViewTextBoxColumn.Name = "idvidachiDataGridViewTextBoxColumn";
            this.idvidachiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idknigiDataGridViewTextBoxColumn
            // 
            this.idknigiDataGridViewTextBoxColumn.DataPropertyName = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.HeaderText = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.Name = "idknigiDataGridViewTextBoxColumn";
            // 
            // idpolzovyatelyaDataGridViewTextBoxColumn
            // 
            this.idpolzovyatelyaDataGridViewTextBoxColumn.DataPropertyName = "id_polzovyatelya";
            this.idpolzovyatelyaDataGridViewTextBoxColumn.HeaderText = "id_polzovyatelya";
            this.idpolzovyatelyaDataGridViewTextBoxColumn.Name = "idpolzovyatelyaDataGridViewTextBoxColumn";
            // 
            // datavidachiDataGridViewTextBoxColumn
            // 
            this.datavidachiDataGridViewTextBoxColumn.DataPropertyName = "data_vidachi";
            this.datavidachiDataGridViewTextBoxColumn.HeaderText = "data_vidachi";
            this.datavidachiDataGridViewTextBoxColumn.Name = "datavidachiDataGridViewTextBoxColumn";
            // 
            // datasdachiDataGridViewTextBoxColumn
            // 
            this.datasdachiDataGridViewTextBoxColumn.DataPropertyName = "data_sdachi";
            this.datasdachiDataGridViewTextBoxColumn.HeaderText = "data_sdachi";
            this.datasdachiDataGridViewTextBoxColumn.Name = "datasdachiDataGridViewTextBoxColumn";
            // 
            // mDK0701VidachaBindingSource
            // 
            this.mDK0701VidachaBindingSource.DataMember = "MDK0701_Vidacha";
            this.mDK0701VidachaBindingSource.DataSource = this.user59_dbDataSet2;
            // 
            // user59_dbDataSet2
            // 
            this.user59_dbDataSet2.DataSetName = "user59_dbDataSet2";
            this.user59_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 14;
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
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.книгиToolStripMenuItem.Text = "Книги";
            this.книгиToolStripMenuItem.Click += new System.EventHandler(this.книгиToolStripMenuItem_Click);
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
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem3.Text = "Выдача";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(605, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mDK0701_VidachaTableAdapter
            // 
            this.mDK0701_VidachaTableAdapter.ClearBeforeFill = true;
            // 
            // vыdacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "vыdacha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vыdacha";
            this.Load += new System.EventHandler(this.vыdacha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701VidachaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button button3;
        private user59_dbDataSet2 user59_dbDataSet2;
        private System.Windows.Forms.BindingSource mDK0701VidachaBindingSource;
        private user59_dbDataSet2TableAdapters.MDK0701_VidachaTableAdapter mDK0701_VidachaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvidachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idknigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpolzovyatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavidachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasdachiDataGridViewTextBoxColumn;
    }
}