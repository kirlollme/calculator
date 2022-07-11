using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            currencies = new Currencies(); ;
        }
        char last_operation = '0';
        string last_operand = "";
        Currencies currencies;
        public char[] operations = { '-', '+', 'X', '÷'  };
        private string Calculate(string line , char oper = 'N' ) 
        {
            bool flag_one_operand_operation = (oper == '√' || oper == '^') ? true : false;
            if (!flag_one_operand_operation)
            {
                (string[], char) expression = Split_Input(line, oper);
                dynamic operand_1 = Is_Int(expression.Item1[0]) ? Convert.ToInt64(expression.Item1[0]) : Convert.ToDouble(expression.Item1[0]);
                dynamic operand_2 = Is_Int(expression.Item1[1]) ? Convert.ToInt64(expression.Item1[1]) : Convert.ToDouble(expression.Item1[1]);

                string ans = Do_Operation(operand_1, operand_2, expression.Item2).ToString();
                return ans;
            }
            else 
            {
                dynamic operand_1 = Is_Int(line) ? Convert.ToInt64(line) : Convert.ToDouble(line);
                string ans = Do_Operation(operand_1, operand_1, oper).ToString();
               
                return ans;
            }
        }
        private dynamic Do_Operation(dynamic operand_1 , dynamic operand_2 , char operation ) 
        {
            switch (operation) 
            {
                case '-':
                    return operand_1 - operand_2;
                
                case '+':
                    return operand_1 + operand_2;


                case 'X':
                    return operand_1 * operand_2;
                
                case '÷':
                    if (operand_2 == 0) return Double.NaN;
                    return Math.Round(operand_1 / operand_2,10);

                case '√':
                    return Math.Round(Math.Sqrt(operand_1), 10);

                case '^':
                    return Math.Round(Math.Pow(operand_1,2),10);
                default:  return Double.NaN;
            }


        }
        private (string[] , char ) Split_Input(string line, char oper = 'N')
        {
            string[] ans = { line };
            char[] operations = { '-', '+', 'X', '÷' };
            foreach (char i in operations) 
            {
                if (line.IndexOf(i) != -1 && line.IndexOf(i) != 0) 
                {
                    return (line.Split(i), i);
                }
            }
            if (oper == 'N')
            {
                return (ans, oper);
            }
            return (ans, '0');
        }
        private bool Is_Int(string number) 
        {
            if (number.IndexOf(',') == -1) { return true; }
            else { return false; }
        
        }
        private int Find_Operator(string line) 
        {
            foreach (char i in operations)
            {
                if (line.IndexOf(i) != -1) 
                {
                    return line.IndexOf(i);
                }
            }
            return -1;
        }

        private bool Correct_Input_Operation(string line, char oper) 
        {
            if (input_box.Text.Length == 0)
            {
                return false;
            }
            bool flag_one_operand_operation = (oper == '√' || oper == '^') ? true:false ;
            if (Find_Operator(input_box.Text) == -1)
            {
                if (!flag_one_operand_operation) 
                {
                    this.input_box.Text = this.input_box.Text + oper;
                    return false;
                }
                else 
                {
                    return true;
                }
                
            }
            else if (this.input_box.Text.Length - 1 == Find_Operator(input_box.Text) && !flag_one_operand_operation)
            {
                this.input_box.Text = this.input_box.Text.Substring(0, this.input_box.Text.Length - 1) + oper;
                return false;
            }
            return true;
        }


        private bool Check_Input()
        {
            if (this.input_box.Text == "не число") { return false; }
            return true;

        }
        private void Enable_Operations() 
        {
            this.num_plus_btn.Enabled = true;
            this.num_minus_btn.Enabled = true;
            this.num_multiply_btn.Enabled = true;
            this.num_division_btn.Enabled = true;
            this.num_equal_btn.Enabled = true;
            this.num_sq_root_btn.Enabled = true;
            this.num_square_btn.Enabled = true;
            this.num_negative_btn.Enabled = true; 
            this.num_dot_btn.Enabled = true;

        }
        private void Disable_Operations() 
        {
            this.num_plus_btn.Enabled = false;
            this.num_minus_btn.Enabled = false;
            this.num_multiply_btn.Enabled = false;
            this.num_division_btn.Enabled = false;
            this.num_equal_btn.Enabled = false;
            this.num_sq_root_btn.Enabled = false;
            this.num_square_btn.Enabled = false;
            this.num_negative_btn.Enabled = false;
            this.num_dot_btn.Enabled = false;
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void num_1_Click(object sender, EventArgs e)
        {
            if (Check_Input()) 
            {
                this.input_box.Text = this.input_box.Text + "1";
            }
            else 
            {
                this.input_box.Text = "1";
                Enable_Operations();
            }
            
        }

        private void num_2_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "2";
            }
            else
            {
                this.input_box.Text = "2";
                Enable_Operations();
            }
        }
        private void num_3_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "3";
            }
            else
            {
                this.input_box.Text = "3";
                Enable_Operations();
            }
        }
        private void num_4_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "4";
            }
            else
            {
                this.input_box.Text = "4";
                Enable_Operations();
            }
        }
        private void num_5_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "5";
            }
            else
            {
                this.input_box.Text = "5";
                Enable_Operations();
            }
        }
        private void num_6_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "6";
            }
            else
            {
                this.input_box.Text = "6";
                Enable_Operations();
            }
        }
        private void num_7_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "7";
            }
            else
            {
                this.input_box.Text = "7";
                Enable_Operations();
            }
        }
        private void num_8_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "8";
            }
            else
            {
                this.input_box.Text = "8";
                Enable_Operations();
            }
        }
        private void num_9_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "9";
            }
            else
            {
                this.input_box.Text = "9";
                Enable_Operations();
            }
        }
        private void num_0_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                this.input_box.Text = this.input_box.Text + "0";
            }
            else
            {
                this.input_box.Text = "0";
                Enable_Operations();
            }
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }
        private void num_negative_btn_Click(object sender, EventArgs e)
        {
            if (input_box.Text.Length == 0)
            {
                return;
            }
            if (this.input_box.Text[0] == '-') 
            {
                int len = this.input_box.Text.Length;
                this.input_box.Text = this.input_box.Text.Substring(1, len-1);
            }
            else this.input_box.Text = "-"+this.input_box.Text;
        }

        private void num_del_btn_Click(object sender, EventArgs e)
        {
            if (!Check_Input()) 
            {
                this.input_box.Text = "";
                Enable_Operations();
            }
                if (this.input_box.Text.Length > 0) 
            {
                this.input_box.Text = this.input_box.Text.Substring(0, this.input_box.Text.Length - 1);
                if (this.input_box.Text.Length == 1 && this.input_box.Text[0] == '-') 
                {
                    this.input_box.Text = "";
                }
            }
        }

        private void num_dot_btn_Click(object sender, EventArgs e)
        {
            this.input_box.Text = this.input_box.Text + ",";
        }

        private void num_division_btn_Click(object sender, EventArgs e)
        {
            if (Correct_Input_Operation(this.input_box.Text, operations[3])) 
            {
                this.input_box.Text = Calculate(this.input_box.Text);
                if (!Check_Input())
                {
                    Disable_Operations();
                }
            };
        }

        private void num_multiply_btn_Click(object sender, EventArgs e)
        {
            if (Correct_Input_Operation(this.input_box.Text, operations[2]))
            {
                this.input_box.Text = Calculate(this.input_box.Text);

            };
        }
        private void num_equal_btn_Click(object sender, EventArgs e)
        {
            if (Find_Operator (this.input_box.Text) == -1) 
            {
                return;
            }
            else if (Find_Operator(this.input_box.Text) == this.input_box.Text.Length - 1) 
            { 
                if (this.input_box.Text[Find_Operator(this.input_box.Text)] == '+' || this.input_box.Text[Find_Operator(this.input_box.Text)] == '-') 
                {
                    this.input_box.Text += this.input_box.Text;
                }
                else 
                {
                    this.input_box.Text += this.input_box.Text;
                }
            }
            this.input_box.Text = Calculate(this.input_box.Text);
            if (!Check_Input())
            {
                Disable_Operations();
            }
        }

        private void num_plus_btn_Click(object sender, EventArgs e)
        {
            if (Correct_Input_Operation(this.input_box.Text, operations[1]))
            {
                this.input_box.Text = Calculate(this.input_box.Text);
            };
        }

        private void num_minus_btn_Click(object sender, EventArgs e)
        {
            if (Correct_Input_Operation(this.input_box.Text, operations[0]))
            {
                this.input_box.Text = Calculate(this.input_box.Text);
            };
        }

        private void num_square_btn_Click(object sender, EventArgs e)
        {
            if (Correct_Input_Operation(this.input_box.Text, '^'))
            {
                this.input_box.Text = Calculate(this.input_box.Text, '^');
            };
        }

        private void num_sq_root_btn_Click(object sender, EventArgs e)
        {
            if (Correct_Input_Operation(this.input_box.Text, '√'))
            {
                this.input_box.Text = Calculate(this.input_box.Text, '√');
                if (!Check_Input())
                {
                    Disable_Operations();
                }
            };
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (!Check_Input())
            {
                Enable_Operations();
            }
            this.input_box.Text = "";

        }


        private void dollar_btn_Click(object sender, EventArgs e)
        {
            if (!Check_Input())
            {
                Enable_Operations();
            }
            if (Find_Operator(this.input_box.Text) == -1)
            {
                this.input_box.Text = currencies.Get_Dollar().ToString();
            }
            else if (Find_Operator(this.input_box.Text) == this.input_box.Text.Length - 1) 
            {
                this.input_box.Text += currencies.Get_Dollar().ToString();
            }
        }

        private void euro_btn_Click(object sender, EventArgs e)
        {
            if (!Check_Input()) 
            {
                Enable_Operations();
            }
            if (Find_Operator(this.input_box.Text) == -1)
            {
                this.input_box.Text = currencies.Get_Euro().ToString();
            }
            else if (Find_Operator(this.input_box.Text) == this.input_box.Text.Length - 1)
            {
                this.input_box.Text += currencies.Get_Euro().ToString(); 
            }
        }
    }
}
