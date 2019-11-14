namespace Calculator
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
            this.button_0 = new System.Windows.Forms.Button();
            this.button_Decimal = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Equals = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.result_Box = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.DarkRed;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(115, 369);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(49, 54);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.click_button);
            // 
            // button_Decimal
            // 
            this.button_Decimal.BackColor = System.Drawing.Color.DarkRed;
            this.button_Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Decimal.Location = new System.Drawing.Point(209, 369);
            this.button_Decimal.Name = "button_Decimal";
            this.button_Decimal.Size = new System.Drawing.Size(49, 54);
            this.button_Decimal.TabIndex = 0;
            this.button_Decimal.Text = ".";
            this.button_Decimal.UseVisualStyleBackColor = false;
            this.button_Decimal.Click += new System.EventHandler(this.click_button);
            // 
            // button_Plus
            // 
            this.button_Plus.BackColor = System.Drawing.Color.Transparent;
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Plus.Location = new System.Drawing.Point(398, 369);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(49, 54);
            this.button_Plus.TabIndex = 0;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = false;
            this.button_Plus.Click += new System.EventHandler(this.operator_click);
            // 
            // button_Equals
            // 
            this.button_Equals.BackColor = System.Drawing.Color.DarkRed;
            this.button_Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Equals.Location = new System.Drawing.Point(304, 369);
            this.button_Equals.Name = "button_Equals";
            this.button_Equals.Size = new System.Drawing.Size(49, 54);
            this.button_Equals.TabIndex = 0;
            this.button_Equals.Text = "=";
            this.button_Equals.UseVisualStyleBackColor = false;
            this.button_Equals.Click += new System.EventHandler(this.button_Equals_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.DarkRed;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(115, 286);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(49, 54);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.click_button);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.DarkRed;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(209, 286);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(49, 54);
            this.button_2.TabIndex = 0;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.click_button);
            // 
            // button_Minus
            // 
            this.button_Minus.BackColor = System.Drawing.Color.Transparent;
            this.button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Minus.Location = new System.Drawing.Point(398, 286);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(49, 54);
            this.button_Minus.TabIndex = 0;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = false;
            this.button_Minus.Click += new System.EventHandler(this.operator_click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.DarkRed;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(304, 286);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(49, 54);
            this.button_3.TabIndex = 0;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.click_button);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.DarkRed;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(115, 199);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(49, 54);
            this.button_4.TabIndex = 0;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.click_button);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.DarkRed;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(209, 199);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(49, 54);
            this.button_5.TabIndex = 0;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.click_button);
            // 
            // button_Multiply
            // 
            this.button_Multiply.BackColor = System.Drawing.Color.Transparent;
            this.button_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Multiply.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Multiply.Location = new System.Drawing.Point(398, 199);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(49, 54);
            this.button_Multiply.TabIndex = 0;
            this.button_Multiply.Text = "×";
            this.button_Multiply.UseVisualStyleBackColor = false;
            this.button_Multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(304, 199);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 54);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.click_button);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkRed;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(115, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 54);
            this.button9.TabIndex = 0;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.click_button);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkRed;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(209, 120);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 54);
            this.button10.TabIndex = 0;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.click_button);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button11.Location = new System.Drawing.Point(398, 120);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 54);
            this.button11.TabIndex = 0;
            this.button11.Text = "÷";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkRed;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(304, 120);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 54);
            this.button12.TabIndex = 0;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.click_button);
            // 
            // result_Box
            // 
            this.result_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_Box.Location = new System.Drawing.Point(115, 30);
            this.result_Box.Multiline = true;
            this.result_Box.Name = "result_Box";
            this.result_Box.Size = new System.Drawing.Size(332, 61);
            this.result_Box.TabIndex = 1;
            this.result_Box.Text = "0";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Red;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(134, 446);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(301, 54);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(564, 536);
            this.Controls.Add(this.result_Box);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_Equals);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Decimal);
            this.Controls.Add(this.button_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_Decimal;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Equals;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox result_Box;
        private System.Windows.Forms.Button button_Clear;
    }
}

