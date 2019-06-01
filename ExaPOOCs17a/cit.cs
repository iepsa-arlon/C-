using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaPOOCs17a
{
    abstract class cit
    {
        private	uint typcit;
	    private bool typcarb;

        protected float vol;

        public cit(uint t_typcit)
        {
	        this.typcit = t_typcit;
        }

        public cit(cit r_cit)
        {
            this.typcit = r_cit.typcit;
            this.typcarb = r_cit.typcarb;
            this.vol = r_cit.vol;
        }

        public uint get_typcit()
        {
	        return this.typcit;
        }

        public void set_typcarb(bool t_typcarb)
        {
	        this.typcarb = t_typcarb;
        }

        public bool get_typcarb()
        {
	        return this.typcarb;
        }


        public float get_vol()
        {
	        return this.vol;
        }

        public virtual void calc_vol()
        {

        }

        public virtual void introdim(uint a, uint b = 1, uint c = 2)
        {

        }

         public virtual uint recudim(int a)
        {
	        return 0;
        }

    }
}
