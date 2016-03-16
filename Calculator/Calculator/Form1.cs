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

        }

        private void one_Click(object sender, EventArgs e)
        {
            input += "1";
        }

    }
}
