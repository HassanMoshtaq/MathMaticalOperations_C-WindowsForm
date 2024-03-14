using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oop_Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Number1_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check Only digit OF enter Key press Of text Box

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Only allow Digit");


            }
        }


        private void Number2_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check Only digit OF enter Key press Of text Box

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-'  )
            {
                e.Handled = true;
                MessageBox.Show("Only allow Digit");


            }

        }

        private void Addition_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the numbers from textboxes
                int number1 = int.Parse(Number1_textBox.Text);
                int number2 = int.Parse(Number2_textBox.Text);

                // Perform addition
                int result = number1 + number2;

                if (result > 0)
                {
                    Result_lb.BackColor = Color.Green;
                }
                else
                    Result_lb.BackColor = Color.Red;

                // Display result in label
                Result_lb.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Subtraction_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the numbers from textboxes
                int number1 = int.Parse(Number1_textBox.Text);
                int number2 = int.Parse(Number2_textBox.Text);

                // Perform Subtraction
                int result = number1 - number2;

                if (result > 0)
                {
                    Result_lb.BackColor = Color.Green;
                }
                else
                    Result_lb.BackColor = Color.Red;

                // Display result in label
                Result_lb.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Multiplication_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the numbers from textboxes
                int number1 = int.Parse(Number1_textBox.Text);
                int number2 = int.Parse(Number2_textBox.Text);

                // Perform Multiplication
                int result = number1 * number2;

                if (result > 0)
                {
                    Result_lb.BackColor = Color.Green;
                }
                else
                    Result_lb.BackColor = Color.Red;

                // Display result in label
                Result_lb.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Divition_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the numbers from textboxes
                double number1 = double.Parse(Number1_textBox.Text);
                double number2 = double.Parse(Number2_textBox.Text);

                // Check if either number is zero
                if (number2 == 0)
                {
                    MessageBox.Show("Please enter numbers other than 0 in textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Perform division
                double result = number1 / number2;

                if (result > 0)
                {
                    Result_lb.BackColor = Color.Green;
                }
                else
                    Result_lb.BackColor = Color.Red;

                // Display result in label
                Result_lb.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in both textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero. Please enter a non-zero number in the second textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Addition_btn_MouseMove(object sender, MouseEventArgs e)
        {
            Addition_btn.ForeColor = Color.Red;
        }

        private void Subtraction_Btn_MouseMove(object sender, MouseEventArgs e)
        {
           Subtraction_Btn.ForeColor = Color.Red;
        }

        private void Multiplication_btn_MouseMove(object sender, MouseEventArgs e)
        {
            Multiplication_btn.ForeColor = Color.Red;   

        }

        private void Divition_btn_MouseMove(object sender, MouseEventArgs e)
        {
            Divition_btn.ForeColor = Color.Red;

        }
    }
}
