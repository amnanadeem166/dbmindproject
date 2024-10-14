namespace MidProject
{
    partial class CLOSForm
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
            Idlb = new Label();
            idtb = new TextBox();
            label3 = new Label();
            nametb = new TextBox();
            DateClb = new Label();
            DataCtb = new TextBox();
            DateUplb = new Label();
            datauptb = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            clsearchbt = new Button();
            Searchtb = new TextBox();
            deletestb = new Button();
            Deletetb = new TextBox();
            Updatebt = new Button();
            Addbt = new Button();
            loaddatabt = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel2.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.59799F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.40201F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 124);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(800, 326);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(159, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(638, 320);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Idlb);
            flowLayoutPanel1.Controls.Add(idtb);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(nametb);
            flowLayoutPanel1.Controls.Add(DateClb);
            flowLayoutPanel1.Controls.Add(DataCtb);
            flowLayoutPanel1.Controls.Add(DateUplb);
            flowLayoutPanel1.Controls.Add(datauptb);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(150, 320);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Idlb
            // 
            Idlb.AutoSize = true;
            Idlb.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Idlb.Location = new Point(3, 0);
            Idlb.Name = "Idlb";
            Idlb.Size = new Size(33, 27);
            Idlb.TabIndex = 1;
            Idlb.Text = "ID";
            // 
            // idtb
            // 
            idtb.Location = new Point(3, 30);
            idtb.Name = "idtb";
            idtb.Size = new Size(150, 31);
            idtb.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 64);
            label3.Name = "label3";
            label3.Size = new Size(68, 27);
            label3.TabIndex = 26;
            label3.Text = "Name";
            // 
            // nametb
            // 
            nametb.Location = new Point(3, 94);
            nametb.Name = "nametb";
            nametb.Size = new Size(150, 31);
            nametb.TabIndex = 27;
            // 
            // DateClb
            // 
            DateClb.AutoSize = true;
            DateClb.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateClb.Location = new Point(3, 128);
            DateClb.Name = "DateClb";
            DateClb.Size = new Size(138, 27);
            DateClb.TabIndex = 28;
            DateClb.Text = "Date Created";
            // 
            // DataCtb
            // 
            DataCtb.Location = new Point(3, 158);
            DataCtb.Name = "DataCtb";
            DataCtb.Size = new Size(150, 31);
            DataCtb.TabIndex = 29;
            // 
            // DateUplb
            // 
            DateUplb.AutoSize = true;
            DateUplb.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateUplb.Location = new Point(3, 192);
            DateUplb.Name = "DateUplb";
            DateUplb.Size = new Size(96, 54);
            DateUplb.TabIndex = 30;
            DateUplb.Text = "Date Updated";
            // 
            // datauptb
            // 
            datauptb.Location = new Point(3, 249);
            datauptb.Name = "datauptb";
            datauptb.Size = new Size(150, 31);
            datauptb.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.2580643F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.7419357F));
            tableLayoutPanel1.Size = new Size(800, 124);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 65);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(263, 6);
            label1.Name = "label1";
            label1.Size = new Size(231, 45);
            label1.TabIndex = 0;
            label1.Text = "Manage CLOS";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel2.Controls.Add(clsearchbt);
            flowLayoutPanel2.Controls.Add(Searchtb);
            flowLayoutPanel2.Controls.Add(deletestb);
            flowLayoutPanel2.Controls.Add(Deletetb);
            flowLayoutPanel2.Controls.Add(Updatebt);
            flowLayoutPanel2.Controls.Add(Addbt);
            flowLayoutPanel2.Controls.Add(loaddatabt);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 74);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(794, 47);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // clsearchbt
            // 
            clsearchbt.Location = new Point(3, 3);
            clsearchbt.Name = "clsearchbt";
            clsearchbt.Size = new Size(90, 34);
            clsearchbt.TabIndex = 10;
            clsearchbt.Text = "Search";
            clsearchbt.UseVisualStyleBackColor = true;
            clsearchbt.Click += clsearchbt_Click;
            // 
            // Searchtb
            // 
            Searchtb.Location = new Point(99, 3);
            Searchtb.Name = "Searchtb";
            Searchtb.Size = new Size(91, 31);
            Searchtb.TabIndex = 11;
            // 
            // deletestb
            // 
            deletestb.Location = new Point(196, 3);
            deletestb.Name = "deletestb";
            deletestb.Size = new Size(85, 34);
            deletestb.TabIndex = 15;
            deletestb.Text = "Delete";
            deletestb.UseVisualStyleBackColor = true;
            deletestb.Click += deletestb_Click;
            // 
            // Deletetb
            // 
            Deletetb.Location = new Point(287, 3);
            Deletetb.Name = "Deletetb";
            Deletetb.Size = new Size(89, 31);
            Deletetb.TabIndex = 18;
            // 
            // Updatebt
            // 
            Updatebt.Location = new Point(382, 3);
            Updatebt.Name = "Updatebt";
            Updatebt.Size = new Size(112, 34);
            Updatebt.TabIndex = 19;
            Updatebt.Text = "Update";
            Updatebt.UseVisualStyleBackColor = true;
            Updatebt.Click += Updatebt_Click;
            // 
            // Addbt
            // 
            Addbt.Location = new Point(500, 3);
            Addbt.Name = "Addbt";
            Addbt.Size = new Size(122, 34);
            Addbt.TabIndex = 20;
            Addbt.Text = "Add ";
            Addbt.UseVisualStyleBackColor = true;
            Addbt.Click += Addbt_Click;
            // 
            // loaddatabt
            // 
            loaddatabt.Location = new Point(628, 3);
            loaddatabt.Name = "loaddatabt";
            loaddatabt.Size = new Size(112, 34);
            loaddatabt.TabIndex = 23;
            loaddatabt.Text = "Load Data";
            loaddatabt.UseVisualStyleBackColor = true;
            loaddatabt.Click += loaddatabt_Click;
            // 
            // CLOSForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CLOSForm";
            Text = "CLOSForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Idlb;
        private TextBox idtb;
        private Label label3;
        private TextBox nametb;
        private Label DateClb;
        private TextBox DataCtb;
        private Label DateUplb;
        private TextBox datauptb;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button clsearchbt;
        private TextBox Searchtb;
        private Button deletestb;
        private TextBox Deletetb;
        private Button Updatebt;
        private Button Addbt;
        private Button loaddatabt;
    }
}