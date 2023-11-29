using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ostrowski_Projekt
{
    public partial class Form1 : Form   
    {
        
        private Liczby liczbyB = new Bubble(20000);
        private Liczby liczbyI = new Insert(20000);
        private Liczby liczbyS = new Insert(20000);
            
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for()
            if(checkBox1.Checked)
            {
                    liczbyB.Generowanie(textBox1);
                    liczbyB.Sortowanie(textBox2);
            }else if (checkBox2.Checked)
            {
                liczbyI.Generowanie(textBox1);
                liczbyI.Sortowanie(textBox2);
            }
            else if (checkBox3.Checked)
            {
                liczbyS.Generowanie(textBox1);
                liczbyS.Sortowanie(textBox2);

            }
            //  liczby.Generowanie(textBox1);
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }


    }
     abstract public class Liczby
    {
        Random generuj = new Random();
        protected int[] tab;
       

        public Liczby(int n)
        {
            tab = new int[n];
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

        abstract public void Sortowanie(System.Windows.Forms.TextBox textBox2);
        
    }
    public class Bubble : Liczby
    {
        public Bubble(int n) : base(n)
        {
        }
        public override void Sortowanie(System.Windows.Forms.TextBox textBox2)
        {
            textBox2.Text = "";
            int tmp;

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

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
            stopwatch.Stop();
            for (int i = 0; i < tab.Length; i++)
            {
                textBox2.Text += " " + tab[i];
            }
            textBox2.Text = $"Czas sortowania: {stopwatch.ElapsedMilliseconds} ms";

        }
    }

    public class Insert : Liczby
    {
        public Insert(int n) : base(n) { }

        public override void Sortowanie(System.Windows.Forms.TextBox textBox2)
        {
            textBox2.Text = "";
            int tmp;
            int j;
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
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
            }
            stopwatch.Stop();

            for (int i = 0; i < tab.Length; i++)
            {
                textBox2.Text += " " + tab[i];
            }
            textBox2.Text = $"Czas sortowania: {stopwatch.ElapsedMilliseconds} ms";
        }
    }

    public class Select : Liczby
    {
        public Select(int n) : base(n) { }

        public override void Sortowanie(System.Windows.Forms.TextBox textBox2)
        {
            textBox2.Text = "";
            int tmp;

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

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
            stopwatch.Stop();


            for (int i = 0; i < tab.Length; i++)
            {
                textBox2.Text += " " + tab[i];
            }
            textBox2.Text = $"Czas sortowania: {stopwatch.ElapsedMilliseconds} ms";
        }
    }

    public class Merge : Liczby
    { 
        public Merge(int n) : base(n) { }

        public override void Sortowanie(System.Windows.Forms.TextBox textBox2)
        {
            textBox2.Text = "";
            int[] tmpA= new int[tab.Length/2];
            int[] tmpB= new int[tab.Length-tmpA.Length];
            //1 9 3 7 3 9 3 8 9

        //protected int[] tab;
        //public Liczby(int n)
        //{
        //    tab = new int[n];
        //}

            for (int i=0;i < tab.Length/2; i++)
            {
                tmpA[i] = tab[i];
            }
            
          
        }

    }

    }

