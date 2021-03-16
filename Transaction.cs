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
using System.Configuration;

namespace TotalEvaluation
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        public int id;
       // public DateTime Date;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
           // date.CustomFormat = "";
            GetTransactionRecord();
        }
        private void GetTransactionRecord()
        {
            String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SELECT * From transaction_123", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView.DataSource = dt;

        }
        private void Closebttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
                SqlConnection con = new SqlConnection(str);

                string sql = "INSERT INTO transaction_123(description,category,date,amount,amount_type)" +
                                    "VALUES (@description,@category,@date,@amount,@amount_type)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@description", Description_txt.Text);
                cmd.Parameters.AddWithValue("@category", Combo_category.Text);
                cmd.Parameters.AddWithValue("@date", date.Text);
                cmd.Parameters.AddWithValue("@amount", amount_txt.Text);
                cmd.Parameters.AddWithValue("@amount_type", comboamounttype.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data saved!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not saved");
                }
                con.Close();
                GetTransactionRecord();
                ResetFormControls();
            }



        }
        private bool IsValid()
        {
            if (Description_txt.Text == string.Empty)
            {
                MessageBox.Show("Description is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Jan_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetFormControls();

        }
        private void ResetFormControls()
        {
            id = 0;
            Description_txt.Clear();
            // Combo_category.Clear();//
            Combo_category.SelectedIndex = -1;
           
            amount_txt.Clear();           
            comboamounttype.SelectedIndex = -1;
            Description_txt.Focus();


            //date.Format = DateTimePickerFormat.Custom;
            //date.CustomFormat = " ";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            Description_txt.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Combo_category.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            date.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            amount_txt.Text= dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            comboamounttype.Text= dataGridView.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            if(id>0)
            {
                String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
                SqlConnection con = new SqlConnection(str);

                string sql1 = "UPDATE transaction_123 SET description=@description,category=@category,date=@date,amount=@amount,amount_type=@amount_type WHERE id=@Id"; 
       

                SqlCommand cmd = new SqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@description", Description_txt.Text);
                cmd.Parameters.AddWithValue("@category", Combo_category.Text);
                cmd.Parameters.AddWithValue("@date", date.Text);
                cmd.Parameters.AddWithValue("@amount", amount_txt.Text);
                cmd.Parameters.AddWithValue("@amount_type", comboamounttype.Text);
                cmd.Parameters.AddWithValue("@Id", this.id);
                con.Open();
                int b = cmd.ExecuteNonQuery();
                if (b > 0)
                {
                    MessageBox.Show("Data Updated!!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not saved");
                }
                con.Close();
                GetTransactionRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select Data To Update", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deltebtn_Click(object sender, EventArgs e)
        {
            if(id>0)
            {
                String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
                SqlConnection con = new SqlConnection(str);

                string sql2 = "DELETE FROM transaction_123 WHERE id=@Id";


                SqlCommand cmd = new SqlCommand(sql2, con);
                cmd.Parameters.AddWithValue("@Id", this.id);
                con.Open();
                int c = cmd.ExecuteNonQuery();
                if (c > 0)
                {
                    MessageBox.Show("Data Deleted!!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data not deleted");
                }
                con.Close();
                GetTransactionRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select Data To Delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
