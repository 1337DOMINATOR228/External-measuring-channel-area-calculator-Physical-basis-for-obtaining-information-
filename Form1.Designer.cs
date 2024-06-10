namespace AbtiLog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            tbSideA = new TextBox();
            tbSideB = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            tbRadius = new TextBox();
            OutputTable = new DataGridView();
            BtnPlot = new DataGridViewButtonColumn();
            Shag = new DataGridViewTextBoxColumn();
            ShagSideA = new DataGridViewTextBoxColumn();
            ShagSideB = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnSave = new Button();
            pbSideA = new PictureBox();
            label2 = new Label();
            dgFoundS = new DataGridView();
            dgS = new DataGridViewTextBoxColumn();
            tbTochonst = new TextBox();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OutputTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSideA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgFoundS).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbSideA
            // 
            tbSideA.BackColor = Color.Ivory;
            resources.ApplyResources(tbSideA, "tbSideA");
            tbSideA.ForeColor = SystemColors.MenuText;
            tbSideA.Name = "tbSideA";
            // 
            // tbSideB
            // 
            tbSideB.BackColor = Color.Ivory;
            resources.ApplyResources(tbSideB, "tbSideB");
            tbSideB.Name = "tbSideB";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Ivory;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(tbSideA);
            groupBox1.Controls.Add(tbSideB);
            groupBox1.FlatStyle = FlatStyle.Popup;
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbRadius
            // 
            tbRadius.BackColor = Color.Ivory;
            tbRadius.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(tbRadius, "tbRadius");
            tbRadius.Name = "tbRadius";
            // 
            // OutputTable
            // 
            OutputTable.AllowUserToAddRows = false;
            OutputTable.AllowUserToDeleteRows = false;
            OutputTable.BackgroundColor = Color.ForestGreen;
            OutputTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { BtnPlot, Shag, ShagSideA, ShagSideB });
            resources.ApplyResources(OutputTable, "OutputTable");
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowTemplate.Height = 25;
            OutputTable.CellClick += OutputTable_CellClick;
            // 
            // BtnPlot
            // 
            resources.ApplyResources(BtnPlot, "BtnPlot");
            BtnPlot.Name = "BtnPlot";
            BtnPlot.ReadOnly = true;
            // 
            // Shag
            // 
            resources.ApplyResources(Shag, "Shag");
            Shag.Name = "Shag";
            Shag.ReadOnly = true;
            // 
            // ShagSideA
            // 
            resources.ApplyResources(ShagSideA, "ShagSideA");
            ShagSideA.Name = "ShagSideA";
            ShagSideA.ReadOnly = true;
            // 
            // ShagSideB
            // 
            resources.ApplyResources(ShagSideB, "ShagSideB");
            ShagSideB.Name = "ShagSideB";
            ShagSideB.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Ivory;
            label1.Name = "label1";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pbSideA
            // 
            pbSideA.BackColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(pbSideA, "pbSideA");
            pbSideA.Name = "pbSideA";
            pbSideA.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Ivory;
            label2.Name = "label2";
            // 
            // dgFoundS
            // 
            dgFoundS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFoundS.Columns.AddRange(new DataGridViewColumn[] { dgS });
            resources.ApplyResources(dgFoundS, "dgFoundS");
            dgFoundS.Name = "dgFoundS";
            dgFoundS.RowTemplate.Height = 25;
            // 
            // dgS
            // 
            resources.ApplyResources(dgS, "dgS");
            dgS.Name = "dgS";
            // 
            // tbTochonst
            // 
            tbTochonst.BackColor = Color.Ivory;
            tbTochonst.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(tbTochonst, "tbTochonst");
            tbTochonst.Name = "tbTochonst";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Ivory;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Ivory;
            label4.Name = "label4";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Fuchsia;
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbTochonst);
            Controls.Add(dgFoundS);
            Controls.Add(label2);
            Controls.Add(pbSideA);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(OutputTable);
            Controls.Add(tbRadius);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OutputTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSideA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgFoundS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox tbSideA;
        private TextBox tbSideB;
        private GroupBox groupBox1;
        private TextBox tbRadius;
        private DataGridView OutputTable;
        private Label label1;
        private DataGridViewButtonColumn BtnPlot;
        private DataGridViewTextBoxColumn Shag;
        private DataGridViewTextBoxColumn ShagSideA;
        private DataGridViewTextBoxColumn ShagSideB;
        private Button btnSave;
        private PictureBox pbSideA;
        private Label label2;
        private Button button2;
        private DataGridView dgFoundS;
        private DataGridViewTextBoxColumn dgS;
        private TextBox tbTochonst;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
    }
}
