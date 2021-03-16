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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = UserName_txt;
            UserName_txt.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            String str = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString.ToString();
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username='" + UserName_txt.Text + "'and password='" + Password_txt.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

           private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

           private void UserName_txt_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Password_txt.Focus();
                }


            }

            private void Password_txt_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LoginBttn.Focus();
                }
            }

            private void Password_txt_TextChanged(object sender, EventArgs e)
            {

                Password_txt.PasswordChar = '*';
                Password_txt.MaxLength = 11;


            }
        }
    } 

