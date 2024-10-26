namespace Delivery
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
            richTextBox3 = new RichTextBox();
            textBox1 = new TextBox();
            sort = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(12, 12);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(816, 578);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(923, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 6;
            // 
            // sort
            // 
            sort.Location = new Point(12, 607);
            sort.Name = "sort";
            sort.Size = new Size(816, 110);
            sort.TabIndex = 7;
            sort.Text = "Sort";
            sort.UseVisualStyleBackColor = true;
            sort.Click += sort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(923, 15);
            label1.Name = "label1";
            label1.Size = new Size(301, 32);
            label1.TabIndex = 10;
            label1.Text = "Введите название района";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 989);
            Controls.Add(label1);
            Controls.Add(sort);
            Controls.Add(textBox1);
            Controls.Add(richTextBox3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox3;
        private TextBox textBox1;
        private Button sort;
        private Label label1;
    }
}