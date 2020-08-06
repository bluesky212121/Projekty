using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public float liczbaPamiec1 = 0; float liczbaPamiec2 = 0;
        public bool zresetuj;
        public string typDzialania;
        public int indeksHistorii = -1;
        public List<string> historia = new List<string>();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text += "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(1);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(2);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(3);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(4);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(5);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(6);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(7);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(8);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(9);

        }
        private void button20_Click(object sender, EventArgs e)
        {
            KontrolaZapisu(0);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
        public void KontrolaZapisu(int liczba)
        {
            if (zresetuj)
            {
                textBox1.Text = "0";
                zresetuj = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.Length <= 19)
            {
                textBox1.Text += $"{liczba}";
            }
        }
        public string WynikPotegowania()
        {
            liczbaPamiec2 = liczbaPamiec1;
            if (Int64.Parse(textBox1.Text) == 0)
            {
                return "1";

            }
            else if (Int64.Parse(textBox1.Text) == 1)
            {
                return $"{liczbaPamiec1}";
            }
            for (int i = 2; i <= Int64.Parse(textBox1.Text); i++)
            {
                liczbaPamiec1 *= liczbaPamiec2;
            }
            
            return $"{liczbaPamiec1}";
        }

        public void Dzialanie(int numerDzialania)
        {
            if(numerDzialania == 1)//dodawanie
            {
                typDzialania = "dod";
                if (liczbaPamiec1 == 0)
                {
                   liczbaPamiec1 = float.Parse(textBox1.Text);
                   textBox1.Text = "0";
                }
                else
                {
                   textBox1.Text = $"{liczbaPamiec1 + float.Parse(textBox1.Text)}";
                   Historia();
                   liczbaPamiec1 = 0;
                   zresetuj = true;
                }

            }
            else if (numerDzialania == 2)//odejmowanie
            {
                typDzialania = "ode";

                if (liczbaPamiec1 == 0)
                {
                    liczbaPamiec1 = float.Parse(textBox1.Text);
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = $"{liczbaPamiec1 - float.Parse(textBox1.Text)}";
                    Historia();
                    liczbaPamiec1 = 0;
                    zresetuj = true;
                }

            }
            else if (numerDzialania == 3)//wynik
            {
                textBox1.Text = typDzialania == "dod" ? $"{liczbaPamiec1 + float.Parse(textBox1.Text)}" : textBox1.Text;
                textBox1.Text = typDzialania == "ode" ? $"{liczbaPamiec1 - float.Parse(textBox1.Text)}" : textBox1.Text;
                textBox1.Text = typDzialania == "mno" ? $"{liczbaPamiec1 * float.Parse(textBox1.Text)}" : textBox1.Text;
                textBox1.Text = typDzialania == "dzi" ? $"{liczbaPamiec1 / float.Parse(textBox1.Text)}" : textBox1.Text;
                textBox1.Text = typDzialania == "pot" ? WynikPotegowania() : textBox1.Text;
                Historia();
                zresetuj = true;
                typDzialania = "clear";
                liczbaPamiec1 = 0;
            }
            else if (numerDzialania == 4)//clear
            {
                typDzialania = "clear";
                textBox1.Text = "0";
                liczbaPamiec1 = 0;
                liczbaPamiec2 = 0;
                Historia();
            }
            else if (numerDzialania == 5)//mnozenie
            {
                typDzialania = "mno";
                if (liczbaPamiec1 == 0)
                {
                    liczbaPamiec1 = float.Parse(textBox1.Text);
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = $"{liczbaPamiec1 * float.Parse(textBox1.Text)}";
                    Historia();
                    liczbaPamiec1 = 0;
                    zresetuj = true;
                }

            }
            else if (numerDzialania == 6)//dzielenie
            {
                typDzialania = "dzi";
                if (liczbaPamiec1 == 0)
                {
                    liczbaPamiec1 = float.Parse(textBox1.Text);
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = $"{liczbaPamiec1 / float.Parse(textBox1.Text)}";
                    Historia();
                    liczbaPamiec1 = 0;
                    zresetuj = true;
                }

            }
            else if (numerDzialania == 7)//potegowanie
            {
                typDzialania = "pot";
                if (liczbaPamiec1 == 0)
                {
                    liczbaPamiec1 = float.Parse(textBox1.Text);
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = WynikPotegowania();
                    Historia();
                    liczbaPamiec1 = 0;
                    zresetuj = true;
                }

            }
        }
        public void Historia()
        {
            
        }
    }
}
