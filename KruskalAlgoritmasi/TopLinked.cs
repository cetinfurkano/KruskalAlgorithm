using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KruskalAlgoritmasi
{
    public class TopLinked
    {

        public int topId;

        public void Ekle(Top kimden, Top kime, int uzaklik)
        {

            kimden.next.Add(kime);
            kimden.x.Add(uzaklik);
            kime.prev.Add(kimden);

        }

       
        public bool Dolas(Top top, int id)
        {
            bool basarili = false;

            if (top.TopId == topId || id == topId)
            {
                basarili = true;
                return basarili;
            }

            if (top.next.Count > 0)
            {
                for (int i = 0; i < top.next.Count; i++)
                {
                    if (top.next[i].TopId == id)
                    {
                        continue;
                    }

                    if (Dolas(top.next[i], top.TopId))
                    {
                        basarili = true;
                        return basarili;
                    }
                }
            }

            if (top.prev.Count > 0)
            {
                for (int i = 0; i < top.prev.Count; i++)
                {
                    if (top.prev[i].TopId == id)
                    {
                        continue;
                    }

                    if (Dolas(top.prev[i], top.TopId))
                    {
                        basarili = true;
                        return basarili;
                    }
                }
            }

            return basarili;
        }
    }

}
