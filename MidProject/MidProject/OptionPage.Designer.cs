namespace MidProject
{
    partial class OptionPage
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            rep_btn = new Button();
            eval_btn = new Button();
            attendence = new Button();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ScrollBar;
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Size = new Size(1058, 394);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(rep_btn, 0, 8);
            tableLayoutPanel1.Controls.Add(eval_btn, 0, 7);
            tableLayoutPanel1.Controls.Add(attendence, 0, 6);
            tableLayoutPanel1.Controls.Add(button1, 0, 5);
            tableLayoutPanel1.Controls.Add(button6, 0, 4);
            tableLayoutPanel1.Controls.Add(button5, 0, 3);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6402121F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.58201F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Size = new Size(300, 394);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rep_btn
            // 
            rep_btn.Dock = DockStyle.Fill;
            rep_btn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rep_btn.ForeColor = Color.Brown;
            rep_btn.Location = new Point(3, 347);
            rep_btn.Name = "rep_btn";
            rep_btn.Size = new Size(294, 44);
            rep_btn.TabIndex = 16;
            rep_btn.Text = "Reports";
            rep_btn.UseVisualStyleBackColor = true;
            rep_btn.Click += rep_btn_Click;
            // 
            // eval_btn
            // 
            eval_btn.Dock = DockStyle.Fill;
            eval_btn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eval_btn.ForeColor = Color.Brown;
            eval_btn.Location = new Point(3, 304);
            eval_btn.Name = "eval_btn";
            eval_btn.Size = new Size(294, 37);
            eval_btn.TabIndex = 15;
            eval_btn.Text = "Evaluation";
            eval_btn.UseVisualStyleBackColor = true;
            eval_btn.Click += eval_btn_Click;
            // 
            // attendence
            // 
            attendence.Dock = DockStyle.Fill;
            attendence.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendence.ForeColor = Color.Brown;
            attendence.Location = new Point(3, 261);
            attendence.Name = "attendence";
            attendence.Size = new Size(294, 37);
            attendence.TabIndex = 14;
            attendence.Text = "Attendence";
            attendence.UseVisualStyleBackColor = true;
            attendence.Click += attendence_Click_1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(3, 218);
            button1.Name = "button1";
            button1.Size = new Size(294, 37);
            button1.TabIndex = 12;
            button1.Text = "Assessment Component";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Brown;
            button6.Location = new Point(3, 175);
            button6.Name = "button6";
            button6.Size = new Size(294, 37);
            button6.TabIndex = 11;
            button6.Text = "Assessments";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Brown;
            button5.Location = new Point(3, 132);
            button5.Name = "button5";
            button5.Size = new Size(294, 37);
            button5.TabIndex = 10;
            button5.Text = "Rubrics Level";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Brown;
            button4.Location = new Point(3, 89);
            button4.Name = "button4";
            button4.Size = new Size(294, 37);
            button4.TabIndex = 5;
            button4.Text = "Rubrics";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Brown;
            button3.Location = new Point(3, 48);
            button3.Name = "button3";
            button3.Size = new Size(294, 35);
            button3.TabIndex = 3;
            button3.Text = "CLOS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(294, 39);
            button2.TabIndex = 2;
            button2.Text = " Student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackgroundImage = Properties.Resources.FirstPage;
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(755, 394);
            flowLayoutPanel2.TabIndex = 17;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // OptionPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 394);
            Controls.Add(splitContainer1);
            Name = "OptionPage";
            Text = "OptionPage";
            Load += OptionPage_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button attendence;
        private Button button1;
        private Button eval_btn;
        private Button rep_btn;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}