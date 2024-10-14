namespace MidProject
{
    partial class AssessmentForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            searchbt = new Button();
            Searchtb = new TextBox();
            button2 = new Button();
            Deletetb = new TextBox();
            addbt = new Button();
            Updatebt = new Button();
            loadbt = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label2 = new Label();
            idtb = new TextBox();
            label3 = new Label();
            titletb = new TextBox();
            label4 = new Label();
            DateCtb = new TextBox();
            label5 = new Label();
            TMarkstb = new TextBox();
            label6 = new Label();
            TWeighttb = new TextBox();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 450);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(797, 116);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(searchbt);
            flowLayoutPanel3.Controls.Add(Searchtb);
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Controls.Add(Deletetb);
            flowLayoutPanel3.Controls.Add(addbt);
            flowLayoutPanel3.Controls.Add(Updatebt);
            flowLayoutPanel3.Controls.Add(loadbt);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 61);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(791, 52);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // searchbt
            // 
            searchbt.Location = new Point(3, 3);
            searchbt.Name = "searchbt";
            searchbt.Size = new Size(85, 34);
            searchbt.TabIndex = 0;
            searchbt.Text = "Search";
            searchbt.UseVisualStyleBackColor = true;
            searchbt.Click += searchbt_Click;
            // 
            // Searchtb
            // 
            Searchtb.Location = new Point(94, 3);
            Searchtb.Name = "Searchtb";
            Searchtb.Size = new Size(99, 31);
            Searchtb.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(199, 3);
            button2.Name = "button2";
            button2.Size = new Size(85, 34);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Deletetb
            // 
            Deletetb.Location = new Point(290, 3);
            Deletetb.Name = "Deletetb";
            Deletetb.Size = new Size(100, 31);
            Deletetb.TabIndex = 4;
            // 
            // addbt
            // 
            addbt.Location = new Point(396, 3);
            addbt.Name = "addbt";
            addbt.Size = new Size(85, 34);
            addbt.TabIndex = 4;
            addbt.Text = "Add";
            addbt.UseVisualStyleBackColor = true;
            addbt.Click += addbt_Click;
            // 
            // Updatebt
            // 
            Updatebt.Location = new Point(487, 3);
            Updatebt.Name = "Updatebt";
            Updatebt.Size = new Size(85, 34);
            Updatebt.TabIndex = 5;
            Updatebt.Text = "Update";
            Updatebt.UseVisualStyleBackColor = true;
            Updatebt.Click += Updatebt_Click;
            // 
            // loadbt
            // 
            loadbt.Location = new Point(578, 3);
            loadbt.Name = "loadbt";
            loadbt.Size = new Size(148, 34);
            loadbt.TabIndex = 6;
            loadbt.Text = "Load Data";
            loadbt.UseVisualStyleBackColor = true;
            loadbt.Click += loadbt_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(791, 52);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 43);
            label1.TabIndex = 0;
            label1.Text = "Assessment";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.2770786F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.72292F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 329);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel4.Controls.Add(label2);
            flowLayoutPanel4.Controls.Add(idtb);
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(titletb);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(DateCtb);
            flowLayoutPanel4.Controls.Add(label5);
            flowLayoutPanel4.Controls.Add(TMarkstb);
            flowLayoutPanel4.Controls.Add(label6);
            flowLayoutPanel4.Controls.Add(TWeighttb);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(155, 323);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // idtb
            // 
            idtb.Location = new Point(3, 28);
            idtb.Name = "idtb";
            idtb.Size = new Size(150, 31);
            idtb.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 62);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // titletb
            // 
            titletb.Location = new Point(3, 90);
            titletb.Name = "titletb";
            titletb.Size = new Size(150, 31);
            titletb.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 124);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 4;
            label4.Text = "Date Created";
            // 
            // DateCtb
            // 
            DateCtb.Location = new Point(3, 152);
            DateCtb.Name = "DateCtb";
            DateCtb.Size = new Size(150, 31);
            DateCtb.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 186);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 6;
            label5.Text = "Total Marks";
            // 
            // TMarkstb
            // 
            TMarkstb.Location = new Point(3, 214);
            TMarkstb.Name = "TMarkstb";
            TMarkstb.Size = new Size(150, 31);
            TMarkstb.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 248);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 8;
            label6.Text = "Total Weightage";
            // 
            // TWeighttb
            // 
            TWeighttb.Location = new Point(3, 276);
            TWeighttb.Name = "TWeighttb";
            TWeighttb.Size = new Size(150, 31);
            TWeighttb.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(164, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(627, 323);
            dataGridView1.TabIndex = 2;
            // 
            // AssessmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "AssessmentForm";
            Text = "AssessmentForm";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button searchbt;
        private TextBox Searchtb;
        private Button button2;
        private TextBox Deletetb;
        private Button addbt;
        private Button Updatebt;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label2;
        private TextBox idtb;
        private Label label3;
        private TextBox titletb;
        private Label label4;
        private TextBox DateCtb;
        private Label label5;
        private TextBox TMarkstb;
        private Label label6;
        private TextBox TWeighttb;
        private DataGridView dataGridView1;
        private Button loadbt;
    }
}