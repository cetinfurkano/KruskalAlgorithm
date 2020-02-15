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
    public partial class OrtaNokta : UserControl
    {
        
        public OrtaNokta()
        {
            InitializeComponent();
            this.Size = new Size(324, 36);
            this.Location = new Point(0, 16);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.FillRectangle(brush, new Rectangle(this.Location, this.Size));
        }
    }
}
