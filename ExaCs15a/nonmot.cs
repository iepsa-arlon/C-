using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaCs15a
{
    class nonmot:mat
    {
        private string datach;

        public nonmot(bool t_typmat)
            : base(t_typmat)
        {
        }

        public nonmot(ref nonmot t_nonmot)
            : base(ref t_nonmot)
        {
            this.datach = t_nonmot.datach;
        }

        ~nonmot()
        {
        }

        public void set_datach(string t_datach)
        {
	        this.datach = t_datach;
        }

        public string get_datach()
        {
	        return this.datach;
        }

    }
}
