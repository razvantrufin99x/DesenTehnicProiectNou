using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesenTehnic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        desentehnic desenultehnic = new desentehnic();



        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creaza proiect

            desenultehnic.proiecte.Add(new proiect());
            desenultehnic.proiecte[0].denumireproiect = "schema tehnica ";

            //creaza document in proiect
            desenultehnic.proiecte[0].documente.Add(new document());

            //creaza desen in proiect
            desenultehnic.proiecte[0].documente[0].desene.Add(new desen());
            desenultehnic.proiecte[0].documente[0].desene[0].denumiredesen = "alfa";

            //adauga date despre autorul proiectului
            desenultehnic.proiecte[0].autori.Add(new users.autor());
            desenultehnic.proiecte[0].autori[0].nume = "a";
            desenultehnic.proiecte[0].autori[0].prenume = "b";
            desenultehnic.proiecte[0].autori[0].datecontact = "d";

            //adauga forme in desenul[0] proiectului
            desenultehnic.proiecte[0].documente[0].desene[0].formele.Add(new forme.formageometrica());
            desenultehnic.proiecte[0].documente[0].desene[0].formele[0].x = 100;
            desenultehnic.proiecte[0].documente[0].desene[0].formele[0].y = 200;
            desenultehnic.proiecte[0].documente[0].desene[0].formele[0].width = 100;
            desenultehnic.proiecte[0].documente[0].desene[0].formele[0].height = 50;

            //afiseaza desenul[0].formele in form selected
            desenultehnic.proiecte[0].documente[0].desene[0].setForma(this);
            desenultehnic.proiecte[0].documente[0].desene[0].load();
            desenultehnic.proiecte[0].documente[0].desene[0].drawDesen();
        }
    }
}
