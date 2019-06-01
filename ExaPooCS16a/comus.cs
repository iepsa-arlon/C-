using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ExaPooCS16a
{
    public class comus
    {
        private string idcom;				// identifiant du commerce
	    private uint nbempl;		// nombre d'employés
	    private List <instr> Tabinstr;	// déclaration du tableau de pointeurs d'instruments polymorphiques

        public comus()
        {
            this.Tabinstr = new List <instr>();
        }

        public comus(comus t_comus)
        {
            this.idcom = t_comus.idcom;
            this.nbempl = t_comus.nbempl;

            this.Tabinstr = new List<instr>(t_comus.tabinst_size());
            for (int x = 0; x < this.tabinst_size(); x++)
            {
                if (t_comus.get_instr(x).get_air() == true) this.Tabinstr[x] = new instrair((instrair)t_comus.get_instr(x));
                else this.Tabinstr[x] = new instrcordes((instrcordes)t_comus.get_instr(x));
            }
        }

        ~comus() { this.Tabinstr.Clear(); }

        public void set_idcom(string t_idcom) { this.idcom = t_idcom; }
        public void set_nbempl(uint t_nbempl) { this.nbempl = t_nbempl; }

        public string get_idcom() { return this.idcom; }
        public uint get_nbempl() { return this.nbempl; }

        public void add_instr(instrair t_instr)	// ajout d'un instrument au tableau des instruments à air
        {
            this.Tabinstr.Add(new instrair(t_instr));	// ligature dynamique d'agrégation
        }

        public void add_instr(instrcordes t_instr)
        {
             this.Tabinstr.Add(new instrcordes(t_instr));
        }

        public instr get_instr(int indice)	// récupère un instrument au sein du tableau d'instruments
        {
            if (indice >= 0 && indice <= this.Tabinstr.Count) return this.Tabinstr[indice];
            else
            {
                IndexOutOfRangeException excpt = new IndexOutOfRangeException("Indice hors limites du tableau");
                throw excpt;
            }
        }

        public int tabinst_size()		// récupère la taille du tableau d'instruments 
        {
	        return this.Tabinstr.Count;
        }

    }
}
