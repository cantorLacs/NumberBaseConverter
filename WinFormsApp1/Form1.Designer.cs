namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            txtNumber = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            txtSource = new TextBox();
            txtTarget = new TextBox();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            groupBox2 = new GroupBox();
            txtResult = new Label();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(233, 229);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 1;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNumber
            // 
            txtNumber.Anchor = AnchorStyles.None;
            txtNumber.BackColor = Color.White;
            txtNumber.BorderStyle = BorderStyle.None;
            txtNumber.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber.ForeColor = Color.Black;
            txtNumber.Location = new Point(217, 80);
            txtNumber.Margin = new Padding(3, 4, 3, 4);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(122, 25);
            txtNumber.TabIndex = 3;
            txtNumber.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // txtSource
            // 
            txtSource.Anchor = AnchorStyles.None;
            txtSource.BackColor = Color.White;
            txtSource.BorderStyle = BorderStyle.None;
            txtSource.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSource.ForeColor = Color.Black;
            txtSource.Location = new Point(217, 130);
            txtSource.Margin = new Padding(3, 4, 3, 4);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(122, 25);
            txtSource.TabIndex = 10;
            txtSource.TextChanged += textBox2_TextChanged;
            // 
            // txtTarget
            // 
            txtTarget.Anchor = AnchorStyles.None;
            txtTarget.BackColor = Color.White;
            txtTarget.BorderStyle = BorderStyle.None;
            txtTarget.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTarget.ForeColor = Color.Black;
            txtTarget.Location = new Point(217, 180);
            txtTarget.Margin = new Padding(3, 4, 3, 4);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(122, 25);
            txtTarget.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(22, 80);
            button2.Name = "button2";
            button2.Size = new Size(155, 29);
            button2.TabIndex = 13;
            button2.Text = "Number to convert:";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button3.ForeColor = Color.White;
            button3.Location = new Point(22, 130);
            button3.Name = "button3";
            button3.Size = new Size(155, 29);
            button3.TabIndex = 14;
            button3.Text = "Number base:";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button4.ForeColor = Color.White;
            button4.Location = new Point(22, 180);
            button4.Name = "button4";
            button4.Size = new Size(155, 29);
            button4.TabIndex = 15;
            button4.Text = "Target base:";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button5);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 378);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = " Project 1: Number Base Converter ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 360);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 20;
            label1.Text = "Luis Cantor    -    Joaquín Cervantes";
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button7.ForeColor = Color.White;
            button7.Location = new Point(193, 66);
            button7.Name = "button7";
            button7.Size = new Size(141, 29);
            button7.TabIndex = 19;
            button7.Text = "Target base:";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button6.ForeColor = Color.White;
            button6.Location = new Point(193, 116);
            button6.Name = "button6";
            button6.Size = new Size(141, 29);
            button6.TabIndex = 18;
            button6.Text = "Target base:";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtResult);
            groupBox2.Location = new Point(6, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 110);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "                             ";
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Location = new Point(15, 23);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(0, 20);
            txtResult.TabIndex = 0;
            txtResult.Click += label1_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button5.ForeColor = Color.White;
            button5.Location = new Point(193, 167);
            button5.Name = "button5";
            button5.Size = new Size(141, 29);
            button5.TabIndex = 17;
            button5.Text = "Target base:";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(369, 402);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtTarget);
            Controls.Add(txtSource);
            Controls.Add(txtNumber);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Project 1: Number Base Converter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private TextBox txtNumber;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox txtSource;
        private TextBox txtTarget;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label txtResult;
        private Button button5;
        private Button button7;
        private Button button6;
        private Label label1;
    }
}