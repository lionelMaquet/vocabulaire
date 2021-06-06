using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammation
{
    public class Mot
    {
        public int num_mot;
        public string langue_fr;
        public string traduction;
        public int num_serie;
        public int nombre_reussi;
        public int nombre_rate;

        public int getStats()
        {
            return nombre_reussi + nombre_rate != 0 ? (int)(((float)nombre_reussi / ((float)nombre_reussi + (float)nombre_rate)) * 100) : 100;
        }
    }
}
