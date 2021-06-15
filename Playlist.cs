using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammation
{
    public class Playlist
    {
        public List<Resultat> resultats = new List<Resultat>();
        public Serie serie;
        public int nombreReussis = 0;
        public int nombreRates = 0;
        public int nombreMots;
        public int currentMotIndex = 0;
        public bool isActive = true;
        public bool versFr = false;
    }
}
