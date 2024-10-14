namespace MidProject
{
    partial class AssessmentComponent
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel3 = new FlowLayoutPanel();
            namelb = new Label();
            nametb = new TextBox();
            label2 = new Label();
            rubricidtb = new TextBox();
            label3 = new Label();
            totalMatb = new TextBox();
            label4 = new Label();
            dateCtb = new TextBox();
            label5 = new Label();
            DateUptb = new TextBox();
            label6 = new Label();
            Assessidtb = new TextBox();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Searchbt = new Button();
            Searchtb = new TextBox();
            Deletebt = new Button();
            Deletetb = new TextBox();
            Updatebt = new Button();
            Addbt = new Button();
            LoadDatabt = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.6883605F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.64831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.22278F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.37797236F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 2, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.61616135F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.444445F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(8, 10);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(143, 31);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(157, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(620, 400);
            dataGridView1.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(namelb);
            flowLayoutPanel3.Controls.Add(nametb);
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Controls.Add(rubricidtb);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(totalMatb);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(dateCtb);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(DateUptb);
            flowLayoutPanel3.Controls.Add(label6);
            flowLayoutPanel3.Controls.Add(Assessidtb);
            flowLayoutPanel3.Controls.Add(textBox1);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.Location = new Point(8, 47);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(143, 400);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // namelb
            // 
            namelb.AutoSize = true;
            namelb.Location = new Point(3, 0);
            namelb.Name = "namelb";
            namelb.Size = new Size(59, 25);
            namelb.TabIndex = 0;
            namelb.Text = "Name";
            // 
            // nametb
            // 
            nametb.Location = new Point(3, 28);
            nametb.MaximumSize = new Size(150, 50);
            nametb.Name = "nametb";
            nametb.Size = new Size(129, 31);
            nametb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 3;
            label2.Text = "Rubric ID";
            // 
            // rubricidtb
            // 
            rubricidtb.Location = new Point(3, 90);
            rubricidtb.MaximumSize = new Size(150, 50);
            rubricidtb.Name = "rubricidtb";
            rubricidtb.Size = new Size(129, 31);
            rubricidtb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 124);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 5;
            label3.Text = "Total Marks";
            // 
            // totalMatb
            // 
            totalMatb.Location = new Point(3, 152);
            totalMatb.MaximumSize = new Size(150, 50);
            totalMatb.Name = "totalMatb";
            totalMatb.Size = new Size(129, 31);
            totalMatb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 186);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 7;
            label4.Text = "Date Created";
            // 
            // dateCtb
            // 
            dateCtb.Location = new Point(3, 214);
            dateCtb.MaximumSize = new Size(150, 50);
            dateCtb.Name = "dateCtb";
            dateCtb.Size = new Size(129, 31);
            dateCtb.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 248);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 9;
            label5.Text = "Date Updated";
            // 
            // DateUptb
            // 
            DateUptb.Location = new Point(3, 276);
            DateUptb.MaximumSize = new Size(150, 50);
            DateUptb.Name = "DateUptb";
            DateUptb.Size = new Size(129, 31);
            DateUptb.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 310);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 11;
            label6.Text = "Assessment ID";
            // 
            // Assessidtb
            // 
            Assessidtb.Location = new Point(3, 338);
            Assessidtb.MaximumSize = new Size(150, 50);
            Assessidtb.Name = "Assessidtb";
            Assessidtb.Size = new Size(129, 31);
            Assessidtb.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 375);
            textBox1.MaximumSize = new Size(150, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 31);
            textBox1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ActiveBorder;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.6662494F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.7471848F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.62703383F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.357143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 83.03571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6071415F));
            tableLayoutPanel2.Size = new Size(800, 44);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Searchbt);
            flowLayoutPanel1.Controls.Add(Searchtb);
            flowLayoutPanel1.Controls.Add(Deletebt);
            flowLayoutPanel1.Controls.Add(Deletetb);
            flowLayoutPanel1.Controls.Add(Updatebt);
            flowLayoutPanel1.Controls.Add(Addbt);
            flowLayoutPanel1.Controls.Add(LoadDatabt);
            flowLayoutPanel1.Location = new Point(8, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(774, 30);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Searchbt
            // 
            Searchbt.Location = new Point(3, 3);
            Searchbt.MaximumSize = new Size(150, 50);
            Searchbt.Name = "Searchbt";
            Searchbt.Size = new Size(112, 34);
            Searchbt.TabIndex = 0;
            Searchbt.Text = "Search";
            Searchbt.UseVisualStyleBackColor = true;
            Searchbt.Click += Searchbt_Click;
            // 
            // Searchtb
            // 
            Searchtb.Location = new Point(121, 3);
            Searchtb.MaximumSize = new Size(150, 50);
            Searchtb.Name = "Searchtb";
            Searchtb.Size = new Size(77, 31);
            Searchtb.TabIndex = 1;
            // 
            // Deletebt
            // 
            Deletebt.Location = new Point(204, 3);
            Deletebt.Name = "Deletebt";
            Deletebt.Size = new Size(112, 34);
            Deletebt.TabIndex = 2;
            Deletebt.Text = "Delete";
            Deletebt.UseVisualStyleBackColor = true;
            Deletebt.Click += Deletebt_Click;
            // 
            // Deletetb
            // 
            Deletetb.Location = new Point(322, 3);
            Deletetb.Name = "Deletetb";
            Deletetb.Size = new Size(94, 31);
            Deletetb.TabIndex = 3;
            // 
            // Updatebt
            // 
            Updatebt.Location = new Point(422, 3);
            Updatebt.Name = "Updatebt";
            Updatebt.Size = new Size(112, 34);
            Updatebt.TabIndex = 4;
            Updatebt.Text = "Update";
            Updatebt.UseVisualStyleBackColor = true;
            Updatebt.Click += Updatebt_Click;
            // 
            // Addbt
            // 
            Addbt.Location = new Point(540, 3);
            Addbt.Name = "Addbt";
            Addbt.Size = new Size(112, 34);
            Addbt.TabIndex = 5;
            Addbt.Text = "Add";
            Addbt.UseVisualStyleBackColor = true;
            Addbt.Click += Addbt_Click;
            // 
            // LoadDatabt
            // 
            LoadDatabt.Location = new Point(658, 3);
            LoadDatabt.Name = "LoadDatabt";
            LoadDatabt.Size = new Size(112, 34);
            LoadDatabt.TabIndex = 6;
            LoadDatabt.Text = "LoadData";
            LoadDatabt.UseVisualStyleBackColor = true;
            LoadDatabt.Click += LoadDatabt_Click;
            // 
            // AssessmentComponent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "AssessmentComponent";
            Text = "AssessmentComponent";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Searchbt;
        private TextBox Searchtb;
        private Button Deletebt;
        private TextBox Deletetb;
        private Button Updatebt;
        private Button Addbt;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button LoadDatabt;
        private Label namelb;
        private TextBox nametb;
        private Label label2;
        private TextBox rubricidtb;
        private Label label3;
        private TextBox totalMatb;
        private Label label4;
        private TextBox dateCtb;
        private Label label5;
        private TextBox DateUptb;
        private Label label6;
        private TextBox Assessidtb;
        private TextBox textBox1;
    }
}