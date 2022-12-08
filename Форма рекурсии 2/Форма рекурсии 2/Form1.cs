using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_рекурсии_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void Conv(string check, ref int num)
        {
            if (check != "")
            {
                if (check[0] == '1' | check[0] == '0')
                {
                    num = num * 2 + (check[0] == '1' ? 1 : 0);
                    check = check.Substring(1);
                    Conv(check, ref num);
                }
                else
                {
                    MessageBox.Show("Вы ввели не двоичное");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0, c;
            string check = "";
            do
            {
                try
                {
                    c = Convert.ToInt32(textBox1.Text);
                    check = Convert.ToString(c);
                    break;
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                    break;
                }
            } while (true);
            Conv(check, ref num);
            textBox2.Text = "Результат: " + num;
        }
    }
}
