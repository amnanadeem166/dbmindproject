namespace MidProject
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            classattend_btn = new Button();
            button1 = new Button();
            Studenceatt_btn = new Button();
            dateattend_btn = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.625F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.54955F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.45045F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(214, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 104);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 7);
            label1.Name = "label1";
            label1.Size = new Size(150, 48);
            label1.TabIndex = 0;
            label1.Text = "Reports";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(classattend_btn);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(Studenceatt_btn);
            flowLayoutPanel1.Controls.Add(dateattend_btn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(214, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(583, 334);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // classattend_btn
            // 
            classattend_btn.BackColor = SystemColors.ScrollBar;
            classattend_btn.Location = new Point(3, 3);
            classattend_btn.Name = "classattend_btn";
            classattend_btn.Size = new Size(574, 47);
            classattend_btn.TabIndex = 0;
            classattend_btn.Text = "Class Attendence Report";
            classattend_btn.UseVisualStyleBackColor = false;
            classattend_btn.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(3, 56);
            button1.Name = "button1";
            button1.Size = new Size(574, 44);
            button1.TabIndex = 2;
            button1.Text = "Class Wise Assessment Report";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Studenceatt_btn
            // 
            Studenceatt_btn.BackColor = SystemColors.ScrollBar;
            Studenceatt_btn.Location = new Point(3, 106);
            Studenceatt_btn.Name = "Studenceatt_btn";
            Studenceatt_btn.Size = new Size(574, 34);
            Studenceatt_btn.TabIndex = 4;
            Studenceatt_btn.Text = "Studence Attendence report";
            Studenceatt_btn.UseVisualStyleBackColor = false;
            Studenceatt_btn.Click += Studenceatt_btn_Click;
            // 
            // dateattend_btn
            // 
            dateattend_btn.BackColor = SystemColors.ScrollBar;
            dateattend_btn.Location = new Point(3, 146);
            dateattend_btn.Name = "dateattend_btn";
            dateattend_btn.Size = new Size(574, 34);
            dateattend_btn.TabIndex = 3;
            dateattend_btn.Text = "Studen Average Marks";
            dateattend_btn.UseVisualStyleBackColor = false;
            dateattend_btn.Click += dateattend_btn_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel2.BackgroundImage");
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 113);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(205, 334);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button classattend_btn;
        private Button button1;
        private Button dateattend_btn;
        private Button Studenceatt_btn;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}