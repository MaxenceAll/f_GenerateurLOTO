using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_GenerateurLOTO
{
    internal class Tireuse
    {

        // Attributes
        //////////////
        private List<Objet> godetATirer;
        private List<Objet> godetTire;
        private String nomObjet;
        private int nbTirageGodet;
        private int tailleGodet;        

        // Constructor
        //////////////
        public Tireuse(List<Objet> godetATirer, String nomObjet, int nbTirageGodet)
        {
            this.godetTire = new List<Objet>();
            this.godetATirer = godetATirer;
            this.nomObjet = nomObjet;
            this.nbTirageGodet = nbTirageGodet;
            this.tailleGodet = godetATirer.Count;
        }

        // Getters Setters
        ///////////////////

        // Methods
        ///////////
        public string tirer()
        {
            Random randomizer = new Random();

            for (int i = 0; i < nbTirageGodet; i++)
            {
                int aTirer = randomizer.Next(tailleGodet)-1;
                godetTire.Add(godetATirer[aTirer]);
                godetATirer.RemoveAt(aTirer);
            }

            //MessageBox.Show("Tirage de " + nbTirageGodet + " " + nomObjet + " parmi " + tailleGodet);
            //msgBox.afficherInfo(godetTire.toString(), "Tirage effectué !!!");
            string str = "";
            for (int i = 0; i < godetTire.Count; i++)
            {
                str += "Tirage " + i + " = " + godetTire[i].toString() +"\n";
            }
            //MessageBox.Show(str);
            return str;
        }

        // To String
        /////////////	

    }
}
