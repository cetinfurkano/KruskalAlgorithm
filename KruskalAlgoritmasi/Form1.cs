using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace KruskalAlgoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color[] dizi = { Color.Blue, Color.Black, Color.Red, Color.Green, Color.DarkMagenta, Color.BlueViolet, Color.LightSeaGreen, Color.Coral, Color.Gold, };

        Kumeleme_ kumeleme = new Kumeleme_();

        private bool hareket = false;
        private Point ilkKonum;
        int k = 0;



        private bool oncedenOlusturulduMu = false;



        private void btnRastgeleNokta_Click(object sender, EventArgs e)
        {
            Graphics g = grbToplar.CreateGraphics();
            TopOlustur(g, Convert.ToInt16(textBox1.Text));
        }


        public void TopOlustur(Graphics g, int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                Random r = new Random();
                int x = r.Next(grbButonlar.Width, grbToplar.Width);
                int y = r.Next(grbButonlar.Height);

                if (!uzerineBiniyorMu(x, y))
                {
                    Top top = new Top();
                    top.Top = y;
                    top.Left = x;
                    top.TopId = k;
                    top.DoubleClick += Top_DoubleClick;
                    top.MouseDown += Top_MouseDown;
                    top.MouseUp += Top_MouseUp;
                    top.MouseMove += Top_MouseMove;
                    grbToplar.Controls.Add(top);
                    kumeleme.Toplar.Add(top);
                    k++;
                }
                else
                {
                    i--;
                }

                Thread.Sleep(50);

            }
        }
        
        private void Top_MouseMove(object sender, MouseEventArgs e)
        {
            Top yeni = (Top)sender;

            if (hareket)
            {
                yeni.Left = e.X + yeni.Left - (ilkKonum.X);
                yeni.Top = e.Y + yeni.Top - (ilkKonum.Y);
            }
        }

        private void Top_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }

        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            ilkKonum = e.Location;
        }

        private void Top_DoubleClick(object sender, EventArgs e)
        {
            Top yeni = (Top)sender;
            grbToplar.Controls.Remove(yeni);
            kumeleme.TopSil(yeni);
        }


        public bool uzerineBiniyorMu(int x, int y)
        {
            foreach (Control item in grbToplar.Controls)
            {
                if (item.Top == y && item.Left == x)
                {
                    return true;
                }

            }

            return false;
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nmKumeSayisi.Value) == 0)
            {
                MessageBox.Show("Lütfen küme sayısını belirtin", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(nmKumeSayisi.Value) > kumeleme.Toplar.Count)
            {
                MessageBox.Show("Küme sayısı top sayısından fazla olamaz", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!oncedenOlusturulduMu)
            {
                kumeleme.UzaklikOlc();
                kumeleme.UzakliklarHeap();
                kumeleme.Dolas(Convert.ToInt32(nmKumeSayisi.Value));


                for (int i = 0; i < kumeleme.kumeler.Count; i++)
                {
                    var renk = dizi[i];

                    for (int j = 0; j < kumeleme.kumeler[i].Count; j++)
                    {
                        kumeleme.kumeler[i][j].BackColor = renk;
                    }
                }

                IstatistikNokta();

                Form2 f = new Form2(kumeleme);
                f.Show();

                oncedenOlusturulduMu = true;
                return;
            }

            if (oncedenOlusturulduMu)
            {
                MessageBox.Show("Tekrar oluşturabilmeniz için hepsini silmeniz gerekir.", "Bilgilendirme",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        public void IstatistikNokta()
        {
            int toplamTopSayisi = 0;

            string[,] mesajListesi = new string[kumeleme.kumeler.Count, 3];
            int[] kumelerdekiNoktaSayilari = new int[kumeleme.kumeler.Count];
            int[,] kumelerinOrtaNoktalari = new int[kumeleme.kumeler.Count, 2];

            List<Top> gecici = new List<Top>();

            for (int i = 0; i < kumeleme.kumeler.Count; i++)
            {
                kumelerdekiNoktaSayilari[i] = kumeleme.kumeler[i].Count;

                for (int j = 0; j < kumeleme.kumeler[i].Count; j++)
                {
                    gecici.Add(kumeleme.kumeler[i][j]);
                    toplamTopSayisi++;
                }
                OrtaNoktaHesapla(kumelerinOrtaNoktalari, gecici, i);
                gecici.Clear();
            }

           for (int i = 0; i < kumeleme.kumeler.Count; i++)
            {
                mesajListesi[i, 0] = String.Format("{0}. Küme ", i + 1);
                mesajListesi[i, 1] = String.Format("Nokta Sayisi: {0} ", kumelerdekiNoktaSayilari[i]);
                mesajListesi[i, 2] = String.Format("Orta Noktası X:{0}, Y:{1} ", kumelerinOrtaNoktalari[i, 0], kumelerinOrtaNoktalari[i, 1]);

                OrtaNokta orta = new OrtaNokta();
                orta.BackColor = kumeleme.kumeler[i][0].BackColor;
                orta.Width = 15;
                orta.Height = 15;
                orta.Left = kumelerinOrtaNoktalari[i, 0];
                orta.Top = kumelerinOrtaNoktalari[i, 1];
                grbToplar.Controls.Add(orta);

            }

            for (int i = 0; i < mesajListesi.GetLength(0); i++)
            {
                for (int j = 0; j < mesajListesi.GetLength(1); j++)
                {
                    lstIstatistik.Items.Add(mesajListesi[i, j]);
                }
            }
            
        }

        public void OrtaNoktaHesapla(int[,] veriEklemeYeri, List<Top> topListesi, int i)
        {
            int x = 0;
            int y = 0;

            foreach (var item in topListesi)
            {
                x += item.Left;
                y += item.Top;
            }

            int mx = x / topListesi.Count;
            int my = y / topListesi.Count;
            veriEklemeYeri[i, 0] = mx;
            veriEklemeYeri[i, 1] = my;

        }



        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            nmKumeSayisi.Value = 0;
            grbToplar.Controls.Clear();
            lstIstatistik.Items.Clear();
            kumeleme.Temizle();
            oncedenOlusturulduMu = false;
            k = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Eklenilen topların üzerine çift tıklarsanız silinir.", "Bilgilendirme",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
