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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace rab
{
    public partial class vыdacha : Form
    {

        private string connectionString = "data source=stud-mssql.sttec.yar.ru,38325;user id = user59_db; password=user59;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlDataAdapter adapter;
        private DataTable table;

        public vыdacha()
        {
            InitializeComponent();
        }

        private void vыdacha_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user59_dbDataSet2.MDK0701_Vidacha". При необходимости она может быть перемещена или удалена.
            this.mDK0701_VidachaTableAdapter.Fill(this.user59_dbDataSet2.MDK0701_Vidacha);

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

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            knigi f = new knigi();
            f.Show(); this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            cklad f = new cklad();
            f.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(); this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                string query = "SELECT * FROM [MDK0701_Vidacha] ORDER BY [data_vidachi] ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    adapter = new SqlDataAdapter(query, connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }


            }
        }
     
        private void button4_Click(object sender, EventArgs e)
        {
          
          
        }
    }
}
