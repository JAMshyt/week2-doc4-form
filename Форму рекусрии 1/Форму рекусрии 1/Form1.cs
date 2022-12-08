using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форму_рекусрии_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double calc(int n, double x, int res = 1)
        {
            if (res > n) return x;
            return x / (res + calc(n, x, res + 1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            double x = 0;
            do
            {
                try
                {
                    n = Convert.ToInt32(textBox1.Text);
                    if (n < 0)
                    {
                        MessageBox.Show("Вы ввели n менье 0");
                        break;
                    }
                    else
                    {
                        x = Convert.ToDouble(textBox2.Text);
                        break;
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                    break;
                }
            } while (true);

            textBox3.Text = "Результат: " + calc(n, x);
        }
    }
}
