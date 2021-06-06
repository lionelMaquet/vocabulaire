using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgrammation
{
    public static class DBConnector
    {
        static string connectionString = "server=localhost;userid=root;password=;database=vocabulaire";
        static MySqlConnection mysqlConnection;
        
        
        

        public static List<Langue> getLanguages()
        {
            mysqlConnection = new MySqlConnection(connectionString);
            mysqlConnection.Open();
            List<Langue> langues = new List<Langue>();
            var stm_langues = "SELECT * FROM langues";
            var cmd_langues = new MySqlCommand(stm_langues, mysqlConnection);
            MySqlDataReader rdr_langues = cmd_langues.ExecuteReader();
            while (rdr_langues.Read())
            {
                Langue newLangue = new Langue();
                newLangue.nom_short = (string)rdr_langues["langue_short"];
                newLangue.nom_long = (string)rdr_langues["langue_long"];
                langues.Add(newLangue);
            }
            mysqlConnection.Close();
            return langues;
        }

        public static List<Serie> getSeries(Langue langue)
        {
            mysqlConnection = new MySqlConnection(connectionString);
            mysqlConnection.Open();
            List<Serie> series = new List<Serie>();
            var stm_series = $"SELECT * FROM series WHERE langue_traduction = '{langue.nom_short}'";
            var cmd_series = new MySqlCommand(stm_series, mysqlConnection);
            MySqlDataReader rdr_series = cmd_series.ExecuteReader();
            while (rdr_series.Read())
            {
                Serie newSerie = new Serie();
                newSerie.num_serie = rdr_series.GetInt32(0);
                newSerie.nom_serie = (string)rdr_series["nom_serie"];
                newSerie.langue_traduction = (string)rdr_series["langue_traduction"];
                series.Add(newSerie);
            }
            mysqlConnection.Close();
            return series;
        }

        public static List<Mot> getWords(Serie serie)
        {
            mysqlConnection = new MySqlConnection(connectionString);
            mysqlConnection.Open();
            List<Mot> mots = new List<Mot>();
            var stm_mots = $"SELECT * FROM mots WHERE num_serie = {serie.num_serie}";
            var cmd_mots = new MySqlCommand(stm_mots, mysqlConnection);
            MySqlDataReader rdr_mots = cmd_mots.ExecuteReader();
            while (rdr_mots.Read())
            {
                Mot newMot = new Mot();

                newMot.num_mot = rdr_mots.GetInt32(0);
                newMot.langue_fr = (string)rdr_mots["langue_fr"];
                newMot.traduction = (string)rdr_mots["traduction"];
                newMot.num_serie = rdr_mots.GetInt32(3);
                newMot.nombre_reussi = rdr_mots.GetInt32(4);
                newMot.nombre_rate = rdr_mots.GetInt32(5);

                mots.Add(newMot);

            }
            mysqlConnection.Close();
            return mots;
        }

        public static void addWord(Serie serie, string fr, string traduction)
        {
            mysqlConnection = new MySqlConnection(connectionString);
            mysqlConnection.Open();
            MySqlCommand cmd_addWord = mysqlConnection.CreateCommand();
            cmd_addWord.CommandText = "INSERT INTO mots(langue_fr, traduction, num_serie, nombre_reussi, nombre_rate) VALUES (@langue_fr, @traduction, @num_serie, @nombre_reussi, @nombre_rate)";
            cmd_addWord.Parameters.AddWithValue("@langue_fr", fr );
            cmd_addWord.Parameters.AddWithValue("@traduction", traduction );
            cmd_addWord.Parameters.AddWithValue("@num_serie", serie.num_serie );
            cmd_addWord.Parameters.AddWithValue("@nombre_reussi", 0 );
            cmd_addWord.Parameters.AddWithValue("@nombre_rate", 0 );
            cmd_addWord.ExecuteNonQuery();


            mysqlConnection.Close();
        }
    }
}
