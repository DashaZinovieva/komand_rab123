﻿namespace rab
{
    partial class cklad
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.user59_dbDataSet1 = new rab.user59_dbDataSet1();
            this.mDK0701PolzovyateliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDK0701_PolzovyateliTableAdapter = new rab.user59_dbDataSet1TableAdapters.MDK0701_PolzovyateliTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user59_dbDataSet3 = new rab.user59_dbDataSet3();
            this.mDK0701SKLADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDK0701_SKLADTableAdapter = new rab.user59_dbDataSet3TableAdapters.MDK0701_SKLADTableAdapter();
            this.idskladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idknigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estnaskladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701PolzovyateliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701SKLADBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 7;
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
            this.menuStrip1.TabIndex = 6;
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
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.LightGray;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(40, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Есть на складе";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(483, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(171, 20);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Отсутсвует на складе";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // user59_dbDataSet1
            // 
            this.user59_dbDataSet1.DataSetName = "user59_dbDataSet1";
            this.user59_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDK0701PolzovyateliBindingSource
            // 
            this.mDK0701PolzovyateliBindingSource.DataMember = "MDK0701_Polzovyateli";
            this.mDK0701PolzovyateliBindingSource.DataSource = this.user59_dbDataSet1;
            // 
            // mDK0701_PolzovyateliTableAdapter
            // 
            this.mDK0701_PolzovyateliTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idskladDataGridViewTextBoxColumn,
            this.idknigiDataGridViewTextBoxColumn,
            this.estnaskladeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mDK0701SKLADBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(162, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 271);
            this.dataGridView1.TabIndex = 13;
            // 
            // user59_dbDataSet3
            // 
            this.user59_dbDataSet3.DataSetName = "user59_dbDataSet3";
            this.user59_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDK0701SKLADBindingSource
            // 
            this.mDK0701SKLADBindingSource.DataMember = "MDK0701_SKLAD";
            this.mDK0701SKLADBindingSource.DataSource = this.user59_dbDataSet3;
            // 
            // mDK0701_SKLADTableAdapter
            // 
            this.mDK0701_SKLADTableAdapter.ClearBeforeFill = true;
            // 
            // idskladDataGridViewTextBoxColumn
            // 
            this.idskladDataGridViewTextBoxColumn.DataPropertyName = "id_sklad";
            this.idskladDataGridViewTextBoxColumn.HeaderText = "id_sklad";
            this.idskladDataGridViewTextBoxColumn.Name = "idskladDataGridViewTextBoxColumn";
            // 
            // idknigiDataGridViewTextBoxColumn
            // 
            this.idknigiDataGridViewTextBoxColumn.DataPropertyName = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.HeaderText = "id_knigi";
            this.idknigiDataGridViewTextBoxColumn.Name = "idknigiDataGridViewTextBoxColumn";
            // 
            // estnaskladeDataGridViewTextBoxColumn
            // 
            this.estnaskladeDataGridViewTextBoxColumn.DataPropertyName = "est_na_sklade";
            this.estnaskladeDataGridViewTextBoxColumn.HeaderText = "est_na_sklade";
            this.estnaskladeDataGridViewTextBoxColumn.Name = "estnaskladeDataGridViewTextBoxColumn";
            // 
            // cklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "cklad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cklad";
            this.Load += new System.EventHandler(this.cklad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701PolzovyateliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user59_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0701SKLADBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private user59_dbDataSet1 user59_dbDataSet1;
        private System.Windows.Forms.BindingSource mDK0701PolzovyateliBindingSource;
        private user59_dbDataSet1TableAdapters.MDK0701_PolzovyateliTableAdapter mDK0701_PolzovyateliTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private user59_dbDataSet3 user59_dbDataSet3;
        private System.Windows.Forms.BindingSource mDK0701SKLADBindingSource;
        private user59_dbDataSet3TableAdapters.MDK0701_SKLADTableAdapter mDK0701_SKLADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idskladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idknigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estnaskladeDataGridViewTextBoxColumn;
    }
}