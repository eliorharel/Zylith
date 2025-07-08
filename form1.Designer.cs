namespace Zylith
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            SuspendLayout();
           
            textBox1.Location = new Point(146, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
             
            textBox2.Location = new Point(40, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
          
            textBox3.Location = new Point(146, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
         
            textBox4.Location = new Point(146, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
          
            textBox5.Location = new Point(40, 179);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
          
            textBox6.Location = new Point(40, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
           
            textBoxTarget.Location = new Point(40, 45);
            textBoxTarget.Name = "textBox7";
            textBoxTarget.Size = new Size(206, 23);
            textBoxTarget.TabIndex = 6;
            textBoxTarget.TextChanged += textBox7_TextChanged;
          
            buttonCalculate.Location = new Point(105, 219);
            buttonCalculate.Name = "Calculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "button1";
            buttonCalculate.UseVisualStyleBackColor = true;
           
            listResult.FormattingEnabled = true;
            listResult.ItemHeight = 15;
            listResult.Location = new Point(273, 45);
            listResult.Name = "listBox1";
            listResult.Size = new Size(194, 199);
            listResult.TabIndex = 8;
          
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResult);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxTarget);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBoxTarget;
        private Button buttonCalculate;
        private ListBox listBoxResult;
    }
}
