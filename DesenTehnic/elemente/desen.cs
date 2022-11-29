using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DesenTehnic
{
    public class desen 
    {
        public string denumiredesen = "";
        public grafica.graficaaplicatiei ga;
        public List<forme.formageometrica> formele = new List<forme.formageometrica>();
        public Form forma;

        public void load()
        {
            ga = new grafica.graficaaplicatiei(this.forma);
        }

        public void setForma( Form f)
        { 
             forma =  f;
        }

        public void drawDesen()
        {
            for (int i = 0; i < formele.Count; i++ )
            {

                ga.g.DrawLine(ga.p, formele[i].x, formele[i].y, formele[i].width - formele[i].x, formele[i].height-formele[i].y);
            }
        }
    }
}
