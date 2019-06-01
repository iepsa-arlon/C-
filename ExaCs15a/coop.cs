using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExaCs15a
{
    class coop
    {
        private string idcoop;
	    private uint typcult;
	    private mot [] tabmot;
	    private nonmot [] tabnonmot;

        public coop()
        {
            Array.Resize(ref tabmot,0);
            Array.Resize(ref tabnonmot,0);
        }

        public coop(ref coop t_coop)
        {
            this.idcoop = t_coop.idcoop;
            this.typcult = t_coop.typcult;

            Array.Resize(ref this.tabmot, t_coop.tabmot.Length);
            Array.Resize(ref this.tabnonmot, t_coop.tabnonmot.Length);

            for(uint x = 0; x < t_coop.tabmot.Length; x++) this.tabmot[x] = new mot(ref t_coop.tabmot[x]);
            for(uint x = 0; x < t_coop.tabnonmot.Length; x++) this.tabnonmot[x] = new nonmot(ref t_coop.tabnonmot[x]);
        }

        ~coop()
        {
            try
            {
                Array.Clear(this.tabmot, 0, tabmot.Length);
                Array.Clear(this.tabmot, 0, tabnonmot.Length);
            }
            catch (Exception)
            { 
            }
        }

        public void set_idcoop(string t_idcoop)
        {
	        this.idcoop = t_idcoop;
        }

        public string get_idcoop()
        {
	        return this.idcoop;
        }

        public void set_typcult(uint t_typcult)
        {
	        this.typcult = t_typcult;
        }

        public uint get_typcult()
        {
	        return this.typcult;
        }

        public void add_mot(mot t_mot)
        {
	        Array.Resize(ref this.tabmot, this.tabmot.Length + 1);
            this.tabmot[this.tabmot.Length - 1] = new mot(ref t_mot);
        }

        public mot view_mot(uint id)
        {
            IndexOutOfRangeException e;

	        if(id < this.tabmot.Length) return this.tabmot[id];
	        else throw e = new IndexOutOfRangeException("Index invalide");
        }

        public void add_nonmot(nonmot t_nonmot)
        {
	        Array.Resize(ref this.tabnonmot, this.tabnonmot.Length + 1);
            this.tabnonmot[this.tabnonmot.Length - 1] = new nonmot(ref t_nonmot);
        }

        public nonmot view_nonmot(uint id)
        {
            IndexOutOfRangeException e;

	        if(id < this.tabnonmot.Length) return this.tabnonmot[id];
	        else throw e = new IndexOutOfRangeException("Index invalide");
        }

        public uint tab_size(bool choix)
        {
	        if(choix) return (uint) this.tabmot.Length;
	        else return (uint) this.tabnonmot.Length;
        }

    }
}
