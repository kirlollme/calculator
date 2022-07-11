namespace calc
{
    partial class Calc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.euro_btn = new System.Windows.Forms.Button();
            this.dollar_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.num_square_btn = new System.Windows.Forms.Button();
            this.num_division_btn = new System.Windows.Forms.Button();
            this.num_multiply_btn = new System.Windows.Forms.Button();
            this.num_del_btn = new System.Windows.Forms.Button();
            this.num_sq_root_btn = new System.Windows.Forms.Button();
            this.num_dot_btn = new System.Windows.Forms.Button();
            this.num_0_btn = new System.Windows.Forms.Button();
            this.num_negative_btn = new System.Windows.Forms.Button();
            this.num_minus_btn = new System.Windows.Forms.Button();
            this.num_9_btn = new System.Windows.Forms.Button();
            this.num_8_btn = new System.Windows.Forms.Button();
            this.num_7_btn = new System.Windows.Forms.Button();
            this.num_plus_btn = new System.Windows.Forms.Button();
            this.num_6_btn = new System.Windows.Forms.Button();
            this.num_5_btn = new System.Windows.Forms.Button();
            this.num_4_btn = new System.Windows.Forms.Button();
            this.num_equal_btn = new System.Windows.Forms.Button();
            this.num_3_btn = new System.Windows.Forms.Button();
            this.num_2_btn = new System.Windows.Forms.Button();
            this.num_1_btn = new System.Windows.Forms.Button();
            this.input_box = new System.Windows.Forms.MaskedTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.euro_btn);
            this.panel1.Controls.Add(this.dollar_btn);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.num_square_btn);
            this.panel1.Controls.Add(this.num_division_btn);
            this.panel1.Controls.Add(this.num_multiply_btn);
            this.panel1.Controls.Add(this.num_del_btn);
            this.panel1.Controls.Add(this.num_sq_root_btn);
            this.panel1.Controls.Add(this.num_dot_btn);
            this.panel1.Controls.Add(this.num_0_btn);
            this.panel1.Controls.Add(this.num_negative_btn);
            this.panel1.Controls.Add(this.num_minus_btn);
            this.panel1.Controls.Add(this.num_9_btn);
            this.panel1.Controls.Add(this.num_8_btn);
            this.panel1.Controls.Add(this.num_7_btn);
            this.panel1.Controls.Add(this.num_plus_btn);
            this.panel1.Controls.Add(this.num_6_btn);
            this.panel1.Controls.Add(this.num_5_btn);
            this.panel1.Controls.Add(this.num_4_btn);
            this.panel1.Controls.Add(this.num_equal_btn);
            this.panel1.Controls.Add(this.num_3_btn);
            this.panel1.Controls.Add(this.num_2_btn);
            this.panel1.Controls.Add(this.num_1_btn);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 231);
            this.panel1.TabIndex = 0;
            // 
            // euro_btn
            // 
            this.euro_btn.Location = new System.Drawing.Point(99, 0);
            this.euro_btn.Name = "euro_btn";
            this.euro_btn.Size = new System.Drawing.Size(65, 23);
            this.euro_btn.TabIndex = 22;
            this.euro_btn.Text = "€";
            this.euro_btn.UseVisualStyleBackColor = true;
            this.euro_btn.Click += new System.EventHandler(this.euro_btn_Click);
            // 
            // dollar_btn
            // 
            this.dollar_btn.Location = new System.Drawing.Point(28, 0);
            this.dollar_btn.Name = "dollar_btn";
            this.dollar_btn.Size = new System.Drawing.Size(65, 23);
            this.dollar_btn.TabIndex = 21;
            this.dollar_btn.Text = "$";
            this.dollar_btn.UseVisualStyleBackColor = true;
            this.dollar_btn.Click += new System.EventHandler(this.dollar_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(312, 4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(65, 23);
            this.clear_btn.TabIndex = 20;
            this.clear_btn.Text = "C";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // num_square_btn
            // 
            this.num_square_btn.Location = new System.Drawing.Point(312, 77);
            this.num_square_btn.Name = "num_square_btn";
            this.num_square_btn.Size = new System.Drawing.Size(65, 41);
            this.num_square_btn.TabIndex = 19;
            this.num_square_btn.Text = "x^2";
            this.num_square_btn.UseVisualStyleBackColor = true;
            this.num_square_btn.Click += new System.EventHandler(this.num_square_btn_Click);
            // 
            // num_division_btn
            // 
            this.num_division_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_division_btn.Location = new System.Drawing.Point(241, 170);
            this.num_division_btn.Name = "num_division_btn";
            this.num_division_btn.Size = new System.Drawing.Size(65, 41);
            this.num_division_btn.TabIndex = 18;
            this.num_division_btn.Text = "÷";
            this.num_division_btn.UseVisualStyleBackColor = true;
            this.num_division_btn.Click += new System.EventHandler(this.num_division_btn_Click);
            // 
            // num_multiply_btn
            // 
            this.num_multiply_btn.Location = new System.Drawing.Point(241, 123);
            this.num_multiply_btn.Name = "num_multiply_btn";
            this.num_multiply_btn.Size = new System.Drawing.Size(65, 41);
            this.num_multiply_btn.TabIndex = 17;
            this.num_multiply_btn.Text = "X";
            this.num_multiply_btn.UseVisualStyleBackColor = true;
            this.num_multiply_btn.Click += new System.EventHandler(this.num_multiply_btn_Click);
            // 
            // num_del_btn
            // 
            this.num_del_btn.Location = new System.Drawing.Point(312, 31);
            this.num_del_btn.Name = "num_del_btn";
            this.num_del_btn.Size = new System.Drawing.Size(65, 41);
            this.num_del_btn.TabIndex = 16;
            this.num_del_btn.Text = "\t←";
            this.num_del_btn.UseVisualStyleBackColor = true;
            this.num_del_btn.Click += new System.EventHandler(this.num_del_btn_Click);
            // 
            // num_sq_root_btn
            // 
            this.num_sq_root_btn.Location = new System.Drawing.Point(312, 125);
            this.num_sq_root_btn.Name = "num_sq_root_btn";
            this.num_sq_root_btn.Size = new System.Drawing.Size(65, 41);
            this.num_sq_root_btn.TabIndex = 15;
            this.num_sq_root_btn.Text = "√x";
            this.num_sq_root_btn.UseVisualStyleBackColor = true;
            this.num_sq_root_btn.Click += new System.EventHandler(this.num_sq_root_btn_Click);
            // 
            // num_dot_btn
            // 
            this.num_dot_btn.Location = new System.Drawing.Point(170, 171);
            this.num_dot_btn.Name = "num_dot_btn";
            this.num_dot_btn.Size = new System.Drawing.Size(65, 41);
            this.num_dot_btn.TabIndex = 14;
            this.num_dot_btn.Text = ".";
            this.num_dot_btn.UseVisualStyleBackColor = true;
            this.num_dot_btn.Click += new System.EventHandler(this.num_dot_btn_Click);
            // 
            // num_0_btn
            // 
            this.num_0_btn.Location = new System.Drawing.Point(99, 171);
            this.num_0_btn.Name = "num_0_btn";
            this.num_0_btn.Size = new System.Drawing.Size(65, 41);
            this.num_0_btn.TabIndex = 13;
            this.num_0_btn.Text = "0";
            this.num_0_btn.UseVisualStyleBackColor = true;
            this.num_0_btn.Click += new System.EventHandler(this.num_0_Click);
            // 
            // num_negative_btn
            // 
            this.num_negative_btn.Location = new System.Drawing.Point(28, 171);
            this.num_negative_btn.Name = "num_negative_btn";
            this.num_negative_btn.Size = new System.Drawing.Size(65, 41);
            this.num_negative_btn.TabIndex = 12;
            this.num_negative_btn.Text = "+/-";
            this.num_negative_btn.UseVisualStyleBackColor = true;
            this.num_negative_btn.Click += new System.EventHandler(this.num_negative_btn_Click);
            // 
            // num_minus_btn
            // 
            this.num_minus_btn.Location = new System.Drawing.Point(241, 77);
            this.num_minus_btn.Name = "num_minus_btn";
            this.num_minus_btn.Size = new System.Drawing.Size(65, 41);
            this.num_minus_btn.TabIndex = 11;
            this.num_minus_btn.Text = "-";
            this.num_minus_btn.UseVisualStyleBackColor = true;
            this.num_minus_btn.Click += new System.EventHandler(this.num_minus_btn_Click);
            // 
            // num_9_btn
            // 
            this.num_9_btn.Location = new System.Drawing.Point(170, 125);
            this.num_9_btn.Name = "num_9_btn";
            this.num_9_btn.Size = new System.Drawing.Size(65, 41);
            this.num_9_btn.TabIndex = 10;
            this.num_9_btn.Text = "9";
            this.num_9_btn.UseVisualStyleBackColor = true;
            this.num_9_btn.Click += new System.EventHandler(this.num_9_Click);
            // 
            // num_8_btn
            // 
            this.num_8_btn.Location = new System.Drawing.Point(99, 124);
            this.num_8_btn.Name = "num_8_btn";
            this.num_8_btn.Size = new System.Drawing.Size(65, 41);
            this.num_8_btn.TabIndex = 9;
            this.num_8_btn.Text = "8";
            this.num_8_btn.UseVisualStyleBackColor = true;
            this.num_8_btn.Click += new System.EventHandler(this.num_8_Click);
            // 
            // num_7_btn
            // 
            this.num_7_btn.Location = new System.Drawing.Point(28, 124);
            this.num_7_btn.Name = "num_7_btn";
            this.num_7_btn.Size = new System.Drawing.Size(65, 41);
            this.num_7_btn.TabIndex = 8;
            this.num_7_btn.Text = "7";
            this.num_7_btn.UseVisualStyleBackColor = true;
            this.num_7_btn.Click += new System.EventHandler(this.num_7_Click);
            // 
            // num_plus_btn
            // 
            this.num_plus_btn.Location = new System.Drawing.Point(241, 31);
            this.num_plus_btn.Name = "num_plus_btn";
            this.num_plus_btn.Size = new System.Drawing.Size(65, 41);
            this.num_plus_btn.TabIndex = 7;
            this.num_plus_btn.Text = "+";
            this.num_plus_btn.UseVisualStyleBackColor = true;
            this.num_plus_btn.Click += new System.EventHandler(this.num_plus_btn_Click);
            // 
            // num_6_btn
            // 
            this.num_6_btn.Location = new System.Drawing.Point(170, 78);
            this.num_6_btn.Name = "num_6_btn";
            this.num_6_btn.Size = new System.Drawing.Size(65, 41);
            this.num_6_btn.TabIndex = 6;
            this.num_6_btn.Text = "6";
            this.num_6_btn.UseVisualStyleBackColor = true;
            this.num_6_btn.Click += new System.EventHandler(this.num_6_Click);
            // 
            // num_5_btn
            // 
            this.num_5_btn.Location = new System.Drawing.Point(99, 77);
            this.num_5_btn.Name = "num_5_btn";
            this.num_5_btn.Size = new System.Drawing.Size(65, 41);
            this.num_5_btn.TabIndex = 5;
            this.num_5_btn.Text = "5";
            this.num_5_btn.UseVisualStyleBackColor = true;
            this.num_5_btn.Click += new System.EventHandler(this.num_5_Click);
            // 
            // num_4_btn
            // 
            this.num_4_btn.Location = new System.Drawing.Point(28, 77);
            this.num_4_btn.Name = "num_4_btn";
            this.num_4_btn.Size = new System.Drawing.Size(65, 41);
            this.num_4_btn.TabIndex = 4;
            this.num_4_btn.Text = "4";
            this.num_4_btn.UseVisualStyleBackColor = true;
            this.num_4_btn.Click += new System.EventHandler(this.num_4_Click);
            // 
            // num_equal_btn
            // 
            this.num_equal_btn.Location = new System.Drawing.Point(312, 172);
            this.num_equal_btn.Name = "num_equal_btn";
            this.num_equal_btn.Size = new System.Drawing.Size(65, 41);
            this.num_equal_btn.TabIndex = 3;
            this.num_equal_btn.Text = "=";
            this.num_equal_btn.UseVisualStyleBackColor = true;
            this.num_equal_btn.Click += new System.EventHandler(this.num_equal_btn_Click);
            // 
            // num_3_btn
            // 
            this.num_3_btn.Location = new System.Drawing.Point(170, 31);
            this.num_3_btn.Name = "num_3_btn";
            this.num_3_btn.Size = new System.Drawing.Size(65, 40);
            this.num_3_btn.TabIndex = 2;
            this.num_3_btn.Text = "3";
            this.num_3_btn.UseVisualStyleBackColor = true;
            this.num_3_btn.Click += new System.EventHandler(this.num_3_Click);
            // 
            // num_2_btn
            // 
            this.num_2_btn.Location = new System.Drawing.Point(99, 31);
            this.num_2_btn.Name = "num_2_btn";
            this.num_2_btn.Size = new System.Drawing.Size(65, 41);
            this.num_2_btn.TabIndex = 1;
            this.num_2_btn.Text = "2";
            this.num_2_btn.UseVisualStyleBackColor = true;
            this.num_2_btn.Click += new System.EventHandler(this.num_2_Click);
            // 
            // num_1_btn
            // 
            this.num_1_btn.Location = new System.Drawing.Point(28, 30);
            this.num_1_btn.Name = "num_1_btn";
            this.num_1_btn.Size = new System.Drawing.Size(65, 41);
            this.num_1_btn.TabIndex = 0;
            this.num_1_btn.Text = "1";
            this.num_1_btn.UseVisualStyleBackColor = true;
            this.num_1_btn.Click += new System.EventHandler(this.num_1_Click);
            // 
            // input_box
            // 
            this.input_box.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.input_box.Location = new System.Drawing.Point(34, 12);
            this.input_box.Name = "input_box";
            this.input_box.ReadOnly = true;
            this.input_box.Size = new System.Drawing.Size(349, 20);
            this.input_box.TabIndex = 1;
            this.input_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input_box.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 366);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.panel1);
            this.Name = "Calc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button num_3_btn;
        private System.Windows.Forms.Button num_2_btn;
        private System.Windows.Forms.Button num_1_btn;
        private System.Windows.Forms.Button num_sq_root_btn;
        private System.Windows.Forms.Button num_dot_btn;
        private System.Windows.Forms.Button num_0_btn;
        private System.Windows.Forms.Button num_negative_btn;
        private System.Windows.Forms.Button num_minus_btn;
        private System.Windows.Forms.Button num_9_btn;
        private System.Windows.Forms.Button num_8_btn;
        private System.Windows.Forms.Button num_7_btn;
        private System.Windows.Forms.Button num_plus_btn;
        private System.Windows.Forms.Button num_6_btn;
        private System.Windows.Forms.Button num_5_btn;
        private System.Windows.Forms.Button num_4_btn;
        private System.Windows.Forms.Button num_equal_btn;
        private System.Windows.Forms.MaskedTextBox input_box;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button num_square_btn;
        private System.Windows.Forms.Button num_division_btn;
        private System.Windows.Forms.Button num_multiply_btn;
        private System.Windows.Forms.Button num_del_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button euro_btn;
        private System.Windows.Forms.Button dollar_btn;
    }
}

