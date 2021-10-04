using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var n = int.Parse(this.textBox1.Text);
            int ruble, penny, a, b;
            if (1 <= n && n <= 9999)
            {
                ruble = n / 100;
                penny = n % 100;
                //проверка на однозначные числа рубли
                if (ruble < 10)
                {
                    a = ruble;
                }
                else
                {
                    a = ruble % 10;
                }
                //проверка на однозначные числа копейки
                if (penny < 10)
                {
                    b = penny;
                }
                else
                {
                    b = penny % 10;
                }
                //вывод: рублей
                if (10 <= ruble && ruble <= 20)
                {
                    //вывод: копеек
                    if (10 <= penny && penny <= 20)
                    {
                        MessageBox.Show(ruble +" рублей "+penny+" копеек", "Результат");
                    }
                    //вывод: копейка
                    else if (b == 1)
                    {
                        MessageBox.Show(ruble + " рублей "+penny+" копейка");
                    }
                    //вывод: копейки
                    else if (b == 2 || b == 3 || b == 4)
                    {
                        MessageBox.Show(ruble + " рублей " + penny + " копейки");
                    }
                    //вывод: копеек
                    else
                    {
                        MessageBox.Show(ruble + " рублей " + penny + " копеек");
                    }
                }
                //вывод: рубль
                else if (a == 1)
                {
                    //вывод: копеек
                    if (10 <= penny && penny <= 20)
                    {
                        MessageBox.Show(ruble + " рубль " + penny + " копеек");
                    }
                    //вывод: копейка
                    else if (b == 1)
                    {
                        MessageBox.Show(ruble + " рубль " + penny + " копейка");
                    }
                    //вывод: копейки
                    else if (b == 2 || b == 3 || b == 4)
                    {
                        MessageBox.Show(ruble + " рубль " + penny + " копейки");
                    }
                    //вывод: копеек
                    else
                    {
                        MessageBox.Show(ruble + " рубль " + penny + " копеек");
                    }
                }
                //вывод: рубля
                else if (a == 2 || a == 3 || a == 4)
                {
                    //вывод: копеек
                    if (10 <= penny && penny <= 20)
                    {
                        MessageBox.Show(ruble + " рубля " + penny + " копеек");
                    }
                    //вывод: копейка
                    else if (b == 1)
                    {
                        MessageBox.Show(ruble + " рубля " + penny + " копейка");
                    }
                    //вывод: копейки
                    else if (b == 2 || b == 3 || b == 4)
                    {
                        MessageBox.Show(ruble + " рубля " + penny + " копейки");
                    }
                    //вывод: копеек
                    else
                    {
                        MessageBox.Show(ruble + " рубля " + penny + " копеек");
                    }
                }
                //вывод: рублей
                else
                {
                    //вывод: копеек
                    if (10 <= penny && penny <= 20)
                    {
                        MessageBox.Show(ruble + " рублей " + penny + " копеек");
                    }
                    //вывод: копейка
                    else if (b == 1)
                    {
                        MessageBox.Show(ruble + " рублей " + penny + " копейка");
                    }
                    //вывод: копейки
                    else if (b == 2 || b == 3 || b == 4)
                    {
                        MessageBox.Show(ruble + " рублей " + penny + " копейки");
                    }
                    //вывод: копеек
                    else
                    {
                        MessageBox.Show(ruble + " рублей " + penny + " копеек");
                    }
                }

            }
            else
            {
                MessageBox.Show("Число должно входить в промежуток от 1 до 9999!");
            }
        }

        
    }
}
