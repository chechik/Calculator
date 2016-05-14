using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Std : Form
    {
        string input;
        string operand1;
        string operand2;
        char   operation;
        double result;

        public Std()
        {
            InitializeComponent();

            this.input     = string.Empty;
            this.operand1  = string.Empty;
            this.operand2  = string.Empty;
            this.result    =0.0;
            


        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            this.Display.Text = input; 
        }

        private void zero_Click(object sender, EventArgs e) 
        {
           
            input += "0";
            this.Display_TextChanged(sender, e);
        }

        private void one_Click(object sender, EventArgs e)
        {
            input += "1";
            this.Display_TextChanged(sender, e);
        }

        private void two_Click(object sender, EventArgs e)
        {
            input += "2";
            this.Display_TextChanged(sender, e);
        }
       
        private void three_Click(object sender, EventArgs e) 
        { 
            input += "3";
            this.Display_TextChanged(sender, e);
        }
        
        private void four_Click(object sender, EventArgs e) 
        {
            input += "4";
            this.Display_TextChanged(sender, e);
        }

        private void five_Click(object sender, EventArgs e) 
        { 
            input += "5";
            this.Display_TextChanged(sender, e);
        }

        private void six_Click(object sender, EventArgs e) 
        { 
            input += "6";
            this.Display_TextChanged(sender, e);
        }

        private void seven_Click(object sender, EventArgs e) 
        { 
            input += "7";
            this.Display_TextChanged(sender, e);
        }

        private void eight_Click(object sender, EventArgs e) 
        {
            input += "8";
            this.Display_TextChanged(sender, e);
        }

        private void nine_Click(object sender, EventArgs e) 
        {
            input += "9";
            this.Display_TextChanged(sender, e);
        }

        private void del_Click(object sender, EventArgs e) 
        { 
            //TODO remove operand ( i.e. needs to keep list of inserted operands
        }

        private void plus_Click(object sender, EventArgs e)
        { 
            input += "+"; 
        }

        private void mult_Click(object sender, EventArgs e) 
        {
            input += "*"; 
        }

        private void minus_Click(object sender, EventArgs e) 
        { 
            input += "-"; 
        }

        private void clear_Click(object sender, EventArgs e) 
        {
           //TODO: initialize input variable
        }

        private void dot_Click(object sender, EventArgs e) 
        {
            input += ".";
        }

        private void sign_Click(object sender, EventArgs e)
        {
            //TODO: revert the number of last expression AND to put the sign "-" at heat ov "input" string in case of expression was positive 
        }

        private void div_Click(object sender, EventArgs e)
        {
            input += "/";
        }

        private void power_Click(object sender, EventArgs e)
        {
            input += "^";
        }

        private void percent_Click(object sender, EventArgs e)
        {
            //TODO: to think how to perform this as clear as possible...
        }
 
        private void equal_Click(object sender, EventArgs e)
        {
            input += "=";
            //TODO: It will be trigger to calculation performation
        }
        
    }
}
