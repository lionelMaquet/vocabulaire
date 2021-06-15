using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammation
{
    // Cette classe statique contient des fonctions utiles au fonctionnement du logiciel
    static public class Helper
    {
        // Crée une playlist sur base d'une série
        static public Playlist MakePlaylist(Serie serie, bool versFr) // versFR = de la langue étrangère vers le français ou du français vers la langue étrange
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

        // Réinitialise une playlist
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

        // Crée une nouvelle playlist sur base des mots auxquels l'utilisateur a mal répondu d'une autre playlist
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
