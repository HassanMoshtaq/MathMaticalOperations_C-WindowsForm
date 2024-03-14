namespace Oop_Odev1
{
    partial class Form1
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
            this.Number1_textBox = new System.Windows.Forms.TextBox();
            this.Number2_textBox = new System.Windows.Forms.TextBox();
            this.Number1_lb = new System.Windows.Forms.Label();
            this.Number2_lb = new System.Windows.Forms.Label();
            this.Addition_btn = new System.Windows.Forms.Button();
            this.Divition_btn = new System.Windows.Forms.Button();
            this.Multiplication_btn = new System.Windows.Forms.Button();
            this.Subtraction_Btn = new System.Windows.Forms.Button();
            this.Result_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number1_textBox
            // 
            this.Number1_textBox.Location = new System.Drawing.Point(164, 44);
            this.Number1_textBox.Name = "Number1_textBox";
            this.Number1_textBox.Size = new System.Drawing.Size(259, 22);
            this.Number1_textBox.TabIndex = 0;
            this.Number1_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number1_textBox_KeyPress);
            // 
            // Number2_textBox
            // 
            this.Number2_textBox.Location = new System.Drawing.Point(164, 95);
            this.Number2_textBox.Name = "Number2_textBox";
            this.Number2_textBox.Size = new System.Drawing.Size(259, 22);
            this.Number2_textBox.TabIndex = 1;
            this.Number2_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number2_textBox_KeyPress);
            // 
            // Number1_lb
            // 
            this.Number1_lb.AutoSize = true;
            this.Number1_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1_lb.Location = new System.Drawing.Point(22, 44);
            this.Number1_lb.Name = "Number1_lb";
            this.Number1_lb.Size = new System.Drawing.Size(127, 20);
            this.Number1_lb.TabIndex = 2;
            this.Number1_lb.Text = "Enter Number1:";
            // 
            // Number2_lb
            // 
            this.Number2_lb.AutoSize = true;
            this.Number2_lb.Location = new System.Drawing.Point(23, 101);
            this.Number2_lb.Name = "Number2_lb";
            this.Number2_lb.Size = new System.Drawing.Size(99, 16);
            this.Number2_lb.TabIndex = 3;
            this.Number2_lb.Text = "Enter Number2:";
            // 
            // Addition_btn
            // 
            this.Addition_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition_btn.Location = new System.Drawing.Point(20, 165);
            this.Addition_btn.Name = "Addition_btn";
            this.Addition_btn.Size = new System.Drawing.Size(102, 40);
            this.Addition_btn.TabIndex = 4;
            this.Addition_btn.Text = "Addition";
            this.Addition_btn.UseVisualStyleBackColor = true;
            this.Addition_btn.Click += new System.EventHandler(this.Addition_btn_Click);
            this.Addition_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Addition_btn_MouseMove);
            // 
            // Divition_btn
            // 
            this.Divition_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divition_btn.Location = new System.Drawing.Point(509, 169);
            this.Divition_btn.Name = "Divition_btn";
            this.Divition_btn.Size = new System.Drawing.Size(118, 40);
            this.Divition_btn.TabIndex = 8;
            this.Divition_btn.Text = "Divition";
            this.Divition_btn.UseVisualStyleBackColor = true;
            this.Divition_btn.Click += new System.EventHandler(this.Divition_btn_Click);
            this.Divition_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Divition_btn_MouseMove);
            // 
            // Multiplication_btn
            // 
            this.Multiplication_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplication_btn.Location = new System.Drawing.Point(321, 169);
            this.Multiplication_btn.Name = "Multiplication_btn";
            this.Multiplication_btn.Size = new System.Drawing.Size(135, 40);
            this.Multiplication_btn.TabIndex = 9;
            this.Multiplication_btn.Text = "Multiplication";
            this.Multiplication_btn.UseVisualStyleBackColor = true;
            this.Multiplication_btn.Click += new System.EventHandler(this.Multiplication_btn_Click);
            this.Multiplication_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Multiplication_btn_MouseMove);
            // 
            // Subtraction_Btn
            // 
            this.Subtraction_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction_Btn.Location = new System.Drawing.Point(164, 165);
            this.Subtraction_Btn.Name = "Subtraction_Btn";
            this.Subtraction_Btn.Size = new System.Drawing.Size(118, 44);
            this.Subtraction_Btn.TabIndex = 10;
            this.Subtraction_Btn.Text = "Subtraction";
            this.Subtraction_Btn.UseVisualStyleBackColor = true;
            this.Subtraction_Btn.Click += new System.EventHandler(this.Subtraction_Btn_Click);
            this.Subtraction_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Subtraction_Btn_MouseMove);
            // 
            // Result_lb
            // 
            this.Result_lb.AutoSize = true;
            this.Result_lb.Location = new System.Drawing.Point(328, 298);
            this.Result_lb.Name = "Result_lb";
            this.Result_lb.Size = new System.Drawing.Size(0, 16);
            this.Result_lb.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result_lb);
            this.Controls.Add(this.Subtraction_Btn);
            this.Controls.Add(this.Multiplication_btn);
            this.Controls.Add(this.Divition_btn);
            this.Controls.Add(this.Addition_btn);
            this.Controls.Add(this.Number2_lb);
            this.Controls.Add(this.Number1_lb);
            this.Controls.Add(this.Number2_textBox);
            this.Controls.Add(this.Number1_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number1_textBox;
        private System.Windows.Forms.TextBox Number2_textBox;
        private System.Windows.Forms.Label Number1_lb;
        private System.Windows.Forms.Label Number2_lb;
        private System.Windows.Forms.Button Addition_btn;
        private System.Windows.Forms.Button Divition_btn;
        private System.Windows.Forms.Button Multiplication_btn;
        private System.Windows.Forms.Button Subtraction_Btn;
        private System.Windows.Forms.Label Result_lb;
    }
}

