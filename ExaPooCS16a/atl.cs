using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaPooCS16a
{
    public partial class atlg:agromat
    {
        private	uint nbess;	// nombre d'essieux
	    private bool frein;			// freinée

        public atlg() { this.trac = false; }
	    public atlg(atlg t_atlg):base(t_atlg) 
        { 
            this.nbess = t_atlg.nbess;
	        this.frein = t_atlg.frein;
        }

        public override void set_var(uint t_nbess) { this.nbess = t_nbess; }	        // méthode polymorphique
        public override void set_var(bool t_frein) { this.frein = t_frein; }			// méthode polymorphique surchargée
        public override uint get_var() { return this.nbess; }	                    // méthode polymorphique renvoyant "nbess"
        public override bool get_var(bool x) { return this.frein; }			    // méthode polymorphique renvoyant "frein"
        public override void calcfc() { this.factcout = 9 * this.nbess; }				        // méthode polymorphique de calcul du facteur de coût
    }
}
