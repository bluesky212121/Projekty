using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoIKrzyzyk
{
    public partial class Form1 : Form
    {
        public string wybranyGracz;
        public string zwyciezca = "Reset";
        int _indexLicznik = 0;
        public int szerokoscPolaGry = 7;
        public int wysokoscPolaGry =7;
        List<ModelKratki> kratkiZListy = new List<ModelKratki>();
        List<Button> listaDoResetu = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            IleNaIleLabel.Text = $"{szerokoscPolaGry} x {wysokoscPolaGry}";

            WygenerujGuziki(szerokoscPolaGry, wysokoscPolaGry);
            wybranyGracz = "X";
            label2.Text = wybranyGracz;
        }
        //
        // Wywolania przyciskow
        //
        private void kratkaGry_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (przycisk.Text == "" && zwyciezca == "Reset")
            {
                switch (wybranyGracz)
                {
                    case "X":
                        przycisk.Text = "X";//zmiana znaku kratki

                        for (int i = 0; i < _indexLicznik; i++)
                        {
                            if (kratkiZListy[i].nazwaKratki == przycisk.Name)
                            {
                                kratkiZListy[i].wartoscKratki = przycisk.Text; // zmiana wartosci w liscie
                            }
                        }
                        wybranyGracz = "O";//zmiana gracza
                        break;
                    case "O":
                        przycisk.Text = "O";//zmiana znaku kratki
                        for (int i = 0; i < _indexLicznik; i++)
                        {
                            if (kratkiZListy[i].nazwaKratki == przycisk.Name)
                            {
                                kratkiZListy[i].wartoscKratki = przycisk.Text; // zmiana wartosci w liscie
                            }
                        }
                        wybranyGracz = "X";//zmiana gracza
                        break;
                }
                label2.Text = wybranyGracz; // zmiana symbolu obecnego gracza
                SprawdzWygrana();
                WyswietlWynik();
            }
            
        }
        public void SprawdzWygrana()
        {
            for (int i = 0; i < _indexLicznik; i++)
            {
                try
                {
                    if (kratkiZListy[i].wartoscKratki == kratkiZListy[i + 1].wartoscKratki && kratkiZListy[i + 1].wartoscKratki == kratkiZListy[i + 2].wartoscKratki || kratkiZListy[i].wartoscKratki == kratkiZListy[i + szerokoscPolaGry].wartoscKratki && kratkiZListy[i + szerokoscPolaGry].wartoscKratki == kratkiZListy[i + szerokoscPolaGry * 2].wartoscKratki)
                    {//wzdluzne

                        switch (kratkiZListy[i].wartoscKratki)
                        {
                            case "O":
                                zwyciezca = "OWygral";
                                break;
                            case "X":
                                zwyciezca = "XWygral";
                                break;
                        }
                    }
                    if (kratkiZListy[i].wartoscKratki == kratkiZListy[i + szerokoscPolaGry + 1].wartoscKratki && kratkiZListy[i + szerokoscPolaGry + 1].wartoscKratki == kratkiZListy[i + (szerokoscPolaGry * 2) + 2].wartoscKratki || kratkiZListy[i].wartoscKratki == kratkiZListy[i - szerokoscPolaGry + 1].wartoscKratki && kratkiZListy[i - szerokoscPolaGry + 1].wartoscKratki == kratkiZListy[i - (szerokoscPolaGry * 2) + 2].wartoscKratki)
                    {//skos
                        switch (kratkiZListy[i].wartoscKratki)
                        {
                            case "O":
                                zwyciezca = "OWygral";
                                break;
                            case "X":
                                zwyciezca = "XWygral";
                                break;
                        }

                    }
                }
                catch
                { }
            }

        }
        public void WyswietlWynik()
        {
            switch (zwyciezca)
            {
                case "OWygral":
                    label3.Text = "O";
                    label4.Text = "Wygral";
                    break;
                case "XWygral":
                    label3.Text = "X";
                    label4.Text = "Wygral";
                    break;
                case "Reset":
                    label3.Text = "";
                    label4.Text = "";
                    break;
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {  
            _indexLicznik = 0;
            foreach (Button guzikResetu in listaDoResetu)
            {
              Controls.Remove(guzikResetu);
            }
            listaDoResetu.Clear();
            kratkiZListy.Clear();
            WygenerujGuziki(szerokoscPolaGry,wysokoscPolaGry);
            label3.Text = "";
            label4.Text = "";
            zwyciezca = "Reset";


        }
        private void WygenerujGuziki(int szerokosc, int wysokosc)
        {          
            for (int j = 0; j < wysokosc; j++)
            {
                for (int i = 0; i < szerokosc; i++)
                {
                    Button kratka = new Button();
                    kratka.Location = new Point(35 + i * 80, 83 + j * 80);
                    kratka.Name = $"kratka{_indexLicznik}";
                    kratka.Size = new Size(73, 72);
                    kratka.TabIndex = _indexLicznik;
                    kratka.Text = $"";
                    kratka.Click += new EventHandler(kratkaGry_Click);
                    kratkiZListy.Add( new ModelKratki() { koordynatXKratki =i, koordynatYKratki = j, nazwaKratki = kratka.Name, wartoscKratki = "" });
                    listaDoResetu.Add(kratka);
                    Controls.Add(kratka);
                    _indexLicznik++;
                    Console.WriteLine($"{kratkiZListy[i].koordynatXKratki},{kratkiZListy[i].koordynatYKratki},{kratkiZListy[i].nazwaKratki},{kratkiZListy[i].wartoscKratki}");
                }
            }

        }

        private void SzerokoscUP_Click(object sender, EventArgs e)
        {
            szerokoscPolaGry++;
            IleNaIleLabel.Text = $"{szerokoscPolaGry} x {wysokoscPolaGry}";
        }
        private void SzerokoscDOWN_Click(object sender, EventArgs e)
        {
            szerokoscPolaGry--;
            IleNaIleLabel.Text = $"{szerokoscPolaGry} x {wysokoscPolaGry}";

        }

        private void WysokoscUP_Click(object sender, EventArgs e)
        {
            wysokoscPolaGry++;
            IleNaIleLabel.Text = $"{szerokoscPolaGry} x {wysokoscPolaGry}";

        }

        private void WysokoscDOWN_Click(object sender, EventArgs e)
        {
            wysokoscPolaGry--;
            IleNaIleLabel.Text = $"{szerokoscPolaGry} x {wysokoscPolaGry}";

        }
    }
}
