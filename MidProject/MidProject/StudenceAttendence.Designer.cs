namespace MidProject
{
    partial class StudenceAttendence
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
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            fetchattendbt1 = new Button();
            Deleteattendbt = new Button();
            Checkattendbt = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.683760643F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.37703F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9987516F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7777786F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.55556F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(8, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(780, 362);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.9987516F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.00125F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel2.Location = new Point(0, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.23529F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel2.Size = new Size(800, 67);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(fetchattendbt1);
            flowLayoutPanel1.Controls.Add(Deleteattendbt);
            flowLayoutPanel1.Controls.Add(Checkattendbt);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(10, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(777, 45);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // fetchattendbt1
            // 
            fetchattendbt1.Location = new Point(3, 3);
            fetchattendbt1.Name = "fetchattendbt1";
            fetchattendbt1.Size = new Size(233, 34);
            fetchattendbt1.TabIndex = 0;
            fetchattendbt1.Text = "Fetch Attendence";
            fetchattendbt1.UseVisualStyleBackColor = true;
            fetchattendbt1.Click += fetchattendbt1_Click;
            // 
            // Deleteattendbt
            // 
            Deleteattendbt.Location = new Point(242, 3);
            Deleteattendbt.Name = "Deleteattendbt";
            Deleteattendbt.Size = new Size(260, 34);
            Deleteattendbt.TabIndex = 1;
            Deleteattendbt.Text = "Class Attendence";
            Deleteattendbt.UseVisualStyleBackColor = true;
            Deleteattendbt.Click += Deleteattendbt_Click;
            // 
            // Checkattendbt
            // 
            Checkattendbt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Checkattendbt.Location = new Point(508, 3);
            Checkattendbt.Name = "Checkattendbt";
            Checkattendbt.Size = new Size(250, 34);
            Checkattendbt.TabIndex = 2;
            Checkattendbt.Text = "Mark Attendence";
            Checkattendbt.UseVisualStyleBackColor = true;
            Checkattendbt.Click += Checkattendbt_Click;
            // 
            // StudenceAttendence
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "StudenceAttendence";
            Text = "StudenceAttendence";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button fetchattendbt1;
        private Button Deleteattendbt;
        private Button Checkattendbt;
        private DataGridView dataGridView1;
    }
}