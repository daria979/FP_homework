
namespace Roman_to_decimal_conversion
{
    partial class RomanToDecimal
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.First_Obtion = new System.Windows.Forms.Label();
            this.Input1 = new System.Windows.Forms.Label();
            this.Result1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AllowDrop = true;
            this.maskedTextBox1.BackColor = System.Drawing.Color.Brown;
            this.maskedTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Beige;
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 43);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(803, 31);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.Text = "Converting Roman Numerals to Decimal";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.UseWaitCursor = true;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // First_Obtion
            // 
            this.First_Obtion.AutoSize = true;
            this.First_Obtion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.First_Obtion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Obtion.ForeColor = System.Drawing.Color.Maroon;
            this.First_Obtion.Location = new System.Drawing.Point(217, 113);
            this.First_Obtion.Name = "First_Obtion";
            this.First_Obtion.Size = new System.Drawing.Size(362, 20);
            this.First_Obtion.TabIndex = 2;
            this.First_Obtion.Text = "You can convert only a number (1 to 3999)";
            this.First_Obtion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.First_Obtion.UseWaitCursor = true;
            // 
            // Input1
            // 
            this.Input1.AutoSize = true;
            this.Input1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input1.ForeColor = System.Drawing.Color.RosyBrown;
            this.Input1.Location = new System.Drawing.Point(50, 158);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(43, 16);
            this.Input1.TabIndex = 3;
            this.Input1.Text = "Input";
            this.Input1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Input1.UseWaitCursor = true;
            this.Input1.Click += new System.EventHandler(this.Input1_Click);
            // 
            // Result1
            // 
            this.Result1.AutoSize = true;
            this.Result1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result1.ForeColor = System.Drawing.Color.RosyBrown;
            this.Result1.Location = new System.Drawing.Point(693, 158);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(48, 16);
            this.Result1.TabIndex = 4;
            this.Result1.Text = "Result";
            this.Result1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Result1.UseWaitCursor = true;
            this.Result1.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(516, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 33);
            this.textBox2.TabIndex = 6;
            this.textBox2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(362, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculate";
            this.label1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Roman_to_decimal_conversion.Properties.Resources.small_pencil_arrow_left_icon;
            this.button1.Location = new System.Drawing.Point(340, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 65);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RomanToDecimal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.First_Obtion);
            this.Controls.Add(this.maskedTextBox1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RomanToDecimal";
            this.Text = "Converting Roman Numerals to Decimal App";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label First_Obtion;
        private System.Windows.Forms.Label Input1;
        private System.Windows.Forms.Label Result1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

