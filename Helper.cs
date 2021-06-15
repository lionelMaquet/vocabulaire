using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammation
{
    static public class Helper
    {
        static public Playlist MakePlaylist(Serie serie, bool versFr)
        {
            Playlist newPlaylist = new Playlist();
            List<Mot> motsPlaylist = DBConnector.getWords(serie);
            foreach(Mot m in motsPlaylist)
            {
                Resultat newResultat = new Resultat();
                newResultat.mot = m;
                newPlaylist.resultats.Add(newResultat);
            }
            newPlaylist.nombreMots = motsPlaylist.Count();
            newPlaylist.serie = serie;
            newPlaylist.versFr = versFr;

            return newPlaylist;
        }

        static public Playlist ResetPlaylist(Playlist playlist)
        {
            playlist.nombreRates = 0;
            playlist.nombreReussis = 0;
            foreach(Resultat r in playlist.resultats)
            {
                r.answeredRight = false;
                r.reponse = "";
            }
            playlist.currentMotIndex = 0;
            playlist.isActive = true;
            
            return playlist;
        }

        static public Playlist MakePlaylistFromWrongResults(Playlist playlist)
        {
            Playlist newPlaylist = new Playlist();
            foreach(Resultat r in playlist.resultats)
            {
                if(r.answeredRight == false)
                {
                    newPlaylist.resultats.Add(r);
                }
                newPlaylist.nombreMots = newPlaylist.resultats.Count();
                newPlaylist.serie = playlist.serie;
            }
            newPlaylist.versFr = playlist.versFr;
            return newPlaylist;
        }
    }
}
