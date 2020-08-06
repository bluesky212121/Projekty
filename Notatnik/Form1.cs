using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TerazSieUdaNotatnik
{
    public partial class Form1 : Form
    {
        public string sciezkaDoArchiwum;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = @"D:\ArchiwumNotatek";
            sciezkaDoArchiwum = textBox3.Text;
            WczytajDoComboBoxa();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sciezkaDoArchiwum = textBox3.Text;
            WczytajDoComboBoxa();
        }

        private void textBox1_Click(object sender, EventArgs e) //textbox
        {
            if (textBox1.Text == "Wpisz swoją notatkę tutaj")
            {
                textBox1.Text = "";
            }
        }
        private void textBox2_Click(object sender, EventArgs e) //textbox
        {
            if (textBox2.Text == "Nazwa notatki")
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) //zapis
        {
            PrzyciskWcisniety(2);
        }

        private void button2_Click(object sender, EventArgs e) //wczytaj
        {
            PrzyciskWcisniety(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            WczytajDoComboBoxa();
            ZaladujNotatke();

        }

        public void PrzyciskWcisniety(int czynnosc)
        {
            switch (czynnosc)
            {
                case 2://zapis
                    ZapiszPlik(textBox2.Text, textBox1.Text);
                    break;

                case 1://wczytanie
                  
                    break;
            }

        }

        void ZapiszPlik(string NazwaNotatki, string trescNotatki)
        {
            try
            {
                using (StreamWriter plikZapisywany = new StreamWriter(Path.Combine(sciezkaDoArchiwum, NazwaNotatki)))
                {
                    plikZapisywany.WriteLine(trescNotatki);
                }
            }
            catch //jesli sciezka nie istnieje to ja stworz
            {
                Directory.CreateDirectory(sciezkaDoArchiwum); //dorobić ustalanie ścieżki do plikow
                using (StreamWriter plikWyjsciowy = new StreamWriter(Path.Combine(sciezkaDoArchiwum, NazwaNotatki)))
                {
                    plikWyjsciowy.WriteLine(trescNotatki);
                }
            }
            WczytajDoComboBoxa();
        }
        void ZaladujNotatke()
        {
            textBox2.Text = comboBox1.Text;//zmiana nazwy notatki na wybrana;

            using (StreamReader ladowaniePliku = new StreamReader(Path.Combine(sciezkaDoArchiwum, comboBox1.Text)))
            {
                textBox1.Text = ladowaniePliku.ReadLine();
            }

        }

        void WczytajDoComboBoxa()//ladowanie do comboboxa
        {
            comboBox1.Items.Clear();
            try
            {
                string[] pliki = Directory.GetFiles(sciezkaDoArchiwum);

                foreach (string plik in pliki)
                {
                    comboBox1.Items.Add(Path.GetFileName(plik));
                }
            }
            catch//blok celowo pusty
            {

            }
        }



    }
}
