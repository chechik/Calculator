namespace Calculator
{
    partial class Std
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
            //Numbers(0-9):
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            //Operands
            this.del = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            //Others
            this.clear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 225);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(98, 25);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 193);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(46, 23);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(64, 193);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(46, 23);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(116, 193);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(46, 23);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 164);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(46, 23);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(64, 164);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(46, 23);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(116, 164);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(46, 23);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 135);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(46, 23);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(64, 135);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(46, 23);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(116, 135);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(46, 23);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(116, 106);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(46, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(64, 106);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "CE";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(12, 106);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(46, 23);
            this.del.TabIndex = 9;
            this.del.Text = "<---";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(116, 225);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(46, 23);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(168, 225);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 23);
            this.plus.TabIndex = 22;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(168, 106);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(46, 23);
            this.sign.TabIndex = 21;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(168, 135);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(46, 23);
            this.div.TabIndex = 20;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(168, 164);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(46, 23);
            this.mult.TabIndex = 19;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(168, 193);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 23);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(220, 106);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(46, 23);
            this.power.TabIndex = 26;
            this.power.Text = "pwd";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(220, 135);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(46, 23);
            this.percent.TabIndex = 25;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(220, 164);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(46, 23);
            this.button21.TabIndex = 24;
            this.button21.Text = "1/x";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(220, 193);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(46, 55);
            this.equal.TabIndex = 23;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(260, 88);
            this.Display.TabIndex = 27;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Std
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.power);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.del);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Name = "Std";
            this.Text = "Standarten Calculatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox Display;
    }
}

