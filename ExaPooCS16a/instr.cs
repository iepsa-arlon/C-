using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaPooCS16a
{
    public class instr
    {
        private string idinstr;		// identifiant de l'instrument
	    private uint prix;	// prix

        protected bool air;		// instrument à air si true

        public instr() { }

        public instr(instr t_instr)
        {
	        this.air = t_instr.air;
	        this.idinstr = t_instr.idinstr;
	        this.prix = t_instr.prix;
        }

        public void set_idinstr(string t_idinstr) { this.idinstr = t_idinstr;}
        public void set_prix(uint t_prix) { this.prix = t_prix; }


        public string get_idinstr() { return this.idinstr; }
        public uint get_prix() { return this.prix; }
        public bool get_air() { return this.air; }

        virtual public void set_car(uint t_uint, bool t_bool = true) { }
        virtual public uint get_car(bool choix = true) { return 0; }
    }
}
