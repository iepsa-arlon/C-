using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaPOOCs17a
{
    class para : cit
    {
        private	uint L, H, l;


        public para() : base(3)
        {

        }

        public para(para r_para)
            : base(r_para)
        {
            this.L = r_para.L;
            this.H = r_para.H;
            this.l = r_para.l;
        }

        public void set_L(uint t_L)
        {
	        this.L = t_L;
        }

        public uint get_L()
        {
	        return this.L;
        }

        public void set_H(uint t_H)
        {
	        this.H = t_H;
        }

        public uint get_H()
        {
	        return this.H;
        }

        public void set_l(uint t_l)
        {
	        this.l = t_l;
        }

        public uint get_l()
        {
	        return this.l;
        }


        public override void calc_vol()
        {
	        this.vol = this.L * this.H * this.l;
        }

        public override void introdim(uint t_L, uint t_H, uint t_l)
        {
	         this.set_L(t_L);
	         this.set_H(t_H);
	         this.set_l(t_l);
        }

        public override uint recudim(int dim)
        {
	        if (dim == 1) return this.L;
	        if (dim == 2) return this.H;
	        else return this.l;
        }


    }
}
