using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winform_test
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=(local);database=Car_DB;" +
                "Integrated Security=true";
            con.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void PrintTable()
        {
            string Rec;

            SqlCommand com = new SqlCommand("SELECT * FROM TB_CAR_INFO", con);
            com.Connection = con;

            SqlDataReader R;
            R = com.ExecuteReader();

            listView1.Items.Clear();
            while (R.Read())
            {
                Rec = string.Format("번호 : {0}, 이름 : {1}, 년식 : {2}, 가격 : {3}, 도어 {4}",
                    R["id"], R["carName"], R["carYear"], R["carPrice"], R["carDoor"]);
                listView1.Items.Add(Rec);
            }

            R.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
