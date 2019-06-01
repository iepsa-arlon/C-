using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaPooCS16a
{
    public class instrair:instr
    {
        private	uint nbtouches;
	    private bool soufflet;

        public instrair() { this.air = true; }
        
        public instrair(instrair t_instrair):base(t_instrair)
        {
	        this.nbtouches = t_instrair.nbtouches;
	        this.soufflet = t_instrair.soufflet;
        }

        override public void set_car(uint t_uint, bool t_bool)
        {
	        this.nbtouches = t_uint;
	        this.soufflet = t_bool;
        }

        override public uint get_car(bool choix)
        {
	        if(choix) return this.nbtouches;	// si choix à true, renvoie le nombre de touches
	        if(this.soufflet) return 1;		// renvoie valeur non nulle si soufflet à "true"
	        else return 0;						// renvoie valeur nulle si soufflet à "false"
        }

    }
}
