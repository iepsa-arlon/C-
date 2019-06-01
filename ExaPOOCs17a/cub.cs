using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaPOOCs17a
{
    class cub : cit
    {
        private	uint C;

        public cub() : base(1)
        {

        }

        public cub(cub r_cub)
            :base(r_cub)
        {
            this.C = r_cub.C;
        }

        public void set_C(uint t_C)
        {
	        this.C = t_C;
        }

        public uint get_C()
        {
	        return this.C;
        }

        public override void calc_vol()
        {
	        this.vol = this.C * this.C * this.C;
        }

        public override void introdim(uint t_C, uint a, uint b)
        {
	        this.set_C(t_C);
        }

        public override uint recudim(int a)
        {
	        return this.C;
        }

    }
}
