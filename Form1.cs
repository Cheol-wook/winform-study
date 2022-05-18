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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }
        
        //서버 연결
        private string Constr = "Server=(local); database=Car_DB;" +
            "Integrated Security=true";

        //모든 data 불러오기
        private void LoadAllData()
        {
            txt_reset();
            listView1.BeginUpdate();
            listView1.Items.Clear();
            ListViewItem item;

            SqlConnection con = new SqlConnection(Constr);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM TB_CAR_INFO", con);

            var Read = command.ExecuteReader();
            while (Read.Read())
            {
                item = new ListViewItem(Read[0].ToString());
                item.SubItems.Add(Read[1].ToString());
                item.SubItems.Add(Read[2].ToString());
                item.SubItems.Add(Read[3].ToString());
                item.SubItems.Add(Read[4].ToString());

                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
