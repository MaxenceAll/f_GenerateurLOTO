using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_GenerateurLOTO
{
    internal class Objet
    {

        // Attributes
        //////////////
        private String nomObjet;
        private int numero;

        // Constructor
        //////////////
        public Objet(String nomObjetATirer, int numero)
        {
            this.nomObjet = nomObjetATirer;
            this.numero = numero;
        }


        // Getters Setters
        ///////////////////
        public String getNomObjet()
        {
            return nomObjet;
        }

        // To String
        /////////////
        public string toString()
            {
                return nomObjet + "(" + numero + ")";
            }

    }
}
