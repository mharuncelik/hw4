using System;
using System.Windows.Forms;

namespace homework4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSayi1.Text, out int a) || !int.TryParse(txtSayi2.Text, out int b))
            {
                MessageBox.Show("İki kutuya da geçerli bir tam sayı girin!");
                return;
            }
            MessageBox.Show("Max: " + Max(a, b));
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSayi1.Text, out int a) || !int.TryParse(txtSayi2.Text, out int b))
            {
                MessageBox.Show("İki kutuya da geçerli bir tam sayı girin!");
                return;
            }
            MessageBox.Show(a + " ^ " + b + " = " + Power(a, b));
        }

        private void btnIsPrime_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSayi1.Text, out int n))
            {
                MessageBox.Show("İlk kutuya geçerli bir tam sayı girin!");
                return;
            }
            MessageBox.Show(IsPrime(n) ? n + " asaldır." : n + " asal değildir.");
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSayi1.Text, out int n) || n < 0 || n > 20)
            {
                MessageBox.Show("İlk kutuya 0 ile 20 arasında bir tam sayı girin!");
                return;
            }
            MessageBox.Show(n + "! = " + Factorial(n));
        }

        private int Max(int a, int b)
        {
            return Math.Max(a, b);
        }

        private double Power(int a, int b)
        {
            return Math.Pow(a, b);
        }

        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private long Factorial(int n)
        {
            long sonuc = 1;
            for (int i = 2; i <= n; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
    }
}