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
            this.textBox1.Text = Properties.Settings.Default.n.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(this.textBox1.Text);
                Properties.Settings.Default.n = n;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(Logic.getresult(n), "Результат", MessageBoxButtons.OK);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дано натуральное число 1≤n≤9999, определяющее стоимость товара в копейках.Выразить стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей 5 копеек, 1 рубль ровно и т.п.", "Задача");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    } 
}
