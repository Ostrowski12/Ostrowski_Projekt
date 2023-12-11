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
        public Form1()
        {
            InitializeComponent();
        }
        public void DodajDoListy()
        {
            listaLiczb.Clear();
            for(int i=0;i<=15;i++)
            {
            if(checkBox1.Checked)
                {
                  listaLiczb.Add(new Bubble(1000*i));
                }
                else if(checkBox2.Checked)
                {
                   listaLiczb.Add(new Insert(1000 * i));
                }
                else if (checkBox3.Checked)
                {
                    listaLiczb.Add(new Select(1000 * i));
                }
                else if (checkBox4.Checked)
                {
                    listaLiczb.Add(new Merge(1000 * i));
                }
                else if (checkBox5.Checked)
                {
                    listaLiczb.Add(new Quick(1000 * i));
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DodajDoListy();
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
                DodajDoListy();
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
                DodajDoListy();
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
                DodajDoListy();
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
                DodajDoListy();
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
        {}
        private void chart1_Click(object sender, EventArgs e)
        {}
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {}
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {}
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }
        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
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
                tab[i] = generuj.Next(10000);
            }
        }
        public void GenerowanieMIN()
        {
            int tmp;
            int j;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = generuj.Next(10000);
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
                tab[i] = generuj.Next(10000);
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

            tmp2 = tab[i + 1];
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