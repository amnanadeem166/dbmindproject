namespace MidProject
{
    partial class RubricLevelForm
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
            label2 = new Label();
            idtb = new TextBox();
            label3 = new Label();
            rubricidtb = new TextBox();
            label4 = new Label();
            detailstb = new TextBox();
            label5 = new Label();
            measurestb = new TextBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            searchbt = new Button();
            Searchtb = new TextBox();
            Deletebt = new Button();
            Deletetb = new TextBox();
            Updatebt = new Button();
            Addbt = new Button();
            loadbt = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(idtb);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(rubricidtb);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(detailstb);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(measurestb);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(174, 311);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 32);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // idtb
            // 
            idtb.Location = new Point(3, 35);
            idtb.Name = "idtb";
            idtb.Size = new Size(129, 31);
            idtb.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 3;
            label3.Text = "RubricID";
            // 
            // rubricidtb
            // 
            rubricidtb.Location = new Point(3, 104);
            rubricidtb.Name = "rubricidtb";
            rubricidtb.Size = new Size(129, 31);
            rubricidtb.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 138);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 5;
            label4.Text = "Details";
            // 
            // detailstb
            // 
            detailstb.Location = new Point(3, 173);
            detailstb.Name = "detailstb";
            detailstb.Size = new Size(129, 31);
            detailstb.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 207);
            label5.Name = "label5";
            label5.Size = new Size(124, 32);
            label5.TabIndex = 7;
            label5.Text = "Measures";
            // 
            // measurestb
            // 
            measurestb.Location = new Point(3, 242);
            measurestb.Name = "measurestb";
            measurestb.Size = new Size(129, 31);
            measurestb.TabIndex = 8;
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
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 133);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(searchbt);
            flowLayoutPanel2.Controls.Add(Searchtb);
            flowLayoutPanel2.Controls.Add(Deletebt);
            flowLayoutPanel2.Controls.Add(Deletetb);
            flowLayoutPanel2.Controls.Add(Updatebt);
            flowLayoutPanel2.Controls.Add(Addbt);
            flowLayoutPanel2.Controls.Add(loadbt);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 69);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(794, 61);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // searchbt
            // 
            searchbt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchbt.Location = new Point(3, 3);
            searchbt.Name = "searchbt";
            searchbt.Size = new Size(85, 34);
            searchbt.TabIndex = 10;
            searchbt.Text = "Search";
            searchbt.UseVisualStyleBackColor = true;
            searchbt.Click += searchbt_Click;
            // 
            // Searchtb
            // 
            Searchtb.Dock = DockStyle.Fill;
            Searchtb.Location = new Point(94, 3);
            Searchtb.Name = "Searchtb";
            Searchtb.Size = new Size(87, 31);
            Searchtb.TabIndex = 1;
            // 
            // Deletebt
            // 
            Deletebt.Dock = DockStyle.Fill;
            Deletebt.Location = new Point(187, 3);
            Deletebt.Name = "Deletebt";
            Deletebt.Size = new Size(85, 34);
            Deletebt.TabIndex = 11;
            Deletebt.Text = "Delete";
            Deletebt.UseVisualStyleBackColor = true;
            Deletebt.Click += Deletebt_Click;
            // 
            // Deletetb
            // 
            Deletetb.Dock = DockStyle.Fill;
            Deletetb.Location = new Point(278, 3);
            Deletetb.Name = "Deletetb";
            Deletetb.Size = new Size(89, 31);
            Deletetb.TabIndex = 19;
            // 
            // Updatebt
            // 
            Updatebt.Dock = DockStyle.Fill;
            Updatebt.Location = new Point(373, 3);
            Updatebt.Name = "Updatebt";
            Updatebt.Size = new Size(85, 34);
            Updatebt.TabIndex = 20;
            Updatebt.Text = "Update";
            Updatebt.UseVisualStyleBackColor = true;
            Updatebt.Click += Updatebt_Click;
            // 
            // Addbt
            // 
            Addbt.Location = new Point(464, 3);
            Addbt.Name = "Addbt";
            Addbt.Size = new Size(85, 34);
            Addbt.TabIndex = 21;
            Addbt.Text = "Add";
            Addbt.UseVisualStyleBackColor = true;
            Addbt.Click += Addbt_Click;
            // 
            // loadbt
            // 
            loadbt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loadbt.Location = new Point(555, 3);
            loadbt.Name = "loadbt";
            loadbt.Size = new Size(132, 34);
            loadbt.TabIndex = 22;
            loadbt.Text = "LoadData";
            loadbt.UseVisualStyleBackColor = true;
            loadbt.Click += loadbt_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 60);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 43);
            label1.TabIndex = 0;
            label1.Text = "Manage Rubrics Level";
            // 
            // RubricLevelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "RubricLevelForm";
            Text = "RubricLevelForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button searchbt;
        private TextBox Searchtb;
        private Button Deletebt;
        private TextBox Deletetb;
        private Button Updatebt;
        private Button Addbt;
        private Button loadbt;
        private Label label2;
        private TextBox idtb;
        private Label label3;
        private TextBox rubricidtb;
        private Label label4;
        private TextBox detailstb;
        private Label label5;
        private TextBox measurestb;
    }
}