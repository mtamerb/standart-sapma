using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamer_bilici_190508067_standart_sapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int len = dizi.Length;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = recursiveIleHesapla(dizi, len).ToString();
            textBox2.Text = iterativeIleHesapla(dizi, len).ToString();
        }


        static double recursiveIleHesapla(double[] dizi, int n)
        {

            double fark = 0;
            foreach (double v in dizi)
            {
                fark += (v - recursiveOrtalama(dizi, n)) * (v - recursiveOrtalama(dizi, n));
            }
            fark /= n;

            return Math.Sqrt(fark);

        }

        static double recursiveOrtalama(double[] dizi, int n)
        {
            if (n == 1)
            {
                return dizi[n - 1];
            }
            else{
                return (recursiveOrtalama(dizi, n-1) * (n - 1) + dizi[n -1]) / n;
            }
        }


        static double iterativeIleHesapla(double[] dizi, int n)
        {

            double ortalama = 0;

            for (int i = 0; i < n; i++)
            {
                ortalama += dizi[i];
            }
            ortalama /= n;

            double fark = 0;

            foreach(double v in dizi){
                fark += ((v - ortalama) * (v - ortalama));
            }

            fark /= n;

            return Math.Sqrt(fark);
        }


    }
}
