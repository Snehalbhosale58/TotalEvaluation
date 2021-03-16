using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TotalEvaluation
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            bindGridView();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void rdbincome_CheckedChanged(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(str);
            string query = "SELECT * FROM transaction_123 WHERE category='income'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row["id"].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row["description"].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row["category"].ToString();
                dataGridView1.Rows[index].Cells[3].Value = row["date"].ToString();
                dataGridView1.Rows[index].Cells[4].Value = row["amount"].ToString();

            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView1.DataSource = data;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void bindGridView()
        {
            String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(str);
            string query = "SELECT * FROM transaction_123 ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.Rows.Clear();
            foreach(DataRow row in data.Rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row["id"].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row["description"].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row["category"].ToString();
                dataGridView1.Rows[index].Cells[3].Value = row["date"].ToString();
                dataGridView1.Rows[index].Cells[4].Value = row["amount"].ToString();

            }



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.DataSource = data;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(str);
            string query = "SELECT * FROM transaction_123 WHERE category='expense'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row["id"].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row["description"].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row["category"].ToString();
                dataGridView1.Rows[index].Cells[3].Value = row["date"].ToString();
                dataGridView1.Rows[index].Cells[4].Value = row["amount"].ToString();

            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.DataSource = data;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bindGridView();
            //String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
            //SqlConnection con = new SqlConnection(str);
            //string query = "SELECT * FROM transaction_123 ";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //foreach (DataRow row in data.Rows)
            //{
            //    int index = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[index].Cells[0].Value = row["id"].ToString();
            //    dataGridView1.Rows[index].Cells[1].Value = row["description"].ToString();
            //    dataGridView1.Rows[index].Cells[2].Value = row["category"].ToString();
            //    dataGridView1.Rows[index].Cells[3].Value = row["date"].ToString();
            //    dataGridView1.Rows[index].Cells[4].Value = row["amount"].ToString();

            //}
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(str);
            string query = "SELECT * FROM transaction_123 WHERE date between '"+dateTimePicker1.Value.ToString("MM/dd/yyyy") +"' AND '"+dateTimePicker2.Value.ToString("MM/dd/yyyy") +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
          
            //dataGridView1.DataSource = data;

            dataGridView1.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {

                int index = dataGridView1.Rows.Add();
                //dataGridView1.Rows.Add();
                //int index = dataGridView1.RowCount - 1;
                dataGridView1.Rows[index].Cells[0].Value = row["id"].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row["description"].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row["category"].ToString();
                dataGridView1.Rows[index].Cells[3].Value = row["date"].ToString();
                dataGridView1.Rows[index].Cells[4].Value = row["amount"].ToString();

            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
    }
}
