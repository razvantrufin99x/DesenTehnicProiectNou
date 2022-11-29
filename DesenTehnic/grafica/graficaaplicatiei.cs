using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DesenTehnic.grafica
{
    public class graficaaplicatiei
    {
        public Graphics g;
        public Font f;
        public Brush b;
        public Pen p;
        public Form frm;

        public  graficaaplicatiei (Form pfrm)
        {
            frm = pfrm;
            g = frm.CreateGraphics();
            f = frm.Font;
            b = new SolidBrush(Color.Black);
            p = new Pen(Color.Black);

            
        }
    }
}
