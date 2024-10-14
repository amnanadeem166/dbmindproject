namespace MidProject
{
    partial class Evaluation
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
            assessment_btn = new Button();
            cbxAssessmentTitles = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            clo_btn = new Button();
            cbx_clos = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(845, 460);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.84323F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.15677F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.037199F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.9628F));
            tableLayoutPanel1.Size = new Size(842, 457);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(assessment_btn);
            flowLayoutPanel3.Controls.Add(cbxAssessmentTitles);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(389, 90);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(450, 364);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // assessment_btn
            // 
            assessment_btn.Location = new Point(3, 3);
            assessment_btn.Name = "assessment_btn";
            assessment_btn.Size = new Size(177, 34);
            assessment_btn.TabIndex = 0;
            assessment_btn.Text = "Assessment Result";
            assessment_btn.UseVisualStyleBackColor = true;
            assessment_btn.Click += assessment_btn_Click;
            // 
            // cbxAssessmentTitles
            // 
            cbxAssessmentTitles.FormattingEnabled = true;
            cbxAssessmentTitles.Location = new Point(186, 3);
            cbxAssessmentTitles.Name = "cbxAssessmentTitles";
            cbxAssessmentTitles.Size = new Size(182, 33);
            cbxAssessmentTitles.TabIndex = 1;
            cbxAssessmentTitles.SelectedIndexChanged += cbxAssessmentTitles_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(clo_btn);
            flowLayoutPanel2.Controls.Add(cbx_clos);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 90);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(380, 364);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // clo_btn
            // 
            clo_btn.Location = new Point(3, 3);
            clo_btn.Name = "clo_btn";
            clo_btn.Size = new Size(177, 34);
            clo_btn.TabIndex = 0;
            clo_btn.Text = "CLOS Result";
            clo_btn.UseVisualStyleBackColor = true;
            clo_btn.Click += clo_btn_Click;
            // 
            // cbx_clos
            // 
            cbx_clos.FormattingEnabled = true;
            cbx_clos.Location = new Point(186, 3);
            cbx_clos.Name = "cbx_clos";
            cbx_clos.Size = new Size(182, 33);
            cbx_clos.TabIndex = 1;
            cbx_clos.SelectedIndexChanged += cbx_clos_SelectedIndexChanged;
            // 
            // Evaluation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 460);
            Controls.Add(flowLayoutPanel1);
            Name = "Evaluation";
            Text = "Evaluation";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button clo_btn;
        private ComboBox cbx_clos;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button assessment_btn;
        private ComboBox cbxAssessmentTitles;
    }
}