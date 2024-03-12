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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rab
{
    public partial class Dob : Form
    {
        public Dob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;user id=user59_db;password=user59;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection myConnection = new SqlConnection(@connect);
            myConnection.Open();

            string sInsSql = "Insert into [MDK0701_Knigi]([id_knigi],Nazvanie,Avtor,God_izdaniya,Kolichestvo_na_sklade) Values('{0}','{1}','{2}','{3}','{4}')";


            string id_knigi = textBox1.Text;
            string Nazvanie = textBox2.Text;
            string Avtor = textBox3.Text;
            string God_izdaniya = textBox4.Text;
            string Kolichestvo_na_sklade = textBox5.Text;
         




            string sInsSotr = string.Format(sInsSql,id_knigi, Nazvanie, Avtor, God_izdaniya, Kolichestvo_na_sklade);

            SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);

            cmdIns.ExecuteNonQuery();

            MessageBox.Show(string.Format("Успешно добавлено"), "Сообщение");
        }

        private void Dob_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user59_dbDataSet4.MDK0701_Knigi". При необходимости она может быть перемещена или удалена.
            this.mDK0701_KnigiTableAdapter.Fill(this.user59_dbDataSet4.MDK0701_Knigi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            knigi f = new knigi();
            f.Show(); this.Hide();
        }
    }
}
