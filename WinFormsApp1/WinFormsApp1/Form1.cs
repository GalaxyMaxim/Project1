using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "���������� ������";
            label1.Text = "";
            button1.Text = "���������� ������";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int storonaMonety = random.Next(0, 2);
            if (storonaMonety == 0)
            {
                label1.Text = "���";
            }
            else
            {
                label1.Text = "�����";
            }
        }
    }
}