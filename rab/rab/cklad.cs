using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rab
{
    public partial class cklad : Form
    {
        private string connectionString = "data source=stud-mssql.sttec.yar.ru,38325;user id = user59_db; password=user59;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlDataAdapter adapter;
        private DataTable table;

        public cklad()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                string query = "SELECT * FROM [MDK0701_SKLAD] WHERE est_na_sklade = 'нет' ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    adapter = new SqlDataAdapter(query, connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            vыdacha f = new vыdacha();
            f.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            knigi f = new knigi();
            f.Show();
            this.Hide();
        }

        private void cklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user59_dbDataSet3.MDK0701_SKLAD". При необходимости она может быть перемещена или удалена.
            this.mDK0701_SKLADTableAdapter.Fill(this.user59_dbDataSet3.MDK0701_SKLAD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user59_dbDataSet1.MDK0701_Polzovyateli". При необходимости она может быть перемещена или удалена.
            this.mDK0701_PolzovyateliTableAdapter.Fill(this.user59_dbDataSet1.MDK0701_Polzovyateli);

        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                string query = "SELECT * FROM [MDK0701_SKLAD] WHERE est_na_sklade ='да'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    adapter = new SqlDataAdapter(query, connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }


            }
        }
    }
}
