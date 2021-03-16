namespace TotalEvaluation
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.LoginBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(76, 68);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(80, 20);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username :";
            this.Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(76, 129);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(80, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password :";
            this.Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(186, 129);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(186, 20);
            this.Password_txt.TabIndex = 3;
            this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
            this.Password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_txt_KeyDown);
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(186, 68);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(186, 20);
            this.UserName_txt.TabIndex = 4;
            this.UserName_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.UserName_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserName_txt_KeyDown);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBttn.Location = new System.Drawing.Point(240, 202);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(104, 29);
            this.ExitBttn.TabIndex = 5;
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // LoginBttn
            // 
            this.LoginBttn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBttn.Location = new System.Drawing.Point(93, 202);
            this.LoginBttn.Name = "LoginBttn";
            this.LoginBttn.Size = new System.Drawing.Size(104, 29);
            this.LoginBttn.TabIndex = 6;
            this.LoginBttn.Text = "Login";
            this.LoginBttn.UseVisualStyleBackColor = true;
            this.LoginBttn.Click += new System.EventHandler(this.LoginBttn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(450, 282);
            this.Controls.Add(this.LoginBttn);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.Button ExitBttn;
        private System.Windows.Forms.Button LoginBttn;
        private System.Windows.Forms.TextBox Password_txt;
    }
}

