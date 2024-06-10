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
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 146);
            button1.Name = "button1";
            button1.Size = new Size(438, 75);
            button1.TabIndex = 1;
            button1.Text = "Рассчитать шаги";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbSideA
            // 
            tbSideA.BackColor = Color.Ivory;
            tbSideA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbSideA.ForeColor = SystemColors.MenuText;
            tbSideA.Location = new Point(6, 24);
            tbSideA.Name = "tbSideA";
            tbSideA.PlaceholderText = "Сторона A (См)";
            tbSideA.Size = new Size(330, 29);
            tbSideA.TabIndex = 2;
            // 
            // tbSideB
            // 
            tbSideB.BackColor = Color.Ivory;
            tbSideB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbSideB.Location = new Point(6, 59);
            tbSideB.Name = "tbSideB";
            tbSideB.PlaceholderText = "Сторона B (См)";
            tbSideB.Size = new Size(330, 29);
            tbSideB.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Ivory;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(tbSideA);
            groupBox1.Controls.Add(tbSideB);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 93);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Стороны прямоугольника:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(342, 26);
            button2.Name = "button2";
            button2.Size = new Size(81, 61);
            button2.TabIndex = 4;
            button2.Text = "/\\\r\n |\r\n\\/";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbRadius
            // 
            tbRadius.BackColor = Color.Ivory;
            tbRadius.BorderStyle = BorderStyle.FixedSingle;
            tbRadius.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbRadius.Location = new Point(12, 111);
            tbRadius.Name = "tbRadius";
            tbRadius.PlaceholderText = "Радиус окружности (См)";
            tbRadius.Size = new Size(438, 29);
            tbRadius.TabIndex = 5;
            // 
            // OutputTable
            // 
            OutputTable.AllowUserToAddRows = false;
            OutputTable.AllowUserToDeleteRows = false;
            OutputTable.BackgroundColor = Color.ForestGreen;
            OutputTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutputTable.Columns.AddRange(new DataGridViewColumn[] { BtnPlot, Shag, ShagSideA, ShagSideB });
            OutputTable.Location = new Point(12, 309);
            OutputTable.Name = "OutputTable";
            OutputTable.ReadOnly = true;
            OutputTable.RowTemplate.Height = 25;
            OutputTable.Size = new Size(438, 273);
            OutputTable.TabIndex = 9;
            OutputTable.CellClick += OutputTable_CellClick;
            // 
            // BtnPlot
            // 
            BtnPlot.HeaderText = "Рассчитать график";
            BtnPlot.Name = "BtnPlot";
            BtnPlot.ReadOnly = true;
            // 
            // Shag
            // 
            Shag.HeaderText = "Шаг";
            Shag.Name = "Shag";
            Shag.ReadOnly = true;
            // 
            // ShagSideA
            // 
            ShagSideA.HeaderText = "Шагов со стороны А";
            ShagSideA.Name = "ShagSideA";
            ShagSideA.ReadOnly = true;
            // 
            // ShagSideB
            // 
            ShagSideB.HeaderText = "Шагов стороны B";
            ShagSideB.Name = "ShagSideB";
            ShagSideB.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 281);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 10;
            label1.Text = "Ваши возможные шаги";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(1107, 586);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 82);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить график";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pbSideA
            // 
            pbSideA.BackColor = SystemColors.ButtonHighlight;
            pbSideA.Location = new Point(611, 40);
            pbSideA.Name = "pbSideA";
            pbSideA.Size = new Size(1203, 540);
            pbSideA.TabIndex = 12;
            pbSideA.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1107, 12);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 13;
            label2.Text = "Ваш ГРАФИК";
            // 
            // dgFoundS
            // 
            dgFoundS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFoundS.Columns.AddRange(new DataGridViewColumn[] { dgS });
            dgFoundS.Location = new Point(456, 12);
            dgFoundS.Name = "dgFoundS";
            dgFoundS.RowTemplate.Height = 25;
            dgFoundS.Size = new Size(149, 644);
            dgFoundS.TabIndex = 14;
            // 
            // dgS
            // 
            dgS.HeaderText = "Площади";
            dgS.Name = "dgS";
            // 
            // tbTochonst
            // 
            tbTochonst.BackColor = Color.Ivory;
            tbTochonst.BorderStyle = BorderStyle.FixedSingle;
            tbTochonst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbTochonst.Location = new Point(275, 242);
            tbTochonst.Multiline = true;
            tbTochonst.Name = "tbTochonst";
            tbTochonst.PlaceholderText = "Точность";
            tbTochonst.Size = new Size(175, 25);
            tbTochonst.TabIndex = 15;
            tbTochonst.Text = "10000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 242);
            label3.Name = "label3";
            label3.Size = new Size(257, 25);
            label3.TabIndex = 16;
            label3.Text = "Кол-во генерируемых точек";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Ivory;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(129, 586);
            label4.Name = "label4";
            label4.Size = new Size(236, 25);
            label4.TabIndex = 17;
            label4.Text = "Прогресс печати графика";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Fuchsia;
            progressBar1.Location = new Point(2, 624);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(448, 44);
            progressBar1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1826, 680);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Радар шагов";
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
