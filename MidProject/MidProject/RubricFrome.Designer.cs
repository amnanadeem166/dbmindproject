namespace MidProject
{
    partial class RubricFrome
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
            flowLayoutPanel3 = new FlowLayoutPanel();
            Idlb = new Label();
            idtb = new TextBox();
            label3 = new Label();
            detailstb = new TextBox();
            CLOid = new Label();
            CLOIDtb = new TextBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            searchbt = new Button();
            Searchtb = new TextBox();
            deletestb = new Button();
            Deletetb = new TextBox();
            Updatebt = new Button();
            Addbt = new Button();
            loaddatabt = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.5F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 133);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 317);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(Idlb);
            flowLayoutPanel3.Controls.Add(idtb);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(detailstb);
            flowLayoutPanel3.Controls.Add(CLOid);
            flowLayoutPanel3.Controls.Add(CLOIDtb);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(174, 311);
            flowLayoutPanel3.TabIndex = 2;
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
            label3.Size = new Size(78, 27);
            label3.TabIndex = 26;
            label3.Text = "Details";
            // 
            // detailstb
            // 
            detailstb.Location = new Point(3, 94);
            detailstb.Name = "detailstb";
            detailstb.Size = new Size(150, 31);
            detailstb.TabIndex = 27;
            // 
            // CLOid
            // 
            CLOid.AutoSize = true;
            CLOid.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CLOid.Location = new Point(3, 128);
            CLOid.Name = "CLOid";
            CLOid.Size = new Size(78, 27);
            CLOid.TabIndex = 28;
            CLOid.Text = "CLO ID";
            // 
            // CLOIDtb
            // 
            CLOIDtb.Location = new Point(3, 158);
            CLOIDtb.Name = "CLOIDtb";
            CLOIDtb.Size = new Size(150, 31);
            CLOIDtb.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(183, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(614, 311);
            dataGridView1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 133);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(searchbt);
            flowLayoutPanel4.Controls.Add(Searchtb);
            flowLayoutPanel4.Controls.Add(deletestb);
            flowLayoutPanel4.Controls.Add(Deletetb);
            flowLayoutPanel4.Controls.Add(Updatebt);
            flowLayoutPanel4.Controls.Add(Addbt);
            flowLayoutPanel4.Controls.Add(loaddatabt);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 69);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(794, 61);
            flowLayoutPanel4.TabIndex = 5;
            // 
            // searchbt
            // 
            searchbt.Location = new Point(3, 3);
            searchbt.Name = "searchbt";
            searchbt.Size = new Size(85, 34);
            searchbt.TabIndex = 9;
            searchbt.Text = "Search";
            searchbt.UseVisualStyleBackColor = true;
            searchbt.Click += searchbt_Click;
            // 
            // Searchtb
            // 
            Searchtb.Location = new Point(94, 3);
            Searchtb.Name = "Searchtb";
            Searchtb.Size = new Size(83, 31);
            Searchtb.TabIndex = 10;
            // 
            // deletestb
            // 
            deletestb.Location = new Point(183, 3);
            deletestb.Name = "deletestb";
            deletestb.Size = new Size(85, 34);
            deletestb.TabIndex = 15;
            deletestb.Text = "Delete";
            deletestb.UseVisualStyleBackColor = true;
            deletestb.Click += deletestb_Click;
            // 
            // Deletetb
            // 
            Deletetb.Location = new Point(274, 3);
            Deletetb.Name = "Deletetb";
            Deletetb.Size = new Size(89, 31);
            Deletetb.TabIndex = 18;
            // 
            // Updatebt
            // 
            Updatebt.Location = new Point(369, 3);
            Updatebt.Name = "Updatebt";
            Updatebt.Size = new Size(97, 34);
            Updatebt.TabIndex = 19;
            Updatebt.Text = "Update";
            Updatebt.UseVisualStyleBackColor = true;
            Updatebt.Click += Updatebt_Click;
            // 
            // Addbt
            // 
            Addbt.Location = new Point(472, 3);
            Addbt.Name = "Addbt";
            Addbt.Size = new Size(93, 34);
            Addbt.TabIndex = 20;
            Addbt.Text = "Add ";
            Addbt.UseVisualStyleBackColor = true;
            Addbt.Click += Addbt_Click;
            // 
            // loaddatabt
            // 
            loaddatabt.Location = new Point(571, 3);
            loaddatabt.Name = "loaddatabt";
            loaddatabt.Size = new Size(112, 34);
            loaddatabt.TabIndex = 30;
            loaddatabt.Text = "Load Data";
            loaddatabt.UseVisualStyleBackColor = true;
            loaddatabt.Click += loaddatabt_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 60);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(274, 6);
            label1.Name = "label1";
            label1.Size = new Size(230, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Rubrics";
            // 
            // RubricFrome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "RubricFrome";
            Text = "RubricFrome";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label Idlb;
        private TextBox idtb;
        private Label label3;
        private TextBox detailstb;
        private Label CLOid;
        private TextBox CLOIDtb;
        private Button loaddatabt;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button searchbt;
        private TextBox Searchtb;
        private Button deletestb;
        private TextBox Deletetb;
        private Button Updatebt;
        private Button Addbt;
        private Panel panel2;
        private Label label1;
    }
}