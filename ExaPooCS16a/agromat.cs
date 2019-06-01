using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaPooCS16a
{
    public abstract class agromat
    {
        private	uint poidsmax;		// poids maximum du véhicule
        protected uint factcout;	// facteur de coût du véhicule
        protected bool trac;		// tracteur ou attelage

        public agromat() {}		// constructeur standard
	    public agromat(agromat t_agromat)	// constructeur par copie
        {
            this.poidsmax = t_agromat.poidsmax;
	        this.factcout = t_agromat.factcout;
	        this.trac = t_agromat.trac;
        }

    // mutateurs standards	
        public void set_poidsmax(uint t_poidsmax) { this.poidsmax = t_poidsmax; }

    // accesseurs standards
        public uint get_poidsmax() { return this.poidsmax; }
        public uint get_factcout() { return this.factcout; }
        public bool get_tract() { return this.trac; }

    // signature des méthodes virtuelles
        public virtual void set_var(uint x) { }// méthode polymorphique responsable du caractère abstrait de la classe
        public virtual void set_var(bool x) { }			// méthode polymorphique surchargée
        public virtual uint get_var() { return 0; }	// méthode polymorphique
        public virtual bool get_var(bool x) { return false; }			// méthode polymorphique surchargée
        public virtual void calcfc() { }				// méthode polymorphique de calcul du facteur de coût

    }
}
