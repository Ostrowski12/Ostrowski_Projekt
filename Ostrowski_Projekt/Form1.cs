using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ostrowski_Projekt
{
    public partial class Form1 : Form
    {
        List<Liczby> listaLiczb = new List<Liczby>();
       

        private Liczby liczbyB = new Bubble(1000);
        private Liczby liczbyB1 = new Bubble(2000);
        private Liczby liczbyB2 = new Bubble(4000);
        private Liczby liczbyB3 = new Bubble(8000);
        
        private Liczby liczbyI = new Insert(1000);
        private Liczby liczbyI1 = new Insert(2000);
        private Liczby liczbyI2 = new Insert(4000);
        private Liczby liczbyI3 = new Insert(8000);

        private Liczby liczbyS = new Select(1000);
        private Liczby liczbyS1 = new Select(2000);
        private Liczby liczbyS2 = new Select(4000);
        private Liczby liczbyS3 = new Select(8000);
        public Form1()
        {
            InitializeComponent();

        }

        public void DodajDoListyB()
        {
            listaLiczb.Clear();
            listaLiczb.Add(liczbyB);
            listaLiczb.Add(liczbyB1);
            listaLiczb.Add(liczbyB2);
            listaLiczb.Add(liczbyB3);
        }

        public void DodajDoListyI()
        {
            listaLiczb.Clear();
            listaLiczb.Add(liczbyI);
            listaLiczb.Add(liczbyI1);
            listaLiczb.Add(liczbyI2);
            listaLiczb.Add(liczbyI3);
        }
        public void DodajDoListyS()
        {
            listaLiczb.Clear();
            listaLiczb.Add(liczbyS);
            listaLiczb.Add(liczbyS1);
            listaLiczb.Add(liczbyS2);
            listaLiczb.Add(liczbyS3);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                DodajDoListyB();
                foreach (Liczby elem in listaLiczb)
                {
                    elem.Generowanie();
                    elem.Sortowanie();
                    elem.DodajNaWykres(chart1);

                }
             
            }
            else if (checkBox2.Checked)
            {
                DodajDoListyI();
                foreach (Liczby elem in listaLiczb)
                {
                    elem.Generowanie();
                    elem.Sortowanie();
                    elem.DodajNaWykres(chart1);

                }
            }
            else if (checkBox3.Checked)
            {
                DodajDoListyS();
                foreach (Liczby elem in listaLiczb)
                {
                    elem.Generowanie();
                    elem.Sortowanie();
                    elem.DodajNaWykres(chart1);

                }

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

        public void Generowanie()
        {
            
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = generuj.Next(100);
            }

        }

        abstract public void Sortowanie();
        abstract public void DodajNaWykres(Chart chart1);



    }


    public class Bubble : Liczby
    {
        public long test;
        protected long czas;
        public Bubble(int n) : base(n)
        {

        }
        public override void Sortowanie()
        {
            
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
            
            czas = stopwatch.ElapsedMilliseconds;
        }

        public override void DodajNaWykres(Chart chart1)
            {
            if (chart1.Series.Count == 0)
            {
               
                Series series = new Series("Bąbelkowe");
                
                chart1.Series.Add(series);
            }
            else
            {
                
                Series existingSeries = chart1.Series.FindByName("Bąbelkowe");

                if (existingSeries == null)
                {
                    
                    Series series = new Series("Bąbelkowe");
                    series.ChartType = SeriesChartType.Line;
                    chart1.Series.Add(series);
                }
            }

           
            chart1.Series["Bąbelkowe"].Points.AddXY(tab.Length, czas);
        }
    }

    public class Insert : Liczby
    {
        public Insert(int n) : base(n) { }
        protected long czas;

        public override void Sortowanie()
        {
            
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
            czas = stopwatch.ElapsedMilliseconds;
        }

        public override void DodajNaWykres(Chart chart1)
        {
            if (chart1.Series.Count == 0)
            {
              
                Series series = new Series("Wstawianie");
                series.ChartType = SeriesChartType.Line;
                chart1.Series.Add(series);
            }
            else
            {
               
                Series existingSeries = chart1.Series.FindByName("Wstawianie");

                if (existingSeries == null)
                {
                   
                    Series series = new Series("Wstawianie");
                    series.ChartType = SeriesChartType.Line;
                    chart1.Series.Add(series);
                }
            }

          
            chart1.Series["Wstawianie"].Points.AddXY( tab.Length, czas);
        }


    }

    public class Select : Liczby
    {
        public Select(int n) : base(n) { }
        protected long czas;
        public override void Sortowanie()
        { 
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

        czas = stopwatch.ElapsedMilliseconds;
        }
        public override void DodajNaWykres(Chart chart1)
        {
            if (chart1.Series.Count == 0)
            {
                Series series = new Series("Wybór");
              
                chart1.Series.Add(series);
            }
            else
            {
               
                Series existingSeries = chart1.Series.FindByName("Wybór");

                if (existingSeries == null)
                {
                    
                    Series series = new Series("Wybór");
                    series.ChartType = SeriesChartType.Line;
                    chart1.Series.Add(series);
                }
            }

           
            chart1.Series["Wybór"].Points.AddXY(tab.Length,czas);
        }


    }

    public class Merge : Liczby
    { 
        public Merge(int n) : base(n) { }

        public override void Sortowanie()
        {
          
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
        public override void DodajNaWykres(Chart chart1)
        {

        }
    }

    }

