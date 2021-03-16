namespace TotalEvaluation
{
    partial class Transaction
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
            this.Description = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.Combo_category = new System.Windows.Forms.ComboBox();
            this.savebttn = new System.Windows.Forms.Button();
            this.Closebttn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.updatebttn = new System.Windows.Forms.Button();
            this.resetbttn = new System.Windows.Forms.Button();
            this.deltebtn = new System.Windows.Forms.Button();
            this.comboamounttype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(12, 17);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(84, 17);
            this.Description.TabIndex = 0;
            this.Description.Text = "Description";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(19, 52);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(68, 17);
            this.category.TabIndex = 7;
            this.category.Text = "Category";
            // 
            // Description_txt
            // 
            this.Description_txt.Location = new System.Drawing.Point(115, 17);
            this.Description_txt.Name = "Description_txt";
            this.Description_txt.Size = new System.Drawing.Size(128, 20);
            this.Description_txt.TabIndex = 8;
            // 
            // Combo_category
            // 
            this.Combo_category.FormattingEnabled = true;
            this.Combo_category.Items.AddRange(new object[] {
            "expense",
            "income"});
            this.Combo_category.Location = new System.Drawing.Point(117, 56);
            this.Combo_category.Name = "Combo_category";
            this.Combo_category.Size = new System.Drawing.Size(126, 21);
            this.Combo_category.TabIndex = 9;
            this.Combo_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // savebttn
            // 
            this.savebttn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebttn.Location = new System.Drawing.Point(33, 145);
            this.savebttn.Name = "savebttn";
            this.savebttn.Size = new System.Drawing.Size(75, 23);
            this.savebttn.TabIndex = 10;
            this.savebttn.Text = "SAVE";
            this.savebttn.UseVisualStyleBackColor = true;
            this.savebttn.Click += new System.EventHandler(this.savebttn_Click);
            // 
            // Closebttn
            // 
            this.Closebttn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebttn.Location = new System.Drawing.Point(451, 145);
            this.Closebttn.Name = "Closebttn";
            this.Closebttn.Size = new System.Drawing.Size(75, 23);
            this.Closebttn.TabIndex = 11;
            this.Closebttn.Text = "CLOSE";
            this.Closebttn.UseVisualStyleBackColor = true;
            this.Closebttn.Click += new System.EventHandler(this.Closebttn_Click);
            // 
            // date
            // 
            this.date.CustomFormat = "dd:mm:yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(412, 17);
            this.date.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.RightToLeftLayout = true;
            this.date.ShowUpDown = true;
            this.date.Size = new System.Drawing.Size(126, 20);
            this.date.TabIndex = 30;
            this.date.Value = new System.DateTime(2021, 2, 20, 19, 57, 38, 0);
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(117, 91);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(126, 20);
            this.amount_txt.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Amount Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Date";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 174);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(680, 325);
            this.dataGridView.TabIndex = 36;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // updatebttn
            // 
            this.updatebttn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebttn.Location = new System.Drawing.Point(140, 145);
            this.updatebttn.Name = "updatebttn";
            this.updatebttn.Size = new System.Drawing.Size(75, 23);
            this.updatebttn.TabIndex = 37;
            this.updatebttn.Text = "UPDATE";
            this.updatebttn.UseVisualStyleBackColor = true;
            this.updatebttn.Click += new System.EventHandler(this.updatebttn_Click);
            // 
            // resetbttn
            // 
            this.resetbttn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbttn.Location = new System.Drawing.Point(249, 145);
            this.resetbttn.Name = "resetbttn";
            this.resetbttn.Size = new System.Drawing.Size(75, 23);
            this.resetbttn.TabIndex = 38;
            this.resetbttn.Text = "RESET";
            this.resetbttn.UseVisualStyleBackColor = true;
            this.resetbttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // deltebtn
            // 
            this.deltebtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltebtn.Location = new System.Drawing.Point(355, 145);
            this.deltebtn.Name = "deltebtn";
            this.deltebtn.Size = new System.Drawing.Size(75, 23);
            this.deltebtn.TabIndex = 39;
            this.deltebtn.Text = "DELETE";
            this.deltebtn.UseVisualStyleBackColor = true;
            this.deltebtn.Click += new System.EventHandler(this.deltebtn_Click);
            // 
            // comboamounttype
            // 
            this.comboamounttype.FormattingEnabled = true;
            this.comboamounttype.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.comboamounttype.Location = new System.Drawing.Point(412, 60);
            this.comboamounttype.Name = "comboamounttype";
            this.comboamounttype.Size = new System.Drawing.Size(126, 21);
            this.comboamounttype.TabIndex = 40;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 519);
            this.Controls.Add(this.comboamounttype);
            this.Controls.Add(this.deltebtn);
            this.Controls.Add(this.resetbttn);
            this.Controls.Add(this.updatebttn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Closebttn);
            this.Controls.Add(this.savebttn);
            this.Controls.Add(this.Combo_category);
            this.Controls.Add(this.Description_txt);
            this.Controls.Add(this.category);
            this.Controls.Add(this.Description);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox Description_txt;
        private System.Windows.Forms.ComboBox Combo_category;
        private System.Windows.Forms.Button savebttn;
        private System.Windows.Forms.Button Closebttn;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button updatebttn;
        private System.Windows.Forms.Button resetbttn;
        private System.Windows.Forms.Button deltebtn;
        private System.Windows.Forms.ComboBox comboamounttype;
    }
}