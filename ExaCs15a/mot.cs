using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaCs15a
{
    class mot:mat
    {
        private uint nbh;

        public mot(bool t_typmat)
            : base(t_typmat)
        {
        }

        public mot(ref mot t_mot)
            : base(ref t_mot)
        {
            this.nbh = t_mot.nbh;
        }

        ~mot()
        {
        }

        public void set_nbh(uint t_nbh)
        {
	        this.nbh = t_nbh;
        }

        public uint get_nbh()
        {
	        return this.nbh;
        }
    }
}
