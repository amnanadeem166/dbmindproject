namespace MidProject
{
    partial class StudentForm1
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            fnametxt = new TextBox();
            LNameLb = new Label();
            Lnametb = new TextBox();
            contactlb = new Label();
            contacttb = new TextBox();
            emaillb = new Label();
            emailtb = new TextBox();
            reglb = new Label();
            regtb = new TextBox();
            Statuslb = new Label();
            statuscb = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            loaddatabt = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            searchbt = new Button();
            Searchtb = new TextBox();
            Deletebt = new Button();
            deletetb = new TextBox();
            Updatebt = new Button();
            addtb = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4285717F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.57143F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(800, 383);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(174, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(623, 369);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(fnametxt);
            flowLayoutPanel1.Controls.Add(LNameLb);
            flowLayoutPanel1.Controls.Add(Lnametb);
            flowLayoutPanel1.Controls.Add(contactlb);
            flowLayoutPanel1.Controls.Add(contacttb);
            flowLayoutPanel1.Controls.Add(emaillb);
            flowLayoutPanel1.Controls.Add(emailtb);
            flowLayoutPanel1.Controls.Add(reglb);
            flowLayoutPanel1.Controls.Add(regtb);
            flowLayoutPanel1.Controls.Add(Statuslb);
            flowLayoutPanel1.Controls.Add(statuscb);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(165, 369);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // fnametxt
            // 
            fnametxt.Location = new Point(3, 28);
            fnametxt.Name = "fnametxt";
            fnametxt.Size = new Size(141, 31);
            fnametxt.TabIndex = 11;
            // 
            // LNameLb
            // 
            LNameLb.AutoSize = true;
            LNameLb.Location = new Point(3, 62);
            LNameLb.Name = "LNameLb";
            LNameLb.Size = new Size(95, 25);
            LNameLb.TabIndex = 12;
            LNameLb.Text = "Last Name";
            // 
            // Lnametb
            // 
            Lnametb.Location = new Point(3, 90);
            Lnametb.Name = "Lnametb";
            Lnametb.Size = new Size(141, 31);
            Lnametb.TabIndex = 13;
            // 
            // contactlb
            // 
            contactlb.AutoSize = true;
            contactlb.Location = new Point(3, 124);
            contactlb.Name = "contactlb";
            contactlb.Size = new Size(73, 25);
            contactlb.TabIndex = 14;
            contactlb.Text = "Contact";
            // 
            // contacttb
            // 
            contacttb.Location = new Point(3, 152);
            contacttb.Name = "contacttb";
            contacttb.Size = new Size(141, 31);
            contacttb.TabIndex = 15;
            // 
            // emaillb
            // 
            emaillb.AutoSize = true;
            emaillb.Location = new Point(3, 186);
            emaillb.Name = "emaillb";
            emaillb.Size = new Size(54, 25);
            emaillb.TabIndex = 16;
            emaillb.Text = "Email";
            // 
            // emailtb
            // 
            emailtb.Location = new Point(3, 214);
            emailtb.Name = "emailtb";
            emailtb.Size = new Size(141, 31);
            emailtb.TabIndex = 17;
            // 
            // reglb
            // 
            reglb.AutoSize = true;
            reglb.Location = new Point(3, 248);
            reglb.Name = "reglb";
            reglb.Size = new Size(135, 25);
            reglb.TabIndex = 18;
            reglb.Text = "Registration No";
            // 
            // regtb
            // 
            regtb.Location = new Point(3, 276);
            regtb.Name = "regtb";
            regtb.Size = new Size(141, 31);
            regtb.TabIndex = 19;
            // 
            // Statuslb
            // 
            Statuslb.AutoSize = true;
            Statuslb.Location = new Point(3, 310);
            Statuslb.Name = "Statuslb";
            Statuslb.Size = new Size(60, 25);
            Statuslb.TabIndex = 20;
            Statuslb.Text = "Status";
            // 
            // statuscb
            // 
            statuscb.FormattingEnabled = true;
            statuscb.Items.AddRange(new object[] { "Active", "Inactive" });
            statuscb.Location = new Point(3, 338);
            statuscb.Name = "statuscb";
            statuscb.Size = new Size(149, 33);
            statuscb.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.25F));
            tableLayoutPanel1.Controls.Add(loaddatabt, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.086956F));
            tableLayoutPanel1.Size = new Size(800, 67);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // loaddatabt
            // 
            loaddatabt.Location = new Point(3, 3);
            loaddatabt.Name = "loaddatabt";
            loaddatabt.Size = new Size(104, 34);
            loaddatabt.TabIndex = 22;
            loaddatabt.Text = "Load Data";
            loaddatabt.UseVisualStyleBackColor = true;
            loaddatabt.Click += loaddatabt_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(searchbt);
            flowLayoutPanel2.Controls.Add(Searchtb);
            flowLayoutPanel2.Controls.Add(Deletebt);
            flowLayoutPanel2.Controls.Add(deletetb);
            flowLayoutPanel2.Controls.Add(Updatebt);
            flowLayoutPanel2.Controls.Add(addtb);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(113, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(684, 61);
            flowLayoutPanel2.TabIndex = 23;
            // 
            // searchbt
            // 
            searchbt.Location = new Point(3, 3);
            searchbt.MinimumSize = new Size(50, 50);
            searchbt.Name = "searchbt";
            searchbt.Size = new Size(122, 55);
            searchbt.TabIndex = 9;
            searchbt.Text = "Search";
            searchbt.UseVisualStyleBackColor = true;
            searchbt.Click += searchbt_Click;
            // 
            // Searchtb
            // 
            Searchtb.Location = new Point(131, 3);
            Searchtb.MinimumSize = new Size(50, 50);
            Searchtb.Name = "Searchtb";
            Searchtb.Size = new Size(101, 50);
            Searchtb.TabIndex = 10;
            // 
            // Deletebt
            // 
            Deletebt.Location = new Point(238, 3);
            Deletebt.MinimumSize = new Size(50, 50);
            Deletebt.Name = "Deletebt";
            Deletebt.Size = new Size(112, 50);
            Deletebt.TabIndex = 11;
            Deletebt.Text = "Delete";
            Deletebt.UseVisualStyleBackColor = true;
            Deletebt.Click += Deletebt_Click;
            // 
            // deletetb
            // 
            deletetb.Location = new Point(356, 3);
            deletetb.Name = "deletetb";
            deletetb.Size = new Size(100, 31);
            deletetb.TabIndex = 12;
            // 
            // Updatebt
            // 
            Updatebt.Location = new Point(462, 3);
            Updatebt.MinimumSize = new Size(50, 50);
            Updatebt.Name = "Updatebt";
            Updatebt.Size = new Size(89, 50);
            Updatebt.TabIndex = 13;
            Updatebt.Text = "Update";
            Updatebt.UseVisualStyleBackColor = true;
            Updatebt.Click += Updatebt_Click;
            // 
            // addtb
            // 
            addtb.Location = new Point(557, 3);
            addtb.MinimumSize = new Size(50, 50);
            addtb.Name = "addtb";
            addtb.Size = new Size(112, 50);
            addtb.TabIndex = 14;
            addtb.Text = "Add";
            addtb.UseVisualStyleBackColor = true;
            addtb.Click += deletestb_Click;
            // 
            // StudentForm1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "StudentForm1";
            Text = "StudentForm1";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox fnametxt;
        private Label LNameLb;
        private TextBox Lnametb;
        private Label contactlb;
        private TextBox contacttb;
        private Label emaillb;
        private TextBox emailtb;
        private Label reglb;
        private TextBox regtb;
        private Label Statuslb;
        private ComboBox statuscb;
        private Button loaddatabt;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button searchbt;
        private TextBox Searchtb;
        private Button Deletebt;
        private TextBox deletetb;
        private Button Updatebt;
        private Button addtb;
    }
}