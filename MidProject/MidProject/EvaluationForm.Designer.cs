namespace MidProject
{
    partial class EvaluationForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            clo_btn = new Button();
            splitter1 = new Splitter();
            cbx_clos = new ComboBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            assessment_btn = new Button();
            splitter2 = new Splitter();
            cbxAssessmentTitles = new ComboBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.8510628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.1489372F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.Evaluation;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 116);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel2.Controls.Add(clo_btn);
            flowLayoutPanel2.Controls.Add(splitter1);
            flowLayoutPanel2.Controls.Add(cbx_clos);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 125);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(794, 170);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // clo_btn
            // 
            clo_btn.Location = new Point(3, 3);
            clo_btn.Name = "clo_btn";
            clo_btn.Size = new Size(284, 34);
            clo_btn.TabIndex = 1;
            clo_btn.Text = "CLOS Result";
            clo_btn.UseVisualStyleBackColor = true;
            clo_btn.Click += clo_btn_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(293, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(252, 34);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // cbx_clos
            // 
            cbx_clos.FormattingEnabled = true;
            cbx_clos.Location = new Point(551, 3);
            cbx_clos.Name = "cbx_clos";
            cbx_clos.Size = new Size(234, 33);
            cbx_clos.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel3.Controls.Add(assessment_btn);
            flowLayoutPanel3.Controls.Add(splitter2);
            flowLayoutPanel3.Controls.Add(cbxAssessmentTitles);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 301);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(794, 146);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // assessment_btn
            // 
            assessment_btn.Location = new Point(3, 3);
            assessment_btn.Name = "assessment_btn";
            assessment_btn.Size = new Size(284, 34);
            assessment_btn.TabIndex = 1;
            assessment_btn.Text = "Assessment Result";
            assessment_btn.UseVisualStyleBackColor = true;
            assessment_btn.Click += assessment_btn_Click;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(293, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(252, 34);
            splitter2.TabIndex = 3;
            splitter2.TabStop = false;
            // 
            // cbxAssessmentTitles
            // 
            cbxAssessmentTitles.FormattingEnabled = true;
            cbxAssessmentTitles.Location = new Point(551, 3);
            cbxAssessmentTitles.Name = "cbxAssessmentTitles";
            cbxAssessmentTitles.Size = new Size(234, 33);
            cbxAssessmentTitles.TabIndex = 4;
            // 
            // EvaluationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EvaluationForm";
            Text = "EvaluationForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button clo_btn;
        private Splitter splitter1;
        private ComboBox cbx_clos;
        private Button assessment_btn;
        private Splitter splitter2;
        private ComboBox cbxAssessmentTitles;
    }
}