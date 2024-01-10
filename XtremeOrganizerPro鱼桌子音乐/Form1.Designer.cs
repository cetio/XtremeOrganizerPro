namespace XtremeOrganizerPro鱼桌子音乐
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            bzzzttWRONG = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Extension";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 371);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 32);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(588, 371);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Folder source";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.Location = new Point(12, 414);
            button3.Name = "button3";
            button3.Size = new Size(68, 29);
            button3.TabIndex = 7;
            button3.Text = "❎";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(86, 416);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "1m";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(145, 416);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 24);
            radioButton2.TabIndex = 13;
            radioButton2.Text = "10m";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(210, 416);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(59, 24);
            radioButton3.TabIndex = 14;
            radioButton3.Text = "30m";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(275, 416);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(59, 24);
            radioButton4.TabIndex = 15;
            radioButton4.Text = "60m";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(796, 32);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(588, 371);
            textBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(796, 9);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 17;
            label4.Text = "Folder destination";
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(741, 414);
            button1.Name = "button1";
            button1.Size = new Size(184, 29);
            button1.TabIndex = 18;
            button1.Text = "Save Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(980, 416);
            button2.Name = "button2";
            button2.Size = new Size(184, 29);
            button2.TabIndex = 19;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bzzzttWRONG
            // 
            bzzzttWRONG.Enabled = true;
            bzzzttWRONG.Tick += bzzzttWRONG_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 455);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "XtremeOrganizerPro鱼骨架";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer bzzzttWRONG;
    }
}
