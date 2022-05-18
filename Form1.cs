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

            var Read = command.ExecuteReader();     //다중 레코드 반환 (한 개 이상의 레코드)
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

        private void Save_Click(object sender, EventArgs e)
        {
            //오류검출
            if(this.txtName.Text == "" | this.txtYear.Text == "" | this.txtPrice.Text == "" | this.txtDoor.Text == "")
            {
                MessageBox.Show("입력되지 않은 정보가 있습니다.");
                return;
            }

            string Conditional = "(";
            Conditional += "'" + this.txtName.Text + "', ";
            Conditional += "'" + this.txtYear.Text + "', ";
            Conditional += this.txtPrice.Text + "', ";
            Conditional += this.txtDoor + ")";

            SqlConnection con = new SqlConnection(Constr);
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TB_CAR_INFO VALUES" + Conditional, con);
            command.ExecuteNonQuery();      //반환값이 없는 (영향 받은 레코드 수만 반환) 명령어 실행
            con.Close();

            MessageBox.Show("정상적으로 데이터가 저장되었습니다.");
            LoadAllData();
        }

        private void Modify_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                int SelectRow = listView1.SelectedItems[0].Index;

                string Search_Conditional = listView1.Items[SelectRow].SubItems[0].Text;

                string Set_Conditional = "";
                Set_Conditional += "carName = '" + txtName.Text + "', ";
                Set_Conditional += "carYear = '" + txtYear.Text + "', ";
                Set_Conditional += "carPrice = '" + txtPrice.Text + "', ";
                Set_Conditional += "carDoor = '" + txtDoor.Text + "'";

                SqlConnection Conn = new SqlConnection(Constr);
                Conn.Open();
                SqlCommand Command = new SqlCommand("UPDATE TB_CAR_INFO SET " + Set_Conditional +
                    " WHERE id = " + Search_Conditional, Conn);
                Command.ExecuteNonQuery();
                Conn.Close();

                listView1.Items[SelectRow].SubItems[1].Text = txtName.Text;
                listView1.Items[SelectRow].SubItems[2].Text = txtYear.Text;
                listView1.Items[SelectRow].SubItems[3].Text = txtPrice.Text;
                listView1.Items[SelectRow].SubItems[4].Text = txtDoor.Text;

                listView1.Update();

                MessageBox.Show("정상적으로 데이터가 수정되었습니다.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
