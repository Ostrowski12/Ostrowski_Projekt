using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ostrowski_Projekt
{
    public partial class Form1 : Form
    {
        private Liczby liczby = new Liczby();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liczby.Generowanie(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                liczby.Sortowanie(textBox2);
            }
            else if (checkBox2.Checked)
            {
                liczby.Sortowanie2(textBox2);
            }
            else if (checkBox3.Checked)
            {
                liczby.Sortowanie3(textBox2);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Liczby
    {
        Random generuj = new Random();
        private int[] tab;

        public Liczby()
        {
            tab = new int[10];
        }

        public void Generowanie(System.Windows.Forms.TextBox textBox1)
        {
            textBox1.Text = "";
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = generuj.Next(100);
            }

            for (int i = 0; i < tab.Length; i++)
            {
                textBox1.Text += " " + tab[i];
            }
        }

        public void Sortowanie(System.Windows.Forms.TextBox textBox2)
        {
            textBox2.Text = "";
            int tmp;

            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - 1 - i; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
            }

            for (int i = 0; i < tab.Length; i++)
            {
                textBox2.Text += " " + tab[i];
            }
        }

        public void Sortowanie2(System.Windows.Forms.TextBox textBox2)
        {
            textBox2.Text = "";
            int tmp;
            int j;
            for (int i = 1; i < tab.Length; i++)
            {
                tmp = tab[i];
                j = i - 1;
                while (j >= 0 && tab[j] > tmp)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = tmp;
                // 3 2 5 6
                // j i
            }

            for (int i = 0; i < tab.Length; i++)
            {
                textBox2.Text += " " + tab[i];
            }
        }
        public void Sortowanie3(System.Windows.Forms.TextBox textBox2)
        {
            textBox2.Text = "";
            int tmp;

            for (int i = 0; i < tab.Length - 1; i++)
            {
                tmp = tab[i];
                for (int j = i + 1; j < tab.Length; j++)
                {

                    if (tab[j] < tab[i])
                    {
                        tmp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = tmp;
                    }

                }

            }


            for (int i = 0; i < tab.Length; i++)
            {
                textBox2.Text += " " + tab[i];
            }
        }

    }



}

