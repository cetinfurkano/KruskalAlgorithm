using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalAlgoritmasi
{
    public class Kumeleme_
    {
        private TopLinked topLinked;


        public List<Top> Toplar = new List<Top>();

        public List<int> Uzakliklar = new List<int>();
        public List<Top> kimden = new List<Top>();
        public List<Top> kime = new List<Top>();

        public List<Top> dolaskimden = new List<Top>();
        public List<Top> dolaskime = new List<Top>();
        public List<int> dolasuzaklik = new List<int>();

        public List<List<Top>> kumeler = new List<List<Top>>();



        private int index;

        public Kumeleme_()
        {
            topLinked = new TopLinked();
        }


        public void Temizle()
        {

            Toplar.Clear();

            kimden.Clear();
            kimden.Clear();
            kime.Clear();

            Uzakliklar.Clear();

            dolaskimden.Clear();
            dolaskime.Clear();
            dolasuzaklik.Clear();

            kumeler.Clear();

        }


        public void UzaklikOlc()
        {
            List<Top> gecici = new List<Top>();


            foreach (var item in Toplar)
            {
                gecici.Add(item);
            }

            for (int i = 0; i < gecici.Count; i++)
            {
                for (int j = 0; j < gecici.Count; j++)
                {
                    if (j <= i)
                    {
                        continue;
                    }

                    int uzaklik = Convert.ToInt32(Oklit(gecici[i], gecici[j]));

                    Uzakliklar.Add(uzaklik);
                    kimden.Add(gecici[i]);
                    kime.Add(gecici[j]);

                }
            }

        }

        public double Oklit(Top top1, Top top2)
        {
            double farkXKare = (top1.Left - top2.Left) * (top1.Left - top2.Left);
            double farkYKare = (top1.Top - top2.Top) * (top1.Top - top2.Top);

            double sonuc = Math.Sqrt(farkXKare + farkYKare);

            return sonuc;
        }

        public void UzakliklarHeap()
        {
            Heap h = new Heap();
            for (int i = 0; i < Uzakliklar.Count; i++)
            {
                h.Sort(Uzakliklar, kimden, kime);
            }

        }

        public void Dolas(int kumeSayisi)
        {
            foreach (var item in Toplar)
            {
                var gecici = new List<Top>();
                gecici.Add(item);
                kumeler.Add(gecici);
            }

            if (kumeler.Count == kumeSayisi)
            {
                return;
            }


            int j = 0;

            while (kumeler.Count > kumeSayisi)
            {
                topLinked.topId = kime[j].TopId;
                if (!topLinked.Dolas(kimden[j], kimden[j].TopId))
                {
                    dolaskimden.Add(kimden[j]);
                    dolaskime.Add(kime[j]);
                    dolasuzaklik.Add(Uzakliklar[j]);
                    topLinked.Ekle(kimden[j], kime[j], Uzakliklar[j]);


                    KumeyeEkle(kime[j], kimden[j]);
                }

                j++;
            }


        }

        public void KumeyeEkle(Top kime, Top kimden)
        {
            for (int i = 0; i < kumeler.Count; i++)
            {
                for (int j = 0; j < kumeler[i].Count; j++)
                {
                    if (kumeler[i][j].TopId == kime.TopId)
                    {
                        var liste = KimdeninOlduguListeyiGetir(kimden);
                        foreach (var item in liste)
                        {
                            if (!IceriyorMu(kumeler[i], item))
                            {
                                kumeler[i].Add(item);
                            }
                        }

                        kumeler.RemoveAt(index);
                        return;
                    }
                }

            }
        }

        public List<Top> KimdeninOlduguListeyiGetir(Top kimden)
        {
            for (int i = 0; i < kumeler.Count; i++)
            {
                for (int j = 0; j < kumeler[i].Count; j++)
                {
                    if (kumeler[i][j].TopId == kimden.TopId)
                    {
                        index = i;
                        return kumeler[i];
                    }
                }
            }

            return null;
        }


        public bool IceriyorMu(List<Top> liste, Top top)
        {
            foreach (var item in liste)
            {
                if (item.TopId == top.TopId)
                {
                    return true;
                }
            }

            return false;
        }


        public void TopSil(Top top)
        {
            Toplar.Remove(top);
        }

    }
}
