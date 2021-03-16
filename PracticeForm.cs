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

namespace TotalEvaluation
{
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();
            getrecord();
        }


     
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\C#\TotalEvaluation\TotalEvaluation\database.mdf;Integrated Security=True");
       public string gender = "";
        public int studentId;

        private void getrecord()
        {
            SqlCommand cmd = new SqlCommand("select * from information", con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            //DataTable dt = new DataTable();

            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();
            //dataGridView1.DataSource = dt;
        }

        private void clear()
        {
            studentId = 0;
            gender = "";
            femalerb.Checked = false;
            malerb.Checked = false;
            departmentcb.SelectedIndex = -1;
            txtname.Clear();
            txtcontact.Clear();
            txtaddress.Clear();
          
        }

        

        private void savebtn_Click_1(object sender, EventArgs e)
        {
            if (femalerb.Checked)
            {
                gender = femalerb.Text;
            }
            else
            {
                gender = malerb.Text;
            }

            SqlCommand cmd = new SqlCommand("insert into information values(@name,@gender,@address,@contact,@department)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", txtname.Text.ToString());
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text.ToString());
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text.ToString());
            cmd.Parameters.AddWithValue("@department", departmentcb.SelectedItem);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Record Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record Not Inserted", "Not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            getrecord();
            clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            //Description_txt.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            //Combo_category.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            //date.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            //amount_txt.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            //comboamounttype.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            gender = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if(gender=="FEMALE")
            {
                femalerb.Select();
            }
            else
            {
                malerb.Select();
            }
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtcontact.Text= dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            departmentcb.SelectedItem= dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if(studentId>0)
            {
                SqlCommand cmd = new SqlCommand("update information set name=@name,gender=@gender,address=@address,contact=@contact,department=@department where id=@id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id",this.studentId);
                cmd.Parameters.AddWithValue("@name", txtname.Text.ToString());
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text.ToString());
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text.ToString());
                cmd.Parameters.AddWithValue("@department", departmentcb.SelectedItem);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Record Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Not Updated", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                getrecord();
                clear();

            }
            else
            {
                MessageBox.Show("Please Select Record For Updation", "Record Not Selected ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (studentId > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from information  where id=@id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id",this.studentId);
               
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Record Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                getrecord();
                clear();

            }
            else
            {
                MessageBox.Show("Please Select Record For Delete", "Record Not Selected ?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PracticeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
