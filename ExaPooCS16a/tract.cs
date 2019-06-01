using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaPooCS16a
{
    public partial class tract:agromat
    {
        private	uint pmot;	//puissance moteur
        public tract() { this.trac = true; }
        public tract(tract t_tract):base(t_tract) { this.pmot = t_tract.pmot; }

        public override void set_var(uint t_uint) { this.pmot = t_uint; }	// méthode polymorphique
        public override uint get_var() { return this.pmot; }	            // méthode polymorphique
        public override void calcfc() { this.factcout = 2 * this.pmot; }				// méthode polymorphique de calcul du facteur de coût
    }
}
