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
            int n = int.Parse(this.textBox1.Text);
           
            MessageBox.Show(Logic.getresult(n), "Результат", MessageBoxButtons.OK);
        }
    } 
}
