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
            //System.out.println("Vous jouez au " + super.getNom() + "-" + this.getNom() + " :");
            Tireuse tireuse1 = new Tireuse(tabObjet1, this.nomObjet1, nbTirageGodetObjet1);
            tireuse1.tirer();
            Tireuse tireuse2 = new Tireuse(tabObjet2, this.nomObjet2, nbTirageGodetObjet2);
            tireuse2.tirer();
        }

    }
}
