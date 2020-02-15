using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KruskalAlgoritmasi
{
    public partial class Form2 : Form
    {
        private Kumeleme_ kumeleme;
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();

        public Form2(Kumeleme_ kumeleme)
        {
            this.kumeleme = kumeleme;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Top1", typeof(int));
            tablo.Columns.Add("Top2", typeof(int));
            tablo.Columns.Add("Uzaklık", typeof(int));

            tablo2.Columns.Add("Top1", typeof(int));
            tablo2.Columns.Add("Top2", typeof(int));
            tablo2.Columns.Add("Uzaklık", typeof(int));

           

            for (int i = 0; i < kumeleme.kimden.Count; i++)
            {
                tablo2.Rows.Add(kumeleme.kimden[i].TopId, kumeleme.kime[i].TopId, kumeleme.Uzakliklar[i]);
            }

            

            for (int i = 0; i < kumeleme.dolaskimden.Count; i++)
            {
                tablo.Rows.Add(kumeleme.dolaskimden[i].TopId, kumeleme.dolaskime[i].TopId, kumeleme.dolasuzaklik[i]);
            }


            dataGridView2.DataSource = tablo2;
            dataGridView1.DataSource = tablo;
        }

        
    }
}
