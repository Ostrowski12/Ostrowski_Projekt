using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private Liczby liczbyM = new Merge(1000);
        private Liczby liczbyM1 = new Merge(2000);
        private Liczby liczbyM2 = new Merge(4000);
        private Liczby liczbyM3 = new Merge(8000);
        
        private Liczby liczbyQ = new Quick(1000);
        private Liczby liczbyQ1 = new Quick(2000);
        private Liczby liczbyQ2 = new Quick(4000);
        private Liczby liczbyQ3 = new Quick(8000);
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
        public void DodajDoListyM()
        {
            listaLiczb.Clear();
            listaLiczb.Add(liczbyM);
            listaLiczb.Add(liczbyM1);
            listaLiczb.Add(liczbyM2);
            listaLiczb.Add(liczbyM3);
        }
        public void DodajDoListyQ()
        {
            listaLiczb.Clear();
            listaLiczb.Add(liczbyQ);
            listaLiczb.Add(liczbyQ1);
            listaLiczb.Add(liczbyQ2);
            listaLiczb.Add(liczbyQ3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DodajDoListyB();
                foreach (Liczby elem in listaLiczb)
                {
                    if (radioButton1.Checked)
                    {
                        elem.Generowanie();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1,radioButton1);
                    }
                    else if (radioButton2.Checked)
                    {
                        elem.GenerowanieMIN();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton2);
                    }
                    else if (radioButton3.Checked)
                    {
                        elem.GenerowanieMAX();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton3);
                    }
                    
                }
            }
            else if (checkBox2.Checked)
            {
                DodajDoListyI();
                foreach (Liczby elem in listaLiczb)
                {
                    if (radioButton1.Checked)
                    {
                        elem.Generowanie();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1,radioButton1);
                    }
                    else if (radioButton2.Checked)
                    {
                        elem.GenerowanieMIN();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton2);
                    }
                    else if (radioButton3.Checked)
                    {
                        elem.GenerowanieMAX();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton3);
                    }
                   
                }
            }
            else if (checkBox3.Checked)
            {
                DodajDoListyS();
                foreach (Liczby elem in listaLiczb)
                {
                    if (radioButton1.Checked)
                    {
                        elem.Generowanie();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton1);
                    }
                    else if (radioButton2.Checked)
                    {
                        elem.GenerowanieMIN();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton2);
                    }
                    else if (radioButton3.Checked)
                    {
                        elem.GenerowanieMAX();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton3);
                    }
                 
                }
            }
            else if (checkBox4.Checked)
            {
                DodajDoListyM();
                foreach (Liczby elem in listaLiczb)
                {
                    if (radioButton1.Checked)
                    {
                        elem.Generowanie();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton1);
                    }
                    else if (radioButton2.Checked)
                    {
                        elem.GenerowanieMIN();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton2);
                    }
                    else if (radioButton3.Checked)
                    {
                        elem.GenerowanieMAX();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton3);
                    }
                }
            }
            else if (checkBox5.Checked)
            {
                DodajDoListyQ();
                foreach (Liczby elem in listaLiczb)
                {
                    if (radioButton1.Checked)
                    {
                        elem.Generowanie();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton1);
                    }
                    else if (radioButton2.Checked)
                    {
                        elem.GenerowanieMIN();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton2);
                    }
                    else if (radioButton3.Checked)
                    {
                        elem.GenerowanieMAX();
                        elem.Sortowanie();
                        elem.DodajNaWykres(chart1, radioButton3);
                    }
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

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

        public void GenerowanieMIN()
        {
            int tmp;
            int j;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = generuj.Next(100);
            }

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

        }

        public void GenerowanieMAX()
        {
            int tmp;
            int j;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = generuj.Next(100);
            }

            for (int i = 1; i < tab.Length; i++)
            {
                tmp = tab[i];
                j = i - 1;
                while (j >= 0 && tab[j] < tmp)  
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = tmp;
            }

        }

        abstract public void Sortowanie();
        abstract public void DodajNaWykres(Chart chart1,RadioButton radioButton);
    }
    public class Bubble : Liczby
    {
        public long test;
        protected long czas;
        public Bubble(int n) : base(n) { }
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
        public override void DodajNaWykres(Chart chart1, RadioButton radioButton)
            {
            if (chart1.Series.Count == 0)
            {
               
                Series series = new Series("Bąbelkowe "+radioButton.Text);
                
                chart1.Series.Add(series);
                series.ChartType = SeriesChartType.Line;
            }
            else
            { 
                Series existingSeries = chart1.Series.FindByName("Bąbelkowe " + radioButton.Text);

                if (existingSeries == null)
                { 
                    Series series = new Series("Bąbelkowe " + radioButton.Text);
                    series.ChartType = SeriesChartType.Line;
                    chart1.Series.Add(series);
                }
            }     
            chart1.Series["Bąbelkowe " + radioButton.Text].Points.AddXY(tab.Length, czas);
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
        public override void DodajNaWykres(Chart chart1, RadioButton radioButton)
        {
            if (chart1.Series.Count == 0)
            { 
                Series series = new Series("Wstawianie "+radioButton.Text);
                chart1.Series.Add(series);
                series.ChartType = SeriesChartType.Line;
            }
            else
            {
                Series existingSeries = chart1.Series.FindByName("Wstawianie "+radioButton.Text);

                if (existingSeries == null)
                {
                   
                    Series series = new Series("Wstawianie "+radioButton.Text);
                    chart1.Series.Add(series);
                    series.ChartType = SeriesChartType.Line;
                }
            }
            chart1.Series["Wstawianie "+radioButton.Text].Points.AddXY( tab.Length, czas);
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
        public override void DodajNaWykres(Chart chart1, RadioButton radioButton)
        {
            if (chart1.Series.Count == 0)
            {
                Series series = new Series("Wybór " + radioButton.Text);      
                chart1.Series.Add(series);
                series.ChartType = SeriesChartType.Line;
            }
            else
            { 
                Series existingSeries = chart1.Series.FindByName("Wybór " + radioButton.Text);

                if (existingSeries == null)
                {     
                    Series series = new Series("Wybór " + radioButton.Text);
                    chart1.Series.Add(series);
                    series.ChartType = SeriesChartType.Line;
                }
            }
            chart1.Series["Wybór " + radioButton.Text].Points.AddXY(tab.Length,czas);
        }
    }
    public class Merge : Liczby
    { 
        public Merge(int n) : base(n) { }
        protected long czas;

        public override void Sortowanie()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            MergeSort(0, tab.Length - 1);
            stopwatch.Stop();
            czas = stopwatch.ElapsedMilliseconds;
        }
        private void MergeSort(int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(left, mid);
                MergeSort(mid + 1, right);

                Sort(left, mid, right);
            }
        }
        private void Sort(int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(tab, left, leftArray, 0, n1);
            Array.Copy(tab, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    tab[k] = leftArray[i];
                    i++;
                }
                else
                {
                    tab[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                tab[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                tab[k] = rightArray[j];
                j++;
                k++;
            }
        }
        public override void DodajNaWykres(Chart chart1, RadioButton radioButton)
        {
            if (chart1.Series.Count == 0)
            {
                Series series = new Series("Scalanie " + radioButton.Text);
                chart1.Series.Add(series);
                series.ChartType = SeriesChartType.Line;
            }
            else
            {
                Series existingSeries = chart1.Series.FindByName("Scalanie " + radioButton.Text);

                if (existingSeries == null)
                {

                    Series series = new Series("Scalanie " + radioButton.Text);
                    chart1.Series.Add(series);
                    series.ChartType = SeriesChartType.Line;
                }
            }
            chart1.Series["Scalanie " + radioButton.Text].Points.AddXY(tab.Length, czas);
        }
    }
    public class Quick : Liczby
    {
        public Quick(int n) : base(n) { }
        protected long czas;

        public override void Sortowanie()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(0, tab.Length - 1);
            stopwatch.Stop();
            czas = stopwatch.ElapsedMilliseconds;

        }

        private void QuickSort(int low, int high)
        {
            if (low < high)
            {
                int mid = Partition(low, high);

                QuickSort(low, mid - 1);
                QuickSort(mid + 1, high);
            }
        }
        int tmp;
        int tmp2;
        private int Partition(int low, int high)
        {
            int pivot = tab[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (tab[j] < pivot)
                {
                    i++;

                    tmp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = tmp;
                }
            }

            int tmp2 = tab[i + 1];
            tab[i + 1] = tab[high];
            tab[high] = tmp2;

            return i + 1;
        }

        public override void DodajNaWykres(Chart chart1, RadioButton radioButton)
        {

            if (chart1.Series.Count == 0)
            {
                Series series = new Series("Szybkie " + radioButton.Text);
                chart1.Series.Add(series);
                series.ChartType = SeriesChartType.Line;
            }
            else
            {
                Series existingSeries = chart1.Series.FindByName("Szybkie " + radioButton.Text);

                if (existingSeries == null)
                {

                    Series series = new Series("Szybkie " + radioButton.Text);
                    chart1.Series.Add(series);
                    series.ChartType = SeriesChartType.Line;
                }
            }
            chart1.Series["Szybkie " + radioButton.Text].Points.AddXY(tab.Length, czas);
        }
    }
    }

