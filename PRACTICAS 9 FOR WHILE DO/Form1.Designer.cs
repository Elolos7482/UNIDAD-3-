﻿namespace PRACTICAS_9_FOR_WHILE_DO
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
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 39);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 0;
            label1.Text = "Factorial de un numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 31);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(328, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(129, 179);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(521, 79);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 311);
            label2.Name = "label2";
            label2.Size = new Size(173, 25);
            label2.TabIndex = 4;
            label2.Text = "Factorial del numero";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(92, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(448, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(340, 31);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 311);
            label3.Name = "label3";
            label3.Size = new Size(29, 25);
            label3.TabIndex = 7;
            label3.Text = "es";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
    }
}
