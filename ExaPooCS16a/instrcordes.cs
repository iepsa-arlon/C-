using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaPooCS16a
{
    public class instrcordes:instr
    {
        private uint nbcordes;

        public instrcordes() { this.air = false; }

        public instrcordes(instrcordes t_instrcordes):base(t_instrcordes)
        {
	        this.nbcordes = t_instrcordes.nbcordes;
        }

         override public void set_car(uint t_uint, bool t_bool = true)
         {
	         this.nbcordes = t_uint;
         }

         override public uint get_car(bool choix)
         {
	         return this.nbcordes;
         }

    }
}
