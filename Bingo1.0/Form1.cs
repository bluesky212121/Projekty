using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo1._0
{
    public partial class Form1 : Form
    {
        //
        //listy
        //
        private List<Button> _listakratek = new List<Button>();
        private List<string> _listaTekstow = new List<string>();
        private List<string> _listaUzytychTekstow = new List<string>();
        private List<Color> _listaKolorowDoTestu = new List<Color>();
        //
        //random
        //
        Random random = new Random();
        //
        //Zasoby
        //
        public string sciezkaDoPliku = @"C:\bingopliki\";
        private string _plikDoZaladowania;
        //
        //Typowe zmienne
        //
        public string[] ciagZPliku;
        int _indexLicznik = 0;
 
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = sciezkaDoPliku;
            label3.Text = "";
            WygenerujGuziki(5, 5);
            WczytajDoComboBoxa();
        }
        private void WygenerujGuziki(int _szerokosc, int _wysokosc)
        {
            for (int j = 0; j < _wysokosc; j++)
            {
                for (int i = 0; i < _szerokosc; i++)
                {
                    Button kratka = new Button();
                    kratka.Location = new Point(12 + i * 100, 12 + j * 100);
                    kratka.Name = $"kratka{_indexLicznik}";
                    kratka.Size = new Size(100, 100);
                    kratka.TabIndex = _indexLicznik;
                    kratka.Text = $"{_indexLicznik}";
                    kratka.BackColor = Color.DarkGray;
                    kratka.Click += new EventHandler(kratkaGry_Click);
                    _listakratek.Add(kratka);
                    Controls.Add(kratka);
                    _indexLicznik++;
                }
            }
        }
        private void kratkaGry_Click(object sender, EventArgs e)
        {
            Button _kratka = (Button)sender;

            if (_kratka.BackColor == Color.Magenta)
            {
                _kratka.BackColor = Color.DarkGray;
            }
            else
            {
                _kratka.BackColor = Color.Magenta;
            }
            SprawdzWygrana();
        }
        //
        //Do naprawy
        //
        void SprawdzWygrana()
        {
            //
            // no name rules
            // this is not effcient, Too bad! Its just a bingo
            _listaKolorowDoTestu.Clear();
            bool _wygrana = false;
            int[] _pozium = { 0, 5, 10, 15, 20 };
            int[] _skosDol = {0,6,12,18,24};
            int[] _skosGora = { 20, 16, 12, 8, 4 };
            for (int i = 0; i <= 4; i++)
            {
                _listaKolorowDoTestu.Clear();
                if (_wygrana == false)
                {
                    foreach (int jj in _pozium)
                    {
                        _listaKolorowDoTestu.Add(_listakratek[jj + i].BackColor);
                        _wygrana = _listaKolorowDoTestu.Contains(Color.DarkGray) ? false : true;
                    }
                    foreach (int jj in _pozium)
                    {
                        _listaKolorowDoTestu.Clear();
                        if (_wygrana == false)
                        {
                            for (int _g = 0; _g <= 4; _g++)
                            {
                                _listaKolorowDoTestu.Add(_listakratek[_g + jj].BackColor);
                                 _wygrana = _listaKolorowDoTestu.Contains(Color.DarkGray) ? false : true;
                            }
                        }
                    }
                }
            }
            if (_wygrana == false)
            {
                _listaKolorowDoTestu.Clear();
                foreach (int dol in _skosDol)
                {
                    _listaKolorowDoTestu.Clear();
                    _listaKolorowDoTestu.Add(_listakratek[dol].BackColor);
                    _wygrana = _listaKolorowDoTestu.Contains(Color.DarkGray) ? false : true;
                }
                _listaKolorowDoTestu.Clear();
                if (_wygrana == false)
                {
                    foreach (int gora in _skosGora)
                    {
                        _listaKolorowDoTestu.Add(_listakratek[gora].BackColor);
                        _wygrana = _listaKolorowDoTestu.Contains(Color.DarkGray) ? false : true;
                    }
                }

                
            }
            label3.Text = _wygrana ? "BINGO!" : "";
        }
        private void Wczytaj_Click(object sender, EventArgs e)
        {
            _listaTekstow.Clear();
            label3.Text = "";
            try
            {
                ciagZPliku = File.ReadAllLines(sciezkaDoPliku + _plikDoZaladowania);

                for (int i = 0; i < ciagZPliku.Length; i++)
                {
                    _listaTekstow.Add(ciagZPliku[i]);
                }

                for (int j = 0; j < 25; j++)
                {
                    int losowyIndex = random.Next(_listaTekstow.Count);
                    _listakratek[j].Text = _listaTekstow[losowyIndex];
                    _listaTekstow.Remove(_listaTekstow[losowyIndex]);
                }
                    _listakratek[12].Text = "FREE SPACE";
                }

            catch { }
            foreach(Button kratka in _listakratek)
            {
                kratka.BackColor = Color.DarkGray;
            }
        }
        private void WczytajDoComboBoxa()//ladowanie do comboboxa
        {
            comboBox1.Items.Clear();
            try
            {
                string[] _pliki = Directory.GetFiles(sciezkaDoPliku, "*.txt");
                foreach (string _plik in _pliki)
                {
                    comboBox1.Items.Add(Path.GetFileName(_plik));
                }
            }
            catch{}
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _plikDoZaladowania = comboBox1.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sciezkaDoPliku = textBox1.Text;
            WczytajDoComboBoxa();
        }

        private void przegladaj_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = sciezkaDoPliku;
            folderBrowserDialog1.ShowDialog();
            sciezkaDoPliku = folderBrowserDialog1.SelectedPath;
            //
            //wykonac skrypt do odswiezania przyciskow
            //
            textBox1.Text = sciezkaDoPliku;
        }
    }
}
