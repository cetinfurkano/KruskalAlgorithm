using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruskalAlgoritmasi
{
    public class Heap
    {
        private static int n;

        private int Left(int i)
        {
            return (2 * i) + 1;
        }

        private int Right(int i)
        {
            return (2 * i) + 2;
        }

       
        public void Sort(List<int> liste,List<Top> kimden, List<Top> kime)
        {
            n = liste.Count - 1;

            Heapify(liste,kimden,kime); // O(n) tüm diziyi düzenle
            // tüm sort işlemi => O(n log(n))

            for (int i = n; i >= 0; i--)
            {
                int temp = liste[0];
                liste[0] = liste[i];
                liste[i] = temp;

                Top temp1 = kimden[0];
                kimden[0] = kimden[i];
                kimden[i] = temp1;

                Top temp2 = kime[0];
                kime[0] = kime[i];
                kime[i] = temp2;

                n = n - 1;
                heap(liste, kimden, kime, 0);
            }
        }

        private void Heapify(List<int> liste, List<Top> kimden, List<Top> kime)
        {
            for (int i = n; i >= 0; i--) heap(liste, kimden,kime, i); // her heap sorgusu => O (log(n))
        }

        private void heap(List<int> liste,List<Top> kimden,List<Top> kime, int i)
        {
            int left = Left(i); // şuanki indisin sol çocuğu
            int right = Right(i); // şuanki indisin sağ çocuğunun indisi
            int largest = i; // kendisini büyükmüş gibi görüyoruz

            if ((left <= n) && (liste[left] > liste[largest])) // sol çocuğu büyükse en büyük sol oluyor
                largest = left;

            if ((right <= n) && (liste[right] > liste[largest])) // sağ ile büyüğü karşılaştırıyoruz
                largest = right; // büyükse en büyük sağ çocuk oluyor

            if (largest != i) // iki indis aynı olana kadar
            {
                // indisler arası değiştirme, swap işlemi yapıyoruz
                int temp = liste[i];
                liste[i] = liste[largest];
                liste[largest] = temp;

                Top temp1 = kimden[i];
                kimden[i] = kimden[largest];
                kimden[largest] = temp1;

                Top temp2 = kime[i];
                kime[i] = kime[largest];
                kime[largest] = temp2;

                heap(liste,kimden,kime, largest); // değiştirilen indisleri kontrol ediyoruz
            }
        }

        
    }
}
