using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaPooCS16a
{
    public partial class coop
    {
        private string idcoop;
        private uint nbouv;
        private agromat[] tabmat;

        public coop() { Array.Resize(ref this.tabmat, 0); }

        public coop(coop t_coop)
        {
            Array.Resize(ref tabmat, t_coop.tabmat_size());
            for (int x = 0; x < t_coop.tabmat_size(); x++)
            {
                if (t_coop.tabmat[x].get_tract() == true) this.tabmat[x] = new tract((tract) t_coop.tabmat[x]);
                else this.tabmat[x] = new atlg((atlg) t_coop.tabmat[x]);
            }
        }

        ~coop() { Array.Clear(this.tabmat, 0, this.tabmat.Length); }

        public void set_idcoop(string t_idcoop) { this.idcoop = t_idcoop; }
        public void set_nbouv(uint t_nbouv) { this.nbouv = t_nbouv; }
        public string get_idcoop() { return this.idcoop; }
        public uint get_nbouv() { return this.nbouv; }

        public void add_mat(agromat t_agromat)
        {
            Array.Resize(ref this.tabmat, this.tabmat.Length + 1);
            if (t_agromat.get_tract() == true) this.tabmat[this.tabmat.Length - 1] = new tract((tract)t_agromat);
            else this.tabmat[this.tabmat.Length - 1] = new atlg((atlg)t_agromat);
        }

        public agromat get_mat(int indice) 
        { 
            if(indice >= 0  && indice < this.tabmat.Length) return this.tabmat[indice];
            else
            {
                IndexOutOfRangeException exc = new IndexOutOfRangeException("Indice hors limites");
                throw exc;
            } 
        }

        public int tabmat_size() { return this.tabmat.Length; }
    }
}
