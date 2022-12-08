using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_GenerateurLOTO
{
    internal class Classique : Loto
    {

        // Attributes (AKA rules) :
        ////////////////////////////
        private String nomSousJeu = "Classique";

        private String nomObjet1 = "boule";
        private int nbTirageGodetObjet1 = 6;
        private int tailleGodetObjet1 = 49;
        private List<Objet> tabObjet1;

        private String nomObjet2 = "boule(c)";
        private int nbTirageGodetObjet2 = 1;
        private int tailleGodetObjet2 = 49;
        private List<Objet> tabObjet2;

        private int nombreTirageTotal = 2;

        // Constructor
        //////////////
        public Classique()
        {
            this.tabObjet1 = new List<Objet>();
            for (int i = 1; i <= tailleGodetObjet1; i++)
            {
                tabObjet1.Add(new Objet(nomObjet1, i));
            }
            this.tabObjet2 = new List<Objet>();
            for (int i = 1; i <= tailleGodetObjet2; i++)
            {
                tabObjet2.Add(new Objet(nomObjet2, i));
            }
        }
        // Getters Setters
        ///////////////////
        public String getNom()
        {
            return nomSousJeu;
        }

        // Methods
        ///////////
        public void tirer()
        {
            tirageForm tirage = new tirageForm();
            tirage.Show(); tirage.labelJeu.Text = ("Vous jouez au " + base.getNom() + "-" + this.getNom() + " :");

            switch (nombreTirageTotal)
            {
                case 1: 
                    tirage.groupBox1.Visible = true; 
                    tirage.labelTirage.Visible = true;
                    break;
                case 2: 
                    tirage.groupBox1.Visible = true;    tirage.groupBox2.Visible = true;
                    tirage.labelTirage.Visible = true;  tirage.labelTirage2.Visible = true;
                    break;
                case 3:
                    tirage.groupBox1.Visible = true;    tirage.groupBox2.Visible = true;    tirage.groupBox3.Visible = true; 
                    tirage.labelTirage.Visible = true;  tirage.labelTirage2.Visible = true; tirage.labelTirage3.Visible = true;
                    break;
                case 4:
                    tirage.groupBox1.Visible = true;    tirage.groupBox2.Visible = true;    tirage.groupBox3.Visible = true;    tirage.groupBox4.Visible = true;
                    tirage.labelTirage.Visible = true;  tirage.labelTirage2.Visible = true; tirage.labelTirage3.Visible = true; tirage.labelTirage4.Visible = true;
                    break;
                default: break;                     
            }

            Tireuse tireuse1 = new Tireuse(tabObjet1, this.nomObjet1, nbTirageGodetObjet1);           
            tirage.labelTirage.Text = tireuse1.tirer();
            tirage.groupBox1.Text = "Tirage de " + nbTirageGodetObjet1 + " " + nomObjet1 + " parmi " + tailleGodetObjet1;

            Tireuse tireuse2 = new Tireuse(tabObjet2, this.nomObjet2, nbTirageGodetObjet2);
            tirage.labelTirage2.Text = tireuse2.tirer();
            tirage.groupBox2.Text = "Tirage de " + nbTirageGodetObjet2 + " " + nomObjet2 + " parmi " + tailleGodetObjet2;
        }

    }
}
