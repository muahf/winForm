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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(359, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(673, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kurai Type Light Uppercase", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(281, 20);
            label1.TabIndex = 3;
            label1.Text = "Введите длину первой стороны";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kurai Type Light Uppercase", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 78);
            label2.Name = "label2";
            label2.Size = new Size(282, 20);
            label2.TabIndex = 4;
            label2.Text = "Введите длину второй стороны";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kurai Type Light Uppercase", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(645, 78);
            label3.Name = "label3";
            label3.Size = new Size(288, 20);
            label3.TabIndex = 5;
            label3.Text = "Введите длину третьей стороны";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kurai Type Light Uppercase", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 9);
            label4.Name = "label4";
            label4.Size = new Size(471, 31);
            label4.TabIndex = 6;
            label4.Text = "Определение типа треугольника";
            // 
            // button1
            // 
            button1.Font = new Font("Kurai Type Light Uppercase", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(290, 179);
            button1.Name = "button1";
            button1.Size = new Size(363, 49);
            button1.TabIndex = 7;
            button1.Text = "Определить";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kurai Type Light Uppercase", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(389, 265);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 8;
            label5.Text = "Результат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kurai Type Light Uppercase", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 341);
            label6.Name = "label6";
            label6.Size = new Size(644, 100);
            label6.TabIndex = 9;
            label6.Text = "Указания:\r\n1. Числа должны быть целыми\r\n2. Числа должны быть больше нуля\r\n3. Длина сторон треугольника должны следовать теореме треугольника\r\n4. Никаких лишних знаков\r\n";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(957, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}
