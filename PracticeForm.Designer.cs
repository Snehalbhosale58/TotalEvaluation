
namespace TotalEvaluation
{
    partial class PracticeForm
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
            this.namelbl = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genderlbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.contactlbl = new System.Windows.Forms.Label();
            this.departmentlbl = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.departmentcb = new System.Windows.Forms.ComboBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.femalerb = new System.Windows.Forms.RadioButton();
            this.malerb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(97, 38);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(55, 17);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "NAME :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(213, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(176, 23);
            this.txtname.TabIndex = 1;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.Control;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(12, 237);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(85, 30);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 183);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlbl.Location = new System.Drawing.Point(77, 71);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(75, 17);
            this.genderlbl.TabIndex = 5;
            this.genderlbl.Text = "GENDER :";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(70, 110);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(82, 17);
            this.addresslbl.TabIndex = 6;
            this.addresslbl.Text = "ADDRESS :";
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(12, 149);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(145, 17);
            this.contactlbl.TabIndex = 8;
            this.contactlbl.Text = "CONTACT NUMBER :";
            // 
            // departmentlbl
            // 
            this.departmentlbl.AutoSize = true;
            this.departmentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentlbl.Location = new System.Drawing.Point(43, 189);
            this.departmentlbl.Name = "departmentlbl";
            this.departmentlbl.Size = new System.Drawing.Size(111, 17);
            this.departmentlbl.TabIndex = 9;
            this.departmentlbl.Text = "DEPARTMENT :";
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(213, 143);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(176, 23);
            this.txtcontact.TabIndex = 11;
            // 
            // departmentcb
            // 
            this.departmentcb.FormattingEnabled = true;
            this.departmentcb.Items.AddRange(new object[] {
            "CSE",
            "ELECTRICAL",
            "MECHANICAL",
            "CIVIL",
            "IT",
            "E&TC"});
            this.departmentcb.Location = new System.Drawing.Point(213, 189);
            this.departmentcb.Name = "departmentcb";
            this.departmentcb.Size = new System.Drawing.Size(121, 21);
            this.departmentcb.TabIndex = 12;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.Control;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(122, 237);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(85, 30);
            this.updatebtn.TabIndex = 13;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.Control;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(234, 237);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(85, 30);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(338, 237);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(85, 30);
            this.clearbtn.TabIndex = 15;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(213, 104);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(176, 23);
            this.txtaddress.TabIndex = 10;
            // 
            // femalerb
            // 
            this.femalerb.AutoSize = true;
            this.femalerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalerb.Location = new System.Drawing.Point(213, 71);
            this.femalerb.Name = "femalerb";
            this.femalerb.Size = new System.Drawing.Size(80, 21);
            this.femalerb.TabIndex = 3;
            this.femalerb.TabStop = true;
            this.femalerb.Text = "FEMALE";
            this.femalerb.UseVisualStyleBackColor = true;
            // 
            // malerb
            // 
            this.malerb.AutoSize = true;
            this.malerb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malerb.Location = new System.Drawing.Point(326, 71);
            this.malerb.Name = "malerb";
            this.malerb.Size = new System.Drawing.Size(63, 21);
            this.malerb.TabIndex = 7;
            this.malerb.TabStop = true;
            this.malerb.Text = "MALE";
            this.malerb.UseVisualStyleBackColor = true;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 477);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.departmentcb);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.departmentlbl);
            this.Controls.Add(this.contactlbl);
            this.Controls.Add(this.malerb);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.genderlbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.femalerb);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.namelbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label departmentlbl;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.ComboBox departmentcb;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.RadioButton femalerb;
        private System.Windows.Forms.RadioButton malerb;
    }
}