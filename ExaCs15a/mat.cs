using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaCs15a
{
    class mat
    {
        private string idmat;
        private bool typmat;

        public mat(bool t_typmat)
        {
	        this.typmat = t_typmat;
        }
        
        public mat(ref mat t_mat)
        {
            this.idmat = t_mat.idmat;
            this.typmat = t_mat.typmat;
        }

        public mat(ref mot t_mot)
        {          
            this.idmat = t_mot.idmat;
            this.typmat = t_mot.typmat;
        }

        public mat(ref nonmot t_nonmot)
        {
            this.idmat = t_nonmot.idmat;
            this.typmat = t_nonmot.typmat;
        }

        ~mat()
        {
        }

        public void set_idmat(string t_idmat)
        {
	        this.idmat = t_idmat;
        }

        public string get_idmat()
        {
	        return this.idmat;
        }

        public bool get_typmat()
        {
	        return this.typmat;
        }
    }
}
