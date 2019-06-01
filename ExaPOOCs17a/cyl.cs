using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaPOOCs17a
{
    class cyl : cit
    {
        private	uint L, D;

        public cyl() : base(2)
        {

        }

        public cyl(cyl r_cyl)
            : base(r_cyl)
        {
            this.L = r_cyl.L;
            this.D = r_cyl.D;
        }

        public void set_L(uint t_L)
        {
	        this.L = t_L;
        }

        public uint get_L()
        {
	        return this.L;
        }

        public void set_D(uint t_D)
        {
	        this.D = t_D;
        }

        public uint get_D()
        {
	        return this.D;
        }

        public override void calc_vol()
        {
	        this.vol = this.D/2 * this.D/2 * (float)3.14 * this.L;
        }

        public override void introdim(uint t_L, uint t_D, uint a)
        {
	         this.set_L(t_L);
	         this.set_D(t_D);
        }

        public override uint recudim(int dim)
        {
	        if (dim == 1) return this.L;
	        else return this.D;
        }

    }
}
