using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KruskalAlgoritmasi
{
    public partial class Top : UserControl
    {
        GraphicsPath path = new GraphicsPath();

      
        public int TopId { get; set; }
        public List<Top> next = new List<Top>();
        public List<Top> prev = new List<Top>();
        public List<int> x = new List<int>();


        public Top()
        {
            InitializeComponent();
            path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new Region(path);

            this.BackColor = SystemColors.ControlDarkDark;
        }

        private void FindWord_Resize(object sender, EventArgs e)
        {
            path.Reset();

            if (this.Region != null)
            {
                this.Region.Dispose();
                this.Region = null;
            }

            path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new Region(path);
        }

    }
}
